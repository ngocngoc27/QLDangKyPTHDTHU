namespace BTL_QLPTH
{
    partial class HeThong
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BTL_QLPTH.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThong));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.barTracuuTTDK = new DevExpress.XtraBars.BarButtonItem();
            this.barTracuuTTmaytinh = new DevExpress.XtraBars.BarButtonItem();
            this.barQLCanbo = new DevExpress.XtraBars.BarButtonItem();
            this.barQLLopHP = new DevExpress.XtraBars.BarButtonItem();
            this.barQLPTH = new DevExpress.XtraBars.BarButtonItem();
            this.barQLMaytinh = new DevExpress.XtraBars.BarButtonItem();
            this.barPhieuDK = new DevExpress.XtraBars.BarButtonItem();
            this.barQLDangky = new DevExpress.XtraBars.BarButtonItem();
            this.barPhieuThongke = new DevExpress.XtraBars.BarButtonItem();
            this.barBaoCao = new DevExpress.XtraBars.BarButtonItem();
            this.barNgayThangNam = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grDoiMk = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grTracuuDK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grQLcanbo = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grQLPTH = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grPhieuDK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grQLDangky = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grthongke = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grbaocao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 300;
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.White;
            this.ribbon.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 33, 35, 33);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barDoiMK,
            this.barStaticItem1,
            this.barButtonItem1,
            this.barDangxuat,
            this.barTracuuTTDK,
            this.barTracuuTTmaytinh,
            this.barQLCanbo,
            this.barQLLopHP,
            this.barQLPTH,
            this.barQLMaytinh,
            this.barPhieuDK,
            this.barQLDangky,
            this.barPhieuThongke,
            this.barBaoCao,
            this.barNgayThangNam});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 385;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbon.Size = new System.Drawing.Size(934, 132);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barDoiMK
            // 
            this.barDoiMK.Caption = "Đổi mật khẩu";
            this.barDoiMK.Id = 1;
            this.barDoiMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barDoiMK.ImageOptions.Image")));
            this.barDoiMK.Name = "barDoiMK";
            this.barDoiMK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDoiMK_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barDangxuat
            // 
            this.barDangxuat.Caption = "Đăng xuất";
            this.barDangxuat.Id = 4;
            this.barDangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barDangxuat.ImageOptions.Image")));
            this.barDangxuat.Name = "barDangxuat";
            this.barDangxuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barDangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDangxuat_ItemClick);
            // 
            // barTracuuTTDK
            // 
            this.barTracuuTTDK.Caption = "Thông tin đăng ký PTH";
            this.barTracuuTTDK.Id = 5;
            this.barTracuuTTDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barTracuuTTDK.ImageOptions.Image")));
            this.barTracuuTTDK.Name = "barTracuuTTDK";
            this.barTracuuTTDK.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barTracuuTTDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barTracuuTTDK_ItemClick);
            // 
            // barTracuuTTmaytinh
            // 
            this.barTracuuTTmaytinh.Caption = "Thông tin máy tính hư hỏng";
            this.barTracuuTTmaytinh.Id = 6;
            this.barTracuuTTmaytinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barTracuuTTmaytinh.ImageOptions.Image")));
            this.barTracuuTTmaytinh.Name = "barTracuuTTmaytinh";
            this.barTracuuTTmaytinh.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barTracuuTTmaytinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barTracuuTTmaytinh_ItemClick);
            // 
            // barQLCanbo
            // 
            this.barQLCanbo.Caption = "Quản lý Cán bộ";
            this.barQLCanbo.Id = 7;
            this.barQLCanbo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barQLCanbo.ImageOptions.Image")));
            this.barQLCanbo.Name = "barQLCanbo";
            this.barQLCanbo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barQLCanbo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQLCanbo_ItemClick);
            // 
            // barQLLopHP
            // 
            this.barQLLopHP.Caption = "Quản lý Lớp học phần";
            this.barQLLopHP.Id = 8;
            this.barQLLopHP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barQLLopHP.ImageOptions.Image")));
            this.barQLLopHP.Name = "barQLLopHP";
            this.barQLLopHP.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barQLLopHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQLLopHP_ItemClick);
            // 
            // barQLPTH
            // 
            this.barQLPTH.Caption = "Quản lý Phòng thực hành";
            this.barQLPTH.Id = 9;
            this.barQLPTH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barQLPTH.ImageOptions.Image")));
            this.barQLPTH.Name = "barQLPTH";
            this.barQLPTH.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barQLPTH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQLPTH_ItemClick);
            // 
            // barQLMaytinh
            // 
            this.barQLMaytinh.Caption = "Quản lý Máy tính";
            this.barQLMaytinh.Id = 10;
            this.barQLMaytinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barQLMaytinh.ImageOptions.Image")));
            this.barQLMaytinh.Name = "barQLMaytinh";
            this.barQLMaytinh.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barQLMaytinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQLMaytinh_ItemClick);
            // 
            // barPhieuDK
            // 
            this.barPhieuDK.Caption = "Đăng ký phòng thực hành";
            this.barPhieuDK.Id = 11;
            this.barPhieuDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barPhieuDK.ImageOptions.Image")));
            this.barPhieuDK.Name = "barPhieuDK";
            this.barPhieuDK.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barPhieuDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barPhieuDK_ItemClick);
            // 
            // barQLDangky
            // 
            this.barQLDangky.Caption = "Quản lý đăng ký PTH";
            this.barQLDangky.Id = 12;
            this.barQLDangky.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barQLDangky.ImageOptions.Image")));
            this.barQLDangky.Name = "barQLDangky";
            this.barQLDangky.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barQLDangky.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQLDangky_ItemClick);
            // 
            // barPhieuThongke
            // 
            this.barPhieuThongke.Caption = "Phiếu thống kê máy tính hư hỏng";
            this.barPhieuThongke.Id = 13;
            this.barPhieuThongke.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barPhieuThongke.ImageOptions.Image")));
            this.barPhieuThongke.Name = "barPhieuThongke";
            this.barPhieuThongke.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barPhieuThongke.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barPhieuThongke_ItemClick);
            // 
            // barBaoCao
            // 
            this.barBaoCao.Caption = "Báo cáo danh sách đăng ký PTH";
            this.barBaoCao.Id = 14;
            this.barBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBaoCao.ImageOptions.Image")));
            this.barBaoCao.Name = "barBaoCao";
            this.barBaoCao.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBaoCao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBaoCao_ItemClick);
            // 
            // barNgayThangNam
            // 
            this.barNgayThangNam.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barNgayThangNam.Caption = "barStaticItem2";
            this.barNgayThangNam.Id = 15;
            this.barNgayThangNam.Name = "barNgayThangNam";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grDoiMk});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HỆ THỐNG";
            // 
            // grDoiMk
            // 
            this.grDoiMk.ItemLinks.Add(this.barDoiMK);
            this.grDoiMk.ItemLinks.Add(this.barDangxuat);
            this.grDoiMk.Name = "grDoiMk";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grTracuuDK});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "TRA CỨU";
            // 
            // grTracuuDK
            // 
            this.grTracuuDK.ItemLinks.Add(this.barTracuuTTDK);
            this.grTracuuDK.ItemLinks.Add(this.barTracuuTTmaytinh);
            this.grTracuuDK.Name = "grTracuuDK";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grQLcanbo,
            this.grQLPTH,
            this.grPhieuDK,
            this.grQLDangky});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "DANH MỤC";
            // 
            // grQLcanbo
            // 
            this.grQLcanbo.ItemLinks.Add(this.barQLCanbo);
            this.grQLcanbo.ItemLinks.Add(this.barQLLopHP, true);
            this.grQLcanbo.Name = "grQLcanbo";
            // 
            // grQLPTH
            // 
            this.grQLPTH.ItemLinks.Add(this.barQLPTH);
            this.grQLPTH.ItemLinks.Add(this.barQLMaytinh, true);
            this.grQLPTH.Name = "grQLPTH";
            // 
            // grPhieuDK
            // 
            this.grPhieuDK.ItemLinks.Add(this.barPhieuDK);
            this.grPhieuDK.Name = "grPhieuDK";
            // 
            // grQLDangky
            // 
            this.grQLDangky.ItemLinks.Add(this.barQLDangky);
            this.grQLDangky.Name = "grQLDangky";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grthongke,
            this.grbaocao});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // grthongke
            // 
            this.grthongke.ItemLinks.Add(this.barPhieuThongke);
            this.grthongke.Name = "grthongke";
            // 
            // grbaocao
            // 
            this.grbaocao.ItemLinks.Add(this.barBaoCao);
            this.grbaocao.Name = "grbaocao";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barNgayThangNam);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 424);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(934, 41);
            // 
            // HeThong
            // 
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(934, 465);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Cambria", 9F);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("HeThong.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HeThong";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "HỆ THỐNG QUẢN LÝ ĐĂNG KÝ PHÒNG THỰC HÀNH DTHU";
            this.TransparencyKey = System.Drawing.Color.Aquamarine;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HeThong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grDoiMk;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barDoiMK;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barDangxuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grTracuuDK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grQLcanbo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grthongke;
        private DevExpress.XtraBars.BarButtonItem barTracuuTTDK;
        private DevExpress.XtraBars.BarButtonItem barTracuuTTmaytinh;
        private DevExpress.XtraBars.BarButtonItem barQLCanbo;
        private DevExpress.XtraBars.BarButtonItem barQLLopHP;
        private DevExpress.XtraBars.BarButtonItem barQLPTH;
        private DevExpress.XtraBars.BarButtonItem barQLMaytinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grQLPTH;
        private DevExpress.XtraBars.BarButtonItem barPhieuDK;
        private DevExpress.XtraBars.BarButtonItem barQLDangky;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grPhieuDK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grQLDangky;
        private DevExpress.XtraBars.BarButtonItem barPhieuThongke;
        private DevExpress.XtraBars.BarButtonItem barBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grbaocao;
        private DevExpress.XtraBars.BarStaticItem barNgayThangNam;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
    }
}