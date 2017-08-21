using OSGeo.OGR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorTileGenerator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configure.SetEnvironmentVariables();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            

            //string tilesFolder = @"E:\VectorTiles\cache\test";

            //var dataset = Ogr.OpenShared("PG:host = 121.41.34.50 dbname = njqwebdb user = git password = 123", 0);
            //var layer = dataset.GetLayerByName("njq_v_geo_dk");

            //int  z = 17;

            //Envelope envelope = new Envelope();
            //layer.GetExtent(envelope, 1);
            //var rectExtent = CommonUtils.EnvelopeToRectExtent(envelope);
            //var tileSeqs = TileGenerator.GetTileSeqsFromGeoExtent(rectExtent, z);
            //for (int x = tileSeqs.Left; x <= tileSeqs.Right; x++)
            //{
            //    for (int y = tileSeqs.Top; y <= tileSeqs.Bottom; y++)
            //    {
            //        var tileExtent = TileGenerator.GetTileExtent(x, y, z);
            //        string saveFile = string.Format(@"{0}\{1}\{2}\{3}.{4}", tilesFolder, z, x, y, "json");
            //        FileInfo fi = new FileInfo(saveFile);
            //        if (!fi.Directory.Exists)
            //            fi.Directory.Create();
            //        if (fi.Exists)
            //            fi.Delete();

                    
            //        var flag = TileGenerator.CreateTileFile(layer, tileExtent, "GeoJSON", saveFile, layer.GetSpatialRef(), 0.0000000000000001);

            //    }
            //}

            ////var ssss = TileGenerator.WorldToTilePos(121.17624544147137, 30.75982355963534, 18);
            ////ssss = TileGenerator.WorldToTilePos(180, -85.051132202148438, 18);
            ////var ss = TileGenerator.TileToWorldPos(262144, 262144, 18);
            ////TileGenerator tileGenerator = new TileGenerator(16, 16);
            ////var extent =tileGenerator.GetTileExtent(262144, 262144, 18);

            ////tileGenerator.SetCalculateRect(new RectExtent() { LeftUp = new Coord() { Lon = 120, Lat = 30 }, Width=1, Height = 1 });
            ////var text =tileGenerator.GetTileExtent(54828, 27304, 16);
            ////tileGenerator.Generate();


            ////Driver driver = Ogr.GetDriverByName("GeoJSON");
            ////var destDs = driver.CreateDataSource("", null);



            //return;
            //Ogr2OgrUtil util = new Ogr2OgrUtil();
            ////util.SourceDataConfig(@"D:\Study\Learning\VectorTile-Research\TestData\result\4326.shp");

            //// util.SavePGConfig("121.41.34.50", "git", "njqwebdb", "123");

            //// util.SourcePGConfigBySql("121.41.34.50", "git", "njqwebdb", "123", "select  ST_SimplifyPreserveTopology(geom,1) from njq_v_geo_dk ");
            //util.SourcePGConfigBySql("121.41.34.50", "git", "njqwebdb", "123", "select * from njq_v_geo_dk ");
            //// util.InputSrc("4326");
            //// util.OutputSrs("4326");
            //// util.SaveShapeFileConfig(@"D:\Study\Learning\VectorTile-Research\TestData\result\1-0.02.shp");
            ////util.OverWriteConfig(true);
            //util.SimlifyTolerance(0.1);
            //util.SaveGeojsonConfig(@"D:\Study\Learning\VectorTile-Research\TestData\result\4326-03.geojson");
            //util.OutputExtent(121.18, 30.75, 121.19, 30.76);
            ////util.OverWriteConfig(true);
            //util.Start();
        }

        
    }
}

            