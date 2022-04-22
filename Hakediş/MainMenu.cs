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
using System.Diagnostics;
namespace Hakediş
{
    public partial class MainMenu : Form
    {
        Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        static string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        readonly static string pathApplication = System.IO.Path.GetDirectoryName(path);
        readonly string jsonWorkOrderDataPath = pathApplication+ @"\WorkOrderJson.json";
        readonly string jsonPaymentsDataPath = pathApplication + @"\PaymentJson.json";
        readonly string jsonMailUpdateDataPath = pathApplication + @"\jsonMailUpdateData.json";
        readonly string jsonUserConfigPathFile = pathApplication + @"\UserConfig.json";
        readonly string jsonAppVersionConfigPathFile = pathApplication + @"\AppVersionConfig.json";
        readonly string appHakedisUpdaterPath = pathApplication + @"\UpdaterHakedis.exe";
        string userTypeString;
        public List<WorkOrder> workOrders = new List<WorkOrder>();
        public List<WorkOrder> isDoneWorkOrders = new List<WorkOrder>();
        public List<Payment> payments = new List<Payment>();
        public bool checkedFilter;
        int currentMonth = int.Parse(DateTime.Now.Month.ToString());
        static int weatherIconID;
        double totalPay;
        double currtenPay;
        short calculateParameterNum = 0;
        public string weatherCityKey = "745044";
        public string weatherCityName = "İstanbul";
        public MainMenu()
        {
            InitializeComponent();
            ReadWeather(weatherCityKey,weatherCityName);
            ReadUserConfigData();

        }

