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
using System.Globalization;
namespace Hakediş
{
    public partial class AddNewWorkOrder : Form
    {
        static string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        readonly static string pathApplication = System.IO.Path.GetDirectoryName(path);
        readonly string jsonWorkOrderDataPath = pathApplication + @"\WorkOrderJson.json";
        private readonly MainMenu mainMenu;
        int idIndex = 0;
        public List<WorkOrder> workOrders { get; set; }
        public AddNewWorkOrder(MainMenu mainMenu1)
        {
            InitializeComponent();
            workOrders = new List<WorkOrder>();
            mainMenu = mainMenu1;
        }

        #region Veri İşlemleri
        private void CreateNewWorkOrder()
        {
            try
            {

                WorkOrder workOrder = new WorkOrder();
                workOrder.Name = txtNewName.Text;
                workOrder.Description = txtNewDesc.Text;
                workOrder.StartingDate = dateTimeNewFirst.Value;
                workOrder.ExpiredDate = null;
                workOrder.ManOfDay = double.Parse(numericNewManDay.Value.ToString());
                workOrder.FinishedDate = dateTimeNewFinish.Value;
                workOrder.ID = int.Parse(txtID.Text);
                var isThere = workOrders.Where(x => x.ID == workOrder.ID).Count();
                if (isThere == 0)
                {
                    workOrders.Add(workOrder);
                    CreateJsonFile.CreateNewWorkOrdersJsonFile(workOrders, jsonWorkOrderDataPath);
                    //string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(workOrders);
                    //File.WriteAllText(jsonWorkOrderDataPath, sjsonData);
                    MessageBox.Show("Yeni İş Emri Başarılı Bir Şekilde Eklendi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainMenu.UpdateDataList();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu ID Daha Önce Kullanılmıştır !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void AddNewWorkOrder_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(252, 541);
            workOrders = DataListing.ReadWorkOrderJson(jsonWorkOrderDataPath, workOrders);
            if (workOrders.Count > 0)
            {
                for (int i = workOrders.Count - 1; i < workOrders.Count; i++)
                {
                    idIndex = workOrders[i].ID + 1;
                }
            }
            else
            {
                idIndex = 0;
            }

        }

        private void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            if (dateTimeNewFirst.Value != null && dateTimeNewFinish.Value != null)
            {
                CreateNewWorkOrder();
            }
            else
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Boş Bırakmayın !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void DateTimeChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            switch (dateTimePicker.Name)
            {
                case "dateTimeNewFirst":
                    dateTimeNewFinish.MinDate = dateTimeNewFirst.Value;
                    break;
                case "dateTimeNewFinish":

                    break;
                default:
                    break;
            }
        }

        private void numericNewManDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            //{
            //    e.Handled = true;
            //    return;
            //}

            //tek bir virgül eklemesi gerektiğini kontrol et
            //if (e.KeyChar == 46)
            //{
            //    if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
            //        e.Handled = true;
            //}
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
