using OSGeo.OGR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorTileGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        DataSource dataset;
        Layer srcLayer;
        

        private void cbLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            srcLayer = ((ComboboxItem)cbLayers.SelectedItem).Value as Layer;
        }

        private void btnConnectPostGIS_Click(object sender, EventArgs e)
        {
            string utf8Path = string.Format("PG:host = {0} dbname = {1} user = {2} password = {3}", tbHost.Text, tbDbname.Text, tbUser.Text, tbPwd.Text);
            ChangeDataSource(utf8Path);
        }

        private void btnShapefileBrowser_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog() { Filter= "*.shp|*.shp|*.*|*.*" })
            {
                if(dlg.ShowDialog()== DialogResult.OK)
                {
                    tbShapefilePath.Text = dlg.FileName;
                    ChangeDataSource(tbShapefilePath.Text);
                }
            }
        }


        private void btnFileGdbBrowser_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog() )
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbFileGdbPath.Text = dlg.SelectedPath;
                    ChangeDataSource(tbFileGdbPath.Text);
                }
            }
        }

        private void btnFieldMapBroswer_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog() { Filter = "*.xml|*.xml|*.*|*.*" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbFieldMap.Text = dlg.FileName;
                }
            }
        }

        private void tbRasterColorMapBroswer_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog() { Filter = "*.xml|*.xml|*.*|*.*" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbRasterColorMap.Text = dlg.FileName;
                }
            }
        }

        void ChangeDataSource(string path)
        {
            if (dataset != null)
                dataset.Dispose();
            dataset = Ogr.OpenShared(path, 0);
            var layers = CommonUtils.GetDatasetLayers(dataset);
            cbLayers.Items.Clear();
            foreach (var layer in layers)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = layer.GetName();
                item.Value = layer;
                cbLayers.Items.Add(item);
            }
            cbLayers.SelectedIndex = 0;
        }

        private void btnTileToLayerExtent_Click(object sender, EventArgs e)
        {
            if (srcLayer == null) return;
            Envelope envelop = new Envelope();
            srcLayer.GetExtent(envelop, 1);
            tbMinY.Text = envelop.MinY.ToString();
            tbMaxY.Text = envelop.MaxY.ToString();
            tbMinX.Text = envelop.MinX.ToString();
            tbMaxX.Text = envelop.MaxX.ToString();
        }

        private void btnSaveFolderBrowser_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog() { ShowNewFolderButton=true} )
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbSaveFolder.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            lblProcessInfo.Text = string.Empty;
           

            Envelope envolope = new Envelope()
            {
                MinY = double.Parse(tbMinY.Text),
                MaxY = double.Parse(tbMaxY.Text),
                MinX = double.Parse(tbMinX.Text),
                MaxX = double.Parse(tbMaxX.Text)
            };

            WorkArgs args = new WorkArgs();
            args.MinZoom = int.Parse(tbMinZoom.Text);
            args.MaxZoom = int.Parse(tbMaxZoom.Text);
            args.SaveFolder = tbSaveFolder.Text;
            args.Extent = CommonUtils.EnvelopeToRectExtent(envolope);
            args.SourceLayer = srcLayer;
            args.SaveFormat = comboBox1.Text;
            args.SaveExt = comboBox2.Text;
            args.CreateEmptyFile = cbCreateEmptyTile.Checked;
            args.SimplifyVector = cbVectorSimplify.Checked;

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync(args);

            progressBar1.Maximum = args.MaxZoom - args.MinZoom + 1;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("操作完成！");
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            WorkArgs args = e.Argument as WorkArgs;
            var rectExtent = args.Extent;
            var vectorTilesFolder = args.SaveFolder+"\\Vectors";
            var rasterTileFolder = args.SaveFolder + "\\Rasters";
            var layer = args.SourceLayer;
            var saveFormat = args.SaveFormat;
            var saveExt = args.SaveExt;
            var createEmptyFile = args.CreateEmptyFile;
            var simplifyVector = args.SimplifyVector;

            ChangeProgressSize(progressBar1, args.MaxZoom - args.MinZoom + 1);
            ChangeProgressNum(progressBar1, 0);

            for (int z = args.MinZoom; z <= args.MaxZoom; z++)
            {
                var tileSeqs = TileGenerator.GetTileSeqsFromGeoExtent(rectExtent, z);
                long tilesCount = ((long)tileSeqs.Width + 1) * ((long)tileSeqs.Height + 1);

                ChangeControlText(lblProcessInfo, string.Format("process level:{0},tiles count:{1}", z, tilesCount));

                long count = 0;
                for (int x = tileSeqs.Left; x <= tileSeqs.Right; x++)
                {
                    for (int y = tileSeqs.Top; y <= tileSeqs.Bottom; y++)
                    {
                        count++;
                        ChangeControlText(lblProcessInfo,
                            string.Format("zoom level:{0},tiles progress:{1}/{2},process tile:{3}/{4}/{5}(z/x/y)...", z, count, tilesCount, z, x, y));
                        var tileExtent = TileGenerator.GetTileExtent(x, y, z);
                        string saveFile = string.Format(@"{0}\{1}\{2}\{3}.{4}", vectorTilesFolder, z, x, y, saveExt);
                        FileInfo fi = new FileInfo(saveFile);
                        if (!fi.Directory.Exists)
                            fi.Directory.Create();
                        if (fi.Exists)
                            fi.Delete();

                        double simplifyDiff = 0; //简化距离(经纬度)
                        if (simplifyVector)
                        {

                        }

                        var flag = TileGenerator.CreateTileFile(layer, tileExtent, "GeoJSON", saveFile, layer.GetSpatialRef(), simplifyDiff, createEmptyFile);
                        if (flag)
                            ChangeControlText(lblProcessInfo,
                               string.Format("process level:{0},tiles count:{1},process tile:{2}/{3}/{4}(z/x/y)...Success!", z, tilesCount, z, x, y));
                        else
                            ChangeControlText(lblProcessInfo,
                               string.Format("process level:{0},tiles count:{1},process tile:{2}/{3}/{4}(z/x/y)...Failed!", z, tilesCount, z, x, y));
                    }
                }


                ChangeProgressNum(progressBar1, z - args.MinZoom + 1);
            }

            
        }

        private void ChangeControlText(Control control,object text)
        {
            control.Invoke((MethodInvoker)delegate {
                control.Text = text.ToString();
            });
        }

        private void ChangeProgressNum(ProgressBar progressBar, int num)
        {
            progressBar.Invoke((MethodInvoker)delegate {
                progressBar.Value = num;
            });
        }

        private void ChangeProgressSize(ProgressBar progressBar,int count)
        {
            progressBar.Invoke((MethodInvoker)delegate {
                progressBar.Maximum = count;
            });
        }

        private void cbCreateRasterTile_CheckedChanged(object sender, EventArgs e)
        {
            panelRasterColorMap.Enabled = cbCreateRasterTile.Checked;
        }

        private void btnOpenTools_Click(object sender, EventArgs e)
        {
            new FrmTools() { StartPosition = FormStartPosition.CenterParent}.Show();
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class WorkArgs
    {
        public int MinZoom { get; set; }
        public int MaxZoom { get; set; }
        public string SaveFolder { get; set; }
        public RectExtent Extent { get; set; }
        public Layer SourceLayer { get; set; }
        public string SaveFormat { get; set; }
        public string SaveExt { get; set; }
        public bool CreateEmptyFile { get; set; }
        public bool SimplifyVector { get; set; }
    }
}
