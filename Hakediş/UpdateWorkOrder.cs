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
using System.Reflection;
namespace Hakediş
{
    public partial class UpdateWorkOrder : Form
    {
        readonly static string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        readonly static string pathApplication = System.IO.Path.GetDirectoryName(path);
        readonly string jsonWorkOrderDataPath = pathApplication + @"\WorkOrderJson.json";
        private readonly MainMenu mainMenu;
        public string txtName, txtDesc;
        public DateTime? startDate;
        public DateTime? expiredDate;
        public DateTime? finishDate;
        public double ManDay;
        public int idIndex;
        public List<WorkOrder> workOrders { get; set; }
        public UpdateWorkOrder(MainMenu main)
        {
            InitializeComponent();
            workOrders = new List<WorkOrder>();
            mainMenu = main;
        }

        private void UpdateWorkOrder_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(262, 512);
            try
            {
                ReadJson();
                int selectID = workOrders.FindIndex(x=> x.ID ==idIndex);
                if (workOrders[selectID].ExpiredDate != null)
                {
                    chckbxIsWorkFinished.Checked = true;
                }
                else
                {
                    chckbxIsWorkFinished.Checked = false;
                }
                //dataGridView1.CurrentRow.Cells[i].Selected = true;
                txtUpdateName.Text = txtName;
                txtUpdateDesc.Text = txtDesc;
                dateTimeUpdateFirst.Value = startDate.Value;
                dateTimeNewFinish.Value = finishDate.Value;
                txtUpdateID.Text = idIndex.ToString();
                txtUpdateMan.Text = ManDay.ToString();
                if (expiredDate != null)
                {
                    dateTimeUpdateExpired.Value = expiredDate.Value;
                }
                else
                {
                    dateTimeUpdateExpired.Value = DateTime.Parse(null);
                }

            }
            catch (Exception)
            {


            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
        #region Data İşlemleri
        public void ReadJson()
        {
            try
            {
               workOrders = DataListing.ReadWorkOrderJson(jsonWorkOrderDataPath, workOrders);
            }
            catch (Exception)
            {

            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void NewUpdateWorkOrder()
        {
            try
            {
                //string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(workOrders);
                //File.WriteAllText(jsonWorkOrderDataPath, jsonData);
                if (File.Exists(jsonWorkOrderDataPath))
                {
                    CreateJsonFile.CreateNewWorkOrdersJsonFile(workOrders, jsonWorkOrderDataPath);
                    MessageBox.Show(" İş Emri Başarılı Bir Şekilde Güncellendi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainMenu.UpdateDataList();
                }
                else
                {
                    MessageBox.Show(" İş Emri Dosyası Bulunamadı !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        #endregion

   

        private void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            if (txtUpdateMan.Text != ""&& dateTimeNewFinish.Value != null&& dateTimeUpdateFirst.Value != null)
            {
                try
                {
                    int selectedID = workOrders.FindIndex(x => x.ID == idIndex);
                    workOrders[selectedID].ID = int.Parse(txtUpdateID.Text);
                    workOrders[selectedID].Name = txtUpdateName.Text;
                    workOrders[selectedID].Description = txtUpdateDesc.Text;
                    workOrders[selectedID].StartingDate = dateTimeUpdateFirst.Value;
                    workOrders[selectedID].ManOfDay = double.Parse(txtUpdateMan.Text);
                    workOrders[selectedID].FinishedDate = dateTimeNewFinish.Value;
                    if (chckbxIsWorkFinished.Checked == true)
                    {
                        workOrders[selectedID].ExpiredDate = dateTimeUpdateExpired.Value;
                    }
                    else
                    {
                        workOrders[selectedID].ExpiredDate = null;
                    }

                }
                catch (Exception)
                {

                }

                NewUpdateWorkOrder();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Boş Bırakmayın !","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void chckbxIsWorkFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxIsWorkFinished.Checked == false)
            {
                dateTimeUpdateExpired.Enabled = false;
            }
            else
            {
                dateTimeUpdateExpired.Enabled = true;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void txtUpdateMan_KeyPress(object sender, KeyPressEventArgs e)
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnDeleteWorkOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("İş Emrini Silmek İstiyormusunuz ?","İş Emri",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int selectID = workOrders.FindIndex(x => x.ID == idIndex);
                workOrders.RemoveAt(selectID);
                NewUpdateWorkOrder();
                this.Close();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void DateTimePickerValueChange(object sender, EventArgs e)
        {

        }
    }
}
