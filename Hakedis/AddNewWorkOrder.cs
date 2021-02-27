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
    public partial class AddNewWorkOrder : Form
    {

        readonly string jsonDataPath = @"WorkOrderJson.json";

        int idIndex = 0;
        public List<WorkOrder> workOrders { get; set; }
        public AddNewWorkOrder()
        {
            InitializeComponent();
            workOrders = new List<WorkOrder>();

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
                workOrder.ID = idIndex;
                workOrders.Add(workOrder);
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(workOrders);
                File.WriteAllText(jsonDataPath, jsonData);
                MessageBox.Show("Yeni İş Emri Başarılı Bir Şekilde Eklendi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void AddNewWorkOrder_Load(object sender, EventArgs e)
        {
            if (workOrders.Count>0)
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
            CreateNewWorkOrder();
        }
    }
}
