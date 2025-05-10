using AnyLogReader.Properties;
using PdfSharp.Charting;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AnyLogReader
{
    public partial class chartForm : Form
    {
        public MainForm mainForm;
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea;
        System.Windows.Forms.DataVisualization.Charting.Legend legend;
        System.Windows.Forms.DataVisualization.Charting.Series[] series;
        VerticalLineAnnotation vLineLeft;
        VerticalLineAnnotation vLineRight;
        int currentCount;
        int startNum;
        int zoomRate;
        int totalCount;
        int seriesCount;
        int totalZoomCounts;
        const int minItemCount = 10;

        int startX;
        int endX;
        int oldPosition;
        bool moveState;

        double[] deltaTime;
        double[] deltaValue;
        double[] minValue;
        double[] maxValue;

        string logoDirPath;
        int logoImgStatus;
        string strLlogo;
        string strRlogo;
        public chartForm()
        {
            InitializeComponent();
            try
            {
                logoDirPath = AppDomain.CurrentDomain.BaseDirectory + "logo";
                strLlogo = logoDirPath + "\\logoL.png";
                strRlogo = logoDirPath + "\\logoR.png";

                logoImgStatus = 0;
                mainForm = null;
                startNum = 0;
                zoomRate = 1;
                seriesCount = 0;
                totalCount = 0;
                zoomOutImgBtn.Enabled = false;
                oldPosition = 0;
                startX = 0;
                endX = 0;
                moveState = true;
                itemNameG.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                leftTimeG.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                startValueG.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                rightTimeG.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                endValueG.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                deltaTimeG.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                deltaValueG.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                minValueG.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                maxValueG.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch
            {
                return;
            }            
        }
        private void chartForm_Load(object sender, EventArgs e)
        {
            try
            {
                initChart();
                totalCountsTxt.Text = $"{totalCount}";
                currentCountsTxt.Text = $"{currentCount}";
                startTimeTxt.Text = $"{DateTime.Parse(mainForm.cnvSheet.Cells[2, 1].Text).ToString("HH:mm:ss")}";
                endTimeTxt.Text = $"{DateTime.Parse(mainForm.cnvSheet.Cells[totalCount + 1, 1].Text).ToString("HH:mm:ss")}";
                zoomRateTxt.Text = $"{zoomRate}";
                //chart.Titles.Add($"{Path.GetFileName(mainForm.filePath)}");
                filePathTxt.Text = mainForm.filePath;
                addSeries(0, totalCount);
                double minV = double.MaxValue;
                for (int i = 0; i < seriesCount; i++)
                {
                    if (minV > minValue[i])
                    {
                        minV = minValue[i];
                    }
                }
                if (minV > 0)
                {
                    chartArea.AxisY.Minimum = 0D;
                    chartArea.AxisY2.Minimum = 0D;
                }
                setLogoImage();
            }
            catch
            {
                return;
            }            
        }
        void setLogoImage()
        {
            try
            {
                if (File.Exists(strLlogo))
                    logoImgStatus = 1;
                if (File.Exists(strRlogo))
                    logoImgStatus += 2;
                if (logoImgStatus < 2)
                    logoDirOpenBtn.Image = Resources.Lo2;
                else
                    logoDirOpenBtn.Image = Resources.Lo1;
            }
            catch
            {
                return;
            }            
        }
        void initChart()
        {
            try
            {
                //this.chart.Dispose();
                this.chart.ChartAreas.Clear();
                this.chart.Series.Clear();
                this.chart.Legends.Clear();
                chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                legend = new System.Windows.Forms.DataVisualization.Charting.Legend();
                //this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
                //((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
                //this.SuspendLayout();

                this.chart.BorderlineColor = System.Drawing.Color.Black;
                //chartArea.AxisX.LabelStyle.Angle = -90;

                chartArea.AxisX.LabelStyle.Format = "HH:mm:ss";
                chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                chartArea.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
                chartArea.AxisX.Title = "Time[HH:mm:ss]";
                chartArea.AxisY.LineColor = System.Drawing.Color.Black;
                chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
                chartArea.AxisY2.LineColor = System.Drawing.Color.Black;
                chartArea.AxisY2.MajorGrid.LineDashStyle = ChartDashStyle.DashDot;
                chartArea.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Gray;
                chartArea.AxisY.Title = "Pressure[PSI]";
                chartArea.AxisY.TitleFont = new System.Drawing.Font(chartArea.AxisY.TitleFont.FontFamily, 15);
                chartArea.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
                chartArea.Name = "ChartArea";
                this.chart.ChartAreas.Add(chartArea);
                this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
                this.chart.IsSoftShadows = false;
                legend.Alignment = System.Drawing.StringAlignment.Center;
                legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
                legend.Name = "Legend";
                this.chart.Legends.Add(legend);
                this.chart.Location = new System.Drawing.Point(0, 0);
                this.chart.Margin = new System.Windows.Forms.Padding(0);
                this.chart.Name = "chart";
                this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
                this.chart.TabIndex = 0;
                this.chart.Text = "chart";
                //this.chart.Size = new System.Drawing.Size(1194, 469);
                //this.Controls.Add(this.chart);
                seriesCount = mainForm.seriesCount;
                series = new System.Windows.Forms.DataVisualization.Charting.Series[seriesCount];
                deltaTime = new double[seriesCount];
                deltaValue = new double[seriesCount];
                minValue = new double[seriesCount];
                maxValue = new double[seriesCount];
                for (int i = 0; i < seriesCount; i++)
                {
                    series[i] = new System.Windows.Forms.DataVisualization.Charting.Series();
                    series[i].Name = mainForm.cnvSheet.Cells[1, i + 2].Text;
                    series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    series[i].ChartArea = "ChartArea";
                    series[i].Legend = "Legend";
                    this.chart.Series.Add(series[i]);
                    resultGrid.Rows.Add();
                }
                if (seriesCount == 2)
                {
                    chart.ChartAreas[0].AxisY.Title = mainForm.cnvSheet.Cells[1, 2].Text;
                    // Set custom labels for secondary y-axes
                    chart.Series[1].YAxisType = AxisType.Secondary;
                    chart.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
                    chart.ChartAreas[0].AxisY2.Title = mainForm.cnvSheet.Cells[1, 3].Text;
                    chart.ChartAreas[0].AxisY2.TitleFont = new System.Drawing.Font(chartArea.AxisY.TitleFont.FontFamily, 15);
                    series[1].Color = Color.Orange;
                    chart.ChartAreas[0].AxisY2.TitleForeColor = Color.Orange;
                }
                series[0].Color = Color.Blue;
                chart.ChartAreas[0].AxisY.TitleForeColor = Color.Blue;
                currentCount = totalCount = mainForm.cnvRowCount;
                chartArea.AxisX.Minimum = 1;
                chartArea.AxisX.Maximum = totalCount + 1;
                vLineLeft = new VerticalLineAnnotation
                {
                    AxisX = chart.ChartAreas[0].AxisX,
                    AxisY = chart.ChartAreas[0].AxisY,
                    ClipToChartArea = chart.ChartAreas[0].Name,
                    IsInfinitive = true,
                    LineColor = Color.Red,
                    LineDashStyle = ChartDashStyle.Dash,
                    LineWidth = 2,
                    X = 0
                };
                vLineRight = new VerticalLineAnnotation
                {
                    AxisX = chart.ChartAreas[0].AxisX,
                    AxisY = chart.ChartAreas[0].AxisY,
                    ClipToChartArea = chart.ChartAreas[0].Name,
                    IsInfinitive = true,
                    LineColor = Color.DarkBlue,
                    LineDashStyle = ChartDashStyle.Dash,
                    LineWidth = 2,
                    X = totalCount + 5
                };
                chart.Annotations.Add(vLineLeft);
                chart.Annotations.Add(vLineRight);

                totalZoomCounts = (int)(Math.Log((double)totalCount / 10.0) / Math.Log(2));
                if (totalZoomCounts < Math.Log((double)totalCount / 10.0) / Math.Log(2))
                {
                    totalZoomCounts += 1;
                }
                totalZoomCounts = (int)Math.Pow(2.0, (double)totalZoomCounts) * 10;

                chart.MouseMove += Chart_MouseMove;
                chart.MouseClick += Chart_MouseClick;
                chart.PostPaint += Chart_PostPaint;
                chart.MouseDoubleClick += Chart_MouseDClick;
            }
            catch
            {
                return;
            }            
        }
        private void Chart_PostPaint(object sender, ChartPaintEventArgs e)
        {
            try
            {
                if (endX == 0)
                {
                    startX = 0;
                    endX = (int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(vLineRight.X);
                    setGridValue(vLineLeft.X, vLineRight.X);
                }
            }
            catch
            {
                return;
            }           
        }
        void addSeries(int startID, int count)
        {
            try
            {
                series[0].Points.Clear();
                series[1].Points.Clear();
                chartArea.AxisX.Interval = count / 10;
                for (int i = 0; i < seriesCount; i++)
                {
                    /*minValue[i] = double.MaxValue;
                    maxValue[i] = double.MinValue;*/
                    for (int j = startID; j <= startID + count; j++)
                    {
                        if (j > totalCount)
                            return;
                        if (DateTime.TryParse(mainForm.cnvSheet.Cells[j + 2, 1].Text, out DateTime parsedDateTime))
                        {
                            string formattedDateTimeString = parsedDateTime.ToString("HH:mm:ss");
                            series[i].Points.AddXY(formattedDateTimeString, mainForm.cnvSheet.Cells[j + 2, i + 2].Value);
                            /*if (minValue[i] > Convert.ToDouble(mainForm.cnvSheet.Cells[j + 2, i + 2].Value))
                                minValue[i] = Convert.ToDouble(mainForm.cnvSheet.Cells[j + 2, i + 2].Value);
                            if (maxValue[i] < Convert.ToDouble(mainForm.cnvSheet.Cells[j + 2, i + 2].Value))
                                maxValue[i] = Convert.ToDouble(mainForm.cnvSheet.Cells[j + 2, i + 2].Value);*/
                        }
                    }
                }
                chartArea.AxisX.Minimum = 1;
                chartArea.AxisX.Maximum = count + 1;
            }
            catch
            {
                return;
            }            
        }
        void setAnnotationPosition()
        {
            try
            {
                vLineLeft.X = chart.ChartAreas[0].AxisX.PixelPositionToValue(startX);
                vLineRight.X = chart.ChartAreas[0].AxisX.PixelPositionToValue(endX);
                setGridValue(vLineLeft.X, vLineRight.X);
            }
            catch
            {
                return;
            }            
        }
        void setGridValue(double firstPos, double secondPos)
        {
            try
            {
                getMinMaxValue();
                int id1 = (int)(firstPos + 0.5) - 1;
                int id2 = (int)(secondPos + 0.5) - 1;
                if (id1 < 0)
                    id1 = 0;
                if (id2 > currentCount)
                    id2 = currentCount;
                if (id2 >= totalCount)
                    id2 = totalCount - 1;
                for (int i = 0; i < seriesCount; i++)
                {
                    resultGrid.Rows[i].Cells[0].Value = $"{i + 1}";                                    //No
                    resultGrid.Rows[i].Cells[1].Value = $"{series[i].Name}";                       //Name
                    resultGrid.Rows[i].Cells[2].Value = $"{series[i].Points[id1].AxisLabel}";     //startTime
                    resultGrid.Rows[i].Cells[3].Value = $"{series[i].Points[id1].YValues[0].ToString("0.00")}";   //Value    
                    resultGrid.Rows[i].Cells[4].Value = $"{series[i].Points[id2].AxisLabel}";    //startTime
                    resultGrid.Rows[i].Cells[5].Value = $"{series[i].Points[id2].YValues[0].ToString("0.00")}";  //Value
                    TimeSpan timeSpan = DateTime.Parse(series[i].Points[id2].AxisLabel) - DateTime.Parse(series[i].Points[id1].AxisLabel);
                    deltaTime[i] = timeSpan.TotalSeconds;
                    resultGrid.Rows[i].Cells[6].Value = $"{timeSpan} ({deltaTime[i]} S)";                  //deltaTime
                    deltaValue[i] = series[i].Points[id2].YValues[0] - series[i].Points[id1].YValues[0];
                    resultGrid.Rows[i].Cells[7].Value = $"{deltaValue[i].ToString("0.00")}";                 //deltaValue
                    resultGrid.Rows[i].Cells[8].Value = $"{minValue[i].ToString("0.00")}";                   //minValue
                    resultGrid.Rows[i].Cells[9].Value = $"{maxValue[i].ToString("0.00")}";                   //maxValue
                }
            }
            catch
            {
                return;
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = null;
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    InitialDirectory = Path.GetDirectoryName(mainForm.filePath),
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Title = "Save PDF File",
                    DefaultExt = "pdf",
                    AddExtension = true,
                    FileName = $"{Path.GetFileNameWithoutExtension(mainForm.filePath)}"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    PdfDocument document = new PdfDocument();

                    int textX = 100;
                    int startTextY = 100;
                    int intervalY = 20;
                    document.Info.Title = "cnvPDF";
                    PdfPage page = document.AddPage();
                    page.Size = PdfSharp.PageSize.A4;
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    //logo Image
                    setLogoImage();
                    if (logoImgStatus > 0)
                    {
                        if ((logoImgStatus & 0x1) == 0x1)
                            using (var xImage = XImage.FromFile(strLlogo))
                            {
                                gfx.DrawImage(xImage, 10, 10, /*xImage.PixelWidth * 70 / xImage.PixelHeight*/ 200, 70);
                            }
                        if ((logoImgStatus & 0x2) == 0x2)
                            using (var xImage = XImage.FromFile(strRlogo))
                            {
                                gfx.DrawImage(xImage, page.Width - 210/*page.Width - xImage.PixelWidth * 70 / xImage.PixelHeight -10*/, 10, /*xImage.PixelWidth * 70 / xImage.PixelHeight*/ 200, 70);
                            }
                    }
                    //Operator Name
                    XFont font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Operator Name", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{mainForm.operatorName}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    //Customer
                    startTextY += intervalY;
                    font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Customer", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{mainForm.customer}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    //Well Number
                    startTextY += intervalY;
                    font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Well Number", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{mainForm.wellNumber}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    //Job Description
                    startTextY += intervalY;
                    font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Job Description", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{mainForm.jobDescription}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    //Job SAP#
                    startTextY += intervalY;
                    font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Job SO#", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{mainForm.jobSAP}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    //Customer Representative
                    startTextY += intervalY;
                    font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Customer Representative", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{mainForm.customerRep}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    //Date
                    startTextY += intervalY;
                    font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Date", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{mainForm.createDateTime}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    //Transducer Name
                    startTextY += intervalY;
                    font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Transducer Name", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{mainForm.transducerName}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    //Transducer Serial Number
                    startTextY += intervalY;
                    font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Transducer Serial Number", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{mainForm.transducerSN}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    //Transducer Calibration due date
                    startTextY += intervalY;
                    font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Transducer Calibration due date", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{mainForm.transducerDateTime.ToString("HH:mm:ss")}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    //chart
                    //XImage xImage = XImage.FromFile(chartImgPath());
                    startTextY += intervalY;
                    using (var xImage = XImage.FromFile(chartImgPath(chart, (int)(page.Width) - 100, 350)))
                    {
                        gfx.DrawImage(xImage, 50, startTextY, page.Width - 100, 350/*xImage.PixelHeight / 2*/);
                        startTextY += (350/*xImage.PixelHeight / 2*/ + intervalY);
                    }
                    //delta time                
                    font = new XFont("arias", 12, XFontStyle.Regular);
                    gfx.DrawString($"Delta Time", font, XBrushes.Black,
                    new XRect(textX, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);
                    font = new XFont("arias", 13, XFontStyle.Bold);
                    gfx.DrawString($"{resultGrid.Rows[1].Cells[6].Value}", font, XBrushes.Black,
                    new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                    XStringFormats.TopLeft);

                    if (seriesCount == 2)
                    {
                        //delta Pressure
                        startTextY += intervalY;
                        font = new XFont("arias", 12, XFontStyle.Regular);
                        gfx.DrawString($"Delta {mainForm.headerLEO[1]}", font, XBrushes.Black,
                        new XRect(textX, startTextY, page.Width / 2, page.Height),
                        XStringFormats.TopLeft);
                        font = new XFont("arias", 13, XFontStyle.Bold);
                        gfx.DrawString($"{deltaValue[0].ToString("0.00")}", font, XBrushes.Black,
                        new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                        XStringFormats.TopLeft);
                        //delta Temperature
                        startTextY += intervalY;
                        font = new XFont("arias", 12, XFontStyle.Regular);
                        gfx.DrawString($"Delta Temperature [°C]", font, XBrushes.Black,
                        new XRect(textX, startTextY, page.Width / 2, page.Height),
                        XStringFormats.TopLeft);
                        font = new XFont("arias", 13, XFontStyle.Bold);
                        gfx.DrawString($"{deltaValue[1].ToString("0.00")}", font, XBrushes.Black,
                        new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                        XStringFormats.TopLeft);
                    }
                    else
                    {
                        //delta Pressures
                        for (int i = 0; i < seriesCount; i++)
                        {
                            startTextY += intervalY;
                            font = new XFont("arias", 12, XFontStyle.Regular);
                            gfx.DrawString($"Delta {mainForm.headerKELLER[i + 1]}", font, XBrushes.Black,
                            new XRect(textX, startTextY, page.Width / 2, page.Height),
                            XStringFormats.TopLeft);
                            font = new XFont("arias", 13, XFontStyle.Bold);
                            gfx.DrawString($"{deltaValue[i].ToString("0.00")}", font, XBrushes.Black,
                            new XRect(page.Width / 2, startTextY, page.Width / 2, page.Height),
                            XStringFormats.TopLeft);
                        }
                    }
                    // save and start a viewer
                    document.Save(filePath);
                    Process.Start(filePath);
                    //SaveScreenshotAsPdf(chartImgPath(), filePath);

                    filePath = $"{Path.GetDirectoryName(filePath)}/{Path.GetFileNameWithoutExtension(filePath)}_cnv.xlsx";
                    FileInfo fi = new FileInfo(filePath);
                    mainForm.package.SaveAs(fi);
                }
            }
            catch
            {
                return;
            }
        }
        string chartImgPath(System.Windows.Forms.DataVisualization.Charting.Chart pChart, int width, int height)
        {
            try
            {
                // Set the size of the copied chart
                pChart.Dock = System.Windows.Forms.DockStyle.None;
                int rate = pChart.Width / width;
                pChart.Height = height * rate ;

                // Perform layout to ensure all elements are properly scaled and positioned
                //pChart.PerformLayout();
                //string tempImagePath = Path.GetTempFileName();
                string tempImagePath = Path.Combine(Path.GetTempPath(), "tempScreenshot.png");
                pChart.SaveImage(tempImagePath, ChartImageFormat.Png);
                pChart.Dock = System.Windows.Forms.DockStyle.Fill;
                return tempImagePath;
            }
            catch
            {
                return string.Empty;
            }
            
        }
        private void SaveScreenshotAsPdf(string imgPath, string filePath)
        {
            try
            {
                using (PdfDocument document = new PdfDocument())
                {
                    using (XImage image = XImage.FromFile(imgPath))
                    {
                        PdfPage page = document.AddPage();
                        page.Width = image.Width;
                        page.Height = image.Height;
                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        gfx.DrawImage(image, 0, 0, image.Width, image.Height);
                    }
                    document.Save(filePath);
                }
            }
            catch
            {
                return;
            }            
        }
        private void Chart_MouseDClick(object sender, MouseEventArgs e)
        {
            try
            {
                Color changeColor;
                System.Windows.Forms.DataVisualization.Charting.HitTestResult result = chart.HitTest(e.X, e.Y);
                if (result.ChartElementType == ChartElementType.LegendItem)
                {
                    LegendItem legendItem = (LegendItem)result.Object;
                    string seriesName = legendItem.SeriesName;
                    if (seriesCount == 2 && seriesName.Contains("Temp"))
                        return;
                    changeColor = getColor();
                    if (changeColor == Color.Empty)
                        return;
                    if (seriesName == mainForm.headerLEO[1])//Pressure [PSI]
                    {
                        series[0].Color = changeColor;
                        series[1].Color = Color.Orange;
                        chart.ChartAreas[0].AxisY.TitleForeColor = changeColor;
                        chart.ChartAreas[0].AxisY2.TitleForeColor = Color.Orange;
                    }
                    else if (seriesName == mainForm.headerKELLER[1])//blue lo [Psi]
                    {
                        series[0].Color = changeColor;
                    }
                    else if (seriesName == mainForm.headerKELLER[2])//yelow uo [Psi]
                    {
                        series[1].Color = changeColor;
                    }
                    else if (seriesName == mainForm.headerKELLER[3])//white uo [psi]
                    {
                        series[2].Color = changeColor;
                    }
                    else if (seriesName == mainForm.headerKELLER[4])//close [psi]
                    {
                        series[3].Color = changeColor;
                    }
                }
            }
            catch
            {
                return;
            }
        }
        private void Chart_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                oldPosition = e.X;
            }
            catch
            {
                return;
            }
        }
        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (moveState)
                {
                    if (e.Button != MouseButtons.Left)
                        return;
                    if (oldPosition - e.X > 10)
                    {
                        oldPosition = e.X;
                        startNum += currentCount / 10;
                        if (startNum + currentCount >= totalCount)
                            startNum = totalCount - currentCount;
                        addSeries(startNum, currentCount);
                        setGridValue(vLineLeft.X, vLineRight.X);
                    }
                    else if (e.X - oldPosition > 10)
                    {
                        oldPosition = e.X;
                        startNum -= currentCount / 10;
                        if (startNum < 0)
                            startNum = 0;
                        addSeries(startNum, currentCount);
                        setGridValue(vLineLeft.X, vLineRight.X);
                    }
                    return;
                }
                if (e.Button == MouseButtons.Left)
                {
                    if (e.X > endX || e.Y > 550)
                        return;
                    //HitTestResult result = chart.HitTest(e.X, e.Y);
                    //if (result.ChartElementType == ChartElementType.PlottingArea)
                    {
                        double xValue = chart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                        vLineLeft.X = xValue;
                        chart.Invalidate();
                    }
                    startX = e.X;
                    setGridValue(vLineLeft.X, vLineRight.X);
                }
                if (e.Button == MouseButtons.Right)
                {
                    if (e.X < startX || e.Y > 550)
                        return;
                    //HitTestResult result = chart.HitTest(e.X, e.Y);
                    //if (result.ChartElementType == ChartElementType.PlottingArea)
                    {
                        double xValue = chart.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                        vLineRight.X = xValue;
                        chart.Invalidate();
                    }
                    endX = e.X;
                    setGridValue(vLineLeft.X, vLineRight.X);
                }
            }
            catch { }
        }
        private void filePathTxt_Click(object sender, EventArgs e)
        {
            if (filePathTxt.Text == null)
                return;
            string directoryPath = Path.GetDirectoryName(filePathTxt.Text);
            try
            {
                // Open the directory in file explorer
                Process.Start("explorer.exe", directoryPath);
            }
            catch
            {
                return;
            }
        }
        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                zoomRate *= 2;
                currentCount = totalZoomCounts / zoomRate;
                if (currentCount <= minItemCount)
                {
                    currentCount = minItemCount;
                    zoomInImgBtn.Enabled = false;
                }
                addSeries(startNum, currentCount);
                zoomOutImgBtn.Enabled = true;
                zoomRateTxt.Text = $"{zoomRate}";
                currentCountsTxt.Text = $"{currentCount}";
                setAnnotationPosition();
            }
            catch
            {
                return;
            }            
        }
        private void zoomOutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                zoomRate /= 2;
                currentCount = currentCount * 2;
                if (startNum + currentCount > totalCount)
                {
                    startNum = totalCount - currentCount - 1;
                    if (startNum < 0)
                    {
                        startNum = 0;
                        currentCount = totalCount;
                        zoomRate = 1;
                        zoomOutImgBtn.Enabled = false;
                    }
                }
                else if (zoomRate <= 1 || currentCount > totalCount)
                {
                    startNum = 0;
                    zoomRate = 1;
                    currentCount = totalCount;
                    zoomOutImgBtn.Enabled = false;
                }
                addSeries(startNum, currentCount);
                zoomInImgBtn.Enabled = true;
                zoomRateTxt.Text = $"{zoomRate}";
                currentCountsTxt.Text = $"{currentCount}";
                setAnnotationPosition();
            }
            catch
            {
                return;
            }
        }
        private void colseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                return; 
            }
        }
        private Color getColor()
        {
            try
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        return colorDialog.Color;
                    }
                }
                return Color.Empty;
            }
            catch
            {
                return Color.Empty;
            }
            
        }
        private void getMinMaxValue()
        {
            try
            {
                int id1 = (int)(vLineLeft.X + 0.5) - 1;
                int id2 = (int)(vLineRight.X + 0.5) - 1;
                if (id1 < 0)
                    id1 = 0;
                if (id2 > currentCount)
                    id2 = currentCount;
                if (id2 >= totalCount)
                    id2 = totalCount - 1;
                for (int i = 0; i < seriesCount; i++)
                {
                    minValue[i] = double.MaxValue;
                    maxValue[i] = double.MinValue;
                    for (int j = id1; j <= id2; j++)
                    {
                        if (minValue[i] > Convert.ToDouble(series[i].Points[j].YValues[0]))
                            minValue[i] = Convert.ToDouble(series[i].Points[j].YValues[0]);
                        if (maxValue[i] < Convert.ToDouble(series[i].Points[j].YValues[0]))
                            maxValue[i] = Convert.ToDouble(series[i].Points[j].YValues[0]);
                    }
                }
            }
            catch
            {
                return;
            }
        }
        private void ImageButton_Down(object sender, MouseEventArgs e)
        {
            try
            {
                if (sender.Equals(closeImgBtn))
                {
                    closeImgBtn.Image = Properties.Resources.Exit3;
                }
                else if (sender.Equals(saveImgBtn))
                {
                    saveImgBtn.Image = Properties.Resources.Save3;
                }
                else if (sender.Equals(moveImgBtn))
                {
                    if (moveState)
                    {
                        moveState = false;
                        moveImgBtn.Image = Properties.Resources.Move4;
                    }
                    else
                    {
                        moveState = true;
                        moveImgBtn.Image = Properties.Resources.Move1;
                    }
                }
                else if (sender.Equals(zoomInImgBtn))
                {
                    zoomInImgBtn.Image = Properties.Resources.ZoomIn2;
                }
                else if (sender.Equals(zoomOutImgBtn))
                {
                    zoomOutImgBtn.Image = Properties.Resources.ZoomOut2;
                }
            }
            catch
            {
                return;
            }            
        }
        private void ImageButton_Up(object sender, MouseEventArgs e)
        {
            try
            {
                PictureBox pictureBox = sender as PictureBox;
                Rectangle buttonRec = pictureBox.ClientRectangle;
                if (sender.Equals(closeImgBtn))
                {
                    closeImgBtn.Image = Properties.Resources.Exit1;
                    if (buttonRec.Contains(e.Location))
                        colseBtn_Click(null, null);
                }
                else if (sender.Equals(saveImgBtn))
                {
                    saveImgBtn.Image = Properties.Resources.Save1;
                    if (buttonRec.Contains(e.Location))
                        saveBtn_Click(null, null);
                }
                else if (sender.Equals(moveImgBtn))
                {

                }
                else if (sender.Equals(zoomInImgBtn))
                {
                    zoomInImgBtn.Image = Properties.Resources.ZoomIn1;
                    if (buttonRec.Contains(e.Location))
                        zoomInBtn_Click(null, null);
                }
                else if (sender.Equals(zoomOutImgBtn))
                {
                    zoomOutImgBtn.Image = Properties.Resources.ZoomOut1;
                    if (buttonRec.Contains(e.Location))
                        zoomOutBtn_Click(null, null);
                }
            }
            catch
            {
                return;
            }            
        }
        static async Task ConvertSvgToPngAsync(string svgFilePath)
        {
            try
            {
                // Load the SVG file
                using (var stream = File.OpenRead(svgFilePath))
                {
                    var svg = new SkiaSharp.Extended.Svg.SKSvg();
                    svg.Load(stream);

                    // Create a bitmap to render the SVG
                    using (var bitmap = new SKBitmap((int)svg.CanvasSize.Width, (int)svg.CanvasSize.Height))
                    {
                        using (var canvas = new SKCanvas(bitmap))
                        {
                            canvas.Clear(SKColors.Transparent);

                            // Render the SVG onto the bitmap
                            canvas.DrawPicture(svg.Picture);

                            // Save the bitmap as PNG
                            using (var outputStream = File.OpenWrite(Path.ChangeExtension(svgFilePath, ".png")))
                            {
                                bitmap.Encode(SKEncodedImageFormat.Png, 100).SaveTo(outputStream);
                            }
                        }
                    }

                }

                // Delete the original SVG file after conversion
                File.Delete(svgFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting SVG to PNG: {ex.Message}");
            }
        }
        static async Task DownloadFileAsync(chartForm chartform, string url, string filePath)
        {
            try
            {
                bool bImgType = false;
                if (Path.GetExtension(url).Equals(".svg", StringComparison.OrdinalIgnoreCase))
                    filePath += ".svg";
                else
                {
                    filePath += ".png";
                    bImgType = true;
                }
                using (var client = new WebClient())
                {
                    await client.DownloadFileTaskAsync(new Uri(url), filePath);
                }
                if (!bImgType)
                {
                    ConvertSvgToPngAsync(filePath);
                }
                chartform.setLogoImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading file: {ex.Message}");
            }
        }
        private void onLogoDownLoad(object sender, EventArgs e)
        {
            try
            {
                downloadLogoForm downloadlogoForm = new downloadLogoForm();
                string strLogoURL = "";
                bool bLLogo = true;
                if (downloadlogoForm.ShowDialog() == DialogResult.OK)
                {
                    strLogoURL = downloadlogoForm.logoURL;
                    bLLogo = downloadlogoForm.leftImg;
                    string logoFilePath = logoDirPath + "\\logoR";
                    if (bLLogo)
                        logoFilePath = logoDirPath + "\\logoL";
                    if (!Directory.Exists(logoDirPath))
                    {
                        Directory.CreateDirectory(logoDirPath);
                    }
                    DownloadFileAsync(this, strLogoURL, logoFilePath);
                }
            }
            catch
            {
                return;
            }            
        }
        private void onLogoDirOpen(object sender, EventArgs e)
        {
            if (logoImgStatus < 1)
                return;
            string directoryPath = logoDirPath;
            try
            {
                // Open the directory in file explorer
                Process.Start("explorer.exe", directoryPath);
            }
            catch
            {
                return;
            }
        }
    }
}
