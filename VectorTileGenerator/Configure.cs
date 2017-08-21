using OSGeo.GDAL;
using OSGeo.OGR;
using OSGeo.OSR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorTileGenerator
{
    public class Configure
    {
        public static string GDAL_CORE = string.Format(@"{0}Libs\release-1600-x64-gdal-1-11-4-mapserver-6-4-3\bin", AppDomain.CurrentDomain.BaseDirectory);
        public static string GDAL_APP = string.Format(@"{0}Libs\release-1600-x64-gdal-1-11-4-mapserver-6-4-3\bin\gdal\apps", AppDomain.CurrentDomain.BaseDirectory);
        public static string GDAL_CSHARP = string.Format(@"{0}Libs\release-1600-x64-gdal-1-11-4-mapserver-6-4-3\bin\gdal\csharp", AppDomain.CurrentDomain.BaseDirectory);

        public static string GDAL_DATA = string.Format(@"{0}Libs\release-1600-x64-gdal-1-11-4-mapserver-6-4-3\bin\gdal-data", AppDomain.CurrentDomain.BaseDirectory);

        /// <summary>
        /// 设置环境变量
        /// </summary>
        public static void SetEnvironmentVariables()
        {
            //  AppDomain.CurrentDomain.AppendPrivatePath(GDAL_CSHARP);
            //  AppDomain.CurrentDomain.AppendPrivatePath(GDAL_CORE);

            if (string.IsNullOrEmpty(GDAL_CORE))
            {
                throw new Exception("没有配置环境变量‘GDAL_CORE’");
            }
            if (string.IsNullOrEmpty(GDAL_APP))
            {
                throw new Exception("没有配置环境变量‘GDAL_APP’");
            }
            if (string.IsNullOrEmpty(GDAL_DATA))
            {
                throw new Exception("没有配置环境变量‘GDAL_DATA’");
            }
            if (string.IsNullOrEmpty(GDAL_CSHARP))
            {
                throw new Exception("没有配置环境变量‘GDAL_CSHARP’");
            }
            string path = Environment.GetEnvironmentVariable("Path");
            string gdalPath = string.Format("{0};{1};{2}", GDAL_CORE, GDAL_APP, GDAL_CSHARP);
            if (string.IsNullOrEmpty(path))
            {
                path = gdalPath;
            }
            else
                path = string.Format("{0};{1}", path, gdalPath);
            Environment.SetEnvironmentVariable("Path", path, EnvironmentVariableTarget.Process);
            Environment.SetEnvironmentVariable("GDAL_DATA", GDAL_DATA, EnvironmentVariableTarget.Process);
            //Environment.SetEnvironmentVariable("NLS_LANG", Constant.NLS_LANG,
            //EnvironmentVariableTarget.Process);

            Gdal.AllRegister();
            Ogr.RegisterAll();
            
        }
    }
}
