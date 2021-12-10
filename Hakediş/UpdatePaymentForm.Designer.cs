
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeletePayment = new FontAwesome.Sharp.IconButton();
            this.dateTimePayment = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdatePayForDay = new System.Windows.Forms.TextBox();
            this.lblUpdatePayForDay = new System.Windows.Forms.Label();
            this.btnAddNewWorkOrder = new FontAwesome.Sharp.IconButton();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeletePayment);
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
            // btnDeletePayment
            // 
            this.btnDeletePayment.FlatAppearance.BorderSize = 0;
            this.btnDeletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeletePayment.ForeColor = System.Drawing.Color.White;
            this.btnDeletePayment.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeletePayment.IconColor = System.Drawing.Color.Red;
            this.btnDeletePayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeletePayment.Location = new System.Drawing.Point(126, 157);
            this.btnDeletePayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(120, 56);
            this.btnDeletePayment.TabIndex = 28;
            this.btnDeletePayment.Text = "Ödeme Sil";
            this.btnDeletePayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // dateTimePayment
            // 
            this.dateTimePayment.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePayment.CustomFormat = "0:dd/MM/yyyy";
            this.dateTimePayment.Location = new System.Drawing.Point(3, 128);
            this.dateTimePayment.Name = "dateTimePayment";
            this.dateTimePayment.Size = new System.Drawing.Size(240, 20);
            this.dateTimePayment.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ödeme Tarihi Giriniz (*):";
            // 
            // txtUpdatePayForDay
            // 
            this.txtUpdatePayForDay.Location = new System.Drawing.Point(3, 79);
            this.txtUpdatePayForDay.Name = "txtUpdatePayForDay";
            this.txtUpdatePayForDay.Size = new System.Drawing.Size(243, 20);
            this.txtUpdatePayForDay.TabIndex = 25;
            this.txtUpdatePayForDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdatePayForDay_KeyPress);
            // 
            // lblUpdatePayForDay
            // 
            this.lblUpdatePayForDay.AutoSize = true;
            this.lblUpdatePayForDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdatePayForDay.ForeColor = System.Drawing.Color.White;
            this.lblUpdatePayForDay.Location = new System.Drawing.Point(4, 56);
            this.lblUpdatePayForDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdatePayForDay.Name = "lblUpdatePayForDay";
            this.lblUpdatePayForDay.Size = new System.Drawing.Size(145, 13);
            this.lblUpdatePayForDay.TabIndex = 24;
            this.lblUpdatePayForDay.Text = "Alınan Ödeme Giriniz (*):";
            // 
            // btnAddNewWorkOrder
            // 
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
            this.btnAddNewWorkOrder.Size = new System.Drawing.Size(124, 56);
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
            this.lblUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateName.ForeColor = System.Drawing.Color.White;
            this.lblUpdateName.Location = new System.Drawing.Point(4, 9);
            this.lblUpdateName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(76, 13);
            this.lblUpdateName.TabIndex = 13;
            this.lblUpdateName.Text = "İsim Giriniz :";
            // 
            // UpdatePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(247, 213);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAddNewWorkOrder;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.TextBox txtUpdatePayForDay;
        private System.Windows.Forms.Label lblUpdatePayForDay;
        private System.Windows.Forms.DateTimePicker dateTimePayment;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnDeletePayment;
    }
}