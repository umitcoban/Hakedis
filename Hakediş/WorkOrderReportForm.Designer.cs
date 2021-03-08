
namespace Hakediş
{
    partial class WorkOrderReportForm
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
            this.txtDetailPayDay = new System.Windows.Forms.TextBox();
            this.lblDetailPayDay = new System.Windows.Forms.Label();
            this.btnAddNewWorkOrder = new FontAwesome.Sharp.IconButton();
            this.numericDetailManDay = new System.Windows.Forms.NumericUpDown();
            this.lblDetailManDay = new System.Windows.Forms.Label();
            this.dateTimeDetailExpired = new System.Windows.Forms.DateTimePicker();
            this.lblDetailExpiredDate = new System.Windows.Forms.Label();
            this.dateTimeDetailFirst = new System.Windows.Forms.DateTimePicker();
            this.lblDetailFirstDate = new System.Windows.Forms.Label();
            this.txtDetailDesc = new System.Windows.Forms.TextBox();
            this.lblDetailDescription = new System.Windows.Forms.Label();
            this.txtDetailName = new System.Windows.Forms.TextBox();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDetailManDay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDetailPayDay);
            this.panel1.Controls.Add(this.lblDetailPayDay);
            this.panel1.Controls.Add(this.btnAddNewWorkOrder);
            this.panel1.Controls.Add(this.numericDetailManDay);
            this.panel1.Controls.Add(this.lblDetailManDay);
            this.panel1.Controls.Add(this.dateTimeDetailExpired);
            this.panel1.Controls.Add(this.lblDetailExpiredDate);
            this.panel1.Controls.Add(this.dateTimeDetailFirst);
            this.panel1.Controls.Add(this.lblDetailFirstDate);
            this.panel1.Controls.Add(this.txtDetailDesc);
            this.panel1.Controls.Add(this.lblDetailDescription);
            this.panel1.Controls.Add(this.txtDetailName);
            this.panel1.Controls.Add(this.lblDetailName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 426);
            this.panel1.TabIndex = 1;
            // 
            // txtDetailPayDay
            // 
            this.txtDetailPayDay.Location = new System.Drawing.Point(4, 305);
            this.txtDetailPayDay.Name = "txtDetailPayDay";
            this.txtDetailPayDay.Size = new System.Drawing.Size(243, 21);
            this.txtDetailPayDay.TabIndex = 25;
            // 
            // lblDetailPayDay
            // 
            this.lblDetailPayDay.AutoSize = true;
            this.lblDetailPayDay.ForeColor = System.Drawing.Color.White;
            this.lblDetailPayDay.Location = new System.Drawing.Point(0, 287);
            this.lblDetailPayDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailPayDay.Name = "lblDetailPayDay";
            this.lblDetailPayDay.Size = new System.Drawing.Size(143, 15);
            this.lblDetailPayDay.TabIndex = 24;
            this.lblDetailPayDay.Text = "Alınan Ödeme Günü :";
            // 
            // btnAddNewWorkOrder
            // 
            this.btnAddNewWorkOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddNewWorkOrder.FlatAppearance.BorderSize = 0;
            this.btnAddNewWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddNewWorkOrder.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnAddNewWorkOrder.IconColor = System.Drawing.Color.Red;
            this.btnAddNewWorkOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewWorkOrder.Location = new System.Drawing.Point(0, 370);
            this.btnAddNewWorkOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewWorkOrder.Name = "btnAddNewWorkOrder";
            this.btnAddNewWorkOrder.Size = new System.Drawing.Size(243, 56);
            this.btnAddNewWorkOrder.TabIndex = 23;
            this.btnAddNewWorkOrder.Text = "Sayfayı Kapat";
            this.btnAddNewWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewWorkOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewWorkOrder.UseVisualStyleBackColor = true;
            // 
            // numericDetailManDay
            // 
            this.numericDetailManDay.DecimalPlaces = 1;
            this.numericDetailManDay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericDetailManDay.Location = new System.Drawing.Point(4, 255);
            this.numericDetailManDay.Name = "numericDetailManDay";
            this.numericDetailManDay.Size = new System.Drawing.Size(243, 21);
            this.numericDetailManDay.TabIndex = 22;
            this.numericDetailManDay.ThousandsSeparator = true;
            // 
            // lblDetailManDay
            // 
            this.lblDetailManDay.AutoSize = true;
            this.lblDetailManDay.ForeColor = System.Drawing.Color.White;
            this.lblDetailManDay.Location = new System.Drawing.Point(1, 226);
            this.lblDetailManDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailManDay.Name = "lblDetailManDay";
            this.lblDetailManDay.Size = new System.Drawing.Size(123, 15);
            this.lblDetailManDay.TabIndex = 21;
            this.lblDetailManDay.Text = "Adam/Gün Sayısı :";
            // 
            // dateTimeDetailExpired
            // 
            this.dateTimeDetailExpired.Location = new System.Drawing.Point(4, 196);
            this.dateTimeDetailExpired.Name = "dateTimeDetailExpired";
            this.dateTimeDetailExpired.Size = new System.Drawing.Size(243, 21);
            this.dateTimeDetailExpired.TabIndex = 20;
            // 
            // lblDetailExpiredDate
            // 
            this.lblDetailExpiredDate.AutoSize = true;
            this.lblDetailExpiredDate.ForeColor = System.Drawing.Color.White;
            this.lblDetailExpiredDate.Location = new System.Drawing.Point(1, 168);
            this.lblDetailExpiredDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailExpiredDate.Name = "lblDetailExpiredDate";
            this.lblDetailExpiredDate.Size = new System.Drawing.Size(84, 15);
            this.lblDetailExpiredDate.TabIndex = 19;
            this.lblDetailExpiredDate.Text = "Bitiş Tarihi :";
            // 
            // dateTimeDetailFirst
            // 
            this.dateTimeDetailFirst.Location = new System.Drawing.Point(3, 137);
            this.dateTimeDetailFirst.Name = "dateTimeDetailFirst";
            this.dateTimeDetailFirst.Size = new System.Drawing.Size(243, 21);
            this.dateTimeDetailFirst.TabIndex = 18;
            // 
            // lblDetailFirstDate
            // 
            this.lblDetailFirstDate.AutoSize = true;
            this.lblDetailFirstDate.ForeColor = System.Drawing.Color.White;
            this.lblDetailFirstDate.Location = new System.Drawing.Point(0, 109);
            this.lblDetailFirstDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailFirstDate.Name = "lblDetailFirstDate";
            this.lblDetailFirstDate.Size = new System.Drawing.Size(119, 15);
            this.lblDetailFirstDate.TabIndex = 17;
            this.lblDetailFirstDate.Text = "Başlangıç Tarihi :";
            // 
            // txtDetailDesc
            // 
            this.txtDetailDesc.Location = new System.Drawing.Point(3, 81);
            this.txtDetailDesc.Name = "txtDetailDesc";
            this.txtDetailDesc.Size = new System.Drawing.Size(243, 21);
            this.txtDetailDesc.TabIndex = 16;
            // 
            // lblDetailDescription
            // 
            this.lblDetailDescription.AutoSize = true;
            this.lblDetailDescription.ForeColor = System.Drawing.Color.White;
            this.lblDetailDescription.Location = new System.Drawing.Point(4, 58);
            this.lblDetailDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailDescription.Name = "lblDetailDescription";
            this.lblDetailDescription.Size = new System.Drawing.Size(69, 15);
            this.lblDetailDescription.TabIndex = 15;
            this.lblDetailDescription.Text = "Açıklama:";
            // 
            // txtDetailName
            // 
            this.txtDetailName.Location = new System.Drawing.Point(3, 28);
            this.txtDetailName.Name = "txtDetailName";
            this.txtDetailName.Size = new System.Drawing.Size(243, 21);
            this.txtDetailName.TabIndex = 14;
            // 
            // lblDetailName
            // 
            this.lblDetailName.AutoSize = true;
            this.lblDetailName.ForeColor = System.Drawing.Color.White;
            this.lblDetailName.Location = new System.Drawing.Point(4, 9);
            this.lblDetailName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailName.Name = "lblDetailName";
            this.lblDetailName.Size = new System.Drawing.Size(42, 15);
            this.lblDetailName.TabIndex = 13;
            this.lblDetailName.Text = "İsim :";
            // 
            // WorkOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(599, 426);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "WorkOrderDetails";
            this.Opacity = 0.96D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkOrderDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDetailManDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAddNewWorkOrder;
        private System.Windows.Forms.NumericUpDown numericDetailManDay;
        private System.Windows.Forms.Label lblDetailManDay;
        private System.Windows.Forms.DateTimePicker dateTimeDetailExpired;
        private System.Windows.Forms.Label lblDetailExpiredDate;
        private System.Windows.Forms.DateTimePicker dateTimeDetailFirst;
        private System.Windows.Forms.Label lblDetailFirstDate;
        private System.Windows.Forms.TextBox txtDetailDesc;
        private System.Windows.Forms.Label lblDetailDescription;
        private System.Windows.Forms.TextBox txtDetailName;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.TextBox txtDetailPayDay;
        private System.Windows.Forms.Label lblDetailPayDay;
    }
}