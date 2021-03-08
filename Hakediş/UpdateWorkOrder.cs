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
    public partial class UpdateWorkOrder : Form
    {
        private readonly MainMenu mainMenu;
        readonly string jsonDataPath = @"WorkOrderJson.json";
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
            try
            {
                ReadJson();
                DataTableColumnNameChange dataTableColumnNameChange = new DataTableColumnNameChange();
                dataTableColumnNameChange.ChangeDataGridHeader(dataGridView1, "İş Adı", "Açıklama", "Başlangıç Tarihi", "Bitirme Tarihi", "Teslim Tarihi", "Adam/Gün");
                int selectID = workOrders.FindIndex(x=> x.ID ==idIndex);
                int selectedRow = 0;
                int i = 0;
                for (i = 0; i <= workOrders.Count - 1; i++)
                {
                    if (workOrders[i].ID == idIndex)
                    {
                        selectedRow = i;
                        break;
                    }
                }
                if (workOrders[selectID].ExpiredDate != null)
                {
                    chckbxIsWorkFinished.Checked = true;
                }
                else
                {
                    chckbxIsWorkFinished.Checked = false;
                }
                
                dataGridView1.Rows[selectedRow].Selected = true;
                //dataGridView1.CurrentRow.Cells[i].Selected = true;
                txtUpdateName.Text = txtName;
                txtUpdateDesc.Text = txtDesc;
                dateTimeUpdateFirst.Value = startDate.Value;
                dateTimeNewFinish.Value = finishDate.Value;
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



        }
        #region Data İşlemleri
        public void ReadJson()
        {
            try
            {
               workOrders = DataListing.ReadWorkOrderJson(jsonDataPath, workOrders);
               dataGridView1.DataSource = workOrders;
               dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception)
            {

            }
        }
        private void NewUpdateWorkOrder()
        {
            try
            {
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(workOrders);
                File.WriteAllText(jsonDataPath, jsonData);
                MessageBox.Show(" İş Emri Başarılı Bir Şekilde Güncellendi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainMenu.UpdateDataList();
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells[5].Value != null)
                {
                    chckbxIsWorkFinished.Checked = true;
                }
                else
                {
                    chckbxIsWorkFinished.Checked = false;
                }
                idIndex = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txtUpdateName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtUpdateDesc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[3].Value != null)
                    dateTimeUpdateFirst.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                if (dataGridView1.CurrentRow.Cells[4].Value != null)
                    dateTimeNewFinish.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                txtUpdateMan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[5].Value != null)
                    dateTimeUpdateExpired.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            }
            catch (Exception exa)
            {
                MessageBox.Show(exa.Message);
            }
        }

        private void btnAddNewWorkOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = workOrders.FindIndex(x=> x.ID == idIndex);
                //for (int i = 0; i <= workOrders.Count - 1; i++)
                //{
                //    if (workOrders[i].ID == idIndex)
                //    {
                //        selectedRow = i;
                //        break;
                //    }
                //}
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
        }
        private void DateTimePickerValueChange(object sender, EventArgs e)
        {
            //DateTimePicker dateTimePicker = (DateTimePicker)sender;
            //switch (dateTimePicker.Name)
            //{
            //    case "dateTimeUpdateFirst":
            //        dateTimeUpdateExpired.MinDate = dateTimeUpdateFirst.Value.AddDays(-5);
            //        break;
            //    case "dateTimeNewFinish":
            //        dateTimeNewFinish.MinDate = dateTimeUpdateExpired.Value;
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
