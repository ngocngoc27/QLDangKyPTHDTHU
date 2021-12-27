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
    public partial class LopHP : MetroFramework.Forms.MetroForm
    {
        LopHP_BUS hp = new LopHP_BUS();
        LopHP_DTO x = new LopHP_DTO();
        string flag = "";
        public LopHP()
        {
            InitializeComponent();
        }
        private void LopHP_Load(object sender, EventArgs e)
        {
            dataLopHP.DataSource = hp.GetList();
            txtID.Enabled = false;
            txtMaHP.Enabled = false;
            txtTenHP.Enabled = false;
            cboSoTC.Enabled = false;
            cboHocki.Enabled = false;
            txtNienkhoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            cboSoTC.SelectedIndex = 0;
            cboHocki.SelectedIndex = 0;
            dataLopHP.Columns[0].HeaderText = "ID_HP";
            dataLopHP.Columns[1].HeaderText = "Mã HP";
            dataLopHP.Columns[2].HeaderText = "Tên HP";
            dataLopHP.Columns[3].HeaderText = "Số tín chỉ";
            dataLopHP.Columns[4].HeaderText = "Học kì";
            dataLopHP.Columns[5].HeaderText = "Niên khóa";
            dataLopHP.Columns[0].Width = 90;
            dataLopHP.Columns[1].Width = 120;
            dataLopHP.Columns[2].Width = 300;
            dataLopHP.Columns[3].Width = 120;
            dataLopHP.Columns[4].Width = 95;
            dataLopHP.Columns[5].Width = 130;

            int iCount = 0;
            for (int i = 0; i <= dataLopHP.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            txtMaHP.Enabled = true;
            txtTenHP.Enabled = true;
            cboSoTC.Enabled = true;
            cboHocki.Enabled = true;
            txtNienkhoa.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtID.Clear();
            txtTenHP.Clear();
            txtMaHP.Clear();
            txtNienkhoa.Clear();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            txtMaHP.Enabled = true;
            txtTenHP.Enabled = true;
            cboSoTC.Enabled = true;
            cboHocki.Enabled = true;
            txtNienkhoa.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    hp.Xoa(txtID.Text);
                }
                MessageBox.Show("Xóa thành công!!!", "Thông báo");
                LopHP_Load(sender, e);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (txtNienkhoa.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập niên khóa!", "Thông báo");
                }
                else
                {
                    Random rd = new Random();
                    x.ID_HP = Convert.ToInt32(rd.Next(1, 1000));

                    x.MaHP = txtMaHP.Text;
                    x.TenHP = txtTenHP.Text;
                    x.SoTC = Convert.ToInt32(cboSoTC.Text);
                    x.HocKi = cboHocki.Text;
                    x.NienKhoa = txtNienkhoa.Text;

                    int check = hp.Them(x);
                    if (check == 0)
                        MessageBox.Show("Lỗi! Bỏ trống.");
                    else if (check == -1)
                        MessageBox.Show("Lỗi! Trùng mã.");
                    else
                        MessageBox.Show("Thêm thành công!!!", "Thông báo");

                    LopHP_Load(sender, e);
                    ResetGridview();
                }
            }
            else if (flag == "edit")
            {
                if (txtNienkhoa.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập niên khóa!", "Thông báo");
                }
                else
                {
                    x.ID_HP = Convert.ToInt32(txtID.Text);
                    x.MaHP = txtMaHP.Text;
                    x.TenHP = txtTenHP.Text;
                    x.SoTC = Convert.ToInt32(cboSoTC.Text);
                    x.HocKi = cboHocki.Text;
                    x.NienKhoa = txtNienkhoa.Text;

                    if (!hp.Sua(x))
                        MessageBox.Show("Lỗi! Bỏ trống.");
                    else
                        MessageBox.Show("Sửa thành công!!!", "Thông báo");
                    LopHP_Load(sender, e);
                    ResetGridview();
                }
            }
        }
        private void ResetGridview()
        {
            txtMaHP.Enabled = false;
            txtTenHP.Enabled = false;
            cboSoTC.Enabled = false;
            cboHocki.Enabled = false;
            txtNienkhoa.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtID.Clear();
            txtTenHP.Clear();
            txtMaHP.Clear();
            txtNienkhoa.Clear();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }
        private void dataLopHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataLopHP.CurrentRow.Index;
            txtID.Text = dataLopHP[0, chiso].Value.ToString();
            txtMaHP.Text = dataLopHP[1, chiso].Value.ToString();
            txtTenHP.Text = dataLopHP[2, chiso].Value.ToString();
            cboSoTC.Text = dataLopHP[3, chiso].Value.ToString();
            cboHocki.Text = dataLopHP[4, chiso].Value.ToString();
            txtNienkhoa.Text = dataLopHP[5, chiso].Value.ToString();
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dataLopHP.DataSource = hp.GetList();
            }
            else
                dataLopHP.DataSource = hp.TimKiem(txtTimkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataLopHP.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void LopHP_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
