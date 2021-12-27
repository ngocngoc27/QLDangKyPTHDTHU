namespace BTL_QLPTH
{
    partial class MayTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MayTinh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboMaphong = new System.Windows.Forms.ComboBox();
            this.phongThucHanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPTHDataSet = new BTL_QLPTH.QLPTHDataSet();
            this.cboTinhtrang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.txtMaMT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.btnNhapDL = new System.Windows.Forms.Button();
            this.btnMofile = new System.Windows.Forms.Button();
            this.txtHieumay = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.txtTS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phongThucHanhTableAdapter = new BTL_QLPTH.QLPTHDataSetTableAdapters.PhongThucHanhTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dataMT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.phongThucHanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMT)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaphong
            // 
            this.cboMaphong.DataSource = this.phongThucHanhBindingSource;
            this.cboMaphong.DisplayMember = "MaPhong";
            this.cboMaphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaphong.Enabled = false;
            this.cboMaphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMaphong.Font = new System.Drawing.Font("Cambria", 12F);
            this.cboMaphong.FormattingEnabled = true;
            this.cboMaphong.Location = new System.Drawing.Point(132, 189);
            this.cboMaphong.Name = "cboMaphong";
            this.cboMaphong.Size = new System.Drawing.Size(138, 27);
            this.cboMaphong.TabIndex = 28;
            this.cboMaphong.ValueMember = "MaPhong";
            // 
            // phongThucHanhBindingSource
            // 
            this.phongThucHanhBindingSource.DataMember = "PhongThucHanh";
            this.phongThucHanhBindingSource.DataSource = this.qLPTHDataSet;
            // 
            // qLPTHDataSet
            // 
            this.qLPTHDataSet.DataSetName = "QLPTHDataSet";
            this.qLPTHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboTinhtrang
            // 
            this.cboTinhtrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhtrang.Enabled = false;
            this.cboTinhtrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTinhtrang.Font = new System.Drawing.Font("Cambria", 12F);
            this.cboTinhtrang.FormattingEnabled = true;
            this.cboTinhtrang.Items.AddRange(new object[] {
            "Tốt ",
            "Hư hỏng"});
            this.cboTinhtrang.Location = new System.Drawing.Point(132, 149);
            this.cboTinhtrang.Name = "cboTinhtrang";
            this.cboTinhtrang.Size = new System.Drawing.Size(138, 27);
            this.cboTinhtrang.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(11, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nhà sản xuất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(11, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tình trạng máy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(11, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hiệu máy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã máy";
            // 
            // txtNSX
            // 
            this.txtNSX.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSX.Location = new System.Drawing.Point(132, 109);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(138, 26);
            this.txtNSX.TabIndex = 4;
            // 
            // txtMaMT
            // 
            this.txtMaMT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMT.Location = new System.Drawing.Point(132, 29);
            this.txtMaMT.Name = "txtMaMT";
            this.txtMaMT.Size = new System.Drawing.Size(138, 26);
            this.txtMaMT.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtHieumay);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboMaphong);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.cboTinhtrang);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNSX);
            this.groupBox1.Controls.Add(this.txtMaMT);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 232);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox2.Controls.Add(this.txtFilename);
            this.groupBox2.Controls.Add(this.cboSheet);
            this.groupBox2.Controls.Add(this.btnNhapDL);
            this.groupBox2.Controls.Add(this.btnMofile);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 13F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(281, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 114);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÊM DỮ LIỆU TỪ FILE EXCEL";
            // 
            // txtFilename
            // 
            this.txtFilename.Enabled = false;
            this.txtFilename.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilename.Location = new System.Drawing.Point(12, 31);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(181, 26);
            this.txtFilename.TabIndex = 7;
            // 
            // cboSheet
            // 
            this.cboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSheet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(12, 73);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(181, 27);
            this.cboSheet.TabIndex = 8;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // btnNhapDL
            // 
            this.btnNhapDL.BackColor = System.Drawing.Color.White;
            this.btnNhapDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapDL.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDL.Location = new System.Drawing.Point(199, 71);
            this.btnNhapDL.Name = "btnNhapDL";
            this.btnNhapDL.Size = new System.Drawing.Size(148, 30);
            this.btnNhapDL.TabIndex = 28;
            this.btnNhapDL.Text = "NHẬP DỮ LIỆU";
            this.btnNhapDL.UseVisualStyleBackColor = false;
            this.btnNhapDL.Click += new System.EventHandler(this.btnNhapDL_Click);
            // 
            // btnMofile
            // 
            this.btnMofile.BackColor = System.Drawing.Color.White;
            this.btnMofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMofile.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMofile.Location = new System.Drawing.Point(198, 29);
            this.btnMofile.Name = "btnMofile";
            this.btnMofile.Size = new System.Drawing.Size(149, 30);
            this.btnMofile.TabIndex = 27;
            this.btnMofile.Text = "MỞ FILE";
            this.btnMofile.UseVisualStyleBackColor = false;
            this.btnMofile.Click += new System.EventHandler(this.btnMofile_Click);
            // 
            // txtHieumay
            // 
            this.txtHieumay.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHieumay.Location = new System.Drawing.Point(132, 69);
            this.txtHieumay.Name = "txtHieumay";
            this.txtHieumay.Size = new System.Drawing.Size(138, 26);
            this.txtHieumay.TabIndex = 30;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(281, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(11, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã phòng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(430, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 52;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BTL_QLPTH.Properties.Resources.search__1_;
            this.pictureBox2.Location = new System.Drawing.Point(430, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(445, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Gõ nội dung tìm kiếm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtTimkiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimkiem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.ForeColor = System.Drawing.Color.White;
            this.txtTimkiem.Location = new System.Drawing.Point(461, 189);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(169, 19);
            this.txtTimkiem.TabIndex = 49;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // txtTS
            // 
            this.txtTS.Enabled = false;
            this.txtTS.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTS.Location = new System.Drawing.Point(632, 472);
            this.txtTS.Name = "txtTS";
            this.txtTS.Size = new System.Drawing.Size(29, 27);
            this.txtTS.TabIndex = 54;
            this.txtTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(518, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "Tổng số máy tính";
            // 
            // phongThucHanhTableAdapter
            // 
            this.phongThucHanhTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Location = new System.Drawing.Point(672, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 455);
            this.panel2.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_QLPTH.Properties.Resources.dthu;
            this.pictureBox1.Location = new System.Drawing.Point(1, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(21, 261);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 43);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(21, 151);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 43);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(21, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 43);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "SỬA";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(21, 316);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 43);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(21, 371);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 43);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dataMT
            // 
            this.dataMT.AllowUserToAddRows = false;
            this.dataMT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMT.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataMT.Location = new System.Drawing.Point(13, 293);
            this.dataMT.Name = "dataMT";
            this.dataMT.Size = new System.Drawing.Size(648, 173);
            this.dataMT.TabIndex = 55;
            this.dataMT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMT_CellClick);
            // 
            // MayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 507);
            this.Controls.Add(this.dataMT);
            this.Controls.Add(this.txtTS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MayTinh";
            this.Text = "QUẢN LÝ THÔNG TIN MÁY TÍNH CỦA CÁC PHÒNG THỰC HÀNH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MayTinh_FormClosing);
            this.Load += new System.EventHandler(this.MayTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phongThucHanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPTHDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMaphong;
        private System.Windows.Forms.ComboBox cboTinhtrang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.TextBox txtMaMT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHieumay;
        private System.Windows.Forms.Label label3;
        private QLPTHDataSet qLPTHDataSet;
        private System.Windows.Forms.BindingSource phongThucHanhBindingSource;
        private QLPTHDataSetTableAdapters.PhongThucHanhTableAdapter phongThucHanhTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTS;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.Button btnNhapDL;
        private System.Windows.Forms.Button btnMofile;
        private System.Windows.Forms.DataGridView dataMT;
    }
}