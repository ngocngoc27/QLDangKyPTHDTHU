using BTL_QLPTH.BUS;
using BTL_QLPTH.DTO;
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
    public partial class DangKyTaiKhoan : MetroFramework.Forms.MetroForm
    {
        NguoiDung_BUS data = new NguoiDung_BUS();
        public DangKyTaiKhoan()
        {
            InitializeComponent();
        }
        public string Md5hash(byte[] value)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(value);
                return Convert.ToBase64String(hash);
            }
        }

        private void btnDangkyTK_Click(object sender, EventArgs e)
        {
            NguoiDung_DTO x = new NguoiDung_DTO();
            x.TenTaiKhoan = txtTaikhoan.Text;
            x.MatKhau = hashed.Text;

            int check = data.Them(x);
            if (check == 0)
            {
                MessageBox.Show("Lỗi bỏ trống tên đăng nhập!", "Thông báo");
            }
            else if (check == -1)
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo");
            }
            else if ((txtMatkhau.Text.Length == 0)|| (txtNhaplai.Text.Length == 0))
            {
                MessageBox.Show("Không được bỏ trống!", "Thông báo");
            }
            else if (txtMatkhau.Text != txtNhaplai.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đăng ký thành công!!!", "Thông báo");
            }
        }

        private void txtNhaplai_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtMatkhau.Text.ToString());
            hashed.Text = Md5hash(passtohash);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            frm.Show();
            this.Hide();
        }

        private void DangKyTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
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
    }
}
