namespace AnyLogReader
{
    partial class downloadLogoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(downloadLogoForm));
            this.siteURLLabel = new System.Windows.Forms.Label();
            this.logoURLTxt = new System.Windows.Forms.TextBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RightImgBtn = new System.Windows.Forms.RadioButton();
            this.leftImgBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siteURLLabel
            // 
            this.siteURLLabel.AutoSize = true;
            this.siteURLLabel.Location = new System.Drawing.Point(17, 16);
            this.siteURLLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.siteURLLabel.Name = "siteURLLabel";
            this.siteURLLabel.Size = new System.Drawing.Size(109, 16);
            this.siteURLLabel.TabIndex = 0;
            this.siteURLLabel.Text = "LogoImageURL :";
            // 
            // logoURLTxt
            // 
            this.logoURLTxt.Location = new System.Drawing.Point(134, 13);
            this.logoURLTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoURLTxt.Name = "logoURLTxt";
            this.logoURLTxt.Size = new System.Drawing.Size(455, 22);
            this.logoURLTxt.TabIndex = 1;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(403, 62);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(83, 34);
            this.downloadBtn.TabIndex = 3;
            this.downloadBtn.Text = "DownLoad";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(514, 62);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 34);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RightImgBtn);
            this.groupBox1.Controls.Add(this.leftImgBtn);
            this.groupBox1.Location = new System.Drawing.Point(32, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 41);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logo Position";
            // 
            // RightImgBtn
            // 
            this.RightImgBtn.AutoSize = true;
            this.RightImgBtn.Location = new System.Drawing.Point(216, 14);
            this.RightImgBtn.Name = "RightImgBtn";
            this.RightImgBtn.Size = new System.Drawing.Size(131, 20);
            this.RightImgBtn.TabIndex = 3;
            this.RightImgBtn.Text = "Right Logo Image";
            this.RightImgBtn.UseVisualStyleBackColor = true;
            // 
            // leftImgBtn
            // 
            this.leftImgBtn.AutoSize = true;
            this.leftImgBtn.Checked = true;
            this.leftImgBtn.Location = new System.Drawing.Point(89, 14);
            this.leftImgBtn.Name = "leftImgBtn";
            this.leftImgBtn.Size = new System.Drawing.Size(121, 20);
            this.leftImgBtn.TabIndex = 4;
            this.leftImgBtn.TabStop = true;
            this.leftImgBtn.Text = "Left Logo Image";
            this.leftImgBtn.UseVisualStyleBackColor = true;
            // 
            // downloadLogoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 119);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.logoURLTxt);
            this.Controls.Add(this.siteURLLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "downloadLogoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AnyLogoReader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label siteURLLabel;
        private System.Windows.Forms.TextBox logoURLTxt;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RightImgBtn;
        private System.Windows.Forms.RadioButton leftImgBtn;
    }
}