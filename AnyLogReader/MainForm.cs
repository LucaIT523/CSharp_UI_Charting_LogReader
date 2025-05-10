using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Runtime.InteropServices;

namespace AnyLogReader
{
    enum FILETYPE { UNKNOWN = 0, LEO = 1, KELLER = 2 };
    public partial class MainForm : Form
    {
        readonly int[] vfLEO = { 10, 1, 3, 4, 6, 7, 8, 9 };      // header, verify rows
        readonly int[] vfKELLER = { 17, 1, 2, 4, 5, 6, 7 };    // header, verify rows
        readonly int[] cnvLEO = { 11, 1, 3 };                  // start row, No, x, y1, y2 
        readonly int[] cnvKELLER = { 19, 1, 3, 8, 9};         // start row, No, x, y1, y2, y3, y4
        public readonly string[] headerLEO = { "Time", "Pressure [PSI]", "Temperature [°C]" };
        public readonly string[] headerKELLER = {"Time", "blue lo [PSI]", "yelow uo [PSI]", "white uo [PSI]", "close [PSI]" };
        public ExcelPackage package;
        ExcelWorksheet rawSheet;
        public ExcelWorksheet cnvSheet;
        int rowCount;
        int colCount;
        public int cnvRowCount;
        public int cnvColCount;
        bool cnvState;
        FILETYPE fileType;
        public string filePath;
        public int seriesCount;


