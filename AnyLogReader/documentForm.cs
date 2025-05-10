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
    public partial class documentForm : Form
    {
        public MainForm mainForm;
        public documentForm()
        {
            InitializeComponent();
            mainForm = null;
#if DEBUG
            operatorNameTxt.Text = "Operator";
            customerTxt.Text = "Customer";
            wellNumberTxt.Text = "1";
            jobDescriptionTxt.Text = "Job Description";
            jobSAPTxt.Text = "Job SAP#";
            customerRepTxt.Text = "Customer Representative";
            transducerNameTxt.Text = "Transducer Name";
            transducerSNTxt.Text = "1";
#endif

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (operatorNameTxt.Text == "")
            {
                MessageBox.Show("Please enter the Operator Name!");
                return;
            }
            if (customerTxt.Text == "")
            {
                MessageBox.Show("Please enter the Customer!");
                return;
            }
            if (wellNumberTxt.Text == "")
            {
                MessageBox.Show("Please enter the Well Number!");
                return;
            }
            if (jobDescriptionTxt.Text == "")
            {
                MessageBox.Show("Please enter the Job Description!");
                return;
            }
            if (jobSAPTxt.Text == "")
            {
                MessageBox.Show("Please enter the Job SAP#!");
                return;
            }
            if (customerRepTxt.Text == "")
            {
                MessageBox.Show("Please enter the Customer Representative!");
                return;
            }
            if (transducerNameTxt.Text == "")
            {
                MessageBox.Show("Please enter the Transducer Name!");
                return;
            }
            if (transducerSNTxt.Text == "")
            {
                MessageBox.Show("Please enter the Transducer Serial Number!");
                return;
            }
            mainForm.operatorName = operatorNameTxt.Text;
            mainForm.customer = customerTxt.Text;
            mainForm.wellNumber = wellNumberTxt.Text;
            mainForm.jobDescription = jobDescriptionTxt.Text;
            mainForm.jobSAP = jobSAPTxt.Text;
            mainForm.customerRep = customerRepTxt.Text;
            mainForm.transducerName = transducerNameTxt.Text;
            mainForm.transducerSN = transducerSNTxt.Text;
            mainForm.createDateTime = creatDate.Value;
            mainForm.transducerDateTime = transCaliData.Value;

            chartForm chart = new chartForm();
            chart.mainForm = mainForm;
            chart.Show();
            this.Hide();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
