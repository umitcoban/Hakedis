
namespace Hakediş
{
    partial class LoginMenuForm
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
            this.components = new System.ComponentModel.Container();
            this.ıconBtnPayed = new FontAwesome.Sharp.IconButton();
            this.ıconBtnPayee = new FontAwesome.Sharp.IconButton();
            this.toolTipBtnDesc = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ıconBtnPayed
            // 
            this.ıconBtnPayed.Dock = System.Windows.Forms.DockStyle.Left;
            this.ıconBtnPayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconBtnPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconBtnPayed.ForeColor = System.Drawing.Color.White;
            this.ıconBtnPayed.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.ıconBtnPayed.IconColor = System.Drawing.Color.White;
            this.ıconBtnPayed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconBtnPayed.IconSize = 52;
            this.ıconBtnPayed.Location = new System.Drawing.Point(0, 0);
            this.ıconBtnPayed.Name = "ıconBtnPayed";
            this.ıconBtnPayed.Size = new System.Drawing.Size(199, 139);
            this.ıconBtnPayed.TabIndex = 0;
            this.ıconBtnPayed.Text = "Ödeme Yapan";
            this.ıconBtnPayed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipBtnDesc.SetToolTip(this.ıconBtnPayed, "(Ödemeyi Gerçekleştiren Kullanıcı)\r\nSisteme kayıtlarınızı girdikten sonra hesapla" +
        "malar her ödeme yaptığınız da pozitif hesaplanacaktır.\r\nHer iş emri bitirildiğin" +
        "de ise hanenize negatif sayılacaktır.");
            this.ıconBtnPayed.UseVisualStyleBackColor = true;
            this.ıconBtnPayed.Click += new System.EventHandler(this.ıconBtnPayed_Click);
            // 
            // ıconBtnPayee
            // 
            this.ıconBtnPayee.Dock = System.Windows.Forms.DockStyle.Left;
            this.ıconBtnPayee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconBtnPayee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconBtnPayee.ForeColor = System.Drawing.Color.White;
            this.ıconBtnPayee.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.ıconBtnPayee.IconColor = System.Drawing.Color.White;
            this.ıconBtnPayee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconBtnPayee.IconSize = 52;
            this.ıconBtnPayee.Location = new System.Drawing.Point(199, 0);
            this.ıconBtnPayee.Name = "ıconBtnPayee";
            this.ıconBtnPayee.Size = new System.Drawing.Size(199, 139);
            this.ıconBtnPayee.TabIndex = 1;
            this.ıconBtnPayee.Text = "Ödeme Alan";
            this.ıconBtnPayee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipBtnDesc.SetToolTip(this.ıconBtnPayee, "(Ödemeyi Alan Kullanıcı)\r\nSisteme kayıtlarınızı girdikten sonra hesaplamalar her " +
        "iş emri bitirildiğinde pozitif hesaplanacaktır.\r\nHer ödeme alındığında ise hanen" +
        "ize negatif sayılacaktır.\r\n");
            this.ıconBtnPayee.UseVisualStyleBackColor = true;
            this.ıconBtnPayee.Click += new System.EventHandler(this.ıconBtnPayee_Click);
            // 
            // LoginMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(398, 139);
            this.Controls.Add(this.ıconBtnPayee);
            this.Controls.Add(this.ıconBtnPayed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginMenuForm";
            this.Load += new System.EventHandler(this.LoginMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton ıconBtnPayed;
        private FontAwesome.Sharp.IconButton ıconBtnPayee;
        private System.Windows.Forms.ToolTip toolTipBtnDesc;
    }
}