        #region Ana Menü İşlemleri
        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                CreateCurrentVersionFile();
                CheckUpdaterAppDone();
                dateTimePickerFinishWorkOrder.MinDate = dateTimePickerStartWorkOrder.Value;
                int currentDay = (int)DateTime.Now.DayOfWeek;
                string currentDayString = ((DaysOfWeek)currentDay).ToString();
                this.IsMdiContainer = true;
                if (CheckAlreadyRunningApp.CheckApp())
                {
                    MessageBox.Show("Uygulama Zaten Şuanda Çalışmakta !", "Uygulama Arka Planda Çalışıyor");
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                this.Text = System.Environment.MachineName + "/ Hakedis /" + userTypeString + "/" + version;
                BackupData(currentDayString);
                //Form size belirleme
                this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
                this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                //
                ReadWorkOrderJson();
                AddSearchFilterTitle();
                //int remainingWeek = ;
                DateInfoStatusApp();
                CheckLastUpdateDate();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                //cmbWorkOrderFilter.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void AddSearchFilterTitle()
        {
            cmbWorkOrderFilter.Items.Clear();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                cmbWorkOrderFilter.Items.Add(dataGridView1.Columns[i].HeaderText);
            }
        }
        private void SearchWorkOrder(string key,string searchColumnName)
        {
            //"İş Adı", "Açıklama", "Başlangıç Tarihi", "Bitirme Tarihi", "Teslim Tarihi", "Adam/Gün"
            List<WorkOrder> cloneWorkOrders = new List<WorkOrder>();
            if (cloneWorkOrders.Count <= 0)
            {
                cloneWorkOrders = workOrders;
            }

            switch (searchColumnName)
            {
                case "ID":
                    cloneWorkOrders = cloneWorkOrders.Where(x => x.ID.ToString().Contains(key)).ToList();
                    break;
                case "İş Adı":
                    cloneWorkOrders = cloneWorkOrders.Where(x => x.Name.ToLower().Contains(key.ToLower())).ToList();
                    break;
                case "Açıklama":
                    cloneWorkOrders = cloneWorkOrders.Where(x => x.Name.ToLower().Contains(key.ToLower())).ToList();
                    break;
                case "Adam/Gün":
                    cloneWorkOrders = cloneWorkOrders.Where(x => x.ManOfDay.ToString().Contains(key)).ToList();
                    break;
                default:
                    break;
            }
            if (key != null || key != string.Empty)
            {
                dataGridView1.DataSource = cloneWorkOrders;
            }
            else
            {
                dataGridView1.DataSource = workOrders;
            }
         
          
        }
        private void SearchWorkOrder(DateTime startTime, DateTime finishedTime)
        {
            //"İş Adı", "Açıklama", "Başlangıç Tarihi", "Bitirme Tarihi", "Teslim Tarihi", "Adam/Gün"
            List<WorkOrder> cloneWorkOrders = new List<WorkOrder>();
            if (cloneWorkOrders.Count <= 0)
            {
                cloneWorkOrders = workOrders;
            }
            if (cmbWorkOrderFilter.SelectedItem != null)
            {
                switch (cmbWorkOrderFilter.SelectedItem.ToString())
                {
                    case "Başlangıç Tarihi":
                        cloneWorkOrders = cloneWorkOrders.Where(x => startTime <= x.StartingDate && finishedTime >= x.StartingDate).ToList();
                        break;
                    case "Bitirme Tarihi":
                        cloneWorkOrders = cloneWorkOrders.Where(x => startTime <= x.ExpiredDate && finishedTime >= x.ExpiredDate).ToList();
                        break;
                    case "Teslim Tarihi":
                        cloneWorkOrders = cloneWorkOrders.Where(x => startTime <= x.FinishedDate && finishedTime >= x.FinishedDate).ToList();
                        break;
                    default:
                        break;
                }
            }
            dataGridView1.DataSource = cloneWorkOrders;
        }
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnUpdatePayment_Click_1(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["UpdatePaymentForm"];
            try
            {
                if (payments.Count > 0)
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
                else
                {
                    MessageBox.Show("Lütfen Ödeme Girişi Yapın !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu! Lütfen Ödeme Seçtiğinize Emin Olun", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            totalPay = 0;
            currtenPay = 0;
            workOrders.Clear();
            isDoneWorkOrders.Clear();
            payments.Clear();
            ReadWorkOrderJson();
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void HideMainItem()
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void btnCreateWorkReport_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["WorkOrderReportForm"];
            if (frm == null)
            {
                WorkOrderReportForm workOrderReportForm = new WorkOrderReportForm(this);
                HideMainItem();

                workOrderReportForm.MdiParent = this;
                workOrderReportForm.WindowState = FormWindowState.Maximized;
                workOrderReportForm.BringToFront();
                workOrderReportForm.Show();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void toolStripBtnBackup_Click(object sender, EventArgs e)
        {
            ManualBackupData();
        }
        private void ManualBackupData()
        {
            try
            {
                List<UpdateMail> updateMails = new List<UpdateMail>();
                updateMails = DataListing.ReadBackupInfo(jsonMailUpdateDataPath, updateMails);
                var date = updateMails[0].UpdateDate.ToString();
                toolStripProgressBarBackup.Visible = true;
                timerBackupStat.Enabled = true;
                BackupData(date);
            }
            catch (Exception)
            {

                throw;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void timerBackupStat_Tick(object sender, EventArgs e)
        {
            toolStripProgressBarBackup.Value += 5;
            if (toolStripProgressBarBackup.Value == 100)
            {
                timerBackupStat.Enabled = false;
                toolStripBtnBackup.Visible = false;
                toolStripProgressBarBackup.Value = 0;
                toolStripProgressBarBackup.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(pathApplication + @"\check.txt");
            Application.Exit();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void ıconToolStripBtnBackupManual_Click(object sender, EventArgs e)
        {
            ManualBackupData();
        }
        #endregion

        #region Data İşlemleri
        private void CheckUpdaterAppDone()
        {
            if (File.Exists(pathApplication + @"\check.txt"))
            {
                File.Delete(pathApplication + @"\check.txt");
            }
            else
            {
                var p = new Process();
                p.StartInfo.FileName = appHakedisUpdaterPath;
                p.Start();
                Application.ExitThread();
                File.Delete(pathApplication + @"\check.txt");
            }
        }
        private void DateInfoStatusApp()
        {
            int week = DateTime.Now.DayOfYear / 7;
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblCurrentMonth.Text = "Şuan Yılın " + currentMonth.ToString() + ". Ayında,";
            lblCurrentWeek.Text = week + ". Haftasında, ";
            int currentDay = (int)DateTime.Now.DayOfWeek;
            lblCurrentDay.Text = ((DaysOfWeek)currentDay).ToString() + " Günündesiniz.";
            lblRemainingWeek.Text = "Geriye " + (52 - week).ToString() + " Hafta Kaldı.";
        }

        private void CheckDataGridEmpty()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                btnUpdateWorkOrder.Enabled = true;
                dataGridView1.Rows[0].Selected = true;
            }
            else
            {
                btnUpdateWorkOrder.Enabled = false;
            }
            if (dataGridView2.Rows.Count >0 )
            {
                btnUpdatePayment.Enabled = true;
                dataGridView2.Rows[0].Selected = true;
            }
            else
            {
                btnUpdatePayment.Enabled = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public void ReadUserConfigData()
        {
            try
            {
                if (File.Exists(jsonUserConfigPathFile) && new FileInfo(jsonUserConfigPathFile).Length > 0)
                {
                    List<User> users = new List<User>();
                    users = DataListing.ReadUserConfig(jsonUserConfigPathFile, users);
                    calculateParameterNum = users[0].CalculateParameter;
                    userTypeString = users[0].Usertype.ToString();
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception)
            {

                throw;
            }
          
        }
        public void ReadWorkOrderJson()
        {
            try
            {
                if(File.Exists(jsonWorkOrderDataPath) && new FileInfo(jsonWorkOrderDataPath).Length > 0)
                {

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
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[2].Visible = false;
                    DataTableColumnNameChange.ChangeDataGridHeader(dataGridView1, "İş Adı", "Açıklama", "Başlangıç Tarihi", "Bitirme Tarihi", "Teslim Tarihi", "Adam/Gün");
                    dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dataGridView1.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                if (File.Exists(jsonPaymentsDataPath) && new FileInfo(jsonPaymentsDataPath).Length >0)
                {

                    payments = DataListing.ReadPaymentJson(jsonPaymentsDataPath, payments);
                    payments.Reverse();
                    dataGridView2.DataSource = payments;
                    DataTableColumnNameChange.ChangeDataGridHeader(dataGridView2, "Ödeme Adı", "Ödenen Gün", "Ödeme Tarihi");
                    dataGridView2.Columns[0].Visible = false;
                    dataGridView2.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                if (File.Exists(jsonPaymentsDataPath)||File.Exists(jsonWorkOrderDataPath))
                    CalculatePayments(isDoneWorkOrders, payments);

                CheckDataGridEmpty();
            }
            catch (Exception)
            {

            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void CheckFilesAndFolders()
        {
            if (File.Exists(pathApplication+@"/Newtonsoft.Json.dll")&& File.Exists(pathApplication + @"/FontAwesome.Sharp.dll"))
            {

            }
            else
            {
                MessageBox.Show("Uygulama Dosyaları Eksik Lütfen Kontrol Edin !","Dosya Eksik!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        public void CalculatePayments(List<WorkOrder> otherList, List<Payment> payments)
        {
            if (payments.Count != 0)
                currtenPay = payments.Sum(x => x.PayforDay);
            totalPay = otherList.Sum(x=> x.ManOfDay);
            double generalPay = 0;
            switch (calculateParameterNum)
            {
                case 1:
                    generalPay = totalPay - currtenPay;
                    break;
                case -1:
                    generalPay = currtenPay - totalPay;
                    break;
                default:
                    break;
            }
            if (generalPay == 0)
            {
                btnGeneralStat.Text = "Durumunuz : Stabil.";
                btnGeneralStat.BackColor = Color.Gray;
                btnGeneralStat.IconChar = FontAwesome.Sharp.IconChar.Equals;
            }
            else if (generalPay>0)
            {
                btnGeneralStat.Visible = true;
                btnGeneralStat.Text = "Durumunuz : " + generalPay.ToString() + " Gün" + " Alacaklısınız !";
                btnGeneralStat.BackColor = Color.Green;
                btnGeneralStat.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            }
            else if (generalPay<0)
            {
                btnGeneralStat.Visible = true;
                btnGeneralStat.Text = "Durumunuz : " + generalPay.ToString() + " Gün" + " Borçlusunuz !";
                btnGeneralStat.BackColor = Color.Crimson;
                btnGeneralStat.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            }


            //if (currtenPay == 0 && totalPay == 0 || currtenPay == totalPay)
            //{
            //    btnGeneralStat.Text = "Durumunuz : Stabil." ;
            //    btnGeneralStat.BackColor = Color.Gray;
            //    btnGeneralStat.IconChar = FontAwesome.Sharp.IconChar.Equals;
            //}
            //else if (totalPay > currtenPay)
            //{
            //    btnGeneralStat.Visible = true;
            //    btnGeneralStat.Text = "Durumunuz : " + generalPay.ToString() + " Gün" + " Alacaklısınız !";
            //    btnGeneralStat.BackColor = Color.Green;
            //    btnGeneralStat.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            //}
            //else
            //{
            //    btnGeneralStat.Visible = true;
            //    btnGeneralStat.Text = "Durumunuz : " + generalPay.ToString() + " Gün" + " Borçlusunuz !";
            //    btnGeneralStat.BackColor = Color.Crimson;
            //    btnGeneralStat.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            //}
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public void UpdateDataList()
        {
            totalPay = 0;
            currtenPay = 0;
            workOrders.Clear();
            isDoneWorkOrders.Clear();
            payments.Clear();
            ReadWorkOrderJson();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #endregion

        #region BackupData
        private void CheckLastUpdateDate()
        {
            toolStripLblLastBackupDays.Visible = false;
            if (File.Exists(jsonMailUpdateDataPath) && new FileInfo(jsonMailUpdateDataPath).Length > 0)
            {
                List<UpdateMail> updateMails = new List<UpdateMail>();
                updateMails = DataListing.ReadBackupInfo(jsonMailUpdateDataPath, updateMails);
                var lastUpdate = updateMails[0].LastUpdateDate.Value;
                var updateDate = updateMails[0].UpdateDate.ToString();
                var nowDate = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
                var remainingDate = (nowDate - lastUpdate).TotalDays;
                if (remainingDate > 0)
                {
                    toolStripLblLastBackupDays.Text = "Son Yedekleme " + remainingDate + " Gün Önce Yapıldı.";
                    ıconToolStripBtnBackupManual.Visible = true;
                    toolStripLblLastBackupDays.Visible = true;
                }

                if (remainingDate > 7 && CheckInternetControl() && Hakediş.Properties.Settings.Default.isAnyUpdate == false && lastUpdate != null)
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show($"Verileriniz En Son {remainingDate} Gün Önce Yedeklendi. \rVerilerinizi Yedeklemek İstersiniz ?","Veri Yedeklemesi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dialog== DialogResult.Yes)
                    {
                        BackupData(updateDate);
                    }
                    else
                    {
                        toolStripBtnBackup.Visible = true;
                    }
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public void BackupData(string DateNow)
        {
            try
            {
                if (CheckInternetControl() && File.Exists(jsonMailUpdateDataPath) && new FileInfo(jsonMailUpdateDataPath).Length > 0)
                {
                    List<UpdateMail> updateMails = new List<UpdateMail>();
                    updateMails = DataListing.ReadBackupInfo(jsonMailUpdateDataPath, updateMails);
                    var date = updateMails[0].UpdateDate.ToString();
                    DateTime? lastUpdateDate = updateMails[0].LastUpdateDate.Value;
                    var nowDate = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
                    if (DateNow == date && Hakediş.Properties.Settings.Default.isAnyUpdate == false && lastUpdateDate != nowDate)
                    {
                        var toEmail = updateMails[0].ToEmail;//Göndermek İstediğin Email Girişi
                        var email = updateMails[0].UserName;
                        var pass = updateMails[0].Password;
                        var body = DateTime.Now.ToString() + " Yedeklemesi " + Environment.NewLine + Application.CompanyName + " " + Application.ProductName + " App";
                        var subject = "Hakediş " + DateTime.Now.ToString() + " Yedek Veri Güncellemesi";
                        if (ConnectAndSendMail.Email_Send(toEmail, body, subject, email, pass, jsonWorkOrderDataPath, jsonPaymentsDataPath))
                        {
                            Hakediş.Properties.Settings.Default.isAnyUpdate = true;
                            updateMails[0].LastUpdateDate = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
                            var json = Newtonsoft.Json.JsonConvert.SerializeObject(updateMails);
                            File.WriteAllText(jsonMailUpdateDataPath, json);
                            ıconToolStripBtnBackupManual.Visible = false;
                            toolStripLblLastBackupDays.Visible = false;
                        }
                    }
                    else
                    {
                        Hakediş.Properties.Settings.Default.isAnyUpdate = false;
                        Hakediş.Properties.Settings.Default.Save();
                        Hakediş.Properties.Settings.Default.Reload();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #endregion

        #region Program Versiyon Kontrol
        private void CreateCurrentVersionFile()
        {
            AppVersion appVersion = new AppVersion();
            appVersion.Major = version.Major;
            appVersion.Minor = version.Minor;
            appVersion.Build = version.Build;
            appVersion.Revision = version.Revision;
            var jsonData = JsonConvert.SerializeObject(appVersion);
            File.WriteAllText(jsonAppVersionConfigPathFile, jsonData);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #endregion

        #region Hava Durumu İslemleri
        private void ReadWeather(string _cityKey,string cityName)
        {
            if (CheckInternetControl())
            {
                string apiKey = "022a034657d661fa210c9cd44185ff5e";
                string cityKey = _cityKey;
                string data = WeatherEngine.DailyWeatherGet(apiKey, cityKey);
                var result = JsonConvert.DeserializeObject<WeatherInfo.Root>(data);
                WeatherInfo.Root weatherInfo = result;
                lblWeather.Text = weatherInfo.weather[0].description.ToUpper();
                lblTemperature.Text = weatherInfo.main.temp.ToString() + "°C";
                weatherIconID = weatherInfo.weather[0].id;
                selectWeatherIcon();
                btnWeatherIcon.Text = cityName;
            }
            else
            {
                btnWeatherIcon.Text = "İnternet Yok!";
                lblWeather.Text = "Bulunamadı.";
                lblTemperature.Text = "Bulunamadı.";
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnUpdateWorkOrder_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["UpdateWorkOrder"];
            try
            {
                if (frm == null)
                {
                    if (workOrders.Count>0)
                    {
                        UpdateWorkOrder updateWorkOrder = new UpdateWorkOrder(this);
                        var selectRow = dataGridView1.SelectedRows[0].Index;
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
                    else
                    {
                        MessageBox.Show("Lütfen İş Emri Girişi Yapın !","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu! Lütfen İş Emri Seçtiğinize Emin Olun", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["OptionsForm"];
            if (frm == null)
            {
                OptionsForm optionsForm = new OptionsForm(this);
                optionsForm.Show();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        #endregion

        #region Notify Ayarları
        private void MainMenu_Resize(object sender, EventArgs e)
        {
            NotifyIcon();
        }
        #region MyRegion
        void NotifyIcon()
        {
            if (FormWindowState.Minimized == WindowState)
            {
                this.Hide();
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "Hakediş Uygulaması Altta Çalışmaya Devam Etmektedir.";
                notifyIcon1.BalloonTipTitle = "Hakediş Uygulaması";
                notifyIcon1.Text = "Hakediş Uygulaması";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(2000);
            }
            else
            {
                notifyIcon1.Visible = false;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        void ShowNotifyNotification(string header, string message)
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.BalloonTipTitle = header;
            notifyIcon1.Text = "Hakediş Uygulaması";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(2000);
        }
        #endregion
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            notifyIcon1.Visible = false;
            this.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void uygulamayıKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
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

        #region Hava Durumu Şehir Seçimi
        private void ankaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                weatherCityKey = "323784";
                weatherCityName = ankaraToolStripMenuItem.Text;
                ReadWeather(weatherCityKey, weatherCityName);
                //  ankaraToolStripMenuItem.CheckState = CheckState.Checked;
                //for (int i = 0; i < şehirToolStripMenuItem.DropDownItems.Count; i++)
                //{
                //    var item = şehirToolStripMenuItem.DropDownItems[i].Selected;
                //}
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception)
            {
                btnWeatherIcon.Text = "İnternet Yok!";
                lblWeather.Text = "Bulunamadı.";
                lblTemperature.Text = "Bulunamadı.";
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            }

        }

        private void izmirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                weatherCityKey = "324294";
                weatherCityName = izmirToolStripMenuItem.Text;
                ReadWeather(weatherCityKey, weatherCityName);
                //  izmirToolStripMenuItem.Checked = true;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception)
            {

                btnWeatherIcon.Text = "İnternet Yok!";
                lblWeather.Text = "Bulunamadı.";
                lblTemperature.Text = "Bulunamadı.";
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            }

        }
        private void kocaeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                weatherCityKey = "742865";
                weatherCityName = kocaeliToolStripMenuItem.Text;
                ReadWeather(weatherCityKey, weatherCityName);
                //  kocaeliToolStripMenuItem.Checked = true;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception)
            {


                btnWeatherIcon.Text = "İnternet Yok!";
                lblWeather.Text = "Bulunamadı.";
                lblTemperature.Text = "Bulunamadı.";
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            }

        }
        private void antalyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                weatherCityKey = "323777";
                weatherCityName = antalyaToolStripMenuItem.Text;
                ReadWeather(weatherCityKey, weatherCityName);
                // antalyaToolStripMenuItem.Checked = true;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception)
            {
                btnWeatherIcon.Text = "İnternet Yok!";
                lblWeather.Text = "Bulunamadı.";
                lblTemperature.Text = "Bulunamadı.";
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            }
         
        }
        private void bursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                weatherCityKey = "750269";
                weatherCityName = bursaToolStripMenuItem.Text;
                ReadWeather(weatherCityKey, weatherCityName);
                //  bursaToolStripMenuItem.Checked = true;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception)
            {


                btnWeatherIcon.Text = "İnternet Yok!";
                lblWeather.Text = "Bulunamadı.";
                lblTemperature.Text = "Bulunamadı.";
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            }
        
        }
        private void konyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                weatherCityKey = "306571";
                weatherCityName = konyaToolStripMenuItem.Text;
                ReadWeather(weatherCityKey, weatherCityName);
                //  konyaToolStripMenuItem.Checked = true;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception)
            {

                btnWeatherIcon.Text = "İnternet Yok!";
                lblWeather.Text = "Bulunamadı.";
                lblTemperature.Text = "Bulunamadı.";
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            }
        
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ReadWeather(weatherCityKey, weatherCityName);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception)
            {


                btnWeatherIcon.Text = "İnternet Yok!";
                lblWeather.Text = "Bulunamadı.";
                lblTemperature.Text = "Bulunamadı.";
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            }
        
        }
        private void istanbultoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                weatherCityKey = "745042";
                weatherCityName = istanbultoolStripMenuItem1.Text;
                ReadWeather(weatherCityKey, weatherCityName);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            catch (Exception)
            {


                btnWeatherIcon.Text = "İnternet Yok!";
                lblWeather.Text = "Bulunamadı.";
                lblTemperature.Text = "Bulunamadı.";
                btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            }
     
        }

        #endregion


        private void txtSearchWorkOrder_TextChanged(object sender, EventArgs e)
        {
            if (cmbWorkOrderFilter.SelectedItem != null)
            {
                SearchWorkOrder(txtSearchWorkOrder.Text, cmbWorkOrderFilter.SelectedItem.ToString());
            }
        }

        private void cmbWorkOrderFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //"İş Adı", "Açıklama", "Başlangıç Tarihi", "Bitirme Tarihi", "Teslim Tarihi", "Adam/Gün"
            switch (cmbWorkOrderFilter.SelectedItem.ToString())
            {
                case "Başlangıç Tarihi":
                    txtSearchWorkOrder.Visible = false;
                    dateTimePickerStartWorkOrder.Visible = true;
                    dateTimePickerFinishWorkOrder.Visible = true;
                    dateTimePickerFinishWorkOrder.Location = new Point(dateTimePickerStartWorkOrder.Right + 1,dateTimePickerFinishWorkOrder.Location.Y);
                    cmbWorkOrderFilter.Location = new Point(dateTimePickerFinishWorkOrder.Right+1, dateTimePickerStartWorkOrder.Location.Y);
                    SearchWorkOrder(dateTimePickerStartWorkOrder.Value, dateTimePickerFinishWorkOrder.Value);
                    break;
                case "Bitirme Tarihi":
                    txtSearchWorkOrder.Visible = false;
                    dateTimePickerFinishWorkOrder.Visible = true;
                    dateTimePickerStartWorkOrder.Visible = true;
                    dateTimePickerFinishWorkOrder.Location = new Point(dateTimePickerStartWorkOrder.Right + 1, dateTimePickerFinishWorkOrder.Location.Y);
                    cmbWorkOrderFilter.Location = new Point(dateTimePickerFinishWorkOrder.Right + 1, dateTimePickerStartWorkOrder.Location.Y);
                    break;
                case "Teslim Tarihi":
                    txtSearchWorkOrder.Visible = false;
                    dateTimePickerFinishWorkOrder.Visible = true;
                    dateTimePickerStartWorkOrder.Visible = true;
                    dateTimePickerFinishWorkOrder.Location = new Point(dateTimePickerStartWorkOrder.Right + 1, dateTimePickerFinishWorkOrder.Location.Y);
                    cmbWorkOrderFilter.Location = new Point(dateTimePickerFinishWorkOrder.Right + 1, dateTimePickerStartWorkOrder.Location.Y);
                    break;
                default:
                    txtSearchWorkOrder.Visible = true;
                    cmbWorkOrderFilter.Location = new Point(txtSearchWorkOrder.Right + 2, txtSearchWorkOrder.Location.Y);
                    dateTimePickerStartWorkOrder.Visible = false;
                    dateTimePickerFinishWorkOrder.Visible = false;
                    break;
            }
        }

   
        private void dateTimePickerStartWorkOrder_Validated(object sender, EventArgs e)
        {
            dateTimePickerFinishWorkOrder.MinDate = dateTimePickerStartWorkOrder.Value;
        }

        private void dateTimePickerStartWorkOrder_Validating(object sender, CancelEventArgs e)
        {

            SearchWorkOrder(dateTimePickerStartWorkOrder.Value, dateTimePickerFinishWorkOrder.Value);
            btnGeneralStat.PerformClick();
            
        }

        private void dateTimePickerFinishWorkOrder_Validating(object sender, CancelEventArgs e)
        {
            SearchWorkOrder(dateTimePickerStartWorkOrder.Value, dateTimePickerFinishWorkOrder.Value);
            btnGeneralStat.PerformClick();
        }


        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                btnUpdateWorkOrder.Enabled = false;
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.Rows.Count ==0)
            {
                btnUpdateWorkOrder.Enabled = false;

            }
            else
            {
                btnUpdateWorkOrder.Enabled = true;
            }

        }
    }
}
