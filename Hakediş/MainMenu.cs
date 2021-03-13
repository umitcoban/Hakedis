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
using Newtonsoft.Json;
using System.Net;

namespace Hakediş
{
    public partial class MainMenu : Form
    {
        static string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        readonly static string pathApplication = System.IO.Path.GetDirectoryName(path);
        readonly string jsonWorkOrderDataPath = pathApplication+ @"\WorkOrderJson.json";
        readonly string jsonPaymentsDataPath = pathApplication + @"\PaymentJson.json";
        readonly string jsonMailUpdateDataPath = pathApplication + @"\jsonMailUpdateData.json";
        static int weatherIconID;
        public List<WorkOrder> workOrders = new List<WorkOrder>();
        public List<WorkOrder> isDoneWorkOrders = new List<WorkOrder>();
        public List<Payment> payments = new List<Payment>();
        public bool checkedFilter;
        int currentMonth = int.Parse(DateTime.Now.Month.ToString());
        double totalPay;
        double currtenPay;
        public MainMenu()
        {
            InitializeComponent();
            ReadWeather();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //Form size belirleme
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //
            ReadWorkOrderJson();
            int week = DateTime.Now.DayOfYear / 7;
            //int remainingWeek = ;
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblCurrentMonth.Text = "Şuan Yılın " + currentMonth.ToString()+ ". Ayında,";
            lblCurrentWeek.Text = week + ". Haftasında, ";
            lblCurrentDay.Text = DateTime.Now.ToString("dddd") + " Günündesiniz.";
            lblRemainingWeek.Text = "Geriye " + (52 - week).ToString() + " Hafta Kaldı.";
            BackupData();
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
                if(File.Exists(jsonWorkOrderDataPath) && new FileInfo(jsonWorkOrderDataPath).Length > 0)
                {
                    //DataListing.ReadWorkOrderJson(dataGridView1, jsonWorkOrderDataPath);
                    workOrders = DataListing.ReadWorkOrderJson(jsonWorkOrderDataPath, workOrders);
                    List<WorkOrder> currentWorkOrders = new List<WorkOrder>();
                    currentWorkOrders.AddRange(workOrders);
                    currentWorkOrders = currentWorkOrders.Where(x => x.ExpiredDate == null).ToList();
                    isDoneWorkOrders = workOrders.Where(x => x.ExpiredDate != null).ToList();
                    if (checkedFilter)
                    {
                    dataGridView1.DataSource = workOrders.OrderBy(x => x.StartingDate).ToList();
                    }
                    else
                    {
                    dataGridView1.DataSource = currentWorkOrders.OrderBy(x => x.StartingDate).ToList();
                    }
                    DataTableColumnNameChange.ChangeDataGridHeader(dataGridView1, "İş Adı", "Açıklama", "Başlangıç Tarihi", "Bitirme Tarihi", "Teslim Tarihi", "Adam/Gün");
                    dataGridView1.Columns[0].Visible = false;
                }
                if (File.Exists(jsonPaymentsDataPath) && new FileInfo(jsonPaymentsDataPath).Length >0)
                {
                    //DataListing.ReadPaymentJson(dataGridView2, jsonPaymentsDataPath);
                    payments = DataListing.ReadPaymentJson(jsonPaymentsDataPath, payments);
                    payments.Reverse();
                    dataGridView2.DataSource = payments;
                    DataTableColumnNameChange.ChangeDataGridHeader(dataGridView2, "Ödeme Adı", "Ödenen Gün", "Ödeme Tarihi");
                    dataGridView2.Columns[0].Visible = false;
                }
                if (File.Exists(jsonPaymentsDataPath)||File.Exists(jsonWorkOrderDataPath))
                    CalculatePayments(isDoneWorkOrders, payments);
                //for (int i = 0; i <= currentWorkOrders.Count - 1; i++)
                //{
                //    if (currentWorkOrders[i].ExpiredDate != null)
                //    {
                //        isDoneWorkOrders.Add(currentWorkOrders[i]);
                //    }
                //}

                //foreach (var item in currentWorkOrders.ToList())
                //{
                //    if (item.ExpiredDate != null)
                //    {
                //        currentWorkOrders.Remove(item);
                //    }
                //}


                //dataGridView1.DataSource = currentWorkOrders;
                //dataGridView1.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
                //dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
                //dataGridView1.Columns[0].Visible = false;

            }
            catch (Exception)
            {

            }
        }

