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
    public partial class DoiMK : MetroFramework.Forms.MetroForm
    {
        MatKhau_BUS data = new MatKhau_BUS();
        NguoiDung_DTO x = new NguoiDung_DTO();
        private string tenDN;
        public DoiMK(string _tenDN)
        {
            InitializeComponent();
            tenDN = _tenDN;
        }
        private void ResetGridview()
        {
            txtMK_cu.Clear();
            txtMK_moi.Clear();
            txtNhaplai.Clear();
        }
        public string Md5hash(byte[] value)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(value);
                return Convert.ToBase64String(hash);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMK_cu.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông báo");
                return;
            }
            else if (txtMK_moi.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo");
                return;
            }
            else if (txtMK_moi.Text != txtNhaplai.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp!", "Thông báo");
                return;
            }
            else if (txtNhaplai.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới!", "Thông báo");
                return;
            }          
            if (data.CheckExist(tenDN, MKC.Text) == true)
            {
                x.TenTaiKhoan = tenDN;
                x.MatKhau = MK.Text;
                data.DoiMatKhau(x);
                MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông báo");
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!!!", "Thông báo");
            }
        }
        private void txtMK_cu_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtMK_cu.Text.ToString());
            MKC.Text = Md5hash(passtohash);
        }
        private void txtNhaplai_TextChanged(object sender, EventArgs e)
        {
            byte[] passtohash = System.Text.Encoding.UTF8.GetBytes(txtMK_moi.Text.ToString());
            MK.Text = Md5hash(passtohash);
        }
        private void MoMK_Click(object sender, EventArgs e)
        {
            if (txtMK_moi.PasswordChar == '*')
            {
                AnMK.BringToFront();
                txtMK_moi.PasswordChar = '\0';
            }
        }

        private void AnMK_Click(object sender, EventArgs e)
        {
            if (txtMK_moi.PasswordChar == '\0')
            {
                MoMK.BringToFront();
                txtMK_moi.PasswordChar = '*';
            }
        }

        private void DoiMK_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
