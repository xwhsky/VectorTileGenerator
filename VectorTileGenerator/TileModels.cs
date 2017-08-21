namespace VectorTileGenerator
{
    /// <summary>
    /// 地理坐标
    /// </summary>
    public struct Coord
    {
        /// <summary>
        /// 纬度（纵向）
        /// </summary>
        public double Lat;

        /// <summary>
        /// 经度（横向）
        /// </summary>
        public double Lon;
    }

    /// <summary>
    /// 四支范围（正矩形）
    /// </summary>
    public struct RectExtent
    {
        public Coord LeftUp { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Coord RightUp { get { return new Coord() { Lat = LeftUp.Lat, Lon = LeftUp.Lon + Width }; }  }
        public Coord LeftDown { get { return new Coord() { Lat = LeftUp.Lat - Height, Lon = LeftUp.Lon }; } }
        public Coord RightDown { get { return new Coord() { Lat = LeftUp.Lat - Height, Lon = LeftUp.Lon + Width }; } }

        public double MinLon { get { return LeftUp.Lon; } }
        public double MaxLon { get { return RightDown.Lon; } }
        public double MinLat { get { return RightDown.Lat; } }
        public double MaxLat { get { return LeftUp.Lat; } }
    }

    /// <summary>
    /// 单个瓦片坐标记录
    /// </summary>
    public struct TileUnit
    {
        /// <summary>
        /// 横向位置（经度）
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// 纵向位置（纬度）
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// 缩放级别
        /// </summary>
        public int Z { get; set; }
        public RectExtent Extent { get; set; }
    }

    
}
