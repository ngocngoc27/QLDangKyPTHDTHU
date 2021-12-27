namespace BTL_QLPTH
{
    partial class BaoCao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PhieuDangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReport = new BTL_QLPTH.DataSetReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PhieuDangKyTableAdapter = new BTL_QLPTH.DataSetReportTableAdapters.PhieuDangKyTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatbc = new System.Windows.Forms.Button();
            this.dateTimeKT = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBD = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuDangKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PhieuDangKyBindingSource
            // 
            this.PhieuDangKyBindingSource.DataMember = "PhieuDangKy";
            this.PhieuDangKyBindingSource.DataSource = this.DataSetReport;
            // 
            // DataSetReport
            // 
            this.DataSetReport.DataSetName = "DataSetReport";
            this.DataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PhieuDangKyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BTL_QLPTH.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 167);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 311);
            this.reportViewer1.TabIndex = 0;
            // 
            // PhieuDangKyTableAdapter
            // 
            this.PhieuDangKyTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXuatbc);
            this.panel1.Controls.Add(this.dateTimeKT);
            this.panel1.Controls.Add(this.dateTimeBD);
            this.panel1.Location = new System.Drawing.Point(-2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 123);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_QLPTH.Properties.Resources.Balance_icon;
            this.pictureBox1.Location = new System.Drawing.Point(417, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(365, 97);
            this.label3.TabIndex = 9;
            this.label3.Text = "BÁO CÁO DANH SÁCH ĐĂNG KÝ \r\nPHÒNG THỰC HÀNH DTHU \r\nTHEO MỐC THỜI GIAN NHẤT ĐỊNH";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(534, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thời gian kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(536, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thời gian bắt đầu";
            // 
            // btnXuatbc
            // 
            this.btnXuatbc.BackColor = System.Drawing.Color.Navy;
            this.btnXuatbc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatbc.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.btnXuatbc.ForeColor = System.Drawing.Color.White;
            this.btnXuatbc.Location = new System.Drawing.Point(828, 25);
            this.btnXuatbc.Name = "btnXuatbc";
            this.btnXuatbc.Size = new System.Drawing.Size(156, 70);
            this.btnXuatbc.TabIndex = 6;
            this.btnXuatbc.Text = "XUẤT BÁO CÁO";
            this.btnXuatbc.UseVisualStyleBackColor = false;
            this.btnXuatbc.Click += new System.EventHandler(this.btnXuatbc_Click);
            // 
            // dateTimeKT
            // 
            this.dateTimeKT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeKT.Location = new System.Drawing.Point(683, 71);
            this.dateTimeKT.Name = "dateTimeKT";
            this.dateTimeKT.Size = new System.Drawing.Size(124, 26);
            this.dateTimeKT.TabIndex = 5;
            // 
            // dateTimeBD
            // 
            this.dateTimeBD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBD.Location = new System.Drawing.Point(683, 24);
            this.dateTimeBD.Name = "dateTimeBD";
            this.dateTimeBD.Size = new System.Drawing.Size(124, 26);
            this.dateTimeBD.TabIndex = 4;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaoCao_FormClosing);
            this.Load += new System.EventHandler(this.BaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuDangKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PhieuDangKyBindingSource;
        private DataSetReport DataSetReport;
        private DataSetReportTableAdapters.PhieuDangKyTableAdapter PhieuDangKyTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatbc;
        private System.Windows.Forms.DateTimePicker dateTimeKT;
        private System.Windows.Forms.DateTimePicker dateTimeBD;
    }
}