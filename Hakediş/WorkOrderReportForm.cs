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
        }
        #region Data İşlemleri
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
                    dataGridView1.Visible = true;
                    chart1.Visible = true;
                    for (int i = 0; i < searchList.Count; i++)
                    {
                        chart1.Series["İş Emirleri"].Points.AddXY(searchList[i].Name, searchList[i].ManOfDay);
                        btnExtractExcell.Enabled = true;
                    }
                    dataGridView1.Columns[0].Visible = false;
                    DataTableColumnNameChange.ChangeDataGridHeader(dataGridView1, "İş Adı", "Açıklama", "Başlangıç Tarihi", "Bitirme Tarihi", "Teslim Tarihi", "Adam/Gün");
                    btnExtractExcell.Enabled = true;
                }
                else
                {
                    btnExtractExcell.Enabled = false;
                    chart1.Visible = false;
                    dataGridView1.Visible = false;
                    MessageBox.Show("Bu Tarihler Arasında İş Yapılmamıştır !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                    
                    break;
                default:
                    break;
            }           
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
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
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
        }

        private void WorkOrderReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainMenu.groupBox1.Visible = true;
            mainMenu.groupBox2.Visible = true;
            mainMenu.dataGridView1.Visible = true;
            mainMenu.dataGridView2.Visible = true;
        }

        private void btnExportGraphImage_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageWorkOrder)
            {
                this.chart1.SaveImage(chartWorkOrderImagePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            }
        }
    }
}
