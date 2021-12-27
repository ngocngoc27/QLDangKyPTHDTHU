using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BTL_QLPTH.DAL;
using DevExpress.XtraSplashScreen;
using System.Drawing.Drawing2D;
using System.Threading;

namespace BTL_QLPTH
{
    public partial class HeThong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string tenDN;
        public HeThong(string _tenDN)
        {
            InitializeComponent();            
            tenDN = _tenDN;
            try
            {
                DataProvider _dt = new DataProvider();
                DataTable dt = _dt.GetData("select * from TaiKhoan where TaiKhoan.TenTaiKhoan = '" + tenDN + "'");
                string gt = dt.Rows[0]["QuyenDN"].ToString();
                if (gt == "1") //users - giảng viên
                {
                    grQLDangky.Visible = false;
                    grQLcanbo.Visible = false; 
                    grQLPTH.Visible = false;
                    grbaocao.Visible = false;
                    barTracuuTTmaytinh.Visibility = BarItemVisibility.Never;
                }
                else if (gt == "0") //admin - cán bộ quản lý
                {
                    grPhieuDK.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }          
        }
        private bool Check_Form(string name)
        {
            bool kt = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    kt = true;
                    break;
                }
            }
            return kt;
        }
        private void Active_Form(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void barDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("DoiMK"))
            {
                DoiMK f = new DoiMK(tenDN);
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("DoiMK");
        }
        private void barDangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Hide();
        }
        private void barTracuuTTDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("TraCuuTTDangKy"))
            {
                TraCuuTTDangKy f = new TraCuuTTDangKy();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("TraCuuTTDangKy");
        }
        private void barTracuuTTmaytinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("TraCuuTTThongKe"))
            {
                TraCuuTTThongKe f = new TraCuuTTThongKe();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("TraCuuTTThongKe");
        }

        private void barQLCanbo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("CanBo"))
            {
                CanBo f = new CanBo();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("CanBo");
        }

        private void barQLLopHP_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("LopHP"))
            {
                LopHP f = new LopHP();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("LopHP");
        }

        private void barQLPTH_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("PhongTH"))
            {
                PhongTH f = new PhongTH();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("PhongTH");
        }

        private void barQLMaytinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("MayTinh"))
            {
                MayTinh f = new MayTinh();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("MayTinh");
        }

        private void barPhieuDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("PhieuDangKy"))
            {
                PhieuDangKy f = new PhieuDangKy();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("PhieuDangKy");
        }

        private void barQLDangky_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("QL_DangKy"))
            {
                QL_DangKy f = new QL_DangKy();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("QL_DangKy");
        }

        private void barPhieuThongke_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("PhieuThongKe"))
            {
                PhieuThongKe f = new PhieuThongKe();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("PhieuThongKe");
        }

        private void barBaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!Check_Form("BaoCao"))
            {
                BaoCao f = new BaoCao();
                f.MdiParent = this;
                f.Show();
            }
            else
                Active_Form("BaoCao");
        }

        private void HeThong_Load(object sender, EventArgs e)
        {
            barNgayThangNam.Caption = DateTime.Now.ToString();
        }
    }
}