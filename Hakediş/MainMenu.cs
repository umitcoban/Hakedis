using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Hakediş
{
    public partial class MainMenu : Form
    {
        readonly string jsonWorkOrderDataPath = @"WorkOrderJson.json";
        readonly string jsonPaymentsDataPath = @"PaymentJson.json";
        public static List<WorkOrder> workOrders = new List<WorkOrder>();
        public List<WorkOrder> isDoneWorkOrders = new List<WorkOrder>();
        public List<Payment> payments = new List<Payment>();
        public bool checkedFilter;
        int currentMonth = int.Parse(DateTime.Now.Month.ToString());
        double totalPay;
        double currtenPay;
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            DataTableColumnNameChange dataTableColumnNameChange = new DataTableColumnNameChange();
            ReadWorkOrderJson();
            dataTableColumnNameChange.ChangeDataGridHeader(dataGridView1, "İş Adı", "Açıklama", "Başlangıç Tarihi", "Bitirme Tarihi", "Teslim Tarihi", "Adam/Gün");
            dataTableColumnNameChange.ChangeDataGridHeader(dataGridView2, "Ödeme Adı", "Ödenen Gün", "Ödeme Tarihi");
            int week = DateTime.Now.DayOfYear / 7;
            //int remainingWeek = ;
            toolStripLblMonth.Text = "Şuan Yılın " + currentMonth.ToString() + ". Ayında, " + week + ". Haftasında, " 
                + DateTime.Now.ToString("dddd") + " Günündesiniz. Geriye ";
        }
        #region Data İşlemleri
        public void ReadWorkOrderJson()
        {
            try
            {
                //if (File.Exists(jsonPaymentsDataPath))
                //{
                //    string jsonPaymentData = File.ReadAllText(jsonPaymentsDataPath);
                //    payments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Payment>>(jsonPaymentData);
                //}
                //List<Payment> paymentsClone = payments;
                //dataGridView2.DataSource = payments;
                //dataGridView2.Columns[0].Visible = false;
                //if (File.Exists(jsonWorkOrderDataPath))
                //{
                //    string jsonData = File.ReadAllText(jsonWorkOrderDataPath);
                //    workOrders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorkOrder>>(jsonData);
                //}

                DataListing dataListing = new DataListing();
                dataListing.ReadPaymentJson(dataGridView2, jsonPaymentsDataPath);
                dataListing.ReadWorkOrderJson(dataGridView1,jsonWorkOrderDataPath);
                workOrders.AddRange(dataListing.WorkOrders);
                payments.AddRange(dataListing.Payments);
                List<WorkOrder> currentWorkOrders = new List<WorkOrder>();
                currentWorkOrders.AddRange(workOrders);
                for (int i = 0; i <= currentWorkOrders.Count-1; i++)
                {
                    if (currentWorkOrders[i].ExpiredDate != null)
                    {
                        isDoneWorkOrders.Add(currentWorkOrders[i]);
                    }
                }

                foreach (var item in currentWorkOrders.ToList())
                {
                    if (item.ExpiredDate != null)
                    {
                        currentWorkOrders.Remove(item);
                    }
                }

                if (checkedFilter)
                {
                    dataGridView1.DataSource = workOrders;
                }
                else
                {
                    dataGridView1.DataSource = currentWorkOrders;
                }
                //dataGridView1.DataSource = currentWorkOrders;
                //dataGridView1.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
                //dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
                //dataGridView1.Columns[0].Visible = false;
                CalculatePayments(isDoneWorkOrders, payments);
            }
            catch (Exception)
            {

            }
        }

        public void CalculatePayments(List<WorkOrder> otherList, List<Payment> payments)
        {
            if (payments.Count != 0)
                for (int i = 0; i < payments.Count; i++)
                {
                    currtenPay += payments[i].PayforDay;
                }
            for (int i = 0; i < otherList.Count; i++)
            {
                totalPay += otherList[i].ManOfDay;
            }
            //toolStripLblTotalPayment.Text = totalPay.ToString();
            //toolStripLblCurrentPay.Text = currtenPay.ToString();
            double generalPay = totalPay - currtenPay;
            if (currtenPay == 0 && totalPay == 0 || currtenPay == totalPay)
            {
                toolStripLblGeneralStat.Visible = false;
            }
            else if (totalPay > currtenPay)
            {
                toolStripLblGeneralStat.Visible = true;
                toolStripLblGeneralStat.Text = "Durumunuz : " + generalPay.ToString() +" Gün" + " Alacaklısınız !";
            }
            else
            {
                toolStripLblGeneralStat.Visible = true;
                toolStripLblGeneralStat.Text = "Durumunuz : " + generalPay.ToString() + " Gün" + " Borçlusunuz !";
            }

        }
        #endregion

        #region Buton İşlemleri
        private void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["AddNewWorkOrder"];
            if (frm == null)
            {
                AddNewWorkOrder addNewWorkOrder = new AddNewWorkOrder();
                addNewWorkOrder.workOrders.AddRange(workOrders);
                addNewWorkOrder.Show();
            }

        }

        private void btnUpdateWorkOrder_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["UpdateWorkOrder"];
            if (frm == null)
            {
                UpdateWorkOrder updateWorkOrder = new UpdateWorkOrder();
                //updateWorkOrder.workOrders.AddRange(workOrders);
                updateWorkOrder.Show();
            }

        }

        private void btnUpdateWorkOrderList_Click(object sender, EventArgs e)
        {
            totalPay = 0;
            currtenPay = 0;
            workOrders.Clear();
            isDoneWorkOrders.Clear();
            payments.Clear();
            ReadWorkOrderJson();
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["AddNewPaymentForm"];
            if (frm == null)
            {
                AddNewPaymentForm addNewPaymentForm = new AddNewPaymentForm();
                //addNewPaymentForm.payments.AddRange(payments);
                addNewPaymentForm.Show();
            }

        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["OptionsForm"];
            if (frm == null)
            {

            }
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
        }

        #endregion

        #region Notify Ayarları
        private void MainMenu_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                this.Hide();
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "Hakediş Uygulaması Altta Çalışmaya Devam Etmektedir.";
                notifyIcon1.BalloonTipTitle = "Hakediş Uygulaması";
                notifyIcon1.Text = "Hakediş Uygulaması";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(30000);
            }
            else
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.Show();
        }

        private void uygulamayıKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.Show();
        }

        #endregion

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectRow = dataGridView1.CurrentCell.RowIndex;
                UpdateWorkOrder updateWorkOrder = new UpdateWorkOrder();
                updateWorkOrder.idIndex = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                updateWorkOrder.txtName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                updateWorkOrder.txtDesc = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                updateWorkOrder.startDate = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                updateWorkOrder.finishDate = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                updateWorkOrder.ManDay = double.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                if (dataGridView1.CurrentRow.Cells[5].Value != null)
                {
                    updateWorkOrder.expiredDate = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                }
                else
                {
                    updateWorkOrder.expiredDate = null;
                }

                updateWorkOrder.Show();
            }
            catch (Exception)
            {

            }

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UpdatePaymentForm updatePaymentForm = new UpdatePaymentForm();
                updatePaymentForm.idIndex = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                updatePaymentForm.name = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                updatePaymentForm.pay = double.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                updatePaymentForm.paymentDate = DateTime.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                updatePaymentForm.Show();
            }
            catch (Exception)
            {


            }

        }

        private void btnUpdatePayment_Click_1(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["UpdatePaymentForm"];
            if (frm == null)
            {
                UpdatePaymentForm updatePaymentForm = new UpdatePaymentForm();
                updatePaymentForm.payments.AddRange(payments);
                updatePaymentForm.Show();
            }

        }

        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            totalPay = 0;
            currtenPay = 0;
            workOrders.Clear();
            isDoneWorkOrders.Clear();
            payments.Clear();
            ReadWorkOrderJson();
        }

        private void MainListFilterClick(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            switch (toolStripMenuItem.Text)
            {
                case "Tamamlanan İşleri Göster":
                    checkedFilter = true;
                    break;
                case "Tamamlanan İşleri Gösterme":
                    checkedFilter = false;
                    break;
                default:
                    break;
            }
            totalPay = 0;
            currtenPay = 0;
            workOrders.Clear();
            isDoneWorkOrders.Clear();
            payments.Clear();
            ReadWorkOrderJson();
        }
    }
}
