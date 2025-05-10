namespace AnyLogReader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.typeGB = new System.Windows.Forms.GroupBox();
            this.kellerBtn = new System.Windows.Forms.RadioButton();
            this.leoBtn = new System.Windows.Forms.RadioButton();
            this.openBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileTypeTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.spilit = new System.Windows.Forms.ToolStripStatusLabel();
            this.filePathTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.typeGB.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeGB
            // 
            this.typeGB.BackColor = System.Drawing.Color.Gray;
            this.typeGB.Controls.Add(this.leoBtn);
            this.typeGB.Controls.Add(this.kellerBtn);
            this.typeGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.typeGB.Location = new System.Drawing.Point(22, 18);
            this.typeGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeGB.Name = "typeGB";
            this.typeGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeGB.Size = new System.Drawing.Size(392, 77);
            this.typeGB.TabIndex = 2;
            this.typeGB.TabStop = false;
            this.typeGB.Text = "XLSX Type";
            // 
            // kellerBtn
            // 
            this.kellerBtn.AutoSize = true;
            this.kellerBtn.Location = new System.Drawing.Point(200, 35);
            this.kellerBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kellerBtn.Name = "kellerBtn";
            this.kellerBtn.Size = new System.Drawing.Size(89, 24);
            this.kellerBtn.TabIndex = 1;
            this.kellerBtn.Text = "KELLER";
            this.kellerBtn.UseVisualStyleBackColor = true;
            // 
            // leoBtn
            // 
            this.leoBtn.AutoSize = true;
            this.leoBtn.Checked = true;
            this.leoBtn.Location = new System.Drawing.Point(82, 35);
            this.leoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leoBtn.Name = "leoBtn";
            this.leoBtn.Size = new System.Drawing.Size(59, 24);
            this.leoBtn.TabIndex = 0;
            this.leoBtn.TabStop = true;
            this.leoBtn.Text = "LEO";
            this.leoBtn.UseVisualStyleBackColor = true;
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.DarkGray;
            this.openBtn.Location = new System.Drawing.Point(130, 111);
            this.openBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(124, 35);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open File";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.DarkGray;
            this.nextBtn.Location = new System.Drawing.Point(290, 111);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(124, 35);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTypeTxt,
            this.spilit,
            this.filePathTxt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 163);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(430, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileTypeTxt
            // 
            this.fileTypeTxt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fileTypeTxt.Name = "fileTypeTxt";
            this.fileTypeTxt.Size = new System.Drawing.Size(59, 17);
            this.fileTypeTxt.Text = "UNKOWN";
            // 
            // spilit
            // 
            this.spilit.Name = "spilit";
            this.spilit.Size = new System.Drawing.Size(16, 17);
            this.spilit.Text = " : ";
            // 
            // filePathTxt
            // 
            this.filePathTxt.AutoToolTip = true;
            this.filePathTxt.DoubleClickEnabled = true;
            this.filePathTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(120, 17);
            this.filePathTxt.Text = "Please click Open File";
            this.filePathTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filePathTxt.DoubleClick += new System.EventHandler(this.filePath_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(430, 185);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.typeGB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Any Log Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.typeGB.ResumeLayout(false);
            this.typeGB.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox typeGB;
        private System.Windows.Forms.RadioButton kellerBtn;
        private System.Windows.Forms.RadioButton leoBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fileTypeTxt;
        private System.Windows.Forms.ToolStripStatusLabel filePathTxt;
        private System.Windows.Forms.ToolStripStatusLabel spilit;
    }
}

