
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportGraphImage = new FontAwesome.Sharp.IconButton();
            this.btnExportPDF = new FontAwesome.Sharp.IconButton();
            this.btnExtractExcell = new FontAwesome.Sharp.IconButton();
            this.btnSearchWorkOrder = new FontAwesome.Sharp.IconButton();
            this.btnAddNewWorkOrder = new FontAwesome.Sharp.IconButton();
            this.dateTimeDetailExpired = new System.Windows.Forms.DateTimePicker();
            this.lblDetailExpiredDate = new System.Windows.Forms.Label();
            this.dateTimeDetailFirst = new System.Windows.Forms.DateTimePicker();
            this.lblDetailFirstDate = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageWorkOrder = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePayment = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.saveFileDiaChart1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageWorkOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPagePayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnExportGraphImage);
            this.panel1.Controls.Add(this.btnExportPDF);
            this.panel1.Controls.Add(this.btnExtractExcell);
            this.panel1.Controls.Add(this.btnSearchWorkOrder);
            this.panel1.Controls.Add(this.btnAddNewWorkOrder);
            this.panel1.Controls.Add(this.dateTimeDetailExpired);
            this.panel1.Controls.Add(this.lblDetailExpiredDate);
            this.panel1.Controls.Add(this.dateTimeDetailFirst);
            this.panel1.Controls.Add(this.lblDetailFirstDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 550);
            this.panel1.TabIndex = 1;
            // 
            // btnExportGraphImage
            // 
            this.btnExportGraphImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportGraphImage.FlatAppearance.BorderSize = 0;
            this.btnExportGraphImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportGraphImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExportGraphImage.ForeColor = System.Drawing.Color.White;
            this.btnExportGraphImage.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.btnExportGraphImage.IconColor = System.Drawing.Color.White;
            this.btnExportGraphImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportGraphImage.Location = new System.Drawing.Point(0, 250);
            this.btnExportGraphImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportGraphImage.Name = "btnExportGraphImage";
            this.btnExportGraphImage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.btnExportGraphImage.Size = new System.Drawing.Size(255, 56);
            this.btnExportGraphImage.TabIndex = 27;
            this.btnExportGraphImage.Text = "Grafik Çıktısı Al";
            this.btnExportGraphImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportGraphImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportGraphImage.UseVisualStyleBackColor = true;
            this.btnExportGraphImage.Click += new System.EventHandler(this.btnExportGraphImage_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportPDF.Enabled = false;
            this.btnExportPDF.FlatAppearance.BorderSize = 0;
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnExportPDF.IconColor = System.Drawing.Color.White;
            this.btnExportPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportPDF.Location = new System.Drawing.Point(0, 194);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.btnExportPDF.Size = new System.Drawing.Size(255, 56);
            this.btnExportPDF.TabIndex = 26;
            this.btnExportPDF.Text = "PDF Çıktısı Al";
            this.btnExportPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Visible = false;
            // 
            // btnExtractExcell
            // 
            this.btnExtractExcell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtractExcell.Enabled = false;
            this.btnExtractExcell.FlatAppearance.BorderSize = 0;
            this.btnExtractExcell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractExcell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExtractExcell.ForeColor = System.Drawing.Color.White;
            this.btnExtractExcell.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExtractExcell.IconColor = System.Drawing.Color.White;
            this.btnExtractExcell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExtractExcell.Location = new System.Drawing.Point(0, 138);
            this.btnExtractExcell.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExtractExcell.Name = "btnExtractExcell";
            this.btnExtractExcell.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.btnExtractExcell.Size = new System.Drawing.Size(255, 56);
            this.btnExtractExcell.TabIndex = 25;
            this.btnExtractExcell.Text = "Excell Çıktısı Al";
            this.btnExtractExcell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtractExcell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtractExcell.UseVisualStyleBackColor = true;
            this.btnExtractExcell.Click += new System.EventHandler(this.btnExtractExcell_Click);
            // 
            // btnSearchWorkOrder
            // 
            this.btnSearchWorkOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchWorkOrder.FlatAppearance.BorderSize = 0;
            this.btnSearchWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchWorkOrder.ForeColor = System.Drawing.Color.White;
            this.btnSearchWorkOrder.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchWorkOrder.IconColor = System.Drawing.Color.White;
            this.btnSearchWorkOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchWorkOrder.Location = new System.Drawing.Point(0, 82);
            this.btnSearchWorkOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchWorkOrder.Name = "btnSearchWorkOrder";
            this.btnSearchWorkOrder.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.btnSearchWorkOrder.Size = new System.Drawing.Size(255, 56);
            this.btnSearchWorkOrder.TabIndex = 24;
            this.btnSearchWorkOrder.Text = "İş Emirlerini Bul";
            this.btnSearchWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchWorkOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchWorkOrder.UseVisualStyleBackColor = true;
            this.btnSearchWorkOrder.Click += new System.EventHandler(this.btnSearchWorkOrder_Click);
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
            this.btnAddNewWorkOrder.Location = new System.Drawing.Point(0, 494);
            this.btnAddNewWorkOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewWorkOrder.Name = "btnAddNewWorkOrder";
            this.btnAddNewWorkOrder.Size = new System.Drawing.Size(255, 56);
            this.btnAddNewWorkOrder.TabIndex = 23;
            this.btnAddNewWorkOrder.Text = "Sayfayı Kapat";
            this.btnAddNewWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewWorkOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewWorkOrder.UseVisualStyleBackColor = true;
            this.btnAddNewWorkOrder.Click += new System.EventHandler(this.btnAddNewWorkOrder_Click);
            // 
            // dateTimeDetailExpired
            // 
            this.dateTimeDetailExpired.CustomFormat = "dd-MM-yyyy";
            this.dateTimeDetailExpired.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimeDetailExpired.Enabled = false;
            this.dateTimeDetailExpired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDetailExpired.Location = new System.Drawing.Point(0, 61);
            this.dateTimeDetailExpired.Name = "dateTimeDetailExpired";
            this.dateTimeDetailExpired.Size = new System.Drawing.Size(255, 21);
            this.dateTimeDetailExpired.TabIndex = 20;
            this.dateTimeDetailExpired.ValueChanged += new System.EventHandler(this.DateTimeChanged);
            // 
            // lblDetailExpiredDate
            // 
            this.lblDetailExpiredDate.AutoSize = true;
            this.lblDetailExpiredDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailExpiredDate.ForeColor = System.Drawing.Color.White;
            this.lblDetailExpiredDate.Location = new System.Drawing.Point(0, 41);
            this.lblDetailExpiredDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailExpiredDate.Name = "lblDetailExpiredDate";
            this.lblDetailExpiredDate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDetailExpiredDate.Size = new System.Drawing.Size(131, 20);
            this.lblDetailExpiredDate.TabIndex = 19;
            this.lblDetailExpiredDate.Text = "Bitiş Tarihi Seçiniz:";
            // 
            // dateTimeDetailFirst
            // 
            this.dateTimeDetailFirst.CustomFormat = "dd-MM-yyyy";
            this.dateTimeDetailFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimeDetailFirst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDetailFirst.Location = new System.Drawing.Point(0, 20);
            this.dateTimeDetailFirst.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dateTimeDetailFirst.Name = "dateTimeDetailFirst";
            this.dateTimeDetailFirst.Size = new System.Drawing.Size(255, 21);
            this.dateTimeDetailFirst.TabIndex = 18;
            this.dateTimeDetailFirst.ValueChanged += new System.EventHandler(this.DateTimeChanged);
            // 
            // lblDetailFirstDate
            // 
            this.lblDetailFirstDate.AutoSize = true;
            this.lblDetailFirstDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailFirstDate.ForeColor = System.Drawing.Color.White;
            this.lblDetailFirstDate.Location = new System.Drawing.Point(0, 0);
            this.lblDetailFirstDate.Margin = new System.Windows.Forms.Padding(2);
            this.lblDetailFirstDate.Name = "lblDetailFirstDate";
            this.lblDetailFirstDate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDetailFirstDate.Size = new System.Drawing.Size(170, 20);
            this.lblDetailFirstDate.TabIndex = 17;
            this.lblDetailFirstDate.Text = "Başlangıç Tarihi Seçiniz :";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 208);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "İş Emirleri";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(735, 320);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // tabPageWorkOrder
            // 
            this.tabPageWorkOrder.Controls.Add(this.chart1);
            this.tabPageWorkOrder.Controls.Add(this.dataGridView1);
            this.tabPageWorkOrder.Location = new System.Drawing.Point(4, 24);
            this.tabPageWorkOrder.Name = "tabPageWorkOrder";
            this.tabPageWorkOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkOrder.Size = new System.Drawing.Size(741, 510);
            this.tabPageWorkOrder.TabIndex = 0;
            this.tabPageWorkOrder.Text = "İş Emirleri";
            this.tabPageWorkOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 199);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageWorkOrder);
            this.tabControl1.Controls.Add(this.tabPagePayment);
            this.tabControl1.Location = new System.Drawing.Point(257, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 538);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPagePayment
            // 
            this.tabPagePayment.Controls.Add(this.chart2);
            this.tabPagePayment.Controls.Add(this.dataGridView2);
            this.tabPagePayment.Location = new System.Drawing.Point(4, 24);
            this.tabPagePayment.Name = "tabPagePayment";
            this.tabPagePayment.Size = new System.Drawing.Size(741, 510);
            this.tabPagePayment.TabIndex = 1;
            this.tabPagePayment.Text = "Ödemeler";
            this.tabPagePayment.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 205);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "İş Emirleri";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Ödemeler";
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(735, 302);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(741, 199);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.Visible = false;
            // 
            // WorkOrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkOrderReportForm";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkOrderDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkOrderReportForm_FormClosing);
            this.Load += new System.EventHandler(this.WorkOrderReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageWorkOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAddNewWorkOrder;
        private System.Windows.Forms.DateTimePicker dateTimeDetailExpired;
        private System.Windows.Forms.Label lblDetailExpiredDate;
        private System.Windows.Forms.DateTimePicker dateTimeDetailFirst;
        private System.Windows.Forms.Label lblDetailFirstDate;
        private FontAwesome.Sharp.IconButton btnSearchWorkOrder;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPageWorkOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePayment;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private FontAwesome.Sharp.IconButton btnExportGraphImage;
        private FontAwesome.Sharp.IconButton btnExportPDF;
        private FontAwesome.Sharp.IconButton btnExtractExcell;
        private System.Windows.Forms.SaveFileDialog saveFileDiaChart1;
    }
}