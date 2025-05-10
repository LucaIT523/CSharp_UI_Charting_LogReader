using System.Windows.Forms;

namespace AnyLogReader
{
    partial class documentForm
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
            /*if(mainForm != null)
            {
                mainForm.Show();
            }
            else*/
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(documentForm));
            this.nextBtn = new System.Windows.Forms.Button();
            this.operatorNameLabel = new System.Windows.Forms.Label();
            this.operatorNameTxt = new System.Windows.Forms.TextBox();
            this.transducerNameLabel = new System.Windows.Forms.Label();
            this.transducerNameTxt = new System.Windows.Forms.TextBox();
            this.createDateLabel = new System.Windows.Forms.Label();
            this.creatDate = new System.Windows.Forms.DateTimePicker();
            this.colseBtn = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerTxt = new System.Windows.Forms.TextBox();
            this.wellNumberLabel = new System.Windows.Forms.Label();
            this.wellNumberTxt = new System.Windows.Forms.TextBox();
            this.jobDescriptionLabel = new System.Windows.Forms.Label();
            this.jobDescriptionTxt = new System.Windows.Forms.TextBox();
            this.jobSAPLabel = new System.Windows.Forms.Label();
            this.jobSAPTxt = new System.Windows.Forms.TextBox();
            this.coustomerRepLabel = new System.Windows.Forms.Label();
            this.customerRepTxt = new System.Windows.Forms.TextBox();
            this.transducerSNLabel = new System.Windows.Forms.Label();
            this.transducerSNTxt = new System.Windows.Forms.TextBox();
            this.transducerCaliDataLabel = new System.Windows.Forms.Label();
            this.transCaliData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(130, 341);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(111, 28);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // operatorNameLabel
            // 
            this.operatorNameLabel.AutoSize = true;
            this.operatorNameLabel.Location = new System.Drawing.Point(23, 24);
            this.operatorNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.operatorNameLabel.Name = "operatorNameLabel";
            this.operatorNameLabel.Size = new System.Drawing.Size(100, 16);
            this.operatorNameLabel.TabIndex = 5;
            this.operatorNameLabel.Text = "Operator Name";
            // 
            // operatorNameTxt
            // 
            this.operatorNameTxt.Location = new System.Drawing.Point(226, 21);
            this.operatorNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.operatorNameTxt.Name = "operatorNameTxt";
            this.operatorNameTxt.Size = new System.Drawing.Size(155, 22);
            this.operatorNameTxt.TabIndex = 0;
            // 
            // transducerNameLabel
            // 
            this.transducerNameLabel.AutoSize = true;
            this.transducerNameLabel.Location = new System.Drawing.Point(23, 236);
            this.transducerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transducerNameLabel.Name = "transducerNameLabel";
            this.transducerNameLabel.Size = new System.Drawing.Size(116, 16);
            this.transducerNameLabel.TabIndex = 5;
            this.transducerNameLabel.Text = "Transducer Name";
            // 
            // transducerNameTxt
            // 
            this.transducerNameTxt.Location = new System.Drawing.Point(226, 233);
            this.transducerNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.transducerNameTxt.Name = "transducerNameTxt";
            this.transducerNameTxt.Size = new System.Drawing.Size(155, 22);
            this.transducerNameTxt.TabIndex = 7;
            // 
            // createDateLabel
            // 
            this.createDateLabel.AutoSize = true;
            this.createDateLabel.Location = new System.Drawing.Point(23, 205);
            this.createDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createDateLabel.Name = "createDateLabel";
            this.createDateLabel.Size = new System.Drawing.Size(36, 16);
            this.createDateLabel.TabIndex = 5;
            this.createDateLabel.Text = "Date";
            // 
            // creatDate
            // 
            this.creatDate.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.creatDate.CustomFormat = "dd MMM yyyy - HH:mm";
            this.creatDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.creatDate.Location = new System.Drawing.Point(226, 202);
            this.creatDate.Name = "creatDate";
            this.creatDate.Size = new System.Drawing.Size(155, 22);
            this.creatDate.TabIndex = 6;
            // 
            // colseBtn
            // 
            this.colseBtn.Location = new System.Drawing.Point(270, 341);
            this.colseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.colseBtn.Name = "colseBtn";
            this.colseBtn.Size = new System.Drawing.Size(111, 28);
            this.colseBtn.TabIndex = 11;
            this.colseBtn.Text = "Close";
            this.colseBtn.UseVisualStyleBackColor = true;
            this.colseBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(23, 54);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(64, 16);
            this.customerLabel.TabIndex = 5;
            this.customerLabel.Text = "Customer";
            // 
            // customerTxt
            // 
            this.customerTxt.Location = new System.Drawing.Point(226, 51);
            this.customerTxt.Margin = new System.Windows.Forms.Padding(4);
            this.customerTxt.Name = "customerTxt";
            this.customerTxt.Size = new System.Drawing.Size(155, 22);
            this.customerTxt.TabIndex = 1;
            // 
            // wellNumberLabel
            // 
            this.wellNumberLabel.AutoSize = true;
            this.wellNumberLabel.Location = new System.Drawing.Point(23, 84);
            this.wellNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wellNumberLabel.Name = "wellNumberLabel";
            this.wellNumberLabel.Size = new System.Drawing.Size(85, 16);
            this.wellNumberLabel.TabIndex = 5;
            this.wellNumberLabel.Text = "Well Number";
            // 
            // wellNumberTxt
            // 
            this.wellNumberTxt.Location = new System.Drawing.Point(226, 81);
            this.wellNumberTxt.Margin = new System.Windows.Forms.Padding(4);
            this.wellNumberTxt.Name = "wellNumberTxt";
            this.wellNumberTxt.Size = new System.Drawing.Size(155, 22);
            this.wellNumberTxt.TabIndex = 2;
            // 
            // jobDescriptionLabel
            // 
            this.jobDescriptionLabel.AutoSize = true;
            this.jobDescriptionLabel.Location = new System.Drawing.Point(23, 114);
            this.jobDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobDescriptionLabel.Name = "jobDescriptionLabel";
            this.jobDescriptionLabel.Size = new System.Drawing.Size(101, 16);
            this.jobDescriptionLabel.TabIndex = 5;
            this.jobDescriptionLabel.Text = "Job Description";
            // 
            // jobDescriptionTxt
            // 
            this.jobDescriptionTxt.Location = new System.Drawing.Point(226, 111);
            this.jobDescriptionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.jobDescriptionTxt.Name = "jobDescriptionTxt";
            this.jobDescriptionTxt.Size = new System.Drawing.Size(155, 22);
            this.jobDescriptionTxt.TabIndex = 3;
            // 
            // jobSAPLabel
            // 
            this.jobSAPLabel.AutoSize = true;
            this.jobSAPLabel.Location = new System.Drawing.Point(23, 144);
            this.jobSAPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobSAPLabel.Name = "jobSAPLabel";
            this.jobSAPLabel.Size = new System.Drawing.Size(59, 16);
            this.jobSAPLabel.TabIndex = 5;
            this.jobSAPLabel.Text = "Job SO#";
            // 
            // jobSAPTxt
            // 
            this.jobSAPTxt.Location = new System.Drawing.Point(226, 141);
            this.jobSAPTxt.Margin = new System.Windows.Forms.Padding(4);
            this.jobSAPTxt.Name = "jobSAPTxt";
            this.jobSAPTxt.Size = new System.Drawing.Size(155, 22);
            this.jobSAPTxt.TabIndex = 4;
            // 
            // coustomerRepLabel
            // 
            this.coustomerRepLabel.AutoSize = true;
            this.coustomerRepLabel.Location = new System.Drawing.Point(23, 174);
            this.coustomerRepLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coustomerRepLabel.Name = "coustomerRepLabel";
            this.coustomerRepLabel.Size = new System.Drawing.Size(159, 16);
            this.coustomerRepLabel.TabIndex = 5;
            this.coustomerRepLabel.Text = "Customer Representative";
            // 
            // customerRepTxt
            // 
            this.customerRepTxt.Location = new System.Drawing.Point(226, 171);
            this.customerRepTxt.Margin = new System.Windows.Forms.Padding(4);
            this.customerRepTxt.Name = "customerRepTxt";
            this.customerRepTxt.Size = new System.Drawing.Size(155, 22);
            this.customerRepTxt.TabIndex = 5;
            // 
            // transducerSNLabel
            // 
            this.transducerSNLabel.AutoSize = true;
            this.transducerSNLabel.Location = new System.Drawing.Point(23, 268);
            this.transducerSNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transducerSNLabel.Name = "transducerSNLabel";
            this.transducerSNLabel.Size = new System.Drawing.Size(165, 16);
            this.transducerSNLabel.TabIndex = 5;
            this.transducerSNLabel.Text = "Transducer Serial Number";
            // 
            // transducerSNTxt
            // 
            this.transducerSNTxt.Location = new System.Drawing.Point(226, 265);
            this.transducerSNTxt.Margin = new System.Windows.Forms.Padding(4);
            this.transducerSNTxt.Name = "transducerSNTxt";
            this.transducerSNTxt.Size = new System.Drawing.Size(155, 22);
            this.transducerSNTxt.TabIndex = 8;
            // 
            // transducerCaliDataLabel
            // 
            this.transducerCaliDataLabel.AutoSize = true;
            this.transducerCaliDataLabel.Location = new System.Drawing.Point(23, 300);
            this.transducerCaliDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transducerCaliDataLabel.Name = "transducerCaliDataLabel";
            this.transducerCaliDataLabel.Size = new System.Drawing.Size(199, 16);
            this.transducerCaliDataLabel.TabIndex = 5;
            this.transducerCaliDataLabel.Text = "Transducer Calibration due date";
            // 
            // transCaliData
            // 
            this.transCaliData.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.transCaliData.CustomFormat = "dd MMM yyyy";
            this.transCaliData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.transCaliData.Location = new System.Drawing.Point(226, 297);
            this.transCaliData.Name = "transCaliData";
            this.transCaliData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.transCaliData.Size = new System.Drawing.Size(155, 22);
            this.transCaliData.TabIndex = 9;
            // 
            // documentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 388);
            this.Controls.Add(this.transCaliData);
            this.Controls.Add(this.creatDate);
            this.Controls.Add(this.transducerSNTxt);
            this.Controls.Add(this.transducerNameTxt);
            this.Controls.Add(this.customerRepTxt);
            this.Controls.Add(this.jobSAPTxt);
            this.Controls.Add(this.jobDescriptionTxt);
            this.Controls.Add(this.coustomerRepLabel);
            this.Controls.Add(this.wellNumberTxt);
            this.Controls.Add(this.jobSAPLabel);
            this.Controls.Add(this.customerTxt);
            this.Controls.Add(this.jobDescriptionLabel);
            this.Controls.Add(this.operatorNameTxt);
            this.Controls.Add(this.wellNumberLabel);
            this.Controls.Add(this.transducerCaliDataLabel);
            this.Controls.Add(this.createDateLabel);
            this.Controls.Add(this.transducerSNLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.transducerNameLabel);
            this.Controls.Add(this.operatorNameLabel);
            this.Controls.Add(this.colseBtn);
            this.Controls.Add(this.nextBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "documentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Any Log Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button nextBtn;
        private Label operatorNameLabel;
        private TextBox operatorNameTxt;
        private Label transducerNameLabel;
        private TextBox transducerNameTxt;
        private Label createDateLabel;
        private DateTimePicker creatDate;
        private Button colseBtn;
        private Label customerLabel;
        private TextBox customerTxt;
        private Label wellNumberLabel;
        private TextBox wellNumberTxt;
        private Label jobDescriptionLabel;
        private TextBox jobDescriptionTxt;
        private Label jobSAPLabel;
        private TextBox jobSAPTxt;
        private Label coustomerRepLabel;
        private TextBox customerRepTxt;
        private Label transducerSNLabel;
        private TextBox transducerSNTxt;
        private Label transducerCaliDataLabel;
        private DateTimePicker transCaliData;
    }
}