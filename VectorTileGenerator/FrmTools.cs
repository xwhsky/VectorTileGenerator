using Newtonsoft.Json;
using OSGeo.OGR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TopoJSON.Net.Geometry;

namespace VectorTileGenerator
{
    public partial class FrmTools : Form
    {
        public FrmTools()
        {
            InitializeComponent();
        }

        private void btnShapefileBrowser_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog() { Filter = "*.shp|*.shp|*.*|*.*" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbShapefilePath.Text = dlg.FileName;
                }
            }
        }

        private void btnJsonBrowser_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog() { Filter = "*.json|*.json|*.*|*.*" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbJsonPath.Text = dlg.FileName;
                }
            }
        }

        private void btnTopoJsonBrowser_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog() { Filter = "*.topojson|*.topojson|*.*|*.*" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbJsonPath.Text = dlg.FileName;
                }
            }
        }

        private void btnShpToJson_Click(object sender, EventArgs e)
        {
            try
            {
                DatasetCopy(tbShapefilePath.Text, tbJsonPath.Text, "GeoJSON");
                MessageBox.Show("操作成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnShpToTopoJson_Click(object sender, EventArgs e)
        {
            try
            {
                var trgPath = tbTopoJsonPath.Text;
                DatasetCopy(tbShapefilePath.Text, tbJsonPath.Text, "GeoJSON");
                if (File.Exists(trgPath))
                {
                    var geojson = JsonConvert.DeserializeObject<Topology>(File.ReadAllText(trgPath));

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DatasetCopy(string srcPath,string trgPath,string driverName)
        {
            var dataset = Ogr.OpenShared(srcPath, 0);
            var layers = CommonUtils.GetDatasetLayers(dataset);

            OSGeo.OGR.Driver driver = Ogr.GetDriverByName(driverName);
            var trgDataset = driver.CreateDataSource(trgPath, null);

            foreach (var srcLayer in layers)
            {
                trgDataset.CopyLayer(srcLayer, srcLayer.GetName(), null);
            }

            trgDataset.Dispose();
        }

        private void btnJsonPath_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog() { Filter = "*.json|*.json|*.*|*.*" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbJson.Text = dlg.FileName;
                }
            }
        }

        private void btnShpPath_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog() { Filter = "*.shp|*.shp|*.*|*.*" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbShp.Text = dlg.FileName;
                }
            }
        }

        private void btnJsonToShp_Click(object sender, EventArgs e)
        {
            try
            {
                var trgPath = tbTopoJsonPath.Text;
                DatasetCopy(tbJson.Text, tbShp.Text, "ESRI Shapefile");
                MessageBox.Show("操作成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
