using OSGeo.GDAL;
using OSGeo.OGR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorTileGenerator
{
    /// <summary>
    /// Ogr2Ogr使用工具
    /// </summary>
    public class Ogr2OgrUtil
    {
        //string _exeutePath = @"D:\Study\Learning\VectorTile-Research\MyCode\GDAL\gdal1.11_x86_x64\gdal1.11.0_x86\bin2\ogr2ogr.exe";
        string _exeutePath = @"ogr2ogr.exe";

        string _helpHtmlPath = "http://www.gdal.org/ogr2ogr.html";

        string _skipfailures = ""; //
        string _append = "";
        string _update = "";
        string _gt = "";
        string _select = "";
        string _where = "";
        string _sql = "";
        string _spat = ""; // 四支坐标
        string _preserve_fid = "";
        string _fid = "";

        string _a_srs = ""; //输出投影
        string _t_srs = ""; //定义原始投影
        string _s_srs = ""; //

        string _overwriteConfig = "";  //是否覆盖目标文件
        string _sourceDataConfig = ""; //原始数据

        string _destinationConfig = "";  //保存的配置路径

        string _simplify = ""; //简化工具

        public Ogr2OgrUtil() { }
        public Ogr2OgrUtil(string exeutePath)
        {
            _exeutePath = exeutePath;
        }

        public string GetCommand()
        {
           // var ss = Gdal.OpenShared("", Access.GA_ReadOnly);

            
            return string.Format(" {0} {1} {2} {3} {4} {5} {6} {7}",
                _exeutePath, _t_srs, _a_srs, _overwriteConfig, _destinationConfig, _sourceDataConfig, _spat, _simplify);
        }

        /// <summary>
        /// 执行操作
        /// </summary>
        public void Start()
        {
            System.Diagnostics.ProcessStartInfo process = null;
            System.Diagnostics.Process p = null;
            process = new ProcessStartInfo();
            process.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            process.FileName = "cmd.exe";

            process.Arguments = "/k " + GetCommand() + @" pause";

            p = System.Diagnostics.Process.Start(process);

            p.WaitForExit();
        }

        

        #region 原始数据配置
        public void SourceDataConfig(string shapeFilePath)
        {
            _sourceDataConfig = shapeFilePath;
        }

        /// <summary>
        /// 还不能用，取巧
        /// </summary>
        /// <param name="host"></param>
        /// <param name="user"></param>
        /// <param name="dbname"></param>
        /// <param name="password"></param>
        /// <param name="tableName"></param>
        public void SourcePGConfigByTableName(string host, string user, string dbname, string password,string tableName)
        {
            var sql = string.Format("select * from {0}", tableName);
            SourcePGConfigBySql(host, user, dbname, password, sql);
            //_sourceDataConfig = string.Format(
            //    "PG:\"host={0} dbname={1} user={2} password={3}\" \"{4}\"",
            //    host, dbname, user, password, tableName);
        }

        public void SourcePGConfigBySql(string host, string user, string dbname, string password, string sql)
        {
            _sourceDataConfig = string.Format(
                "PG:\"host = {0} dbname = {1} user = {2} password = {3}\" -sql \"{4}\"",
                host, dbname, user, password, sql);
        }


        #endregion


        #region 生成数据配置
        public void SaveShapeFileConfig(string shapeFilePath)
        {
            _destinationConfig = string.Format("-f \"ESRI Shapefile\" {0}", shapeFilePath);
        }

        public void SaveGeojsonConfig(string geojsonPath)
        {
            _destinationConfig = string.Format("-f \"GeoJSON\" {0}", geojsonPath);
        }

        /// <summary>
        /// 配置POSTGIS数据连接路径
        /// </summary>
        /// <param name="host"></param>
        /// <param name="user"></param>
        /// <param name="dbname"></param>
        /// <param name="password"></param>
        public void SavePGConfig(string host, string dbname, string user, string password)
        {
            _destinationConfig = string.Format(
                "-f \"PostgreSQL\" PG:\"host = {0} dbname = {1} user = {2} password = {3}\"",
                host, dbname, user, password);
        }

        #endregion


        /// <summary>
        /// 有问题，不要设置
        /// </summary>
        /// <param name="flag"></param>
        public void OverWriteConfig(bool flag)
        {
            _overwriteConfig = flag ? "-overwrite=yes" : string.Empty;
        }

        public void InputSrc(string epsgCode)
        {
            _t_srs = string.Format("-r_srs \"EPSG:{0}\"", epsgCode);
        }

        public void OutputSrs(string epsgCode)
        {
            _a_srs = string.Format("-t_srs \"EPSG:{0}\"", epsgCode);
        }

        public void OutputExtent(double xmin,double ymin, double xmax,double ymax)
        {
            _spat = string.Format("-spat {0} {1} {2} {3}", xmin, ymin, xmax, ymax);
        }

        public void SimlifyTolerance(double tolerance)
        {
            _simplify = string.Format("-simplify {0}", tolerance);
        }

    }

    /// <summary>
    /// 输出文档格式
    /// </summary>
    public enum format_name
    {
        Shapefile=0,
        TIGER=1,
        MapInfo=2,
        GML=3,
        PostgreSQL=4
    }
    
}
