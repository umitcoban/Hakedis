
namespace Hakediş
{
    partial class UpdatePaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePayment = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdatePayForDay = new System.Windows.Forms.TextBox();
            this.lblUpdatePayForDay = new System.Windows.Forms.Label();
            this.btnAddNewWorkOrder = new FontAwesome.Sharp.IconButton();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePayment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUpdatePayForDay);
            this.panel1.Controls.Add(this.lblUpdatePayForDay);
            this.panel1.Controls.Add(this.btnAddNewWorkOrder);
            this.panel1.Controls.Add(this.txtUpdateName);
            this.panel1.Controls.Add(this.lblUpdateName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 213);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePayment
            // 
            this.dateTimePayment.Location = new System.Drawing.Point(3, 128);
            this.dateTimePayment.Name = "dateTimePayment";
            this.dateTimePayment.Size = new System.Drawing.Size(240, 20);
            this.dateTimePayment.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ödeme Tarihi Giriniz :";
            // 
            // txtUpdatePayForDay
            // 
            this.txtUpdatePayForDay.Location = new System.Drawing.Point(3, 79);
            this.txtUpdatePayForDay.Name = "txtUpdatePayForDay";
            this.txtUpdatePayForDay.Size = new System.Drawing.Size(243, 20);
            this.txtUpdatePayForDay.TabIndex = 25;
            // 
            // lblUpdatePayForDay
            // 
            this.lblUpdatePayForDay.AutoSize = true;
            this.lblUpdatePayForDay.ForeColor = System.Drawing.Color.White;
            this.lblUpdatePayForDay.Location = new System.Drawing.Point(4, 56);
            this.lblUpdatePayForDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdatePayForDay.Name = "lblUpdatePayForDay";
            this.lblUpdatePayForDay.Size = new System.Drawing.Size(110, 13);
            this.lblUpdatePayForDay.TabIndex = 24;
            this.lblUpdatePayForDay.Text = "Alınan Ödeme Giriniz :";
            // 
            // btnAddNewWorkOrder
            // 
            this.btnAddNewWorkOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddNewWorkOrder.FlatAppearance.BorderSize = 0;
            this.btnAddNewWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddNewWorkOrder.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnAddNewWorkOrder.IconColor = System.Drawing.Color.Lime;
            this.btnAddNewWorkOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewWorkOrder.Location = new System.Drawing.Point(0, 157);
            this.btnAddNewWorkOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewWorkOrder.Name = "btnAddNewWorkOrder";
            this.btnAddNewWorkOrder.Size = new System.Drawing.Size(243, 56);
            this.btnAddNewWorkOrder.TabIndex = 23;
            this.btnAddNewWorkOrder.Text = "Ödeme Güncelle";
            this.btnAddNewWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewWorkOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewWorkOrder.UseVisualStyleBackColor = true;
            this.btnAddNewWorkOrder.Click += new System.EventHandler(this.btnAddNewWorkOrder_Click);
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(3, 28);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(243, 20);
            this.txtUpdateName.TabIndex = 14;
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.ForeColor = System.Drawing.Color.White;
            this.lblUpdateName.Location = new System.Drawing.Point(4, 9);
            this.lblUpdateName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(62, 13);
            this.lblUpdateName.TabIndex = 13;
            this.lblUpdateName.Text = "İsim Giriniz :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(243, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(342, 213);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // UpdatePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(585, 213);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdatePaymentForm";
            this.Opacity = 0.96D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Güncelleme";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdatePaymentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAddNewWorkOrder;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.TextBox txtUpdatePayForDay;
        private System.Windows.Forms.Label lblUpdatePayForDay;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePayment;
        private System.Windows.Forms.Label label1;
    }
}