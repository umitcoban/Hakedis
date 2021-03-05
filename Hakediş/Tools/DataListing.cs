using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Hakediş
{
   public class DataListing:DataGridView
    {
        public List<Payment> Payments { get; set; }
        public List<WorkOrder> WorkOrders { get; set; }
        public void ReadPaymentJson(DataGridView dataGridView, string jsonPath)
        {
            if (File.Exists(jsonPath))
            {
                string jsonPaymentData = File.ReadAllText(jsonPath);
                Payments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Payment>>(jsonPaymentData);
            }
            List<Payment> paymentsClone = Payments;
            dataGridView.DataSource = Payments;
            dataGridView.Columns[0].Visible = false;
        }
        public List<Payment> ReadPaymentJson(string jsonPath,List <Payment> payments)
        {
            if (File.Exists(jsonPath))
            {
                string jsonPaymentData = File.ReadAllText(jsonPath);
                payments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Payment>>(jsonPaymentData);
            }
            return payments;
        }
        public void ReadWorkOrderJson(DataGridView dataGridView, string jsonPath)
        {
            if (File.Exists(jsonPath))
            {
                string jsonPaymentData = File.ReadAllText(jsonPath);
                WorkOrders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorkOrder>>(jsonPaymentData);
            }
            dataGridView.DataSource = WorkOrders;
            dataGridView.Columns[0].Visible = false;
        }
        public List<WorkOrder> ReadWorkOrderJson(string jsonPath, List<WorkOrder> workOrders)
        {
            if (File.Exists(jsonPath))
            {
                string jsonPaymentData = File.ReadAllText(jsonPath);
                workOrders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorkOrder>>(jsonPaymentData);
            }
            return workOrders;
        }
        public DataListing()
        {
            Payments = new List<Payment>();
            WorkOrders = new List<WorkOrder>();
        }
    }
}
