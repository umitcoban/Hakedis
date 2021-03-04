using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Hakediş
{
    public partial class AddNewPaymentForm : Form
    {
        readonly string jsonPaymentsDataPath = @"PaymentJson.json";
        public List<Payment> payments { get; set; }
        public int idIndex;

        public AddNewPaymentForm()
        {
            DataListing dataListing = new DataListing();
            InitializeComponent();
            payments = new List<Payment>();
        }

        #region Veri İşlemleri
        private void CreateNewPayment()
        {
            try
            {
                DataListing dataListing = new DataListing();
                MainMenu mainMenu = new MainMenu();
                Payment payment = new Payment();
                payment.Name = txtNewName.Text;
                payment.PayforDay = double.Parse(txtNewPayment.Text);
                payment.ID = idIndex;
                payment.PaymentDate = dateTimePayment.Value;
                payments.Add(payment);
                string jsonPaymentData = Newtonsoft.Json.JsonConvert.SerializeObject(payments);
                File.WriteAllText(jsonPaymentsDataPath, jsonPaymentData);
                dataListing.Payments.AddRange(payments);
                mainMenu.ReadWorkOrderJson();
                MessageBox.Show("Yeni İş Emri Başarılı Bir Şekilde Eklendi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Bir Hata Oluştu!", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void AddNewPaymentForm_Load(object sender, EventArgs e)
        {
            if (payments.Count > 0)
            {
                for (int i = payments.Count - 1; i < payments.Count; i++)
                {
                    idIndex = payments[i].ID + 1;
                }
            }
            else
            {
                idIndex = 0;
            }
        }

        private void btnAddNewPayment_Click(object sender, EventArgs e)
        {
            CreateNewPayment();
            this.Close();
        }
    }
}
