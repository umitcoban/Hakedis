
namespace Hakediş
{
    partial class AddNewWorkOrder
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
            this.btnAddNewWorkOrder = new FontAwesome.Sharp.IconButton();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblNewDescription = new System.Windows.Forms.Label();
            this.lblNewFirstDate = new System.Windows.Forms.Label();
            this.dateTimeNewFirst = new System.Windows.Forms.DateTimePicker();
            this.lblNewManDay = new System.Windows.Forms.Label();
            this.numericNewManDay = new System.Windows.Forms.NumericUpDown();
            this.txtNewDesc = new System.Windows.Forms.RichTextBox();
            this.dateTimeNewFinish = new System.Windows.Forms.DateTimePicker();
            this.lblNewFinish = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNewManDay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewWorkOrder
            // 
            this.btnAddNewWorkOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddNewWorkOrder.FlatAppearance.BorderSize = 0;
            this.btnAddNewWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddNewWorkOrder.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddNewWorkOrder.IconColor = System.Drawing.Color.White;
            this.btnAddNewWorkOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewWorkOrder.Location = new System.Drawing.Point(0, 435);
            this.btnAddNewWorkOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewWorkOrder.Name = "btnAddNewWorkOrder";
            this.btnAddNewWorkOrder.Size = new System.Drawing.Size(236, 67);
            this.btnAddNewWorkOrder.TabIndex = 2;
            this.btnAddNewWorkOrder.Text = "Yeni İş Ekle";
            this.btnAddNewWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewWorkOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewWorkOrder.UseVisualStyleBackColor = true;
            this.btnAddNewWorkOrder.Click += new System.EventHandler(this.btnAddNewWorkOrder_Click);
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.ForeColor = System.Drawing.Color.White;
            this.lblNewName.Location = new System.Drawing.Point(0, 57);
            this.lblNewName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(88, 15);
            this.lblNewName.TabIndex = 3;
            this.lblNewName.Text = "İsim Giriniz :";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(3, 78);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(228, 21);
            this.txtNewName.TabIndex = 4;
            // 
            // lblNewDescription
            // 
            this.lblNewDescription.AutoSize = true;
            this.lblNewDescription.ForeColor = System.Drawing.Color.White;
            this.lblNewDescription.Location = new System.Drawing.Point(0, 110);
            this.lblNewDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewDescription.Name = "lblNewDescription";
            this.lblNewDescription.Size = new System.Drawing.Size(119, 15);
            this.lblNewDescription.TabIndex = 5;
            this.lblNewDescription.Text = "Açıklama Giriniz :";
            // 
            // lblNewFirstDate
            // 
            this.lblNewFirstDate.AutoSize = true;
            this.lblNewFirstDate.ForeColor = System.Drawing.Color.White;
            this.lblNewFirstDate.Location = new System.Drawing.Point(3, 236);
            this.lblNewFirstDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewFirstDate.Name = "lblNewFirstDate";
            this.lblNewFirstDate.Size = new System.Drawing.Size(181, 15);
            this.lblNewFirstDate.TabIndex = 7;
            this.lblNewFirstDate.Text = "Başlangıç Tarihi Giriniz (*):";
            // 
            // dateTimeNewFirst
            // 
            this.dateTimeNewFirst.CustomFormat = "0:dd/MM/yyyy";
            this.dateTimeNewFirst.Location = new System.Drawing.Point(6, 263);
            this.dateTimeNewFirst.Name = "dateTimeNewFirst";
            this.dateTimeNewFirst.Size = new System.Drawing.Size(228, 21);
            this.dateTimeNewFirst.TabIndex = 8;
            this.dateTimeNewFirst.ValueChanged += new System.EventHandler(this.DateTimeChanged);
            // 
            // lblNewManDay
            // 
            this.lblNewManDay.AutoSize = true;
            this.lblNewManDay.ForeColor = System.Drawing.Color.White;
            this.lblNewManDay.Location = new System.Drawing.Point(3, 363);
            this.lblNewManDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewManDay.Name = "lblNewManDay";
            this.lblNewManDay.Size = new System.Drawing.Size(185, 15);
            this.lblNewManDay.TabIndex = 11;
            this.lblNewManDay.Text = "Adam Gün Sayısı Giriniz (*):";
            // 
            // numericNewManDay
            // 
            this.numericNewManDay.DecimalPlaces = 1;
            this.numericNewManDay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericNewManDay.Location = new System.Drawing.Point(6, 392);
            this.numericNewManDay.Name = "numericNewManDay";
            this.numericNewManDay.Size = new System.Drawing.Size(227, 21);
            this.numericNewManDay.TabIndex = 12;
            this.numericNewManDay.ThousandsSeparator = true;
            this.numericNewManDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericNewManDay_KeyPress);
            // 
            // txtNewDesc
            // 
            this.txtNewDesc.Location = new System.Drawing.Point(3, 138);
            this.txtNewDesc.Name = "txtNewDesc";
            this.txtNewDesc.Size = new System.Drawing.Size(228, 86);
            this.txtNewDesc.TabIndex = 13;
            this.txtNewDesc.Text = "";
            // 
            // dateTimeNewFinish
            // 
            this.dateTimeNewFinish.CustomFormat = "0:dd/MM/yyyy";
            this.dateTimeNewFinish.Location = new System.Drawing.Point(6, 325);
            this.dateTimeNewFinish.Name = "dateTimeNewFinish";
            this.dateTimeNewFinish.Size = new System.Drawing.Size(228, 21);
            this.dateTimeNewFinish.TabIndex = 15;
            // 
            // lblNewFinish
            // 
            this.lblNewFinish.AutoSize = true;
            this.lblNewFinish.ForeColor = System.Drawing.Color.White;
            this.lblNewFinish.Location = new System.Drawing.Point(3, 297);
            this.lblNewFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewFinish.Name = "lblNewFinish";
            this.lblNewFinish.Size = new System.Drawing.Size(161, 15);
            this.lblNewFinish.TabIndex = 14;
            this.lblNewFinish.Text = "Teslim Tarihi Giriniz (*):";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(2, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(232, 21);
            this.txtID.TabIndex = 17;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(0, 8);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(75, 15);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID Giriniz :";
            // 
            // AddNewWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(236, 502);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dateTimeNewFinish);
            this.Controls.Add(this.lblNewFinish);
            this.Controls.Add(this.txtNewDesc);
            this.Controls.Add(this.numericNewManDay);
            this.Controls.Add(this.lblNewManDay);
            this.Controls.Add(this.dateTimeNewFirst);
            this.Controls.Add(this.lblNewFirstDate);
            this.Controls.Add(this.lblNewDescription);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.btnAddNewWorkOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddNewWorkOrder";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni İş Emri";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddNewWorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNewManDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddNewWorkOrder;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblNewDescription;
        private System.Windows.Forms.Label lblNewFirstDate;
        private System.Windows.Forms.DateTimePicker dateTimeNewFirst;
        private System.Windows.Forms.Label lblNewManDay;
        private System.Windows.Forms.NumericUpDown numericNewManDay;
        private System.Windows.Forms.RichTextBox txtNewDesc;
        private System.Windows.Forms.DateTimePicker dateTimeNewFinish;
        private System.Windows.Forms.Label lblNewFinish;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}