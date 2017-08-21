namespace VectorTileGenerator
{
    partial class FrmTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShpToTopoJson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTopoJsonPath = new System.Windows.Forms.TextBox();
            this.btnTopoJsonBrowser = new System.Windows.Forms.Button();
            this.btnShpToJson = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJsonPath = new System.Windows.Forms.TextBox();
            this.btnJsonBrowser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbShapefilePath = new System.Windows.Forms.TextBox();
            this.btnShapefileBrowser = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnJsonToShp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbShp = new System.Windows.Forms.TextBox();
            this.btnShpPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbJson = new System.Windows.Forms.TextBox();
            this.btnJsonPath = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 495);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShpToTopoJson);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbTopoJsonPath);
            this.tabPage1.Controls.Add(this.btnTopoJsonBrowser);
            this.tabPage1.Controls.Add(this.btnShpToJson);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbJsonPath);
            this.tabPage1.Controls.Add(this.btnJsonBrowser);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbShapefilePath);
            this.tabPage1.Controls.Add(this.btnShapefileBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shp To Json";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnShpToTopoJson
            // 
            this.btnShpToTopoJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShpToTopoJson.Location = new System.Drawing.Point(549, 177);
            this.btnShpToTopoJson.Name = "btnShpToTopoJson";
            this.btnShpToTopoJson.Size = new System.Drawing.Size(75, 23);
            this.btnShpToTopoJson.TabIndex = 37;
            this.btnShpToTopoJson.Text = "生成";
            this.btnShpToTopoJson.UseVisualStyleBackColor = true;
            this.btnShpToTopoJson.Click += new System.EventHandler(this.btnShpToTopoJson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "TopoJson Path:";
            // 
            // tbTopoJsonPath
            // 
            this.tbTopoJsonPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTopoJsonPath.Location = new System.Drawing.Point(103, 131);
            this.tbTopoJsonPath.Name = "tbTopoJsonPath";
            this.tbTopoJsonPath.Size = new System.Drawing.Size(440, 21);
            this.tbTopoJsonPath.TabIndex = 34;
            // 
            // btnTopoJsonBrowser
            // 
            this.btnTopoJsonBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTopoJsonBrowser.Location = new System.Drawing.Point(549, 129);
            this.btnTopoJsonBrowser.Name = "btnTopoJsonBrowser";
            this.btnTopoJsonBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnTopoJsonBrowser.TabIndex = 35;
            this.btnTopoJsonBrowser.Text = "浏览";
            this.btnTopoJsonBrowser.UseVisualStyleBackColor = true;
            this.btnTopoJsonBrowser.Click += new System.EventHandler(this.btnTopoJsonBrowser_Click);
            // 
            // btnShpToJson
            // 
            this.btnShpToJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShpToJson.Location = new System.Drawing.Point(549, 88);
            this.btnShpToJson.Name = "btnShpToJson";
            this.btnShpToJson.Size = new System.Drawing.Size(75, 23);
            this.btnShpToJson.TabIndex = 30;
            this.btnShpToJson.Text = "生成";
            this.btnShpToJson.UseVisualStyleBackColor = true;
            this.btnShpToJson.Click += new System.EventHandler(this.btnShpToJson_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "Json Path:";
            // 
            // tbJsonPath
            // 
            this.tbJsonPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJsonPath.Location = new System.Drawing.Point(103, 42);
            this.tbJsonPath.Name = "tbJsonPath";
            this.tbJsonPath.Size = new System.Drawing.Size(440, 21);
            this.tbJsonPath.TabIndex = 27;
            // 
            // btnJsonBrowser
            // 
            this.btnJsonBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJsonBrowser.Location = new System.Drawing.Point(549, 44);
            this.btnJsonBrowser.Name = "btnJsonBrowser";
            this.btnJsonBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnJsonBrowser.TabIndex = 28;
            this.btnJsonBrowser.Text = "浏览";
            this.btnJsonBrowser.UseVisualStyleBackColor = true;
            this.btnJsonBrowser.Click += new System.EventHandler(this.btnJsonBrowser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "Shp Path:";
            // 
            // tbShapefilePath
            // 
            this.tbShapefilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShapefilePath.Location = new System.Drawing.Point(103, 15);
            this.tbShapefilePath.Name = "tbShapefilePath";
            this.tbShapefilePath.Size = new System.Drawing.Size(440, 21);
            this.tbShapefilePath.TabIndex = 23;
            // 
            // btnShapefileBrowser
            // 
            this.btnShapefileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShapefileBrowser.Location = new System.Drawing.Point(549, 15);
            this.btnShapefileBrowser.Name = "btnShapefileBrowser";
            this.btnShapefileBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnShapefileBrowser.TabIndex = 24;
            this.btnShapefileBrowser.Text = "浏览";
            this.btnShapefileBrowser.UseVisualStyleBackColor = true;
            this.btnShapefileBrowser.Click += new System.EventHandler(this.btnShapefileBrowser_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnJsonToShp);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbShp);
            this.tabPage2.Controls.Add(this.btnShpPath);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbJson);
            this.tabPage2.Controls.Add(this.btnJsonPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Json To Shp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnJsonToShp
            // 
            this.btnJsonToShp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJsonToShp.Location = new System.Drawing.Point(552, 95);
            this.btnJsonToShp.Name = "btnJsonToShp";
            this.btnJsonToShp.Size = new System.Drawing.Size(75, 23);
            this.btnJsonToShp.TabIndex = 37;
            this.btnJsonToShp.Text = "生成";
            this.btnJsonToShp.UseVisualStyleBackColor = true;
            this.btnJsonToShp.Click += new System.EventHandler(this.btnJsonToShp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "Json Path:";
            // 
            // tbShp
            // 
            this.tbShp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShp.Location = new System.Drawing.Point(76, 52);
            this.tbShp.Name = "tbShp";
            this.tbShp.Size = new System.Drawing.Size(470, 21);
            this.tbShp.TabIndex = 34;
            // 
            // btnShpPath
            // 
            this.btnShpPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShpPath.Location = new System.Drawing.Point(552, 52);
            this.btnShpPath.Name = "btnShpPath";
            this.btnShpPath.Size = new System.Drawing.Size(75, 23);
            this.btnShpPath.TabIndex = 35;
            this.btnShpPath.Text = "浏览";
            this.btnShpPath.UseVisualStyleBackColor = true;
            this.btnShpPath.Click += new System.EventHandler(this.btnShpPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "Shp Path:";
            // 
            // tbJson
            // 
            this.tbJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJson.Location = new System.Drawing.Point(76, 23);
            this.tbJson.Name = "tbJson";
            this.tbJson.Size = new System.Drawing.Size(470, 21);
            this.tbJson.TabIndex = 31;
            // 
            // btnJsonPath
            // 
            this.btnJsonPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJsonPath.Location = new System.Drawing.Point(552, 23);
            this.btnJsonPath.Name = "btnJsonPath";
            this.btnJsonPath.Size = new System.Drawing.Size(75, 23);
            this.btnJsonPath.TabIndex = 32;
            this.btnJsonPath.Text = "浏览";
            this.btnJsonPath.UseVisualStyleBackColor = true;
            this.btnJsonPath.Click += new System.EventHandler(this.btnJsonPath_Click);
            // 
            // FrmTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 495);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmTools";
            this.Text = "FrmTools";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnShpToJson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJsonPath;
        private System.Windows.Forms.Button btnJsonBrowser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbShapefilePath;
        private System.Windows.Forms.Button btnShapefileBrowser;
        private System.Windows.Forms.Button btnShpToTopoJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTopoJsonPath;
        private System.Windows.Forms.Button btnTopoJsonBrowser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnJsonToShp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbShp;
        private System.Windows.Forms.Button btnShpPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbJson;
        private System.Windows.Forms.Button btnJsonPath;
    }
}