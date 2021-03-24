
namespace Hakediş
{
    partial class AddNewPaymentForm
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
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewPayment = new System.Windows.Forms.TextBox();
            this.lblNewPayment = new System.Windows.Forms.Label();
            this.btnAddNewPayment = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePayment = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(12, 35);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(228, 21);
            this.txtNewName.TabIndex = 6;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.ForeColor = System.Drawing.Color.White;
            this.lblNewName.Location = new System.Drawing.Point(9, 14);
            this.lblNewName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(88, 15);
            this.lblNewName.TabIndex = 5;
            this.lblNewName.Text = "İsim Giriniz :";
            // 
            // txtNewPayment
            // 
            this.txtNewPayment.Location = new System.Drawing.Point(12, 90);
            this.txtNewPayment.Name = "txtNewPayment";
            this.txtNewPayment.Size = new System.Drawing.Size(228, 21);
            this.txtNewPayment.TabIndex = 8;
            this.txtNewPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPayment_KeyPress);
            // 
            // lblNewPayment
            // 
            this.lblNewPayment.AutoSize = true;
            this.lblNewPayment.ForeColor = System.Drawing.Color.White;
            this.lblNewPayment.Location = new System.Drawing.Point(9, 69);
            this.lblNewPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPayment.Name = "lblNewPayment";
            this.lblNewPayment.Size = new System.Drawing.Size(123, 15);
            this.lblNewPayment.TabIndex = 7;
            this.lblNewPayment.Text = "Ödeme Giriniz (*):";
            // 
            // btnAddNewPayment
            // 
            this.btnAddNewPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddNewPayment.FlatAppearance.BorderSize = 0;
            this.btnAddNewPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewPayment.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPayment.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnAddNewPayment.IconColor = System.Drawing.Color.Lime;
            this.btnAddNewPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewPayment.Location = new System.Drawing.Point(0, 162);
            this.btnAddNewPayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewPayment.Name = "btnAddNewPayment";
            this.btnAddNewPayment.Size = new System.Drawing.Size(251, 67);
            this.btnAddNewPayment.TabIndex = 9;
            this.btnAddNewPayment.Text = "Yeni Ödeme Ekle";
            this.btnAddNewPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewPayment.UseVisualStyleBackColor = true;
            this.btnAddNewPayment.Click += new System.EventHandler(this.btnAddNewPayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ödeme Tarihi Giriniz(*) :";
            // 
            // dateTimePayment
            // 
            this.dateTimePayment.Location = new System.Drawing.Point(12, 145);
            this.dateTimePayment.Name = "dateTimePayment";
            this.dateTimePayment.Size = new System.Drawing.Size(228, 21);
            this.dateTimePayment.TabIndex = 11;
            // 
            // AddNewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(251, 229);
            this.Controls.Add(this.dateTimePayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewPayment);
            this.Controls.Add(this.txtNewPayment);
            this.Controls.Add(this.lblNewPayment);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblNewName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddNewPaymentForm";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Ödeme";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddNewPaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewPayment;
        private System.Windows.Forms.Label lblNewPayment;
        private FontAwesome.Sharp.IconButton btnAddNewPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePayment;
    }
}