﻿using System;
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
        private readonly MainMenu mainMenu;
        public List<Payment> payments { get; set; }
        readonly string jsonPaymentsDataPath = @"PaymentJson.json";
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
                dataGridView2.DataSource = payments;
                dataGridView2.Columns[0].Visible = false;
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
                dataGridView2.DataSource = payments.OrderBy(x=> x.PaymentDate).ToList();
                DataTableColumnNameChange dataTableColumnNameChange = new DataTableColumnNameChange();
                dataTableColumnNameChange.ChangeDataGridHeader(dataGridView2, "Ödeme Adı", "Ödenen Gün", "Ödeme Tarihi");
                txtUpdateName.Text = name;
                txtUpdatePayForDay.Text = pay.ToString();
                dateTimePayment.Value = paymentDate;
                int selectedRow = 0;
                for (int i = 0; i < payments.Count; i++)
                {
                    if (payments[i].ID == idIndex)
                    {
                        selectedRow = i;
                        break;
                    }
                }
                dataGridView2.Rows[selectedRow].Selected = true;
            }
            catch (Exception)
            {

            }
           
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUpdateName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtUpdatePayForDay.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                dateTimePayment.Value = DateTime.Parse( dataGridView2.CurrentRow.Cells[3].Value.ToString());
                
            }
            catch (Exception)
            {

            }

        }

        private void btnAddNewWorkOrder_Click(object sender, EventArgs e)
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

          
            }
        }
    }
}
