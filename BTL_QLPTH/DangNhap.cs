using BTL_QLPTH.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLPTH
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        NguoiDung_BUS data = new NguoiDung_BUS();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (data.DangNhap(txtTaikhoan.Text, hashed.Text) == true)
            {
                HeThong f = new HeThong(txtTaikhoan.Text);                
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
        public string Md5hash(byte[] value)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(value);
                return Convert.ToBase64String(hash);
            }
        }
        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtMatkhau.Text.ToString());
            hashed.Text = Md5hash(passtohash);
        }

        private void MoMK_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '*')
            {
                AnMK.BringToFront();
                txtMatkhau.PasswordChar = '\0';
            }
        }

        private void AnMK_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '\0')
            {
                MoMK.BringToFront();
                txtMatkhau.PasswordChar = '*';
            }
        }

        private void btnDangKyTK_Click(object sender, EventArgs e)
        {
            DangKyTaiKhoan frm = new DangKyTaiKhoan();
            frm.Show();
            this.Hide();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
