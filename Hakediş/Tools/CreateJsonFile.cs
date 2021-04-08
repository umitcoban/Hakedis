using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Hakediş
{
  public static class CreateJsonFile
    {
        public static void CreateNewPaymentsJsonFile(List<Payment> payments,string pathFile)
        {
            string jsonPaymentData = Newtonsoft.Json.JsonConvert.SerializeObject(payments);
            File.WriteAllText(pathFile, jsonPaymentData);
        }
        public static void CreateNewWorkOrdersJsonFile(List<WorkOrder> workOrders, string pathFile)
        {
            string jsonWorkOrderData = Newtonsoft.Json.JsonConvert.SerializeObject(workOrders);
            File.WriteAllText(pathFile, jsonWorkOrderData);
        }
    }
}
