
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
            this.SuspendLayout();
            // 
            // btnOptionsExit
            // 
            this.btnOptionsExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOptionsExit.FlatAppearance.BorderSize = 0;
            this.btnOptionsExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionsExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOptionsExit.ForeColor = System.Drawing.Color.White;
            this.btnOptionsExit.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnOptionsExit.IconColor = System.Drawing.Color.White;
            this.btnOptionsExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOptionsExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionsExit.Location = new System.Drawing.Point(0, 197);
            this.btnOptionsExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOptionsExit.Name = "btnOptionsExit";
            this.btnOptionsExit.Size = new System.Drawing.Size(184, 67);
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
            this.btnAutoStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAutoStart.ForeColor = System.Drawing.Color.White;
            this.btnAutoStart.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnAutoStart.IconColor = System.Drawing.Color.White;
            this.btnAutoStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAutoStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoStart.Location = new System.Drawing.Point(0, 0);
            this.btnAutoStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAutoStart.Name = "btnAutoStart";
            this.btnAutoStart.Size = new System.Drawing.Size(184, 67);
            this.btnAutoStart.TabIndex = 7;
            this.btnAutoStart.Text = "Uygulamayı Otomatik Başlat";
            this.btnAutoStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutoStart.UseVisualStyleBackColor = true;
            this.btnAutoStart.Click += new System.EventHandler(this.btnAutoStart_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(184, 264);
            this.Controls.Add(this.btnAutoStart);
            this.Controls.Add(this.btnOptionsExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnOptionsExit;
        private FontAwesome.Sharp.IconButton btnAutoStart;
    }
}