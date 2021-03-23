using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hakediş
{
    
    public partial class WorkOrderReportForm : Form
    {
        List<WorkOrder> workOrders = new List<WorkOrder>();
        public WorkOrderReportForm()
        {
            InitializeComponent();
        }

        private void WorkOrderReportForm_Load(object sender, EventArgs e)
        {
            workOrders = DataListing.ReadWorkOrderJson("WorkOrderJson.json",workOrders);
            dataGridView1.DataSource = workOrders;
        }
        private void SearchItem()
        {
            List<WorkOrder> cloneWorkOrders = new List<WorkOrder>();
            string word = "";
            for (int i = 0; i <= txtDetailName.Text.Length - 1; i++)
            {
                char character = txtDetailName.Text[i];
                word += character;
                cloneWorkOrders = workOrders.Where(x => x.Name.Contains(word.ToString().ToUpper()) || x.Name.Contains(word.ToString().ToLower())).ToList();
            }
            if(word == "")
            {
                dataGridView1.DataSource = workOrders;
            }
            else
            {
                dataGridView1.DataSource = cloneWorkOrders;
            }
       
        }
        private void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
          
        }
        private void textChange(object sender, EventArgs e)
        {
             
        }
        private void txtDetailName_TextChanged(object sender, EventArgs e)
        {
            SearchItem();
        }
    }
}
