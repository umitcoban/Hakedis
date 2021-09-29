using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hakediş
{
    public static class DataListing
    {
        public static List<Payment> Payments { get; set; }
        public static List<WorkOrder> WorkOrders { get; set; }
        
        public static void ReadPaymentJson(DataGridView dataGridView, string jsonPath)
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
        public static List<Payment> ReadPaymentJson(string jsonPath,List <Payment> payments)
        {
            if (File.Exists(jsonPath))
            {
                string jsonPaymentData = File.ReadAllText(jsonPath);
                payments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Payment>>(jsonPaymentData);
            }
            return payments;
        }
        public static void ReadWorkOrderJson(DataGridView dataGridView, string jsonPath)
        {
            if (File.Exists(jsonPath))
            {
                string jsonPaymentData = File.ReadAllText(jsonPath);
                WorkOrders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorkOrder>>(jsonPaymentData);
            }
            dataGridView.DataSource = WorkOrders;
            dataGridView.Columns[0].Visible = false;
        }
        public static List<WorkOrder> ReadWorkOrderJson(string jsonPath, List<WorkOrder> workOrders)
        {
            if (File.Exists(jsonPath))
            {
                string jsonPaymentData = File.ReadAllText(jsonPath);
                workOrders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorkOrder>>(jsonPaymentData);
            }
            return workOrders;
        }
        public static List<UpdateMail> ReadBackupInfo(string jsonPath, List<UpdateMail> updateMails)
        {
            if (File.Exists(jsonPath))
            {
                string jsonPaymentData = File.ReadAllText(jsonPath);
                updateMails = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UpdateMail>>(jsonPaymentData);
            }
            return updateMails;
        }
        public static List<User> ReadUserConfig(string jsonPath, List<User> userConfig)
        {
            if (File.Exists(jsonPath))
            {
                string jsonUserConfigData = File.ReadAllText(jsonPath);
                userConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(jsonUserConfigData);
            }
            return userConfig;
        }
    }
}
