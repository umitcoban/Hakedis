
namespace Hakediş
{
    partial class UpdateWorkOrder
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
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.lblUpdateID = new System.Windows.Forms.Label();
            this.btnDeleteWorkOrder = new FontAwesome.Sharp.IconButton();
            this.dateTimeNewFinish = new System.Windows.Forms.DateTimePicker();
            this.lblNewFinish = new System.Windows.Forms.Label();
            this.txtUpdateMan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateDesc = new System.Windows.Forms.RichTextBox();
            this.chckbxIsWorkFinished = new System.Windows.Forms.CheckBox();
            this.btnAddNewWorkOrder = new FontAwesome.Sharp.IconButton();
            this.dateTimeUpdateExpired = new System.Windows.Forms.DateTimePicker();
            this.lblUpdateExpiredDate = new System.Windows.Forms.Label();
            this.dateTimeUpdateFirst = new System.Windows.Forms.DateTimePicker();
            this.lblUpdateFirstDate = new System.Windows.Forms.Label();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUpdateID);
            this.panel1.Controls.Add(this.lblUpdateID);
            this.panel1.Controls.Add(this.btnDeleteWorkOrder);
            this.panel1.Controls.Add(this.dateTimeNewFinish);
            this.panel1.Controls.Add(this.lblNewFinish);
            this.panel1.Controls.Add(this.txtUpdateMan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUpdateDesc);
            this.panel1.Controls.Add(this.chckbxIsWorkFinished);
            this.panel1.Controls.Add(this.btnAddNewWorkOrder);
            this.panel1.Controls.Add(this.dateTimeUpdateExpired);
            this.panel1.Controls.Add(this.lblUpdateExpiredDate);
            this.panel1.Controls.Add(this.dateTimeUpdateFirst);
            this.panel1.Controls.Add(this.lblUpdateFirstDate);
            this.panel1.Controls.Add(this.lblUpdateDescription);
            this.panel1.Controls.Add(this.txtUpdateName);
            this.panel1.Controls.Add(this.lblUpdateName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 473);
            this.panel1.TabIndex = 0;
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(3, 21);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(243, 21);
            this.txtUpdateID.TabIndex = 32;
            // 
            // lblUpdateID
            // 
            this.lblUpdateID.AutoSize = true;
            this.lblUpdateID.ForeColor = System.Drawing.Color.White;
            this.lblUpdateID.Location = new System.Drawing.Point(4, 2);
            this.lblUpdateID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateID.Name = "lblUpdateID";
            this.lblUpdateID.Size = new System.Drawing.Size(25, 15);
            this.lblUpdateID.TabIndex = 31;
            this.lblUpdateID.Text = "ID:";
            // 
            // btnDeleteWorkOrder
            // 
            this.btnDeleteWorkOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteWorkOrder.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.btnDeleteWorkOrder.IconColor = System.Drawing.Color.Red;
            this.btnDeleteWorkOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteWorkOrder.Location = new System.Drawing.Point(134, 414);
            this.btnDeleteWorkOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteWorkOrder.Name = "btnDeleteWorkOrder";
            this.btnDeleteWorkOrder.Size = new System.Drawing.Size(116, 56);
            this.btnDeleteWorkOrder.TabIndex = 30;
            this.btnDeleteWorkOrder.Text = "İş Sil";
            this.btnDeleteWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteWorkOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteWorkOrder.UseVisualStyleBackColor = true;
            this.btnDeleteWorkOrder.Click += new System.EventHandler(this.btnDeleteWorkOrder_Click);
            // 
            // dateTimeNewFinish
            // 
            this.dateTimeNewFinish.CustomFormat = "0:dd/MM/yyyy";
            this.dateTimeNewFinish.Location = new System.Drawing.Point(3, 324);
            this.dateTimeNewFinish.Name = "dateTimeNewFinish";
            this.dateTimeNewFinish.Size = new System.Drawing.Size(240, 21);
            this.dateTimeNewFinish.TabIndex = 29;
            this.dateTimeNewFinish.ValueChanged += new System.EventHandler(this.DateTimePickerValueChange);
            // 
            // lblNewFinish
            // 
            this.lblNewFinish.AutoSize = true;
            this.lblNewFinish.ForeColor = System.Drawing.Color.White;
            this.lblNewFinish.Location = new System.Drawing.Point(4, 296);
            this.lblNewFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewFinish.Name = "lblNewFinish";
            this.lblNewFinish.Size = new System.Drawing.Size(146, 15);
            this.lblNewFinish.TabIndex = 28;
            this.lblNewFinish.Text = "Bitiş Tarihi Giriniz(*) :";
            // 
            // txtUpdateMan
            // 
            this.txtUpdateMan.Location = new System.Drawing.Point(3, 200);
            this.txtUpdateMan.Name = "txtUpdateMan";
            this.txtUpdateMan.Size = new System.Drawing.Size(247, 21);
            this.txtUpdateMan.TabIndex = 27;
            this.txtUpdateMan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateMan_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Adam Gün Giriniz (*):";
            // 
            // txtUpdateDesc
            // 
            this.txtUpdateDesc.Location = new System.Drawing.Point(3, 112);
            this.txtUpdateDesc.Name = "txtUpdateDesc";
            this.txtUpdateDesc.Size = new System.Drawing.Size(240, 58);
            this.txtUpdateDesc.TabIndex = 25;
            this.txtUpdateDesc.Text = "";
            // 
            // chckbxIsWorkFinished
            // 
            this.chckbxIsWorkFinished.AutoSize = true;
            this.chckbxIsWorkFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbxIsWorkFinished.ForeColor = System.Drawing.Color.White;
            this.chckbxIsWorkFinished.Location = new System.Drawing.Point(143, 360);
            this.chckbxIsWorkFinished.Name = "chckbxIsWorkFinished";
            this.chckbxIsWorkFinished.Size = new System.Drawing.Size(107, 17);
            this.chckbxIsWorkFinished.TabIndex = 24;
            this.chckbxIsWorkFinished.Text = "İş Tamamlandı";
            this.chckbxIsWorkFinished.UseVisualStyleBackColor = true;
            this.chckbxIsWorkFinished.CheckedChanged += new System.EventHandler(this.chckbxIsWorkFinished_CheckedChanged);
            // 
            // btnAddNewWorkOrder
            // 
            this.btnAddNewWorkOrder.FlatAppearance.BorderSize = 0;
            this.btnAddNewWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddNewWorkOrder.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnAddNewWorkOrder.IconColor = System.Drawing.Color.Lime;
            this.btnAddNewWorkOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewWorkOrder.Location = new System.Drawing.Point(0, 414);
            this.btnAddNewWorkOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewWorkOrder.Name = "btnAddNewWorkOrder";
            this.btnAddNewWorkOrder.Size = new System.Drawing.Size(146, 56);
            this.btnAddNewWorkOrder.TabIndex = 23;
            this.btnAddNewWorkOrder.Text = "İş Güncelle";
            this.btnAddNewWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewWorkOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewWorkOrder.UseVisualStyleBackColor = true;
            this.btnAddNewWorkOrder.Click += new System.EventHandler(this.btnAddNewWorkOrder_Click);
            // 
            // dateTimeUpdateExpired
            // 
            this.dateTimeUpdateExpired.CustomFormat = "0:dd/MM/yyyy";
            this.dateTimeUpdateExpired.Enabled = false;
            this.dateTimeUpdateExpired.Location = new System.Drawing.Point(4, 387);
            this.dateTimeUpdateExpired.Name = "dateTimeUpdateExpired";
            this.dateTimeUpdateExpired.Size = new System.Drawing.Size(243, 21);
            this.dateTimeUpdateExpired.TabIndex = 20;
            // 
            // lblUpdateExpiredDate
            // 
            this.lblUpdateExpiredDate.AutoSize = true;
            this.lblUpdateExpiredDate.ForeColor = System.Drawing.Color.White;
            this.lblUpdateExpiredDate.Location = new System.Drawing.Point(1, 359);
            this.lblUpdateExpiredDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateExpiredDate.Name = "lblUpdateExpiredDate";
            this.lblUpdateExpiredDate.Size = new System.Drawing.Size(145, 15);
            this.lblUpdateExpiredDate.TabIndex = 19;
            this.lblUpdateExpiredDate.Text = "Teslim Tarihi Giriniz :";
            // 
            // dateTimeUpdateFirst
            // 
            this.dateTimeUpdateFirst.CustomFormat = "0:dd/MM/yyyy";
            this.dateTimeUpdateFirst.Location = new System.Drawing.Point(3, 262);
            this.dateTimeUpdateFirst.Name = "dateTimeUpdateFirst";
            this.dateTimeUpdateFirst.Size = new System.Drawing.Size(243, 21);
            this.dateTimeUpdateFirst.TabIndex = 18;
            this.dateTimeUpdateFirst.ValueChanged += new System.EventHandler(this.DateTimePickerValueChange);
            // 
            // lblUpdateFirstDate
            // 
            this.lblUpdateFirstDate.AutoSize = true;
            this.lblUpdateFirstDate.ForeColor = System.Drawing.Color.White;
            this.lblUpdateFirstDate.Location = new System.Drawing.Point(0, 234);
            this.lblUpdateFirstDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateFirstDate.Name = "lblUpdateFirstDate";
            this.lblUpdateFirstDate.Size = new System.Drawing.Size(181, 15);
            this.lblUpdateFirstDate.TabIndex = 17;
            this.lblUpdateFirstDate.Text = "Başlangıç Tarihi Giriniz(*) :";
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.ForeColor = System.Drawing.Color.White;
            this.lblUpdateDescription.Location = new System.Drawing.Point(4, 94);
            this.lblUpdateDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(119, 15);
            this.lblUpdateDescription.TabIndex = 15;
            this.lblUpdateDescription.Text = "Açıklama Giriniz :";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(3, 64);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(243, 21);
            this.txtUpdateName.TabIndex = 14;
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.ForeColor = System.Drawing.Color.White;
            this.lblUpdateName.Location = new System.Drawing.Point(4, 45);
            this.lblUpdateName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(88, 15);
            this.lblUpdateName.TabIndex = 13;
            this.lblUpdateName.Text = "İsim Giriniz :";
            // 
            // UpdateWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(246, 473);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UpdateWorkOrder";
            this.Opacity = 0.96D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Emri Güncelleme";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UpdateWorkOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimeUpdateExpired;
        private System.Windows.Forms.Label lblUpdateExpiredDate;
        private System.Windows.Forms.DateTimePicker dateTimeUpdateFirst;
        private System.Windows.Forms.Label lblUpdateFirstDate;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label lblUpdateName;
        private FontAwesome.Sharp.IconButton btnAddNewWorkOrder;
        private System.Windows.Forms.CheckBox chckbxIsWorkFinished;
        private System.Windows.Forms.RichTextBox txtUpdateDesc;
        private System.Windows.Forms.TextBox txtUpdateMan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeNewFinish;
        private System.Windows.Forms.Label lblNewFinish;
        private FontAwesome.Sharp.IconButton btnDeleteWorkOrder;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.Label lblUpdateID;
    }
}