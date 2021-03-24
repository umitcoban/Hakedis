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
    public partial class UpdatePaymentForm : Form
    {
        static string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        readonly static string pathApplication = System.IO.Path.GetDirectoryName(path);
        private readonly MainMenu mainMenu;
        public List<Payment> payments { get; set; }
        readonly string jsonPaymentsDataPath = pathApplication + @"\PaymentJson.json";
        public double man, pay;
        public string name;
        public int idIndex = 0;
        public DateTime paymentDate;
        public UpdatePaymentForm(MainMenu main)
        {
            InitializeComponent();
            payments = new List<Payment>();
            mainMenu = main;
        }
        #region Data İşlemleri
        public void ReadJson()
        {
            try
            {
                string jsonData = File.ReadAllText(jsonPaymentsDataPath);
                payments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Payment>>(jsonData);
            }
            catch (Exception)
            {

            }
        }
        private void NewUpdatePayments()
        {
            try
            {
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(payments);
                File.WriteAllText(jsonPaymentsDataPath, jsonData);
                MessageBox.Show("Ödemeler Başarılı Bir Şekilde Güncellendi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainMenu.UpdateDataList();
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void UpdatePaymentForm_Load(object sender, EventArgs e)
        {
            try
            {
                //ReadJson();
                payments = DataListing.ReadPaymentJson(jsonPaymentsDataPath,payments);
                txtUpdateName.Text = name;
                txtUpdatePayForDay.Text = pay.ToString();
                dateTimePayment.Value = paymentDate;

            }
            catch (Exception)
            {

            }
           
        }

        private void txtUpdatePayForDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

            // tek bir virgül eklemesi gerektiğini kontrol et
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            if (txtUpdatePayForDay.Text != ""&& dateTimePayment.Value != null)
            {
                try
                {
                    int selectedRow = 0;
                    for (int i = 0; i <= payments.Count - 1; i++)
                    {
                        if (payments[i].ID == idIndex)
                        {
                            selectedRow = i;
                            break;
                        }
                    }
                    payments[selectedRow].Name = txtUpdateName.Text;
                    //payments[selectRow].ManofDay = double.Parse( txtUpdateDayOfMan.Text);
                    payments[selectedRow].PayforDay = double.Parse(txtUpdatePayForDay.Text);
                    payments[selectedRow].PaymentDate = dateTimePayment.Value;
                    NewUpdatePayments();
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir Hata Oluştu !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Boş Bırakmayın !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