        /// Documentation Data Variable.
        public string operatorName;
        public string customer;
        public string wellNumber;
        public string jobDescription;
        public string jobSAP;
        public string customerRep;
        public string transducerName;
        public string transducerSN;
        public DateTime createDateTime;
        public DateTime transducerDateTime;
        public MainForm()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initialData();
            filePath = null;
            filePathTxt.Text = null;
        }
        void initialData()
        {
            seriesCount = 0;
            rowCount = 0;
            colCount = 0;
            cnvRowCount = 0;
            cnvColCount = 0;
            if(cnvSheet != null)
                cnvSheet.Dispose();
            if (package != null)
            {                
                rawSheet.Dispose();
                package.Dispose();
            }
            cnvSheet = null;
            package = null;
            rawSheet = null;
            fileType = FILETYPE.UNKNOWN;
            fileTypeTxt.Text = "UNKNOWN";
            nextBtn.Enabled = false;
            cnvState = false;

            operatorName = null;
            customer = null;
            wellNumber = null;
            jobDescription = null;
            jobSAP = null;
            customerRep = null;
            transducerName = null;
            transducerSN = null;
            createDateTime = DateTime.Now;
            transducerDateTime = DateTime.Now;
        }
        private void openBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Set the filter options
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            openFileDialog.Title = "Open Excel File";
            if (filePath == null)
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            else
                openFileDialog.InitialDirectory = Path.GetDirectoryName(filePath);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                if (filePath.Length > 57)
                    filePathTxt.Text = filePath.Substring(0, 55) + "...";
                else
                    filePathTxt.Text = filePath;
                //filePathTxt.ToolTipText = openFileDialog.FileName;
                cnvState = readXLSXFile(filePath);
                if (cnvState)
                    cnvState = copySheet(); //cnvState = convertSheet(); //cnvState = copySheet();
                if (cnvState)
                    nextBtn.Enabled = true;
                if (!cnvState)
                {
                    fileType = FILETYPE.UNKNOWN;
                    fileTypeTxt.Text = "Unknown";
                    seriesCount = 0;
                }
            }
        }
        bool readXLSXFile(string filePath)
        {
            initialData();
            fileTypeTxt.Text = "UNKNOWN";
            try
            {
                package = new ExcelPackage(new FileInfo(filePath));
                rawSheet = package.Workbook.Worksheets[1];
                rowCount = rawSheet.Dimension.Rows;
                colCount = rawSheet.Dimension.Columns;
            }
            catch (Exception ex) { return false; }
            if (leoBtn.Checked)
            {
                if ((fileType = isLEOFile()) != FILETYPE.UNKNOWN)
                    return true;
            }
                
            else if (kellerBtn.Checked)
            {
                if ((fileType = isKELLERFile()) != FILETYPE.UNKNOWN)
                    return true;
            }
                    
            return false;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (fileType == FILETYPE.UNKNOWN)
                return;
            documentForm documentForm = new documentForm();
            documentForm.Show();
            documentForm.mainForm = this;
            this.Hide();
        }
        bool copySheet()
        {
            try
            {
                cnvSheet = package.Workbook.Worksheets.FirstOrDefault(sheet => sheet.Name == "cnvSheet");
                if (cnvSheet != null)
                    package.Workbook.Worksheets.Delete(cnvSheet);
                //cnvSheet = package.Workbook.Worksheets.Add("cnvSheet");
                package.Workbook.Worksheets.Copy(rawSheet.Name, "cnvSheet");
                cnvSheet = package.Workbook.Worksheets.FirstOrDefault(sheet => sheet.Name == "cnvSheet");
                //cnvSheet = rawSheet;
                if (fileType == FILETYPE.LEO)
                {
                    seriesCount = 2;
                    for (int i = 1; i < cnvLEO[0]-1; i++)
                        cnvSheet.DeleteRow(1);
                    for (int i = 1; i < cnvLEO.Length; i++)
                        cnvSheet.DeleteColumn(cnvLEO[cnvLEO.Length-i]);
                    cnvRowCount = rowCount - cnvLEO[0]+1;

                    cnvColCount = headerLEO.Count();
                    for (int i = 0; i < cnvColCount; i++)
                    {
                        cnvSheet.Cells[1, i + 1].Value = headerLEO[i];
                    }
                }
                if (fileType == FILETYPE.KELLER)
                {
                    seriesCount = 4;
                    for (int i = 1; i < cnvKELLER[0] - 1; i++)
                        cnvSheet.DeleteRow(1);
                    for (int i = 1; i < cnvKELLER.Length; i++)
                        cnvSheet.DeleteColumn(cnvKELLER[cnvKELLER.Length - i]);
                    cnvRowCount = rowCount - cnvKELLER[0]+1;
                    cnvColCount = headerKELLER.Count();
                    for (int i = 0; i < cnvColCount; i++)
                    {
                        cnvSheet.Cells[1, i + 1].Value = headerKELLER[i];
                    }
                }
                for (int i = 0; i < cnvRowCount; i++ )
                {
                    cnvSheet.Cells[i+2, 1].Style.Numberformat.Format = "hh:mm:ss";
                }                
                using (ExcelRange row = cnvSheet.Cells[1, 1, 1, cnvSheet.Dimension.End.Column])
                {
                    // Set background color
                    row.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    row.Style.Fill.BackgroundColor.SetColor(Color.LightBlue);

                    // Set text alignment to center
                    row.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    row.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    // Optional: Make the font bold
                    row.Style.Font.Bold = true;

                    row.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    row.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    row.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    row.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                }
            }
            catch { return false; }            
            return true;
        }
        FILETYPE isLEOFile()
        {
            string valueCell;
            try
            {
                valueCell = rawSheet.Cells[1, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("File created from KolibriDesktop at"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[3, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Time Range Start"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[4, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Time Range End"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[6, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Device name"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[7, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Serial number"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[8, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Device type"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[9, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Record name"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[10, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("No"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[10, 2].Value as string;
                if (valueCell == null || !valueCell.Contains("local time"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[10, 3].Value as string;
                if (valueCell == null || !valueCell.Contains("UTC"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[10, 4].Value as string;
                if (valueCell == null || !valueCell.Contains("PSI"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[10, 5].Value as string;
                if (valueCell == null || !valueCell.Contains("°C"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[rowCount, 2].Text;
                if (string.IsNullOrEmpty(valueCell))
                    rowCount--;
            }
            catch (Exception ex)
            {
                return FILETYPE.UNKNOWN;
            }
            fileTypeTxt.Text = "LEO";
            return FILETYPE.LEO;
        }
        FILETYPE isKELLERFile()
        {
            string valueCell;
            try
            {
                valueCell = rawSheet.Cells[1, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Vendor"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[2, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Model"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[3, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Version"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[4, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Sampling"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[5, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Total data points"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[6, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Start time"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[7, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("End time"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[17, 1].Value as string;
                if (valueCell == null || !valueCell.Contains("Number"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[17, 2].Value as string;
                if (valueCell == null || !valueCell.Contains("Date&Time"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[17, 4].Value as string;
                if (valueCell == null || !valueCell.Contains("CH1"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[17, 5].Value as string;
                if (valueCell == null || !valueCell.Contains("CH2"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[17, 6].Value as string;
                if (valueCell == null || !valueCell.Contains("CH3"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[17, 7].Value as string;
                if (valueCell == null || !valueCell.Contains("CH4"))
                    return FILETYPE.UNKNOWN;
                valueCell = rawSheet.Cells[rowCount, 2].Text;
                if (string.IsNullOrEmpty(valueCell))
                    rowCount--;
            }
            catch (Exception ex)
            {
                return FILETYPE.UNKNOWN;
            }
            fileTypeTxt.Text = "KELLER";
            return FILETYPE.KELLER;
        }

        private void filePath_Click(object sender, EventArgs e)
        {
            if (filePath == null)
                return;
            string directoryPath = Path.GetDirectoryName(filePath);
            try
            {
                // Open the directory in file explorer
                Process.Start("explorer.exe", directoryPath);
            }
            catch (Exception ex)
            {
                ;
            }
        }
    }
}
