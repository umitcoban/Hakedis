
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnUpdatePayment = new FontAwesome.Sharp.IconButton();
            this.btnOptions = new FontAwesome.Sharp.IconButton();
            this.btnAddPayment = new FontAwesome.Sharp.IconButton();
            this.btnCreateWorkReport = new FontAwesome.Sharp.IconButton();
            this.btnUpdateWorkOrder = new FontAwesome.Sharp.IconButton();
            this.btnAddNewWorkOrder = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextWorkOrderList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tamamlananİşleriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamamlananİşleriGöstermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripProgressBarBackup = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripBtnBackup = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uygulamayıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamayıKapatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelStat = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnGeneralStat = new FontAwesome.Sharp.IconButton();
            this.lblRemainingWeek = new System.Windows.Forms.Label();
            this.lblCurrentDay = new System.Windows.Forms.Label();
            this.lblCurrentWeek = new System.Windows.Forms.Label();
            this.lblCurrentMonth = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateStat = new System.Windows.Forms.Label();
            this.splitDate = new System.Windows.Forms.Splitter();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.contextMenuWeather = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.şehirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istanbultoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ankaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kocaeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antalyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTemperatureStat = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.btnWeatherIcon = new FontAwesome.Sharp.IconButton();
            this.lblWeatherStat = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.timerBackupStat = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextWorkOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuNotify.SuspendLayout();
            this.panelStat.SuspendLayout();
            this.contextMenuWeather.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMain.Controls.Add(this.btnUpdatePayment);
            this.panelMain.Controls.Add(this.btnOptions);
            this.panelMain.Controls.Add(this.btnAddPayment);
            this.panelMain.Controls.Add(this.btnCreateWorkReport);
            this.panelMain.Controls.Add(this.btnUpdateWorkOrder);
            this.panelMain.Controls.Add(this.btnAddNewWorkOrder);
            this.panelMain.Controls.Add(this.panelLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(209, 577);
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
            this.btnUpdatePayment.Location = new System.Drawing.Point(0, 397);
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
            this.btnOptions.Location = new System.Drawing.Point(0, 510);
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
            this.btnAddPayment.Location = new System.Drawing.Point(0, 330);
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
            // btnCreateWorkReport
            // 
            this.btnCreateWorkReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateWorkReport.FlatAppearance.BorderSize = 0;
            this.btnCreateWorkReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateWorkReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateWorkReport.ForeColor = System.Drawing.Color.White;
            this.btnCreateWorkReport.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnCreateWorkReport.IconColor = System.Drawing.Color.White;
            this.btnCreateWorkReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateWorkReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateWorkReport.Location = new System.Drawing.Point(0, 263);
            this.btnCreateWorkReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateWorkReport.Name = "btnCreateWorkReport";
            this.btnCreateWorkReport.Size = new System.Drawing.Size(209, 67);
            this.btnCreateWorkReport.TabIndex = 3;
            this.btnCreateWorkReport.Text = "Rapor Oluştur";
            this.btnCreateWorkReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateWorkReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateWorkReport.UseVisualStyleBackColor = true;
            this.btnCreateWorkReport.Visible = false;
            this.btnCreateWorkReport.Click += new System.EventHandler(this.btnCreateWorkReport_Click);
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
            this.btnUpdateWorkOrder.Location = new System.Drawing.Point(0, 196);
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
            this.btnAddNewWorkOrder.Location = new System.Drawing.Point(0, 129);
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
            this.panelLogo.BackgroundImage = global::Hakediş.Properties.Resources.images;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(209, 129);
            this.panelLogo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextWorkOrderList;
            this.dataGridView1.Location = new System.Drawing.Point(221, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(582, 401);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextWorkOrderList
            // 
            this.contextWorkOrderList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextWorkOrderList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamamlananİşleriGösterToolStripMenuItem,
            this.tamamlananİşleriGöstermeToolStripMenuItem});
            this.contextWorkOrderList.Name = "contextMenuMainList";
            this.contextWorkOrderList.Size = new System.Drawing.Size(224, 48);
            // 
            // tamamlananİşleriGösterToolStripMenuItem
            // 
            this.tamamlananİşleriGösterToolStripMenuItem.Name = "tamamlananİşleriGösterToolStripMenuItem";
            this.tamamlananİşleriGösterToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.tamamlananİşleriGösterToolStripMenuItem.Text = "Tamamlanan İşleri Göster";
            this.tamamlananİşleriGösterToolStripMenuItem.Click += new System.EventHandler(this.MainListFilterClick);
            // 
            // tamamlananİşleriGöstermeToolStripMenuItem
            // 
            this.tamamlananİşleriGöstermeToolStripMenuItem.Checked = true;
            this.tamamlananİşleriGöstermeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tamamlananİşleriGöstermeToolStripMenuItem.Name = "tamamlananİşleriGöstermeToolStripMenuItem";
            this.tamamlananİşleriGöstermeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.tamamlananİşleriGöstermeToolStripMenuItem.Text = "Tamamlanan İşleri Gösterme";
            this.tamamlananİşleriGöstermeToolStripMenuItem.Click += new System.EventHandler(this.MainListFilterClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(823, 142);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(190, 401);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarBackup,
            this.toolStripBtnBackup});
            this.toolStrip1.Location = new System.Drawing.Point(209, 552);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripProgressBarBackup
            // 
            this.toolStripProgressBarBackup.Name = "toolStripProgressBarBackup";
            this.toolStripProgressBarBackup.Size = new System.Drawing.Size(100, 24);
            this.toolStripProgressBarBackup.Visible = false;
            // 
            // toolStripBtnBackup
            // 
            this.toolStripBtnBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripBtnBackup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnBackup.Image")));
            this.toolStripBtnBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnBackup.Name = "toolStripBtnBackup";
            this.toolStripBtnBackup.Size = new System.Drawing.Size(302, 22);
            this.toolStripBtnBackup.Text = "(Güncelleme Mevcut) Güncellemek İçin Lütfen Tıklayın!";
            this.toolStripBtnBackup.Visible = false;
            this.toolStripBtnBackup.Click += new System.EventHandler(this.toolStripBtnBackup_Click);
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
            this.contextMenuNotify.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(214, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 420);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(816, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 420);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // panelStat
            // 
            this.panelStat.BackColor = System.Drawing.Color.Transparent;
            this.panelStat.Controls.Add(this.splitter1);
            this.panelStat.Controls.Add(this.btnGeneralStat);
            this.panelStat.Controls.Add(this.lblRemainingWeek);
            this.panelStat.Controls.Add(this.lblCurrentDay);
            this.panelStat.Controls.Add(this.lblCurrentWeek);
            this.panelStat.Controls.Add(this.lblCurrentMonth);
            this.panelStat.Controls.Add(this.lblDate);
            this.panelStat.Controls.Add(this.lblDateStat);
            this.panelStat.Controls.Add(this.splitDate);
            this.panelStat.Controls.Add(this.lblTemperature);
            this.panelStat.Controls.Add(this.lblTemperatureStat);
            this.panelStat.Controls.Add(this.lblWeather);
            this.panelStat.Controls.Add(this.btnWeatherIcon);
            this.panelStat.Controls.Add(this.lblWeatherStat);
            this.panelStat.Controls.Add(this.splitter2);
            this.panelStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStat.Location = new System.Drawing.Point(209, 0);
            this.panelStat.Name = "panelStat";
            this.panelStat.Size = new System.Drawing.Size(818, 129);
            this.panelStat.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(227, 129);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(357, 129);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // btnGeneralStat
            // 
            this.btnGeneralStat.BackColor = System.Drawing.Color.Gray;
            this.btnGeneralStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneralStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneralStat.ForeColor = System.Drawing.Color.White;
            this.btnGeneralStat.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.btnGeneralStat.IconColor = System.Drawing.Color.White;
            this.btnGeneralStat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGeneralStat.Location = new System.Drawing.Point(227, 0);
            this.btnGeneralStat.Name = "btnGeneralStat";
            this.btnGeneralStat.Size = new System.Drawing.Size(357, 129);
            this.btnGeneralStat.TabIndex = 18;
            this.btnGeneralStat.Text = "Durumunuz : Stabil.";
            this.btnGeneralStat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGeneralStat.UseVisualStyleBackColor = false;
            // 
            // lblRemainingWeek
            // 
            this.lblRemainingWeek.AutoSize = true;
            this.lblRemainingWeek.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblRemainingWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingWeek.ForeColor = System.Drawing.Color.White;
            this.lblRemainingWeek.Location = new System.Drawing.Point(6, 104);
            this.lblRemainingWeek.Name = "lblRemainingWeek";
            this.lblRemainingWeek.Size = new System.Drawing.Size(185, 20);
            this.lblRemainingWeek.TabIndex = 15;
            this.lblRemainingWeek.Text = "Geriye 14 Hafta Kaldı.";
            // 
            // lblCurrentDay
            // 
            this.lblCurrentDay.AutoSize = true;
            this.lblCurrentDay.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblCurrentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentDay.ForeColor = System.Drawing.Color.White;
            this.lblCurrentDay.Location = new System.Drawing.Point(7, 81);
            this.lblCurrentDay.Name = "lblCurrentDay";
            this.lblCurrentDay.Size = new System.Drawing.Size(189, 17);
            this.lblCurrentDay.TabIndex = 14;
            this.lblCurrentDay.Text = "Perşembe Günündesiniz.";
            // 
            // lblCurrentWeek
            // 
            this.lblCurrentWeek.AutoSize = true;
            this.lblCurrentWeek.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblCurrentWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentWeek.ForeColor = System.Drawing.Color.White;
            this.lblCurrentWeek.Location = new System.Drawing.Point(5, 60);
            this.lblCurrentWeek.Name = "lblCurrentWeek";
            this.lblCurrentWeek.Size = new System.Drawing.Size(114, 17);
            this.lblCurrentWeek.TabIndex = 13;
            this.lblCurrentWeek.Text = "12. Haftasında";
            // 
            // lblCurrentMonth
            // 
            this.lblCurrentMonth.AutoSize = true;
            this.lblCurrentMonth.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblCurrentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrentMonth.ForeColor = System.Drawing.Color.White;
            this.lblCurrentMonth.Location = new System.Drawing.Point(7, 36);
            this.lblCurrentMonth.Name = "lblCurrentMonth";
            this.lblCurrentMonth.Size = new System.Drawing.Size(76, 17);
            this.lblCurrentMonth.TabIndex = 12;
            this.lblCurrentMonth.Text = "3. Ayında";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(72, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 20);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Tarih :";
            // 
            // lblDateStat
            // 
            this.lblDateStat.AutoSize = true;
            this.lblDateStat.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblDateStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateStat.Location = new System.Drawing.Point(8, 9);
            this.lblDateStat.Name = "lblDateStat";
            this.lblDateStat.Size = new System.Drawing.Size(64, 20);
            this.lblDateStat.TabIndex = 9;
            this.lblDateStat.Text = "Tarih :";
            // 
            // splitDate
            // 
            this.splitDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.splitDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitDate.Location = new System.Drawing.Point(0, 0);
            this.splitDate.Name = "splitDate";
            this.splitDate.Size = new System.Drawing.Size(227, 129);
            this.splitDate.TabIndex = 8;
            this.splitDate.TabStop = false;
            // 
            // lblTemperature
            // 
            this.lblTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTemperature.ContextMenuStrip = this.contextMenuWeather;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTemperature.ForeColor = System.Drawing.Color.White;
            this.lblTemperature.Location = new System.Drawing.Point(675, 108);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(116, 17);
            this.lblTemperature.TabIndex = 5;
            this.lblTemperature.Text = "Hava Durumu :";
            // 
            // contextMenuWeather
            // 
            this.contextMenuWeather.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şehirToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.contextMenuWeather.Name = "contextMenuWeather";
            this.contextMenuWeather.Size = new System.Drawing.Size(197, 48);
            // 
            // şehirToolStripMenuItem
            // 
            this.şehirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istanbultoolStripMenuItem1,
            this.ankaraToolStripMenuItem,
            this.izmirToolStripMenuItem,
            this.kocaeliToolStripMenuItem,
            this.antalyaToolStripMenuItem,
            this.bursaToolStripMenuItem,
            this.konyaToolStripMenuItem});
            this.şehirToolStripMenuItem.Name = "şehirToolStripMenuItem";
            this.şehirToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.şehirToolStripMenuItem.Text = "Şehir";
            // 
            // istanbultoolStripMenuItem1
            // 
            this.istanbultoolStripMenuItem1.Name = "istanbultoolStripMenuItem1";
            this.istanbultoolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.istanbultoolStripMenuItem1.Text = "İstanbul";
            // 
            // ankaraToolStripMenuItem
            // 
            this.ankaraToolStripMenuItem.CheckOnClick = true;
            this.ankaraToolStripMenuItem.Name = "ankaraToolStripMenuItem";
            this.ankaraToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ankaraToolStripMenuItem.Text = "Ankara";
            this.ankaraToolStripMenuItem.Click += new System.EventHandler(this.ankaraToolStripMenuItem_Click);
            // 
            // izmirToolStripMenuItem
            // 
            this.izmirToolStripMenuItem.Name = "izmirToolStripMenuItem";
            this.izmirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.izmirToolStripMenuItem.Text = "İzmir";
            this.izmirToolStripMenuItem.Click += new System.EventHandler(this.izmirToolStripMenuItem_Click);
            // 
            // kocaeliToolStripMenuItem
            // 
            this.kocaeliToolStripMenuItem.Name = "kocaeliToolStripMenuItem";
            this.kocaeliToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kocaeliToolStripMenuItem.Text = "Kocaeli";
            this.kocaeliToolStripMenuItem.Click += new System.EventHandler(this.kocaeliToolStripMenuItem_Click);
            // 
            // antalyaToolStripMenuItem
            // 
            this.antalyaToolStripMenuItem.Name = "antalyaToolStripMenuItem";
            this.antalyaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.antalyaToolStripMenuItem.Text = "Antalya";
            this.antalyaToolStripMenuItem.Click += new System.EventHandler(this.antalyaToolStripMenuItem_Click);
            // 
            // bursaToolStripMenuItem
            // 
            this.bursaToolStripMenuItem.Name = "bursaToolStripMenuItem";
            this.bursaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.bursaToolStripMenuItem.Text = "Bursa";
            this.bursaToolStripMenuItem.Click += new System.EventHandler(this.bursaToolStripMenuItem_Click);
            // 
            // konyaToolStripMenuItem
            // 
            this.konyaToolStripMenuItem.Name = "konyaToolStripMenuItem";
            this.konyaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.konyaToolStripMenuItem.Text = "Konya";
            this.konyaToolStripMenuItem.Click += new System.EventHandler(this.konyaToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.yenileToolStripMenuItem.Text = "Hava Durumunu Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // lblTemperatureStat
            // 
            this.lblTemperatureStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemperatureStat.AutoSize = true;
            this.lblTemperatureStat.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTemperatureStat.ContextMenuStrip = this.contextMenuWeather;
            this.lblTemperatureStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTemperatureStat.Location = new System.Drawing.Point(621, 109);
            this.lblTemperatureStat.Name = "lblTemperatureStat";
            this.lblTemperatureStat.Size = new System.Drawing.Size(57, 13);
            this.lblTemperatureStat.TabIndex = 4;
            this.lblTemperatureStat.Text = "Sıcaklık :";
            // 
            // lblWeather
            // 
            this.lblWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeather.AutoSize = true;
            this.lblWeather.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblWeather.ContextMenuStrip = this.contextMenuWeather;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeather.ForeColor = System.Drawing.Color.White;
            this.lblWeather.Location = new System.Drawing.Point(674, 88);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(102, 15);
            this.lblWeather.TabIndex = 3;
            this.lblWeather.Text = "Hava Durumu :";
            // 
            // btnWeatherIcon
            // 
            this.btnWeatherIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWeatherIcon.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWeatherIcon.ContextMenuStrip = this.contextMenuWeather;
            this.btnWeatherIcon.FlatAppearance.BorderSize = 0;
            this.btnWeatherIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeatherIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWeatherIcon.ForeColor = System.Drawing.Color.White;
            this.btnWeatherIcon.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnWeatherIcon.IconColor = System.Drawing.Color.Black;
            this.btnWeatherIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWeatherIcon.IconSize = 100;
            this.btnWeatherIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeatherIcon.Location = new System.Drawing.Point(584, 0);
            this.btnWeatherIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnWeatherIcon.Name = "btnWeatherIcon";
            this.btnWeatherIcon.Size = new System.Drawing.Size(230, 90);
            this.btnWeatherIcon.TabIndex = 2;
            this.btnWeatherIcon.Text = "İstanbul";
            this.btnWeatherIcon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWeatherIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWeatherIcon.UseVisualStyleBackColor = false;
            // 
            // lblWeatherStat
            // 
            this.lblWeatherStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeatherStat.AutoSize = true;
            this.lblWeatherStat.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblWeatherStat.ContextMenuStrip = this.contextMenuWeather;
            this.lblWeatherStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeatherStat.Location = new System.Drawing.Point(583, 88);
            this.lblWeatherStat.Name = "lblWeatherStat";
            this.lblWeatherStat.Size = new System.Drawing.Size(91, 13);
            this.lblWeatherStat.TabIndex = 1;
            this.lblWeatherStat.Text = "Hava Durumu :";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.RoyalBlue;
            this.splitter2.ContextMenuStrip = this.contextMenuWeather;
            this.splitter2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(584, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(234, 129);
            this.splitter2.TabIndex = 7;
            this.splitter2.TabStop = false;
            // 
            // timerBackupStat
            // 
            this.timerBackupStat.Tick += new System.EventHandler(this.timerBackupStat_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1027, 577);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelStat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hakediş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextWorkOrderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuNotify.ResumeLayout(false);
            this.panelStat.ResumeLayout(false);
            this.panelStat.PerformLayout();
            this.contextMenuWeather.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnAddNewWorkOrder;
        private FontAwesome.Sharp.IconButton btnUpdateWorkOrder;
        public System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnCreateWorkReport;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconButton btnAddPayment;
        private FontAwesome.Sharp.IconButton btnOptions;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem uygulamayıKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamayıKapatToolStripMenuItem1;
        private FontAwesome.Sharp.IconButton btnUpdatePayment;
        private System.Windows.Forms.ContextMenuStrip contextWorkOrderList;
        private System.Windows.Forms.ToolStripMenuItem tamamlananİşleriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamamlananİşleriGöstermeToolStripMenuItem;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelStat;
        private System.Windows.Forms.Label lblWeatherStat;
        private FontAwesome.Sharp.IconButton btnWeatherIcon;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblTemperatureStat;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitDate;
        private System.Windows.Forms.Label lblDateStat;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCurrentDay;
        private System.Windows.Forms.Label lblCurrentWeek;
        private System.Windows.Forms.Label lblCurrentMonth;
        private System.Windows.Forms.Label lblRemainingWeek;
        private System.Windows.Forms.Splitter splitter1;
        private FontAwesome.Sharp.IconButton btnGeneralStat;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarBackup;
        private System.Windows.Forms.ToolStripButton toolStripBtnBackup;
        private System.Windows.Forms.Timer timerBackupStat;
        private System.Windows.Forms.ContextMenuStrip contextMenuWeather;
        private System.Windows.Forms.ToolStripMenuItem şehirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ankaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kocaeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antalyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istanbultoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
    }
}

