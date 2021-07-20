namespace rainControlDevelop
{
    partial class mainFrom
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPointsToMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToReadNewPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePointsToAFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polylineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawNewLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAFileAndReadTheLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveThePolylinesToAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAndOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputAsFormat1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputAsFormat2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polylinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hJelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapBox1 = new SharpMap.Forms.MapBox();
            this.openChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.operationToolStripMenuItem,
            this.verificationToolStripMenuItem,
            this.hJelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointToolStripMenuItem,
            this.polylineToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPointsToMapToolStripMenuItem,
            this.openFileToReadNewPointsToolStripMenuItem,
            this.savePointsToAFilesToolStripMenuItem});
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.pointToolStripMenuItem.Text = "Point";
            // 
            // addNewPointsToMapToolStripMenuItem
            // 
            this.addNewPointsToMapToolStripMenuItem.Name = "addNewPointsToMapToolStripMenuItem";
            this.addNewPointsToMapToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.addNewPointsToMapToolStripMenuItem.Text = "Add new points to map";
            this.addNewPointsToMapToolStripMenuItem.Click += new System.EventHandler(this.addNewPointsToMapToolStripMenuItem_Click);
            // 
            // openFileToReadNewPointsToolStripMenuItem
            // 
            this.openFileToReadNewPointsToolStripMenuItem.Name = "openFileToReadNewPointsToolStripMenuItem";
            this.openFileToReadNewPointsToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.openFileToReadNewPointsToolStripMenuItem.Text = "Open file to read new points";
            this.openFileToReadNewPointsToolStripMenuItem.Click += new System.EventHandler(this.openFileToReadNewPointsToolStripMenuItem_Click);
            // 
            // savePointsToAFilesToolStripMenuItem
            // 
            this.savePointsToAFilesToolStripMenuItem.Name = "savePointsToAFilesToolStripMenuItem";
            this.savePointsToAFilesToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.savePointsToAFilesToolStripMenuItem.Text = "Save points to a files";
            this.savePointsToAFilesToolStripMenuItem.Click += new System.EventHandler(this.savePointsToAFilesToolStripMenuItem_Click);
            // 
            // polylineToolStripMenuItem
            // 
            this.polylineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawNewLinesToolStripMenuItem,
            this.openAFileAndReadTheLinesToolStripMenuItem,
            this.saveThePolylinesToAFileToolStripMenuItem});
            this.polylineToolStripMenuItem.Name = "polylineToolStripMenuItem";
            this.polylineToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.polylineToolStripMenuItem.Text = "Polyline";
            // 
            // drawNewLinesToolStripMenuItem
            // 
            this.drawNewLinesToolStripMenuItem.Name = "drawNewLinesToolStripMenuItem";
            this.drawNewLinesToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.drawNewLinesToolStripMenuItem.Text = "Draw new lines";
            this.drawNewLinesToolStripMenuItem.Click += new System.EventHandler(this.drawNewLinesToolStripMenuItem_Click);
            // 
            // openAFileAndReadTheLinesToolStripMenuItem
            // 
            this.openAFileAndReadTheLinesToolStripMenuItem.Name = "openAFileAndReadTheLinesToolStripMenuItem";
            this.openAFileAndReadTheLinesToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.openAFileAndReadTheLinesToolStripMenuItem.Text = "Open a file and read the lines";
            this.openAFileAndReadTheLinesToolStripMenuItem.Click += new System.EventHandler(this.openAFileAndReadTheLinesToolStripMenuItem_Click);
            // 
            // saveThePolylinesToAFileToolStripMenuItem
            // 
            this.saveThePolylinesToAFileToolStripMenuItem.Name = "saveThePolylinesToAFileToolStripMenuItem";
            this.saveThePolylinesToAFileToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.saveThePolylinesToAFileToolStripMenuItem.Text = "Save the polylines to a file";
            this.saveThePolylinesToAFileToolStripMenuItem.Click += new System.EventHandler(this.saveThePolylinesToAFileToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runAndOutputToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // runAndOutputToolStripMenuItem
            // 
            this.runAndOutputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputAsFormat1ToolStripMenuItem,
            this.outputAsFormat2ToolStripMenuItem});
            this.runAndOutputToolStripMenuItem.Name = "runAndOutputToolStripMenuItem";
            this.runAndOutputToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.runAndOutputToolStripMenuItem.Text = "Run and output";
            // 
            // outputAsFormat1ToolStripMenuItem
            // 
            this.outputAsFormat1ToolStripMenuItem.Name = "outputAsFormat1ToolStripMenuItem";
            this.outputAsFormat1ToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.outputAsFormat1ToolStripMenuItem.Text = "output as format1";
            // 
            // outputAsFormat2ToolStripMenuItem
            // 
            this.outputAsFormat2ToolStripMenuItem.Name = "outputAsFormat2ToolStripMenuItem";
            this.outputAsFormat2ToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.outputAsFormat2ToolStripMenuItem.Text = "output as format2";
            // 
            // verificationToolStripMenuItem
            // 
            this.verificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsToolStripMenuItem,
            this.polylinesToolStripMenuItem});
            this.verificationToolStripMenuItem.Name = "verificationToolStripMenuItem";
            this.verificationToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.verificationToolStripMenuItem.Text = "Verification";
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.pointsToolStripMenuItem.Text = "Points";
            // 
            // polylinesToolStripMenuItem
            // 
            this.polylinesToolStripMenuItem.Name = "polylinesToolStripMenuItem";
            this.polylinesToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.polylinesToolStripMenuItem.Text = "Polylines";
            // 
            // hJelpToolStripMenuItem
            // 
            this.hJelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.hJelpToolStripMenuItem.Name = "hJelpToolStripMenuItem";
            this.hJelpToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.hJelpToolStripMenuItem.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // mapBox1
            // 
            this.mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.mapBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mapBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mapBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapBox1.CustomTool = null;
            this.mapBox1.FineZoomFactor = 10D;
            this.mapBox1.Location = new System.Drawing.Point(123, 41);
            this.mapBox1.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.mapBox1.Name = "mapBox1";
            this.mapBox1.QueryGrowFactor = 5F;
            this.mapBox1.QueryLayerIndex = 0;
            this.mapBox1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapBox1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapBox1.ShowProgressUpdate = false;
            this.mapBox1.Size = new System.Drawing.Size(956, 480);
            this.mapBox1.TabIndex = 0;
            this.mapBox1.Text = "mapBox1";
            this.mapBox1.WheelZoomMagnitude = -2D;
            // 
            // openChart
            // 
            this.openChart.Location = new System.Drawing.Point(12, 154);
            this.openChart.Name = "openChart";
            this.openChart.Size = new System.Drawing.Size(75, 23);
            this.openChart.TabIndex = 9;
            this.openChart.Text = "打开图标";
            this.openChart.UseVisualStyleBackColor = true;
            this.openChart.Click += new System.EventHandler(this.openChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // mainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 519);
            this.Controls.Add(this.openChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mapBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainFrom";
            this.Text = "rainProject";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpMap.Forms.MapBox mapBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPointsToMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToReadNewPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePointsToAFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polylineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawNewLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAFileAndReadTheLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveThePolylinesToAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAndOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputAsFormat1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputAsFormat2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polylinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hJelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.Button openChart;
        private System.Windows.Forms.Label label1;
    }
}

