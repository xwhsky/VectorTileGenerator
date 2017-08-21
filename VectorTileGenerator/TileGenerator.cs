using OSGeo.GDAL;
using OSGeo.OGR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace VectorTileGenerator
{
    /// <summary>
    /// 瓦片操作类
    /// </summary>
    public class TileGenerator
    {
        List<int> _zoomDic;
        /// <summary>
        /// 瓦片结果
        /// </summary>
        public List<TileUnit> Tiles { get; private set; }
        /// <summary>
        /// 计算范围
        /// </summary>
        public RectExtent CalculateRect { get; private set; }


        public TileGenerator(int minZoom, int maxZoom)
        {
            _zoomDic = new List<int>();
            for (int i = minZoom; i <= maxZoom; i++)
                _zoomDic.Add(i);
            Tiles = new List<TileUnit>();
        }

        public void SetCalculateRect(RectExtent rect)
        {
            CalculateRect = rect;
        }

        /// <summary>
        /// 瓦片计算
        /// </summary>
        public void Generate()
        {
            Tiles = new List<TileUnit>();
            foreach (var zoom in _zoomDic)
            {
                var rect = GetTileSeqsFromGeoExtent(CalculateRect, zoom);
                for (int x = rect.Left; x <= rect.Right; x++)
                {
                    for (int y = rect.Top; y <= rect.Bottom; y++)
                    {
                        TileUnit tileUnit = new TileUnit();
                        tileUnit.X = x;
                        tileUnit.Y = y;
                        tileUnit.Z = zoom;
                        tileUnit.Extent = GetTileExtent(x, y, zoom);
                        Tiles.Add(tileUnit);
                    }
                }
            }
        }

        #region 瓦片信息
        /// <summary>
        /// 获取计算范围内的坐标
        /// </summary>
        /// <param name="calculateRect"></param>
        /// <param name="zoom"></param>
        /// <returns></returns>
        public static Rectangle GetTileSeqsFromGeoExtent(RectExtent calculateRect, int zoom)
        {
            var leftUpP = WorldToTilePos(calculateRect.LeftUp.Lon, calculateRect.LeftUp.Lat, zoom);
            var rightDownP = WorldToTilePos(calculateRect.RightDown.Lon, calculateRect.RightDown.Lat, zoom);
            Rectangle result = new Rectangle();
            result.Location = leftUpP;

            result.Width = rightDownP.X - leftUpP.X;
            result.Height = rightDownP.Y - leftUpP.Y;
            return result;
        }


        /// <summary>
        /// 计算单张瓦片层级号的四支范围
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static RectExtent GetTileExtent(int x, int y, int z)
        {
            Coord leftUpCoord = TileToWorldPos(x, y, z);
            Coord rightDownCoord = TileToWorldPos(x + 1, y + 1, z);
            RectExtent result = new RectExtent();
            result.LeftUp = leftUpCoord;
            result.Width = rightDownCoord.Lon - leftUpCoord.Lon;
            result.Height = leftUpCoord.Lat - rightDownCoord.Lat;
            return result;
        }

        /// <summary>
        /// 地理坐标转瓦片层级
        /// </summary>
        /// <param name="lon"></param>
        /// <param name="lat"></param>
        /// <param name="zoom"></param>
        /// <returns></returns>
        public static Point WorldToTilePos(double lon, double lat, int zoom)
        {
            Point p = new Point();
            p.X = (int)((lon + 180.0) / 360.0 * (1 << zoom));
            p.Y = (int)((1.0 - Math.Log(Math.Tan(lat * Math.PI / 180.0) +
                1.0 / Math.Cos(lat * Math.PI / 180.0)) / Math.PI) / 2.0 * (1 << zoom));

            return p;
        }

        /// <summary>
        /// xyz转地理坐标
        /// </summary>
        /// <param name="tile_x"></param>
        /// <param name="tile_y"></param>
        /// <param name="zoom"></param>
        /// <returns></returns>
        public static Coord TileToWorldPos(int tile_x, int tile_y, int zoom)
        {
            Coord p = new Coord();
            double n = Math.PI - ((2.0 * Math.PI * tile_y) / Math.Pow(2.0, zoom));

            p.Lon = (float)((tile_x / Math.Pow(2.0, zoom) * 360.0) - 180.0);  //经度是从-180到180度直接等分切开，每个度没均衡
            p.Lat = (float)(180.0 / Math.PI * Math.Atan(Math.Sinh(n)));  //纬度是？？？

            return p;
        }

        /// <summary>
        /// 根据缩放级别确定显示分辨率
        /// </summary>
        /// <param name="zoom"></param>
        /// <returns></returns>
        public static double ZoomToResolution(int zoom)
        {
            double resolution = 1.0 / Math.Pow(2, zoom);
            return resolution;
        }
        #endregion


        #region 数据生成
        /// <summary>
        /// 生成矢量切片
        /// </summary>
        /// <param name="srcLayer"></param>
        /// <param name="rectExtent"></param>
        /// <param name="format"></param>
        /// <param name="saveFile"></param>
        /// <param name="trgSrs">输出投影</param>
        /// <param name="simplifyDiff">设置两个最小相似点的距离，越大点越容易合并。值类型与图层数据类型（经纬度或长度）保持一致</param>
        /// <param name="createEmptyFile">设置两个最小相似点的距离，越大点越容易合并。值类型与图层数据类型（经纬度或长度）保持一致</param>
        /// <returns></returns>
        public static bool CreateTileFile(Layer srcLayer, RectExtent rectExtent,
            string format, string saveFile, OSGeo.OSR.SpatialReference trgSrs, double simplifyDiff,bool createEmptyFile)
        {
            Geometry rectG = CommonUtils.RectExtentToGeometry(rectExtent);
            srcLayer.SetSpatialFilter(rectG);

            int featureCount = srcLayer.GetFeatureCount(1);
            if (featureCount == 0 && !createEmptyFile)
                return true;

            OSGeo.OGR.Driver driver = Ogr.GetDriverByName(format);
            var trgDataset = driver.CreateDataSource(saveFile, null);
            var trgLayerName = System.IO.Path.GetFileNameWithoutExtension(saveFile);
            var trgLayer = trgDataset.CreateLayer(trgLayerName, trgSrs, srcLayer.GetGeomType(), null);

            Feature feature = null;
            int flag;
            
            srcLayer.ResetReading();
            while ((feature = srcLayer.GetNextFeature()) != null)
            {
                var geometry = feature.GetGeometryRef();
                //Douglas - Peucker algorithm算法进行抽稀
                if (simplifyDiff > 0)
                {
                    var simGeo = geometry.SimplifyPreserveTopology(simplifyDiff);
                    feature.SetGeometry(simGeo);
                }
                flag = trgLayer.CreateFeature(feature);
                
            }
            return true;
        }

        public static double GetDifferenceByZoom(int zoom)
        {
            var pos = TileToWorldPos(1, 1, zoom);

            return 0;
        }
        #endregion

    }
}
