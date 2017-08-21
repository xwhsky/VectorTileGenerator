namespace VectorTileGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConnectPostGIS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDbname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tbShapefilePath = new System.Windows.Forms.TextBox();
            this.btnShapefileBrowser = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.tbFileGdbPath = new System.Windows.Forms.TextBox();
            this.btnFileGdbBrowser = new System.Windows.Forms.Button();
            this.btnTileToLayerExtent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLayers = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbMaxY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMaxX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMinX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMinY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMinZoom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaxZoom = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelRasterColorMap = new System.Windows.Forms.Panel();
            this.tbRasterColorMapBroswer = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tbRasterColorMap = new System.Windows.Forms.TextBox();
            this.cbCreateRasterTile = new System.Windows.Forms.CheckBox();
            this.btnFieldMapBroswer = new System.Windows.Forms.Button();
            this.tbFieldMap = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbVectorSimplify = new System.Windows.Forms.CheckBox();
            this.cbCreateEmptyTile = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblProcessInfo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbSaveFolder = new System.Windows.Forms.TextBox();
            this.btnSaveFolderBrowser = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnOpenTools = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelRasterColorMap.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenTools);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.btnTileToLayerExtent);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbLayers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据源";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(3, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 61);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConnectPostGIS);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbHost);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbDbname);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbUser);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbPwd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 35);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PostGIS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnConnectPostGIS
            // 
            this.btnConnectPostGIS.Location = new System.Drawing.Point(685, 4);
            this.btnConnectPostGIS.Name = "btnConnectPostGIS";
            this.btnConnectPostGIS.Size = new System.Drawing.Size(89, 23);
            this.btnConnectPostGIS.TabIndex = 14;
            this.btnConnectPostGIS.Text = "连接";
            this.btnConnectPostGIS.UseVisualStyleBackColor = true;
            this.btnConnectPostGIS.Click += new System.EventHandler(this.btnConnectPostGIS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Host：";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(54, 6);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(100, 21);
            this.tbHost.TabIndex = 2;
            this.tbHost.Text = "121.41.34.50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "dbname：";
            // 
            // tbDbname
            // 
            this.tbDbname.Location = new System.Drawing.Point(222, 6);
            this.tbDbname.Name = "tbDbname";
            this.tbDbname.Size = new System.Drawing.Size(100, 21);
            this.tbDbname.TabIndex = 4;
            this.tbDbname.Text = "njqwebdb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "user：";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(375, 6);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 21);
            this.tbUser.TabIndex = 6;
            this.tbUser.Text = "git";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "password:";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(546, 6);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(100, 21);
            this.tbPwd.TabIndex = 8;
            this.tbPwd.Text = "123";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbShapefilePath);
            this.tabPage2.Controls.Add(this.btnShapefileBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 35);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ShapeFile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Path:";
            // 
            // tbShapefilePath
            // 
            this.tbShapefilePath.Location = new System.Drawing.Point(54, 6);
            this.tbShapefilePath.Name = "tbShapefilePath";
            this.tbShapefilePath.Size = new System.Drawing.Size(616, 21);
            this.tbShapefilePath.TabIndex = 12;
            // 
            // btnShapefileBrowser
            // 
            this.btnShapefileBrowser.Location = new System.Drawing.Point(676, 4);
            this.btnShapefileBrowser.Name = "btnShapefileBrowser";
            this.btnShapefileBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnShapefileBrowser.TabIndex = 13;
            this.btnShapefileBrowser.Text = "浏览";
            this.btnShapefileBrowser.UseVisualStyleBackColor = true;
            this.btnShapefileBrowser.Click += new System.EventHandler(this.btnShapefileBrowser_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.tbFileGdbPath);
            this.tabPage3.Controls.Add(this.btnFileGdbBrowser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 35);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FileGDB";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 17;
            this.label17.Text = "Path:";
            // 
            // tbFileGdbPath
            // 
            this.tbFileGdbPath.Location = new System.Drawing.Point(52, 8);
            this.tbFileGdbPath.Name = "tbFileGdbPath";
            this.tbFileGdbPath.Size = new System.Drawing.Size(616, 21);
            this.tbFileGdbPath.TabIndex = 15;
            // 
            // btnFileGdbBrowser
            // 
            this.btnFileGdbBrowser.Location = new System.Drawing.Point(674, 6);
            this.btnFileGdbBrowser.Name = "btnFileGdbBrowser";
            this.btnFileGdbBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnFileGdbBrowser.TabIndex = 16;
            this.btnFileGdbBrowser.Text = "浏览";
            this.btnFileGdbBrowser.UseVisualStyleBackColor = true;
            this.btnFileGdbBrowser.Click += new System.EventHandler(this.btnFileGdbBrowser_Click);
            // 
            // btnTileToLayerExtent
            // 
            this.btnTileToLayerExtent.Location = new System.Drawing.Point(641, 82);
            this.btnTileToLayerExtent.Name = "btnTileToLayerExtent";
            this.btnTileToLayerExtent.Size = new System.Drawing.Size(146, 23);
            this.btnTileToLayerExtent.TabIndex = 15;
            this.btnTileToLayerExtent.Text = "使用全图绘制切图范围";
            this.btnTileToLayerExtent.UseVisualStyleBackColor = true;
            this.btnTileToLayerExtent.Click += new System.EventHandler(this.btnTileToLayerExtent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "layers:";
            // 
            // cbLayers
            // 
            this.cbLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayers.FormattingEnabled = true;
            this.cbLayers.Location = new System.Drawing.Point(61, 84);
            this.cbLayers.Name = "cbLayers";
            this.cbLayers.Size = new System.Drawing.Size(574, 20);
            this.cbLayers.TabIndex = 9;
            this.cbLayers.SelectedIndexChanged += new System.EventHandler(this.cbLayers_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbMaxY);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbMaxX);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbMinX);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbMinY);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(412, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 140);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "切图范围";
            // 
            // tbMaxY
            // 
            this.tbMaxY.Location = new System.Drawing.Point(124, 110);
            this.tbMaxY.Name = "tbMaxY";
            this.tbMaxY.Size = new System.Drawing.Size(121, 21);
            this.tbMaxY.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 37;
            this.label12.Text = "纬度（最小）";
            // 
            // tbMaxX
            // 
            this.tbMaxX.Location = new System.Drawing.Point(232, 69);
            this.tbMaxX.Name = "tbMaxX";
            this.tbMaxX.Size = new System.Drawing.Size(121, 21);
            this.tbMaxX.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "经度（最大）";
            // 
            // tbMinX
            // 
            this.tbMinX.Location = new System.Drawing.Point(15, 69);
            this.tbMinX.Name = "tbMinX";
            this.tbMinX.Size = new System.Drawing.Size(121, 21);
            this.tbMinX.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "经度（最小）";
            // 
            // tbMinY
            // 
            this.tbMinY.Location = new System.Drawing.Point(124, 32);
            this.tbMinY.Name = "tbMinY";
            this.tbMinY.Size = new System.Drawing.Size(121, 21);
            this.tbMinY.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "纬度（最大）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "矢量切片制作层级号：";
            // 
            // tbMinZoom
            // 
            this.tbMinZoom.Location = new System.Drawing.Point(153, 23);
            this.tbMinZoom.Name = "tbMinZoom";
            this.tbMinZoom.Size = new System.Drawing.Size(100, 21);
            this.tbMinZoom.TabIndex = 15;
            this.tbMinZoom.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "-";
            // 
            // tbMaxZoom
            // 
            this.tbMaxZoom.Location = new System.Drawing.Point(276, 23);
            this.tbMaxZoom.Name = "tbMaxZoom";
            this.tbMaxZoom.Size = new System.Drawing.Size(100, 21);
            this.tbMaxZoom.TabIndex = 27;
            this.tbMaxZoom.Text = "18";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelRasterColorMap);
            this.groupBox3.Controls.Add(this.cbCreateRasterTile);
            this.groupBox3.Controls.Add(this.btnFieldMapBroswer);
            this.groupBox3.Controls.Add(this.tbFieldMap);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbMaxZoom);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.tbMinZoom);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(793, 171);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "切片设置";
            // 
            // panelRasterColorMap
            // 
            this.panelRasterColorMap.Controls.Add(this.tbRasterColorMapBroswer);
            this.panelRasterColorMap.Controls.Add(this.label19);
            this.panelRasterColorMap.Controls.Add(this.tbRasterColorMap);
            this.panelRasterColorMap.Enabled = false;
            this.panelRasterColorMap.Location = new System.Drawing.Point(0, 117);
            this.panelRasterColorMap.Name = "panelRasterColorMap";
            this.panelRasterColorMap.Size = new System.Drawing.Size(406, 43);
            this.panelRasterColorMap.TabIndex = 54;
            // 
            // tbRasterColorMapBroswer
            // 
            this.tbRasterColorMapBroswer.Location = new System.Drawing.Point(367, 11);
            this.tbRasterColorMapBroswer.Name = "tbRasterColorMapBroswer";
            this.tbRasterColorMapBroswer.Size = new System.Drawing.Size(39, 23);
            this.tbRasterColorMapBroswer.TabIndex = 55;
            this.tbRasterColorMapBroswer.Text = "...";
            this.tbRasterColorMapBroswer.UseVisualStyleBackColor = true;
            this.tbRasterColorMapBroswer.Click += new System.EventHandler(this.tbRasterColorMapBroswer_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 12);
            this.label19.TabIndex = 57;
            this.label19.Text = "字段映射规则：";
            // 
            // tbRasterColorMap
            // 
            this.tbRasterColorMap.Location = new System.Drawing.Point(94, 13);
            this.tbRasterColorMap.Name = "tbRasterColorMap";
            this.tbRasterColorMap.Size = new System.Drawing.Size(267, 21);
            this.tbRasterColorMap.TabIndex = 56;
            // 
            // cbCreateRasterTile
            // 
            this.cbCreateRasterTile.AutoSize = true;
            this.cbCreateRasterTile.Location = new System.Drawing.Point(10, 94);
            this.cbCreateRasterTile.Name = "cbCreateRasterTile";
            this.cbCreateRasterTile.Size = new System.Drawing.Size(96, 16);
            this.cbCreateRasterTile.TabIndex = 53;
            this.cbCreateRasterTile.Text = "制作栅格切片";
            this.cbCreateRasterTile.UseVisualStyleBackColor = true;
            this.cbCreateRasterTile.CheckedChanged += new System.EventHandler(this.cbCreateRasterTile_CheckedChanged);
            // 
            // btnFieldMapBroswer
            // 
            this.btnFieldMapBroswer.Location = new System.Drawing.Point(367, 56);
            this.btnFieldMapBroswer.Name = "btnFieldMapBroswer";
            this.btnFieldMapBroswer.Size = new System.Drawing.Size(39, 23);
            this.btnFieldMapBroswer.TabIndex = 15;
            this.btnFieldMapBroswer.Text = "...";
            this.btnFieldMapBroswer.UseVisualStyleBackColor = true;
            this.btnFieldMapBroswer.Click += new System.EventHandler(this.btnFieldMapBroswer_Click);
            // 
            // tbFieldMap
            // 
            this.tbFieldMap.Location = new System.Drawing.Point(94, 58);
            this.tbFieldMap.Name = "tbFieldMap";
            this.tbFieldMap.Size = new System.Drawing.Size(267, 21);
            this.tbFieldMap.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 12);
            this.label18.TabIndex = 28;
            this.label18.Text = "字段映射规则：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbVectorSimplify);
            this.groupBox4.Controls.Add(this.cbCreateEmptyTile);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.lblProcessInfo);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.btnExecute);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.tbSaveFolder);
            this.groupBox4.Controls.Add(this.btnSaveFolderBrowser);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(793, 176);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "生成设置";
            // 
            // cbVectorSimplify
            // 
            this.cbVectorSimplify.AutoSize = true;
            this.cbVectorSimplify.Checked = true;
            this.cbVectorSimplify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVectorSimplify.Location = new System.Drawing.Point(427, 70);
            this.cbVectorSimplify.Name = "cbVectorSimplify";
            this.cbVectorSimplify.Size = new System.Drawing.Size(84, 16);
            this.cbVectorSimplify.TabIndex = 53;
            this.cbVectorSimplify.Text = "简化矢量点";
            this.cbVectorSimplify.UseVisualStyleBackColor = true;
            // 
            // cbCreateEmptyTile
            // 
            this.cbCreateEmptyTile.AutoSize = true;
            this.cbCreateEmptyTile.Checked = true;
            this.cbCreateEmptyTile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCreateEmptyTile.Location = new System.Drawing.Point(337, 71);
            this.cbCreateEmptyTile.Name = "cbCreateEmptyTile";
            this.cbCreateEmptyTile.Size = new System.Drawing.Size(84, 16);
            this.cbCreateEmptyTile.TabIndex = 52;
            this.cbCreateEmptyTile.Text = "生成空瓦片";
            this.cbCreateEmptyTile.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "json",
            "geojson"});
            this.comboBox2.Location = new System.Drawing.Point(216, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 20);
            this.comboBox2.TabIndex = 50;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(179, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 49;
            this.label16.Text = "后缀：";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GeoJSON"});
            this.comboBox1.Location = new System.Drawing.Point(76, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 20);
            this.comboBox1.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 48;
            this.label15.Text = "切片格式：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcessInfo
            // 
            this.lblProcessInfo.AutoSize = true;
            this.lblProcessInfo.Location = new System.Drawing.Point(75, 103);
            this.lblProcessInfo.Name = "lblProcessInfo";
            this.lblProcessInfo.Size = new System.Drawing.Size(65, 12);
            this.lblProcessInfo.TabIndex = 47;
            this.lblProcessInfo.Text = "执行进度：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 46;
            this.label14.Text = "执行进度：";
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExecute.Location = new System.Drawing.Point(711, 74);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 70);
            this.btnExecute.TabIndex = 45;
            this.btnExecute.Text = "确定";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(77, 118);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(628, 23);
            this.progressBar1.TabIndex = 44;
            // 
            // tbSaveFolder
            // 
            this.tbSaveFolder.Location = new System.Drawing.Point(77, 32);
            this.tbSaveFolder.Name = "tbSaveFolder";
            this.tbSaveFolder.Size = new System.Drawing.Size(628, 21);
            this.tbSaveFolder.TabIndex = 43;
            // 
            // btnSaveFolderBrowser
            // 
            this.btnSaveFolderBrowser.Location = new System.Drawing.Point(711, 32);
            this.btnSaveFolderBrowser.Name = "btnSaveFolderBrowser";
            this.btnSaveFolderBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFolderBrowser.TabIndex = 41;
            this.btnSaveFolderBrowser.Text = "浏览";
            this.btnSaveFolderBrowser.UseVisualStyleBackColor = true;
            this.btnSaveFolderBrowser.Click += new System.EventHandler(this.btnSaveFolderBrowser_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 42;
            this.label13.Text = "生成路径：";
            // 
            // btnOpenTools
            // 
            this.btnOpenTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTools.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTools.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenTools.ForeColor = System.Drawing.Color.Red;
            this.btnOpenTools.Location = new System.Drawing.Point(706, 10);
            this.btnOpenTools.Name = "btnOpenTools";
            this.btnOpenTools.Size = new System.Drawing.Size(75, 23);
            this.btnOpenTools.TabIndex = 54;
            this.btnOpenTools.Text = "工具集";
            this.btnOpenTools.UseVisualStyleBackColor = false;
            this.btnOpenTools.Click += new System.EventHandler(this.btnOpenTools_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 479);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "切片制作";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelRasterColorMap.ResumeLayout(false);
            this.panelRasterColorMap.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLayers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMaxY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbMaxX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMinX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMinY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTileToLayerExtent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMinZoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaxZoom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnConnectPostGIS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDbname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbShapefilePath;
        private System.Windows.Forms.Button btnShapefileBrowser;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbSaveFolder;
        private System.Windows.Forms.Button btnSaveFolderBrowser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblProcessInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbCreateEmptyTile;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbFileGdbPath;
        private System.Windows.Forms.Button btnFileGdbBrowser;
        private System.Windows.Forms.Button btnFieldMapBroswer;
        private System.Windows.Forms.TextBox tbFieldMap;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelRasterColorMap;
        private System.Windows.Forms.Button tbRasterColorMapBroswer;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbRasterColorMap;
        private System.Windows.Forms.CheckBox cbCreateRasterTile;
        private System.Windows.Forms.CheckBox cbVectorSimplify;
        private System.Windows.Forms.Button btnOpenTools;
    }
}

