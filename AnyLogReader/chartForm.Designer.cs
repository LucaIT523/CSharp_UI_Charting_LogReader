namespace AnyLogReader
{
    partial class chartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chartForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.startTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.startTimeTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.endTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.endTimeTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalCountsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalCountsTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentCountsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentCountsTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.zoomRateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.zoomRateTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.noG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftTimeG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startValueG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightTimeG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endValueG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deltaTimeG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deltaValueG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minValueG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxValueG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeImgBtn = new System.Windows.Forms.PictureBox();
            this.saveImgBtn = new System.Windows.Forms.PictureBox();
            this.moveImgBtn = new System.Windows.Forms.PictureBox();
            this.zoomOutImgBtn = new System.Windows.Forms.PictureBox();
            this.logoDownLoadBtn = new System.Windows.Forms.PictureBox();
            this.logoDirOpenBtn = new System.Windows.Forms.PictureBox();
            this.zoomInImgBtn = new System.Windows.Forms.PictureBox();
            this.filePathTxt = new System.Windows.Forms.Label();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeImgBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveImgBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveImgBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomOutImgBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoDownLoadBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoDirOpenBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomInImgBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTimeLabel,
            this.startTimeTxt,
            this.endTimeLabel,
            this.endTimeTxt,
            this.totalCountsLabel,
            this.totalCountsTxt,
            this.currentCountsLabel,
            this.currentCountsTxt,
            this.zoomRateLabel,
            this.zoomRateTxt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1194, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(66, 17);
            this.startTimeLabel.Text = "Start Time :";
            // 
            // startTimeTxt
            // 
            this.startTimeTxt.Name = "startTimeTxt";
            this.startTimeTxt.Size = new System.Drawing.Size(49, 17);
            this.startTimeTxt.Text = "00:00:00";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(62, 17);
            this.endTimeLabel.Text = "End Time :";
            // 
            // endTimeTxt
            // 
            this.endTimeTxt.Name = "endTimeTxt";
            this.endTimeTxt.Size = new System.Drawing.Size(49, 17);
            this.endTimeTxt.Text = "00:00:00";
            // 
            // totalCountsLabel
            // 
            this.totalCountsLabel.Name = "totalCountsLabel";
            this.totalCountsLabel.Size = new System.Drawing.Size(79, 17);
            this.totalCountsLabel.Text = "Total Counts :";
            // 
            // totalCountsTxt
            // 
            this.totalCountsTxt.Name = "totalCountsTxt";
            this.totalCountsTxt.Size = new System.Drawing.Size(13, 17);
            this.totalCountsTxt.Text = "0";
            // 
            // currentCountsLabel
            // 
            this.currentCountsLabel.Name = "currentCountsLabel";
            this.currentCountsLabel.Size = new System.Drawing.Size(94, 17);
            this.currentCountsLabel.Text = "Current Counts :";
            // 
            // currentCountsTxt
            // 
            this.currentCountsTxt.Name = "currentCountsTxt";
            this.currentCountsTxt.Size = new System.Drawing.Size(13, 17);
            this.currentCountsTxt.Text = "0";
            // 
            // zoomRateLabel
            // 
            this.zoomRateLabel.Name = "zoomRateLabel";
            this.zoomRateLabel.Size = new System.Drawing.Size(75, 17);
            this.zoomRateLabel.Text = "ZOOM Rate :";
            // 
            // zoomRateTxt
            // 
            this.zoomRateTxt.Name = "zoomRateTxt";
            this.zoomRateTxt.Size = new System.Drawing.Size(13, 17);
            this.zoomRateTxt.Text = "1";
            // 
            // resultGrid
            // 
            this.resultGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noG,
            this.itemNameG,
            this.leftTimeG,
            this.startValueG,
            this.rightTimeG,
            this.endValueG,
            this.deltaTimeG,
            this.deltaValueG,
            this.minValueG,
            this.maxValueG});
            this.resultGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resultGrid.Location = new System.Drawing.Point(0, 510);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.Size = new System.Drawing.Size(1194, 129);
            this.resultGrid.TabIndex = 5;
            // 
            // noG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.noG.DefaultCellStyle = dataGridViewCellStyle1;
            this.noG.HeaderText = "No";
            this.noG.Name = "noG";
            this.noG.ReadOnly = true;
            this.noG.Width = 35;
            // 
            // itemNameG
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.itemNameG.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemNameG.HeaderText = "   Name";
            this.itemNameG.Name = "itemNameG";
            this.itemNameG.ReadOnly = true;
            // 
            // leftTimeG
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.leftTimeG.DefaultCellStyle = dataGridViewCellStyle3;
            this.leftTimeG.HeaderText = "      Left Time";
            this.leftTimeG.Name = "leftTimeG";
            this.leftTimeG.ReadOnly = true;
            // 
            // startValueG
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.startValueG.DefaultCellStyle = dataGridViewCellStyle4;
            this.startValueG.HeaderText = "   Value";
            this.startValueG.Name = "startValueG";
            this.startValueG.ReadOnly = true;
            this.startValueG.Width = 135;
            // 
            // rightTimeG
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.rightTimeG.DefaultCellStyle = dataGridViewCellStyle5;
            this.rightTimeG.HeaderText = "   Right Time";
            this.rightTimeG.Name = "rightTimeG";
            this.rightTimeG.ReadOnly = true;
            // 
            // endValueG
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.endValueG.DefaultCellStyle = dataGridViewCellStyle6;
            this.endValueG.HeaderText = "   Value";
            this.endValueG.Name = "endValueG";
            this.endValueG.ReadOnly = true;
            this.endValueG.Width = 135;
            // 
            // deltaTimeG
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.deltaTimeG.DefaultCellStyle = dataGridViewCellStyle7;
            this.deltaTimeG.HeaderText = "   Delta Time";
            this.deltaTimeG.Name = "deltaTimeG";
            this.deltaTimeG.ReadOnly = true;
            this.deltaTimeG.Width = 120;
            // 
            // deltaValueG
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.deltaValueG.DefaultCellStyle = dataGridViewCellStyle8;
            this.deltaValueG.HeaderText = "   Delta Value";
            this.deltaValueG.Name = "deltaValueG";
            this.deltaValueG.ReadOnly = true;
            this.deltaValueG.Width = 150;
            // 
            // minValueG
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.minValueG.DefaultCellStyle = dataGridViewCellStyle9;
            this.minValueG.HeaderText = "   Min Value";
            this.minValueG.Name = "minValueG";
            this.minValueG.ReadOnly = true;
            this.minValueG.Width = 135;
            // 
            // maxValueG
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.maxValueG.DefaultCellStyle = dataGridViewCellStyle10;
            this.maxValueG.HeaderText = "   Max Value";
            this.maxValueG.Name = "maxValueG";
            this.maxValueG.ReadOnly = true;
            this.maxValueG.Width = 135;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.filePathTxt);
            this.panel1.Controls.Add(this.filePathLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 469);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 41);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeImgBtn);
            this.panel2.Controls.Add(this.saveImgBtn);
            this.panel2.Controls.Add(this.moveImgBtn);
            this.panel2.Controls.Add(this.zoomOutImgBtn);
            this.panel2.Controls.Add(this.logoDownLoadBtn);
            this.panel2.Controls.Add(this.logoDirOpenBtn);
            this.panel2.Controls.Add(this.zoomInImgBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(774, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 39);
            this.panel2.TabIndex = 10;
            // 
            // closeImgBtn
            // 
            this.closeImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeImgBtn.Image")));
            this.closeImgBtn.Location = new System.Drawing.Point(369, 0);
            this.closeImgBtn.Name = "closeImgBtn";
            this.closeImgBtn.Size = new System.Drawing.Size(41, 39);
            this.closeImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeImgBtn.TabIndex = 8;
            this.closeImgBtn.TabStop = false;
            this.closeImgBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Down);
            this.closeImgBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Up);
            // 
            // saveImgBtn
            // 
            this.saveImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveImgBtn.Image")));
            this.saveImgBtn.Location = new System.Drawing.Point(300, 0);
            this.saveImgBtn.Name = "saveImgBtn";
            this.saveImgBtn.Size = new System.Drawing.Size(37, 39);
            this.saveImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveImgBtn.TabIndex = 9;
            this.saveImgBtn.TabStop = false;
            this.saveImgBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Down);
            this.saveImgBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Up);
            // 
            // moveImgBtn
            // 
            this.moveImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("moveImgBtn.Image")));
            this.moveImgBtn.Location = new System.Drawing.Point(223, 0);
            this.moveImgBtn.Name = "moveImgBtn";
            this.moveImgBtn.Size = new System.Drawing.Size(42, 39);
            this.moveImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveImgBtn.TabIndex = 10;
            this.moveImgBtn.TabStop = false;
            this.moveImgBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Down);
            this.moveImgBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Up);
            // 
            // zoomOutImgBtn
            // 
            this.zoomOutImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutImgBtn.Image")));
            this.zoomOutImgBtn.Location = new System.Drawing.Point(169, 0);
            this.zoomOutImgBtn.Name = "zoomOutImgBtn";
            this.zoomOutImgBtn.Size = new System.Drawing.Size(37, 39);
            this.zoomOutImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zoomOutImgBtn.TabIndex = 11;
            this.zoomOutImgBtn.TabStop = false;
            this.zoomOutImgBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Down);
            this.zoomOutImgBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Up);
            // 
            // logoDownLoadBtn
            // 
            this.logoDownLoadBtn.Image = global::AnyLogReader.Properties.Resources.go1;
            this.logoDownLoadBtn.Location = new System.Drawing.Point(50, 0);
            this.logoDownLoadBtn.Name = "logoDownLoadBtn";
            this.logoDownLoadBtn.Size = new System.Drawing.Size(39, 39);
            this.logoDownLoadBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDownLoadBtn.TabIndex = 12;
            this.logoDownLoadBtn.TabStop = false;
            this.logoDownLoadBtn.DoubleClick += new System.EventHandler(this.onLogoDownLoad);
            this.logoDownLoadBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Down);
            this.logoDownLoadBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Up);
            // 
            // logoDirOpenBtn
            // 
            this.logoDirOpenBtn.Image = global::AnyLogReader.Properties.Resources.Lo1;
            this.logoDirOpenBtn.Location = new System.Drawing.Point(0, 0);
            this.logoDirOpenBtn.Name = "logoDirOpenBtn";
            this.logoDirOpenBtn.Size = new System.Drawing.Size(50, 39);
            this.logoDirOpenBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDirOpenBtn.TabIndex = 13;
            this.logoDirOpenBtn.TabStop = false;
            this.logoDirOpenBtn.DoubleClick += new System.EventHandler(this.onLogoDirOpen);
            this.logoDirOpenBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Down);
            this.logoDirOpenBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Up);
            // 
            // zoomInImgBtn
            // 
            this.zoomInImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("zoomInImgBtn.Image")));
            this.zoomInImgBtn.Location = new System.Drawing.Point(114, 0);
            this.zoomInImgBtn.Name = "zoomInImgBtn";
            this.zoomInImgBtn.Size = new System.Drawing.Size(37, 39);
            this.zoomInImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zoomInImgBtn.TabIndex = 14;
            this.zoomInImgBtn.TabStop = false;
            this.zoomInImgBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Down);
            this.zoomInImgBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageButton_Up);
            // 
            // filePathTxt
            // 
            this.filePathTxt.AutoSize = true;
            this.filePathTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.filePathTxt.Location = new System.Drawing.Point(67, 21);
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(85, 13);
            this.filePathTxt.TabIndex = 8;
            this.filePathTxt.Text = "Current File Path";
            this.filePathTxt.DoubleClick += new System.EventHandler(this.filePathTxt_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(8, 21);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(54, 13);
            this.filePathLabel.TabIndex = 8;
            this.filePathLabel.Text = "File Path :";
            // 
            // chart
            // 
            this.chart.BackSecondaryColor = System.Drawing.Color.Black;
            this.chart.BorderlineColor = System.Drawing.Color.Black;
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Value";
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            chartArea1.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.IsSoftShadows = false;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(0);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1194, 469);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart";
            // 
            // chartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 661);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultGrid);
            this.Controls.Add(this.statusStrip1);
            this.Name = "chartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Any Log Reader";
            this.Load += new System.EventHandler(this.chartForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeImgBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveImgBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveImgBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomOutImgBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoDownLoadBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoDirOpenBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomInImgBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn noG;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameG;
        private System.Windows.Forms.DataGridViewTextBoxColumn leftTimeG;
        private System.Windows.Forms.DataGridViewTextBoxColumn startValueG;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightTimeG;
        private System.Windows.Forms.DataGridViewTextBoxColumn endValueG;
        private System.Windows.Forms.DataGridViewTextBoxColumn deltaTimeG;
        private System.Windows.Forms.DataGridViewTextBoxColumn deltaValueG;
        private System.Windows.Forms.DataGridViewTextBoxColumn minValueG;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxValueG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closeImgBtn;
        private System.Windows.Forms.PictureBox saveImgBtn;
        private System.Windows.Forms.PictureBox moveImgBtn;
        private System.Windows.Forms.PictureBox zoomOutImgBtn;
        private System.Windows.Forms.PictureBox logoDownLoadBtn;
        private System.Windows.Forms.PictureBox logoDirOpenBtn;
        private System.Windows.Forms.PictureBox zoomInImgBtn;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label filePathTxt;
        private System.Windows.Forms.ToolStripStatusLabel startTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel startTimeTxt;
        private System.Windows.Forms.ToolStripStatusLabel endTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel endTimeTxt;
        private System.Windows.Forms.ToolStripStatusLabel totalCountsLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalCountsTxt;
        private System.Windows.Forms.ToolStripStatusLabel currentCountsLabel;
        private System.Windows.Forms.ToolStripStatusLabel currentCountsTxt;
        private System.Windows.Forms.ToolStripStatusLabel zoomRateLabel;
        private System.Windows.Forms.ToolStripStatusLabel zoomRateTxt;
    }
}