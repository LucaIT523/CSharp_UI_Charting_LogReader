using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyLogReader
{
    public partial class downloadLogoForm : Form
    {
        public string logoURL;
        public bool leftImg;
        public downloadLogoForm()
        {
            InitializeComponent();
            logoURL = "";
            leftImg = true;
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            logoURL = logoURLTxt.Text;
            leftImg = leftImgBtn.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
