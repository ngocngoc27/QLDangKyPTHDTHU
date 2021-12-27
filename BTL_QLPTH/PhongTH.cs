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
    public partial class PhongTH : MetroFramework.Forms.MetroForm
    {
        PhongTH_BUS data = new PhongTH_BUS();
        PhongTH_DTO x = new PhongTH_DTO();
        string flag = "";
        public PhongTH()
        {
            InitializeComponent();
        }
        private void PhongTH_Load(object sender, EventArgs e)
        {
            dataPhongTH.DataSource = data.GetList();
            txtMaphong.Enabled = false;
            txtVitri.Enabled = false;
            cboTinhtrang.Enabled = false;
            txtSoluong.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dataPhongTH.Columns[0].HeaderText = "Mã phòng";
            dataPhongTH.Columns[1].HeaderText = "Vị trí";
            dataPhongTH.Columns[2].HeaderText = "Tình trạng phòng";
            dataPhongTH.Columns[3].HeaderText = "Số lượng máy";
            dataPhongTH.Columns[0].Width = 150;
            dataPhongTH.Columns[1].Width = 260;
            dataPhongTH.Columns[2].Width = 160;
            dataPhongTH.Columns[3].Width = 150;

            int iCount = 0;
            for (int i = 0; i <= dataPhongTH.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void dataPhongTH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataPhongTH.CurrentRow.Index;
            txtMaphong.Text = dataPhongTH[0, chiso].Value.ToString();
            txtVitri.Text = dataPhongTH[1, chiso].Value.ToString();
            cboTinhtrang.Text = dataPhongTH[2, chiso].Value.ToString();
            txtSoluong.Text = dataPhongTH[3, chiso].Value.ToString();
        }
        private void ResetGridview()
        {
            txtMaphong.Enabled = false;
            txtVitri.Enabled = false;
            cboTinhtrang.Enabled = false;
            txtSoluong.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaphong.Clear();
            txtVitri.Clear();
            txtSoluong.Clear();
            cboTinhtrang.SelectedIndex = 0;
            int iCount = 0;
            for (int i = 0; i <= dataPhongTH.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            txtMaphong.Enabled = true;
            txtVitri.Enabled = true;
            cboTinhtrang.Enabled = true;
            txtSoluong.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaphong.Clear();
            txtVitri.Clear();
            txtSoluong.Clear();
            cboTinhtrang.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            txtMaphong.Enabled = true;
            txtVitri.Enabled = true;
            cboTinhtrang.Enabled = true;
            txtSoluong.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    data.Xoa(txtMaphong.Text);
                }
                MessageBox.Show("Xóa thành công!!!", "Thông báo");
                PhongTH_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                x.MaPhong = txtMaphong.Text;
                x.ViTri = txtVitri.Text;
                x.TinhTrangPhong = cboTinhtrang.Text;
                x.SoLuongMay = Convert.ToInt32(txtSoluong.Text);

                int check = data.Them(x);
                if (check == 0)
                    MessageBox.Show("Lỗi! Bỏ trống.");
                else if (check == -1)
                    MessageBox.Show("Lỗi! Trùng mã.");
                else
                    MessageBox.Show("Thêm thành công!!!", "Thông báo");

                PhongTH_Load(sender, e);
                ResetGridview();
            }
            else if (flag == "edit")
            {
                x.MaPhong = txtMaphong.Text;
                x.ViTri = txtVitri.Text;
                x.TinhTrangPhong = cboTinhtrang.Text;
                x.SoLuongMay = Convert.ToInt32(txtSoluong.Text);

                if (!data.Sua(x))
                    MessageBox.Show("Lỗi! Bỏ trống.");
                else
                    MessageBox.Show("Sửa thành công!!!", "Thông báo");
                PhongTH_Load(sender, e);
                ResetGridview();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dataPhongTH.DataSource = data.GetList();
            }
            else
                dataPhongTH.DataSource = data.TimKiem(txtTimkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataPhongTH.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }

        private void PhongTH_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