        public void CalculatePayments(List<WorkOrder> otherList, List<Payment> payments)
        {
            if (payments.Count != 0)
                currtenPay = payments.Sum(x => x.PayforDay);
            //if (payments.Count != 0)
            //    for (int i = 0; i < payments.Count; i++)
            //    {
            //        currtenPay += payments[i].PayforDay;
            //    }
           totalPay = otherList.Sum(x=> x.ManOfDay);
                //for (int i = 0; i < otherList.Count; i++)
                //{
                //    totalPay += otherList[i].ManOfDay;
                //}
            //toolStripLblTotalPayment.Text = totalPay.ToString();
            //toolStripLblCurrentPay.Text = currtenPay.ToString();
            double generalPay = totalPay - currtenPay;

            if (currtenPay == 0 && totalPay == 0 || currtenPay == totalPay)
            {
                btnGeneralStat.Text = "Durumunuz : Stabil." ;
                btnGeneralStat.BackColor = Color.Gray;
                btnGeneralStat.IconChar = FontAwesome.Sharp.IconChar.Equals;
            }
            else if (totalPay > currtenPay)
            {
                btnGeneralStat.Visible = true;
                btnGeneralStat.Text = "Durumunuz : " + generalPay.ToString() + " Gün" + " Alacaklısınız !";
                btnGeneralStat.BackColor = Color.Green;
                btnGeneralStat.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            }
            else
            {
                btnGeneralStat.Visible = true;
                btnGeneralStat.Text = "Durumunuz : " + generalPay.ToString() + " Gün" + " Borçlusunuz !";
                btnGeneralStat.BackColor = Color.Crimson;
                btnGeneralStat.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            }

        }
        public void UpdateDataList()
        {
            totalPay = 0;
            currtenPay = 0;
            workOrders.Clear();
            isDoneWorkOrders.Clear();
            payments.Clear();
            ReadWorkOrderJson();
        }
        #endregion
        #region BackupData
        private void BackupData()
        {
            if (CheckInternetControl()&& File.Exists(jsonMailUpdateDataPath)&& new FileInfo(jsonMailUpdateDataPath).Length > 0)
            {
                List<UpdateMail> updateMails = new List<UpdateMail>();
                updateMails = DataListing.ReadBackupInfo(jsonMailUpdateDataPath, updateMails);
                var date = updateMails[0].UpdateDate;
                if (DateTime.Now.ToString("dddd") == date && Hakediş.Properties.Settings.Default.isAnyUpdate==false)
                {
                    var toEmail = updateMails[0].ToEmail;//Göndermek İstediğin Email Girişi
                    var email = updateMails[0].UserName;
                    var pass = updateMails[0].Password;
                    var body = DateTime.Now.ToString() + " Güncellemesi" + Environment.NewLine + Application.CompanyName + " " + Application.ProductName + " App";
                    var subject = "Hakediş" + DateTime.Now.ToString() + " Yedek Veri Güncellemesi";
                    ConnectAndSendMail.Email_Send(toEmail, body, subject, email, pass, jsonWorkOrderDataPath, jsonPaymentsDataPath);
                    Hakediş.Properties.Settings.Default.isAnyUpdate = true;
                    Hakediş.Properties.Settings.Default.Save();
                    Hakediş.Properties.Settings.Default.Reload();
                }
                else
                {
                    Hakediş.Properties.Settings.Default.isAnyUpdate = false;
                    Hakediş.Properties.Settings.Default.Save();
                    Hakediş.Properties.Settings.Default.Reload();
                }
            }
        }
        #endregion
        #region Hava Durumu İslemleri
        private void ReadWeather()
        {
            if (CheckInternetControl())
            {
                string apiKey = "022a034657d661fa210c9cd44185ff5e";
                string cityKey = "745044";
                string data = WeatherEngine.DailyWeatherGet(apiKey, cityKey);
                var result = JsonConvert.DeserializeObject<WeatherInfo.Root>(data);
                WeatherInfo.Root weatherInfo = result;
                lblWeather.Text = weatherInfo.weather[0].description.ToUpper();
                lblTemperature.Text = weatherInfo.main.temp.ToString() + "°C";
                weatherIconID = weatherInfo.weather[0].id;
                selectWeatherIcon();
                btnWeatherIcon.Text = "İstanbul";
            }
            else
            {
                btnWeatherIcon.Text = "İnternet Yok!";
                lblWeather.Text = "Bulunamadı.";
                lblTemperature.Text = "Bulunamadı.";
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            }
        }
        private void selectWeatherIcon()
        {
            if (weatherIconID >= 200 && weatherIconID <=232)
            { 
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.CloudShowersHeavy;
                btnWeatherIcon.IconColor = Color.DarkBlue;
            }
            else if (weatherIconID >= 300 && weatherIconID <= 321)
            {
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.CloudSunRain;
                btnWeatherIcon.IconColor = Color.Blue;
            }
            else if (weatherIconID >= 500 && weatherIconID <= 531)
            {
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.CloudRain;
                btnWeatherIcon.IconColor = Color.Turquoise;
            }
            else if (weatherIconID >= 600 && weatherIconID <= 622)
            {
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
                btnWeatherIcon.IconColor = Color.White;
            }
            else if (weatherIconID >= 701 && weatherIconID <= 781)
            {
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Smog;
                btnWeatherIcon.IconColor = Color.Gray;
            }
            else if (weatherIconID == 800)
            {
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Sun;
                btnWeatherIcon.IconColor = Color.Yellow;
            }
            else
            {
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Cloud;
                btnWeatherIcon.IconColor = Color.Black;
            }
        }
        #endregion
        #region Buton İşlemleri
        private void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["AddNewWorkOrder"];
            if (frm == null)
            {
                AddNewWorkOrder addNewWorkOrder = new AddNewWorkOrder(this);
                //dataListing.ReadWorkOrderJson(jsonWorkOrderDataPath, addNewWorkOrder.workOrders);
                //addNewWorkOrder.workOrders.AddRange(workOrders);
                addNewWorkOrder.Show();
            }

        }

        private void btnUpdateWorkOrder_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["UpdateWorkOrder"];
            try
            {
                if (frm == null)
                {
                    UpdateWorkOrder updateWorkOrder = new UpdateWorkOrder(this);
                    var selectRow = dataGridView1.CurrentCell.RowIndex;
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
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Form frm = Application.OpenForms["UpdateWorkOrder"];
            //if (frm == null)
            //{
            //    UpdateWorkOrder updateWorkOrder = new UpdateWorkOrder(this);
            //    //updateWorkOrder.workOrders.AddRange(workOrders);
            //    updateWorkOrder.Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    updateWorkOrder.Show();
            //}
            //dataGridView1.CellDoubleClick(object sender);
           
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["AddNewPaymentForm"];
            if (frm == null)
            {
                AddNewPaymentForm addNewPaymentForm = new AddNewPaymentForm(this);
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
        #region İnternet Bağlantısı Kontrolü
        public static bool CheckInternetControl()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Form frm = Application.OpenForms["UpdateWorkOrder"];
                if (frm == null)
                {
                    UpdateWorkOrder updateWorkOrder = new UpdateWorkOrder(this);
                    var selectRow = dataGridView1.CurrentCell.RowIndex;
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
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form frm = Application.OpenForms["UpdatePaymentForm"];
            try
            {
                if (frm == null)
                {
                    UpdatePaymentForm updatePaymentForm = new UpdatePaymentForm(this);
                    updatePaymentForm.idIndex = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    updatePaymentForm.name = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    updatePaymentForm.pay = double.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                    updatePaymentForm.paymentDate = DateTime.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                    updatePaymentForm.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnUpdatePayment_Click_1(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["UpdatePaymentForm"];
            try
            {
                if (frm == null)
                {
                    UpdatePaymentForm updatePaymentForm = new UpdatePaymentForm(this);
                    updatePaymentForm.idIndex = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    updatePaymentForm.name = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    updatePaymentForm.pay = double.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                    updatePaymentForm.paymentDate = DateTime.Parse(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                    updatePaymentForm.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    //tamamlananİşleriGösterToolStripMenuItem.BackColor = Color.Blue;
                    tamamlananİşleriGösterToolStripMenuItem.Checked = true;
                    tamamlananİşleriGöstermeToolStripMenuItem.Checked = false;
                    break;
                case "Tamamlanan İşleri Gösterme":
                    checkedFilter = false;
                    //tamamlananİşleriGöstermeToolStripMenuItem.BackColor = Color.Blue;
                    tamamlananİşleriGöstermeToolStripMenuItem.Checked = true;
                    tamamlananİşleriGösterToolStripMenuItem.Checked = false;
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

        private void btnCreateWorkReport_Click(object sender, EventArgs e)
        {

        }


    }
}
