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
        readonly string jsonDataPath = @"WorkOrderJson.json";
        public string txtName, txtDesc;
        public DateTime? startDate;
        public DateTime? expiredDate;
        public DateTime? finishDate;
        public double ManDay;
        public int idIndex;
        public List<WorkOrder> workOrders { get; set; }
        public List<Payment> payments { get; set; }
        public UpdateWorkOrder()
        {
            InitializeComponent();
            workOrders = new List<WorkOrder>();
            payments = new List<Payment>();
        }

        private void UpdateWorkOrder_Load(object sender, EventArgs e)
        {
            try
            {
                ReadJson();
                ChangeDataGridHeader(dataGridView1, "İş Adı", "Açıklama", "Başlangıç Tarihi", "Bitirme Tarihi", "Teslim Tarihi", "Adam/Gün");
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
                if (workOrders[selectedRow].ExpiredDate != null)
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
                string jsonData = File.ReadAllText(jsonDataPath);
                workOrders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorkOrder>>(jsonData);
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
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void ChangeDataGridHeader(DataGridView dataGridView, string name1, string name2, string name3, string name4, string name5, string name6)
        {
            dataGridView.Columns[1].HeaderText = name1;
            dataGridView.Columns[2].HeaderText = name2;
            dataGridView.Columns[3].HeaderText = name3;
            dataGridView.Columns[4].HeaderText = name4;
            dataGridView.Columns[5].HeaderText = name5;
            dataGridView.Columns[6].HeaderText = name6;
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
                dateTimeUpdateFirst.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                dateTimeNewFinish.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                txtUpdateMan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[5].Value != null)
                    dateTimeUpdateExpired.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
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
                for (int i = 0; i <= workOrders.Count - 1; i++)
                {
                    if (workOrders[i].ID == idIndex)
                    {
                        selectedRow = i;
                        break;
                    }
                }
                workOrders[selectedRow].Name = txtUpdateName.Text;
                workOrders[selectedRow].Description = txtUpdateDesc.Text;
                workOrders[selectedRow].StartingDate = dateTimeUpdateFirst.Value;
                workOrders[selectedRow].ManOfDay = double.Parse(txtUpdateMan.Text);
                workOrders[selectedRow].FinishedDate = dateTimeNewFinish.Value;
                if (chckbxIsWorkFinished.Checked == true)
                {
                    workOrders[selectedRow].ExpiredDate = dateTimeUpdateExpired.Value;
                }
                else
                {
                    workOrders[selectedRow].ExpiredDate = null;
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
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            switch (dateTimePicker.Name)
            {
                case "dateTimeUpdateFirst":
                    dateTimeUpdateExpired.MinDate = dateTimeUpdateFirst.Value;
                    break;
                case "dateTimeNewFinish":
                    dateTimeNewFinish.MinDate = dateTimeUpdateExpired.Value;
                    break;
                default:
                    break;
            }
        }
    }
}
