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
        public List<WorkOrder> workOrders = new List<WorkOrder>();
        public List<WorkOrder> isDoneWorkOrders = new List<WorkOrder>();
        public List<Payment> payments = new List<Payment>();

        int currentMonth = int.Parse(DateTime.Now.Month.ToString());
        double totalPay;
        double currtenPay;
        public MainMenu()
        {
            InitializeComponent();

        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            ReadWorkOrderJson();
            toolStripLblMonth.Text = "Şuan Yılın " + currentMonth.ToString() + ". Ayındasınız";
        }
        #region Data İşlemleri
        public void ReadWorkOrderJson()
        {
            try
            {
                if (File.Exists(jsonPaymentsDataPath))
                {
                    string jsonPaymentData = File.ReadAllText(jsonPaymentsDataPath);
                    payments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Payment>>(jsonPaymentData);
                }
                List<Payment> paymentsClone = payments;
                dataGridView2.DataSource = payments;
                dataGridView2.Columns[0].Visible = false;
                if (File.Exists(jsonWorkOrderDataPath))
                {
                    string jsonData = File.ReadAllText(jsonWorkOrderDataPath);
                    workOrders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorkOrder>>(jsonData);
                }
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
                //for (int i = 0; i <= currentWorkOrders.Count-1; i++)
                //{
                //    if (currentWorkOrders[i].ExpiredDate != null)
                //    {
                //        currentWorkOrders.RemoveAt(i);
                //        i = 0;
                //    }
                //}
                if (checkBoxFilter.Checked == true)
                {
                    dataGridView1.DataSource = workOrders;
                }
                else
                {
                    dataGridView1.DataSource = currentWorkOrders;
                }
                //dataGridView1.DataSource = currentWorkOrders;
                dataGridView1.Columns[0].Visible = false;
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
            toolStripLblTotalPayment.Text = totalPay.ToString();
            toolStripLblCurrentPay.Text = currtenPay.ToString();
            double generalPay = totalPay - currtenPay;
            if (currtenPay == 0 && totalPay == 0)
            {
                toolStripLblGeneralStat.Visible = false;
            }
            else if (totalPay > currtenPay)
            {
                toolStripLblGeneralStat.Visible = true;
                toolStripLblGeneralStat.Text = "Durumunuz : " + generalPay.ToString() + " Alacaklısınız !";
            }
            else
            {
                toolStripLblGeneralStat.Visible = true;
                toolStripLblGeneralStat.Text = "Durumunuz : " + generalPay.ToString() + " Borçlusunuz !";
            }

        }

        //private void MakeJson()
        //{
        //    WorkOrder workOrder = new WorkOrder();
        //    workOrder.Name = "Deneme4";
        //    workOrder.Description = "Bu bir deneme açıklamasıdır.";
        //    workOrders.Add(workOrder);
        //    string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(workOrders);
        //    File.WriteAllText(jsonWorkOrderDataPath, jsonData);
        //}

        #endregion

        #region Buton İşlemleri
        private void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            AddNewWorkOrder addNewWorkOrder = new AddNewWorkOrder();
            addNewWorkOrder.workOrders.AddRange(workOrders);
            addNewWorkOrder.Show();
        }

        private void btnUpdateWorkOrder_Click(object sender, EventArgs e)
        {
            UpdateWorkOrder updateWorkOrder = new UpdateWorkOrder();
            updateWorkOrder.workOrders.AddRange(workOrders);
            updateWorkOrder.Show();
        }

        private void btnUpdateWorkOrderList_Click(object sender, EventArgs e)
        {
            workOrders.Clear();
            isDoneWorkOrders.Clear();
            payments.Clear();
            ReadWorkOrderJson();
            totalPay = 0;
            currtenPay = 0;
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            AddNewPaymentForm addNewPaymentForm = new AddNewPaymentForm();
            addNewPaymentForm.payments.AddRange(payments);
            addNewPaymentForm.Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
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
            UpdatePaymentForm updatePaymentForm = new UpdatePaymentForm();
            updatePaymentForm.idIndex = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            updatePaymentForm.name = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            updatePaymentForm.pay = double.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
            updatePaymentForm.Show();
        }

        private void btnUpdatePayment_Click_1(object sender, EventArgs e)
        {
            UpdatePaymentForm updatePaymentForm = new UpdatePaymentForm();
            updatePaymentForm.payments.AddRange(payments);
            updatePaymentForm.Show();
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
    }
}
