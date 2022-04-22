using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
namespace Hakediş
{

    public partial class WorkOrderReportForm : Form
    {
        static string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string jsonWorkOrderPath = appPath + @"\WorkOrderJson.json";
        string jsonPaymentPath = appPath + @"\PaymentJson.json";
        string chartWorkOrderImagePath = appPath + @"\saveWorkOrder.png";
        private MainMenu mainMenu;
        List<WorkOrder> workOrders = new List<WorkOrder>();
        List<Payment> payments = new List<Payment>();
        readonly string applicationVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        string searchButtonText = "";
        public WorkOrderReportForm(MainMenu main)
        {
            InitializeComponent();
            mainMenu = main;
        }

        private void WorkOrderReportForm_Load(object sender, EventArgs e)
        {
            workOrders = DataListing.ReadWorkOrderJson(jsonWorkOrderPath, workOrders);
            payments = DataListing.ReadPaymentJson(jsonPaymentPath, payments);
            //dataGridView1.DataSource = workOrders;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        //private void SearchItem()
        //{
        //    List<WorkOrder> cloneWorkOrders = new List<WorkOrder>();
        //    string word = "";
        //    for (int i = 0; i <= txtDetailName.Text.Length - 1; i++)
        //    {
        //        char character = txtDetailName.Text[i];
        //        word += character;
        //        cloneWorkOrders = workOrders.Where(x => x.Name.Contains(word.ToString().ToUpper()) || x.Name.Contains(word.ToString().ToLower())).ToList();
        //    }
        //    if(word == "")
        //    {
        //        dataGridView1.DataSource = workOrders;
        //    }
        //    else
        //    {
        //        dataGridView1.DataSource = cloneWorkOrders;
        //    }

        //}
        private void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenu.groupBox1.Visible = true;
            mainMenu.groupBox2.Visible = true;
            mainMenu.dataGridView1.Visible = true;
            mainMenu.dataGridView2.Visible = true;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void textChange(object sender, EventArgs e)
        {

        }
        private void txtDetailName_TextChanged(object sender, EventArgs e)
        {
            //SearchItem();
        }
        private void DateTimeChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            switch (dateTimePicker.Name)
            {
                case "dateTimeDetailFirst":
                    dateTimeDetailExpired.MinDate = dateTimeDetailFirst.Value;
                    dateTimeDetailExpired.Enabled = true;
                    break;
                case "dateTimeDetailExpired":
                    dateTimeDetailFirst.MaxDate = dateTimeDetailExpired.Value;
                    break;
                default:
                    break;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #region Data İşlemleri
        private void FindPaymentsList()
        {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            var searchList = payments.Where(x => x.PaymentDate >= dateTimeDetailFirst.Value).ToList();
            if (searchList.Count > 0)
            {
                dataGridView2.DataSource = searchList;
              //  dataGridView2.Visible = true;
                dataGridView1.Visible = false;
                chart1.Visible = false;
                chart2.Visible = true;
                for (int i = 0; i < searchList.Count; i++)
                {
                    chart2.Series["Ödemeler"].Points.AddXY(searchList[i].Name, searchList[i].PayforDay);
                    btnExtractExcell.Enabled = true;
                }
                dataGridView2.Columns[0].Visible = false;
                DataTableColumnNameChange.ChangeDataGridHeader(dataGridView2, "Ödeme Adı", "Ödenen Gün", "Ödeme Tarihi");
                dataGridView2.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else
            {
                btnExtractExcell.Enabled = false;
                chart2.Visible = false;
                dataGridView2.Visible = false;
                MessageBox.Show("Bu Tarihler Arasında Ödeme Yapılmamıştır !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void FindWorkOrders()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            var searchList = workOrders.Where(x => x.ExpiredDate >= dateTimeDetailFirst.Value && x.ExpiredDate <= dateTimeDetailExpired.Value).ToList();
            var listCount = searchList.Count;
            if (listCount > 0)
            {
                dataGridView1.DataSource = searchList;
               // dataGridView1.Visible = true;
                chart1.Visible = true;
                for (int i = 0; i < searchList.Count; i++)
                {
                    chart1.Series["İş Emirleri"].Points.AddXY(searchList[i].Name, searchList[i].ManOfDay);
                    btnExtractExcell.Enabled = true;
                }
                dataGridView1.Columns[0].Visible = false;
                DataTableColumnNameChange.ChangeDataGridHeader(dataGridView1, "İş Adı", "Açıklama", "Başlangıç Tarihi", "Bitirme Tarihi", "Teslim Tarihi", "Adam/Gün");
                dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                btnExtractExcell.Enabled = true;
            }
            else
            {
                btnExtractExcell.Enabled = false;
                chart1.Visible = false;
                dataGridView1.Visible = false;
                MessageBox.Show("Bu Tarihler Arasında İş Yapılmamıştır !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #endregion

        private void btnSearchWorkOrder_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    FindWorkOrders();
                    break;
                case 1:
                    FindPaymentsList();
                    break;
                default:
                    break;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void btnExtractExcell_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Excel_Disa_Aktar(dataGridView1);
            }
            else
            {
                Excel_Disa_Aktar(dataGridView2);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void SaveChartWorkOrderImage()
        {
            saveFileDiaChart1.Filter = ("PNG Files (*.png)|*.png");
            saveFileDiaChart1.DefaultExt = "png";
            //saveFileDiaChart1.OverwritePrompt = false;
            //saveFileDiaChart1.CreatePrompt = true;
            saveFileDiaChart1.Title = "Save PNG File";
            if (saveFileDiaChart1.ShowDialog() == DialogResult.OK)
            {
                chartWorkOrderImagePath = saveFileDiaChart1.FileName;
                this.chart1.SaveImage(chartWorkOrderImagePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void SaveChartPaymentImage()
        {
            saveFileDiaChart1.Filter = ("PNG Files (*.png)|*.png");
            saveFileDiaChart1.DefaultExt = "png";
            //saveFileDiaChart1.OverwritePrompt = false;
            //saveFileDiaChart1.CreatePrompt = true;
            saveFileDiaChart1.Title = "Save PNG File";
            if (saveFileDiaChart1.ShowDialog() == DialogResult.OK)
            {

                chartWorkOrderImagePath = saveFileDiaChart1.FileName;
                this.chart2.SaveImage(chartWorkOrderImagePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public void ExtractPdf(DataGridView dataGridView, bool selectedParameter)
        {
            Phrase p = new Phrase("\n");
            #region Font seç
            BaseFont trArial = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fontArial = new iTextSharp.text.Font(trArial, 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.DARK_GRAY);
            iTextSharp.text.Font fontArialHeader = new iTextSharp.text.Font(trArial, 11, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            iTextSharp.text.Font fontArialbold = new iTextSharp.text.Font(trArial, 9, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY);
            iTextSharp.text.Font fontArialboldgeneral = new iTextSharp.text.Font(trArial, 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            #endregion

            #region Fatura pdf oluştur
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "pdf Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                iTextSharp.text.Document pdfFile = new iTextSharp.text.Document();
                PdfWriter.GetInstance(pdfFile, new FileStream(save.FileName, FileMode.Create));
                pdfFile.Open();

                #region Fatura oluşturan bilgileri
                pdfFile.AddCreator("Hakedis"); //Oluşturan kişinin isminin eklenmesi
                pdfFile.AddCreationDate();//Oluşturulma tarihinin eklenmesi
                pdfFile.AddAuthor("Hakedis" + applicationVersion); //Yazarın isiminin eklenmesi
                pdfFile.AddHeader(DateTime.Now.ToLongDateString(), "Hakediş " + DateTime.Now.ToLongDateString());
                pdfFile.AddTitle("Hakediş Rapor"); //Başlık ve title eklenmesi
                #endregion

                #region Tablo Başlık tarih ve marka bilgileri
                PdfPTable markAndDateTable = new PdfPTable(2);
                markAndDateTable.TotalWidth = 250f;
                markAndDateTable.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                PdfPCell markName = new PdfPCell(new Phrase("Hakediş " + applicationVersion, fontArialbold));
                markName.HorizontalAlignment = Element.ALIGN_LEFT;
                markName.VerticalAlignment = Element.ALIGN_LEFT;
                markName.Border = 0;

                PdfPCell dateTimeReport = new PdfPCell(new Phrase(DateTime.Now.ToLongDateString(), fontArialbold));
                dateTimeReport.VerticalAlignment = Element.ALIGN_RIGHT;
                dateTimeReport.HorizontalAlignment = Element.ALIGN_RIGHT;
                dateTimeReport.Border = 0;
                dateTimeReport.ExtraParagraphSpace = 5f;

                markAndDateTable.AddCell(markName);
                markAndDateTable.AddCell(dateTimeReport);
                #endregion

                #region Veri Tablosu İşlemleri

                #region Pdf Kolon Başlıklarını Belirleme
                int columnCount = dataGridView.Columns.Count;
                PdfPTable pdfColumnheader = new PdfPTable(columnCount - 2);
                pdfColumnheader.TotalWidth = 400f;
                pdfColumnheader.LockedWidth = true;
                pdfColumnheader.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                if (selectedParameter == true)
                {
                    for (int i = 0; i < columnCount; i++)
                    {
                        if (i != 0 && i!=1)
                        {
                            PdfPCell columnName = new PdfPCell(new Phrase(dataGridView.Columns[i].HeaderText, fontArialHeader));
                            columnName.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                            columnName.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                            columnName.FixedHeight = 30f;
                            columnName.Border = 1;
                            pdfColumnheader.AddCell(columnName);
                        }
                    }
                }
                else
                {
                     pdfColumnheader = new PdfPTable(columnCount - 1);
                    for (int i = 0; i < columnCount; i++)
                    {
                        if (i != 0)
                        {
                            PdfPCell columnName = new PdfPCell(new Phrase(dataGridView.Columns[i].HeaderText, fontArialHeader));
                            columnName.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                            columnName.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                            columnName.FixedHeight = 30f;
                            columnName.Border = 1;
                            pdfColumnheader.AddCell(columnName);
                        }
                    }
                }
            
                #region Satır işlemleri

                int rowsCount = dataGridView.Rows.Count;
                PdfPTable pdfDataTable = new PdfPTable(columnCount - 2);
                if (selectedParameter == true)
                {
                    for (int i = 0; i <= rowsCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                        {
                            if (j != 0 && j != 2)
                            {
                                PdfPCell cell2 = new PdfPCell(new Phrase(dataGridView.Rows[i].Cells[j].Value.ToString(), fontArial));
                                pdfDataTable.AddCell(cell2);
                            }
                        }
                    }
                }
                else
                {
                    pdfDataTable = new PdfPTable(columnCount - 1);
                    for (int i = 0; i <= rowsCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                        {
                            if (j != 0)
                            {
                                PdfPCell cell2 = new PdfPCell(new Phrase(dataGridView.Rows[i].Cells[j].Value.ToString(), fontArial));
                                pdfDataTable.AddCell(cell2);
                            }
                        }
                    }
                }
               

                #endregion

                #region Toplam Bilgi Verileri
                PdfPTable tableTotalInfo = new PdfPTable(2);
                tableTotalInfo.TotalWidth = 250f;
                tableTotalInfo.LockedWidth = true;
                tableTotalInfo.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                double totalManOfDay = 0;
                if (selectedParameter == true)
                {
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        totalManOfDay += double.Parse(dataGridView.Rows[i].Cells[6].Value.ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        totalManOfDay += double.Parse(dataGridView.Rows[i].Cells[2].Value.ToString());
                    }
                }

                PdfPCell cellTotalManOfDay = new PdfPCell(new Phrase(totalManOfDay.ToString(), fontArial));
                cellTotalManOfDay.HorizontalAlignment = Element.ALIGN_CENTER;
                cellTotalManOfDay.VerticalAlignment = Element.ALIGN_LEFT;
                PdfPCell cellTotal = new PdfPCell(new Phrase("Toplam İş Günü", fontArial));
                cellTotal.HorizontalAlignment = Element.ALIGN_CENTER;
                cellTotal.VerticalAlignment = Element.ALIGN_LEFT;
                tableTotalInfo.AddCell(cellTotal);
                tableTotalInfo.AddCell(cellTotalManOfDay);
                #endregion

                #endregion

                #region Pdf Dosyasını yaz ve kapat
                if (pdfFile.IsOpen() == false) pdfFile.Open();
                pdfFile.Add(markAndDateTable);
                pdfFile.Add(p);
                pdfFile.Add(pdfColumnheader);
                pdfFile.Add(p);
                pdfFile.Add(pdfDataTable);
                pdfFile.Add(p);
                pdfFile.Add(tableTotalInfo);
                //pdfFile.Add(p);
                //pdfFile.Add(p);
                //pdfFile.Add(p);
                //pdfFile.Add(nameSurname);
                //pdfFile.Add(p);
                //pdfFile.Add(signature);
                pdfFile.Close();
                #endregion
                #endregion
            }
            #endregion
        }
        public static void Excel_Disa_Aktar(DataGridView dataGridView1)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";
                for (int i = 2; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    searchButtonText = tabPageWorkOrder.Text;
                    btnSearchWorkOrder.Text = searchButtonText + " Ara";
                    break;
                case 1:
                    searchButtonText = tabPagePayment.Text;
                    btnSearchWorkOrder.Text = searchButtonText + " Ara";
                    break;
                default:
                    break;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void WorkOrderReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainMenu.groupBox1.Visible = true;
            mainMenu.groupBox2.Visible = true;
            mainMenu.dataGridView1.Visible = true;
            mainMenu.dataGridView2.Visible = true;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnExportGraphImage_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageWorkOrder)
            {
                SaveChartWorkOrderImage();
            }
            else
            {
                SaveChartPaymentImage();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageWorkOrder)
            {
                ExtractPdf(dataGridView1,true);
            }
            else
            {
                ExtractPdf(dataGridView2,false);
            }
          
        }
    }
}
