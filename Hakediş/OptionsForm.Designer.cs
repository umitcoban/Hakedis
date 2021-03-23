
namespace Hakediş
{
    partial class OptionsForm
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
            this.btnOptionsExit = new FontAwesome.Sharp.IconButton();
            this.btnAutoStart = new FontAwesome.Sharp.IconButton();
            this.btnAutoUpdate = new FontAwesome.Sharp.IconButton();
            this.comboBoxSelectUpdateDay = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.maskedtxtUsername = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtPass = new System.Windows.Forms.MaskedTextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.maskedTxtToEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblToEmail = new System.Windows.Forms.Label();
            this.chckboxShowPass = new System.Windows.Forms.CheckBox();
            this.ıconBtnNewUser = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnOptionsExit
            // 
            this.btnOptionsExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOptionsExit.FlatAppearance.BorderSize = 0;
            this.btnOptionsExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionsExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOptionsExit.ForeColor = System.Drawing.Color.White;
            this.btnOptionsExit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnOptionsExit.IconColor = System.Drawing.Color.White;
            this.btnOptionsExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOptionsExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionsExit.Location = new System.Drawing.Point(0, 366);
            this.btnOptionsExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOptionsExit.Name = "btnOptionsExit";
            this.btnOptionsExit.Size = new System.Drawing.Size(201, 67);
            this.btnOptionsExit.TabIndex = 6;
            this.btnOptionsExit.Text = "Ayarları Onayla";
            this.btnOptionsExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionsExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptionsExit.UseVisualStyleBackColor = true;
            this.btnOptionsExit.Click += new System.EventHandler(this.btnOptionsExit_Click);
            // 
            // btnAutoStart
            // 
            this.btnAutoStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutoStart.FlatAppearance.BorderSize = 0;
            this.btnAutoStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAutoStart.ForeColor = System.Drawing.Color.White;
            this.btnAutoStart.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.btnAutoStart.IconColor = System.Drawing.Color.White;
            this.btnAutoStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAutoStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoStart.Location = new System.Drawing.Point(0, 0);
            this.btnAutoStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAutoStart.Name = "btnAutoStart";
            this.btnAutoStart.Size = new System.Drawing.Size(201, 67);
            this.btnAutoStart.TabIndex = 7;
            this.btnAutoStart.Text = "Uygulamayı Otomatik Başlat";
            this.btnAutoStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutoStart.UseVisualStyleBackColor = true;
            this.btnAutoStart.Click += new System.EventHandler(this.btnChangeFunction);
            // 
            // btnAutoUpdate
            // 
            this.btnAutoUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutoUpdate.FlatAppearance.BorderSize = 0;
            this.btnAutoUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAutoUpdate.ForeColor = System.Drawing.Color.White;
            this.btnAutoUpdate.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnAutoUpdate.IconColor = System.Drawing.Color.White;
            this.btnAutoUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAutoUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoUpdate.Location = new System.Drawing.Point(0, 67);
            this.btnAutoUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAutoUpdate.Name = "btnAutoUpdate";
            this.btnAutoUpdate.Size = new System.Drawing.Size(201, 67);
            this.btnAutoUpdate.TabIndex = 8;
            this.btnAutoUpdate.Text = "Otomatik Yedekle";
            this.btnAutoUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutoUpdate.UseVisualStyleBackColor = true;
            this.btnAutoUpdate.Click += new System.EventHandler(this.btnChangeFunction);
            // 
            // comboBoxSelectUpdateDay
            // 
            this.comboBoxSelectUpdateDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxSelectUpdateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSelectUpdateDay.FormattingEnabled = true;
            this.comboBoxSelectUpdateDay.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.comboBoxSelectUpdateDay.Location = new System.Drawing.Point(0, 134);
            this.comboBoxSelectUpdateDay.Name = "comboBoxSelectUpdateDay";
            this.comboBoxSelectUpdateDay.Size = new System.Drawing.Size(201, 24);
            this.comboBoxSelectUpdateDay.TabIndex = 9;
            this.comboBoxSelectUpdateDay.Text = "Yedekleme Gününü Seçin";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(0, 158);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 16);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "Email Girin:";
            // 
            // maskedtxtUsername
            // 
            this.maskedtxtUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.maskedtxtUsername.Location = new System.Drawing.Point(0, 174);
            this.maskedtxtUsername.Name = "maskedtxtUsername";
            this.maskedtxtUsername.PromptChar = '@';
            this.maskedtxtUsername.Size = new System.Drawing.Size(201, 21);
            this.maskedtxtUsername.TabIndex = 11;
            this.maskedtxtUsername.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // maskedTxtPass
            // 
            this.maskedTxtPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.maskedTxtPass.Location = new System.Drawing.Point(0, 211);
            this.maskedTxtPass.Name = "maskedTxtPass";
            this.maskedTxtPass.Size = new System.Drawing.Size(201, 21);
            this.maskedTxtPass.TabIndex = 13;
            this.maskedTxtPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.Location = new System.Drawing.Point(0, 195);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(80, 16);
            this.lblPass.TabIndex = 12;
            this.lblPass.Text = "Şifre Girin:";
            // 
            // maskedTxtToEmail
            // 
            this.maskedTxtToEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.maskedTxtToEmail.Location = new System.Drawing.Point(0, 248);
            this.maskedTxtToEmail.Name = "maskedTxtToEmail";
            this.maskedTxtToEmail.PromptChar = '@';
            this.maskedTxtToEmail.Size = new System.Drawing.Size(201, 21);
            this.maskedTxtToEmail.TabIndex = 15;
            this.maskedTxtToEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lblToEmail
            // 
            this.lblToEmail.AutoSize = true;
            this.lblToEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblToEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToEmail.Location = new System.Drawing.Point(0, 232);
            this.lblToEmail.Name = "lblToEmail";
            this.lblToEmail.Size = new System.Drawing.Size(184, 16);
            this.lblToEmail.TabIndex = 14;
            this.lblToEmail.Text = "Gönderilecek Email Girin:";
            // 
            // chckboxShowPass
            // 
            this.chckboxShowPass.AutoSize = true;
            this.chckboxShowPass.BackColor = System.Drawing.Color.Transparent;
            this.chckboxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckboxShowPass.Location = new System.Drawing.Point(86, 194);
            this.chckboxShowPass.Name = "chckboxShowPass";
            this.chckboxShowPass.Size = new System.Drawing.Size(112, 17);
            this.chckboxShowPass.TabIndex = 16;
            this.chckboxShowPass.Text = "Parolayı Göster";
            this.chckboxShowPass.UseVisualStyleBackColor = false;
            this.chckboxShowPass.CheckedChanged += new System.EventHandler(this.chckboxShowPass_CheckedChanged);
            // 
            // ıconBtnNewUser
            // 
            this.ıconBtnNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconBtnNewUser.FlatAppearance.BorderSize = 0;
            this.ıconBtnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconBtnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconBtnNewUser.ForeColor = System.Drawing.Color.White;
            this.ıconBtnNewUser.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.ıconBtnNewUser.IconColor = System.Drawing.Color.White;
            this.ıconBtnNewUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconBtnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconBtnNewUser.Location = new System.Drawing.Point(0, 269);
            this.ıconBtnNewUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ıconBtnNewUser.Name = "ıconBtnNewUser";
            this.ıconBtnNewUser.Size = new System.Drawing.Size(201, 67);
            this.ıconBtnNewUser.TabIndex = 17;
            this.ıconBtnNewUser.Text = "Yeni Kullanıcı Oluştur";
            this.ıconBtnNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconBtnNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconBtnNewUser.UseVisualStyleBackColor = true;
            this.ıconBtnNewUser.Click += new System.EventHandler(this.ıconBtnNewUser_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(201, 433);
            this.Controls.Add(this.ıconBtnNewUser);
            this.Controls.Add(this.chckboxShowPass);
            this.Controls.Add(this.maskedTxtToEmail);
            this.Controls.Add(this.lblToEmail);
            this.Controls.Add(this.maskedTxtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.maskedtxtUsername);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.comboBoxSelectUpdateDay);
            this.Controls.Add(this.btnAutoUpdate);
            this.Controls.Add(this.btnAutoStart);
            this.Controls.Add(this.btnOptionsExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OptionsForm";
            this.Opacity = 0.96D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnOptionsExit;
        private FontAwesome.Sharp.IconButton btnAutoStart;
        private FontAwesome.Sharp.IconButton btnAutoUpdate;
        private System.Windows.Forms.ComboBox comboBoxSelectUpdateDay;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.MaskedTextBox maskedtxtUsername;
        private System.Windows.Forms.MaskedTextBox maskedTxtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.MaskedTextBox maskedTxtToEmail;
        private System.Windows.Forms.Label lblToEmail;
        private System.Windows.Forms.CheckBox chckboxShowPass;
        private FontAwesome.Sharp.IconButton ıconBtnNewUser;
    }
}