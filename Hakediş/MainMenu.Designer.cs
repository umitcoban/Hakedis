
namespace Hakediş
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnUpdatePayment = new FontAwesome.Sharp.IconButton();
            this.btnOptions = new FontAwesome.Sharp.IconButton();
            this.btnAddPayment = new FontAwesome.Sharp.IconButton();
            this.btnUpdateWorkOrderList = new FontAwesome.Sharp.IconButton();
            this.btnUpdateWorkOrder = new FontAwesome.Sharp.IconButton();
            this.btnAddNewWorkOrder = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLblMonth = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLblPaymentStat = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalPayment = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLlblCurrentPayStat = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblCurrentPay = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLblGeneralStat = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uygulamayıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamayıKapatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMain.Controls.Add(this.btnUpdatePayment);
            this.panelMain.Controls.Add(this.btnOptions);
            this.panelMain.Controls.Add(this.btnAddPayment);
            this.panelMain.Controls.Add(this.btnUpdateWorkOrderList);
            this.panelMain.Controls.Add(this.btnUpdateWorkOrder);
            this.panelMain.Controls.Add(this.btnAddNewWorkOrder);
            this.panelMain.Controls.Add(this.panelLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(209, 525);
            this.panelMain.TabIndex = 0;
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdatePayment.FlatAppearance.BorderSize = 0;
            this.btnUpdatePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdatePayment.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePayment.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnUpdatePayment.IconColor = System.Drawing.Color.White;
            this.btnUpdatePayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdatePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePayment.Location = new System.Drawing.Point(0, 438);
            this.btnUpdatePayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(209, 67);
            this.btnUpdatePayment.TabIndex = 6;
            this.btnUpdatePayment.Text = "Ödeme Güncelle";
            this.btnUpdatePayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdatePayment.UseVisualStyleBackColor = true;
            this.btnUpdatePayment.Click += new System.EventHandler(this.btnUpdatePayment_Click_1);
            // 
            // btnOptions
            // 
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnOptions.IconColor = System.Drawing.Color.White;
            this.btnOptions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.Location = new System.Drawing.Point(0, 458);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(209, 67);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Ayarlar";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPayment.FlatAppearance.BorderSize = 0;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPayment.ForeColor = System.Drawing.Color.White;
            this.btnAddPayment.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnAddPayment.IconColor = System.Drawing.Color.White;
            this.btnAddPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPayment.Location = new System.Drawing.Point(0, 371);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(209, 67);
            this.btnAddPayment.TabIndex = 4;
            this.btnAddPayment.Text = "Ödeme Ekle";
            this.btnAddPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnUpdatePayment_Click);
            // 
            // btnUpdateWorkOrderList
            // 
            this.btnUpdateWorkOrderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateWorkOrderList.FlatAppearance.BorderSize = 0;
            this.btnUpdateWorkOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWorkOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateWorkOrderList.ForeColor = System.Drawing.Color.White;
            this.btnUpdateWorkOrderList.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnUpdateWorkOrderList.IconColor = System.Drawing.Color.White;
            this.btnUpdateWorkOrderList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateWorkOrderList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateWorkOrderList.Location = new System.Drawing.Point(0, 304);
            this.btnUpdateWorkOrderList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateWorkOrderList.Name = "btnUpdateWorkOrderList";
            this.btnUpdateWorkOrderList.Size = new System.Drawing.Size(209, 67);
            this.btnUpdateWorkOrderList.TabIndex = 3;
            this.btnUpdateWorkOrderList.Text = "İş Emri Listesi Güncelle";
            this.btnUpdateWorkOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateWorkOrderList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateWorkOrderList.UseVisualStyleBackColor = true;
            this.btnUpdateWorkOrderList.Click += new System.EventHandler(this.btnUpdateWorkOrderList_Click);
            // 
            // btnUpdateWorkOrder
            // 
            this.btnUpdateWorkOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateWorkOrder.FlatAppearance.BorderSize = 0;
            this.btnUpdateWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnUpdateWorkOrder.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnUpdateWorkOrder.IconColor = System.Drawing.Color.White;
            this.btnUpdateWorkOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateWorkOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateWorkOrder.Location = new System.Drawing.Point(0, 237);
            this.btnUpdateWorkOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateWorkOrder.Name = "btnUpdateWorkOrder";
            this.btnUpdateWorkOrder.Size = new System.Drawing.Size(209, 67);
            this.btnUpdateWorkOrder.TabIndex = 2;
            this.btnUpdateWorkOrder.Text = "İş Emri Güncelle";
            this.btnUpdateWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateWorkOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateWorkOrder.UseVisualStyleBackColor = true;
            this.btnUpdateWorkOrder.Click += new System.EventHandler(this.btnUpdateWorkOrder_Click);
            // 
            // btnAddNewWorkOrder
            // 
            this.btnAddNewWorkOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewWorkOrder.FlatAppearance.BorderSize = 0;
            this.btnAddNewWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddNewWorkOrder.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddNewWorkOrder.IconColor = System.Drawing.Color.White;
            this.btnAddNewWorkOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewWorkOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewWorkOrder.Location = new System.Drawing.Point(0, 170);
            this.btnAddNewWorkOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewWorkOrder.Name = "btnAddNewWorkOrder";
            this.btnAddNewWorkOrder.Size = new System.Drawing.Size(209, 67);
            this.btnAddNewWorkOrder.TabIndex = 1;
            this.btnAddNewWorkOrder.Text = "Yeni İş Ekle";
            this.btnAddNewWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewWorkOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewWorkOrder.UseVisualStyleBackColor = true;
            this.btnAddNewWorkOrder.Click += new System.EventHandler(this.btnAddNewWorkOrder_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(209, 170);
            this.panelLogo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.Location = new System.Drawing.Point(209, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(526, 475);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(743, 22);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(284, 475);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblMonth,
            this.toolStripSeparator1,
            this.toolStripLblPaymentStat,
            this.toolStripLblTotalPayment,
            this.toolStripSeparator2,
            this.toolStripLlblCurrentPayStat,
            this.toolStripLblCurrentPay,
            this.toolStripSeparator3,
            this.toolStripLblGeneralStat,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(209, 500);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLblMonth
            // 
            this.toolStripLblMonth.Name = "toolStripLblMonth";
            this.toolStripLblMonth.Size = new System.Drawing.Size(86, 22);
            this.toolStripLblMonth.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLblPaymentStat
            // 
            this.toolStripLblPaymentStat.Name = "toolStripLblPaymentStat";
            this.toolStripLblPaymentStat.Size = new System.Drawing.Size(202, 22);
            this.toolStripLblPaymentStat.Text = "Toplamda Alınacak Adam Gün Sayısı:";
            // 
            // toolStripLblTotalPayment
            // 
            this.toolStripLblTotalPayment.Name = "toolStripLblTotalPayment";
            this.toolStripLblTotalPayment.Size = new System.Drawing.Size(13, 22);
            this.toolStripLblTotalPayment.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLlblCurrentPayStat
            // 
            this.toolStripLlblCurrentPayStat.Name = "toolStripLlblCurrentPayStat";
            this.toolStripLlblCurrentPayStat.Size = new System.Drawing.Size(155, 22);
            this.toolStripLlblCurrentPayStat.Text = "Aldığınız Ödeme Gün Sayısı:";
            // 
            // toolStripLblCurrentPay
            // 
            this.toolStripLblCurrentPay.Name = "toolStripLblCurrentPay";
            this.toolStripLblCurrentPay.Size = new System.Drawing.Size(13, 22);
            this.toolStripLblCurrentPay.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLblGeneralStat
            // 
            this.toolStripLblGeneralStat.Name = "toolStripLblGeneralStat";
            this.toolStripLblGeneralStat.Size = new System.Drawing.Size(13, 22);
            this.toolStripLblGeneralStat.Text = "0";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuNotify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Hakediş";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuNotify
            // 
            this.contextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamayıKapatToolStripMenuItem,
            this.uygulamayıKapatToolStripMenuItem1});
            this.contextMenuNotify.Name = "contextMenuNotify";
            this.contextMenuNotify.Size = new System.Drawing.Size(171, 48);
            // 
            // uygulamayıKapatToolStripMenuItem
            // 
            this.uygulamayıKapatToolStripMenuItem.Name = "uygulamayıKapatToolStripMenuItem";
            this.uygulamayıKapatToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.uygulamayıKapatToolStripMenuItem.Text = "Uygulamayı Aç";
            this.uygulamayıKapatToolStripMenuItem.Click += new System.EventHandler(this.uygulamayıKapatToolStripMenuItem_Click);
            // 
            // uygulamayıKapatToolStripMenuItem1
            // 
            this.uygulamayıKapatToolStripMenuItem1.Name = "uygulamayıKapatToolStripMenuItem1";
            this.uygulamayıKapatToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.uygulamayıKapatToolStripMenuItem1.Text = "Uygulamayı Kapat";
            this.uygulamayıKapatToolStripMenuItem1.Click += new System.EventHandler(this.uygulamayıKapatToolStripMenuItem1_Click);
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxFilter.Location = new System.Drawing.Point(209, 0);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(818, 19);
            this.checkBoxFilter.TabIndex = 4;
            this.checkBoxFilter.Text = "Tamamlanan İşleri Göster";
            this.checkBoxFilter.UseVisualStyleBackColor = false;
            this.checkBoxFilter.CheckedChanged += new System.EventHandler(this.checkBoxFilter_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 525);
            this.Controls.Add(this.checkBoxFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlkay/Hakediş";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnAddNewWorkOrder;
        private FontAwesome.Sharp.IconButton btnUpdateWorkOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnUpdateWorkOrderList;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLblMonth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLblPaymentStat;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalPayment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLlblCurrentPayStat;
        private System.Windows.Forms.ToolStripLabel toolStripLblCurrentPay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLblGeneralStat;
        private FontAwesome.Sharp.IconButton btnAddPayment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private FontAwesome.Sharp.IconButton btnOptions;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem uygulamayıKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamayıKapatToolStripMenuItem1;
        private FontAwesome.Sharp.IconButton btnUpdatePayment;
        private System.Windows.Forms.CheckBox checkBoxFilter;
    }
}

