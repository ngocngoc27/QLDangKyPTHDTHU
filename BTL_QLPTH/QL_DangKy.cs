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
    public partial class QL_DangKy : MetroFramework.Forms.MetroForm
    {
        PhieuDK_BUS data = new PhieuDK_BUS();
        PhieuDK_DTO x = new PhieuDK_DTO();
        string flag = "";
        public QL_DangKy()
        {
            InitializeComponent();
        }
        private void QL_DangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMAYTINH.PhongThucHanh' table. You can move, or remove it, as needed.
            this.phongThucHanhTableAdapter1.Fill(this.dataSetMAYTINH.PhongThucHanh);
            // TODO: This line of code loads data into the 'qLPTHDataSet.CanBo' table. You can move, or remove it, as needed.
            this.canBoTableAdapter.Fill(this.qLPTHDataSet.CanBo);
            // TODO: This line of code loads data into the 'qLPTHDataSet.LopHP' table. You can move, or remove it, as needed.
            this.lopHPTableAdapter.Fill(this.qLPTHDataSet.LopHP);
            // TODO: This line of code loads data into the 'qLPTHDataSet.PhongThucHanh' table. You can move, or remove it, as needed.
            this.phongThucHanhTableAdapter.Fill(this.qLPTHDataSet.PhongThucHanh);

            dataPhieuDK.DataSource = data.GetList();
            txtSophieu.Enabled = false;
            dateTime.Enabled = false;
            cboTietBD.Enabled = false;
            cboSotiet.Enabled = false;
            cboMaphong.Enabled = false;
            cboMaCB.Enabled = false;
            cboIDHP.Enabled = false;
            checkDK.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dataPhieuDK.Columns[0].HeaderText = "Số phiếu";
            dataPhieuDK.Columns[1].HeaderText = "Ngày đăng ký";
            dataPhieuDK.Columns[2].HeaderText = "Tiết bắt đầu";
            dataPhieuDK.Columns[3].HeaderText = "Số tiết";
            dataPhieuDK.Columns[4].HeaderText = "Mã phòng";
            dataPhieuDK.Columns[5].HeaderText = "ID_HP";
            dataPhieuDK.Columns[6].HeaderText = "Mã cán bộ";
            dataPhieuDK.Columns[7].HeaderText = "Tình trạng đăng ký";
            dataPhieuDK.Columns[0].Width = 95;
            dataPhieuDK.Columns[1].Width = 125;
            dataPhieuDK.Columns[2].Width = 120;
            dataPhieuDK.Columns[3].Width = 80;
            dataPhieuDK.Columns[4].Width = 100;
            dataPhieuDK.Columns[5].Width = 110;
            dataPhieuDK.Columns[6].Width = 105;
            dataPhieuDK.Columns[7].Width = 200;
        }

        private void dataPhieuDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataPhieuDK.CurrentRow.Index;
            txtSophieu.Text = dataPhieuDK[0, chiso].Value.ToString();
            dateTime.Value = (DateTime)dataPhieuDK[1, chiso].Value;
            cboTietBD.Text = dataPhieuDK[2, chiso].Value.ToString();
            cboSotiet.Text = dataPhieuDK[3, chiso].Value.ToString();
            cboMaphong.Text = dataPhieuDK[4, chiso].Value.ToString();
            cboIDHP.Text = dataPhieuDK[5, chiso].Value.ToString();
            cboMaCB.Text = dataPhieuDK[6, chiso].Value.ToString();
            string z = dataPhieuDK[7, chiso].Value.ToString();
            if (z == "Đã duyệt")
                checkDK.Checked = true;
            else
                checkDK.Checked = false;
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dataPhieuDK.DataSource = data.GetList();
            }
            else
                dataPhieuDK.DataSource = data.TimKiem(txtTimkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataPhieuDK.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            dateTime.Enabled = true;
            cboTietBD.Enabled = true;
            cboSotiet.Enabled = true;
            cboMaphong.Enabled = true;
            cboMaCB.Enabled = true;
            cboIDHP.Enabled = true;
            checkDK.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtSophieu.Clear();
            cboMaCB.SelectedIndex = 0;
            cboIDHP.SelectedIndex = 0;
            cboTietBD.SelectedIndex = 0;
            cboSotiet.SelectedIndex = 0;
            cboMaphong.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            dateTime.Enabled = true;
            cboTietBD.Enabled = true;
            cboSotiet.Enabled = true;
            cboMaphong.Enabled = true;
            cboMaCB.Enabled = true;
            cboIDHP.Enabled = true;
            checkDK.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void ResetGridview()
        {
            dateTime.Enabled = false;
            cboTietBD.Enabled = false;
            cboSotiet.Enabled = false;
            cboMaphong.Enabled = false;
            cboMaCB.Enabled = false;
            cboIDHP.Enabled = false;
            checkDK.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtSophieu.Clear();
            cboMaCB.SelectedIndex = 0;
            cboIDHP.SelectedIndex = 0;
            cboTietBD.SelectedIndex = 0;
            cboSotiet.SelectedIndex = 0;
            cboMaphong.SelectedIndex = 0;

            int iCount = 0;
            for (int i = 0; i <= dataPhieuDK.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSophieu.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    data.Xoa(txtSophieu.Text);
                }
                MessageBox.Show("Xóa thành công!!!", "Thông báo");
                QL_DangKy_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (dateTime.Value.Date < DateTime.Today.Date)
                {
                    MessageBox.Show("Ngày đăng ký không hợp lệ!!! Ngày đăng ký phải lớn hơn hoặc là ngày hiện tại.", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((cboTietBD.Text == "5") || (cboTietBD.Text == "10"))
                {
                    MessageBox.Show("Tiết bắt đầu không được là tiết cuối!!!", "LƯU Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Random rd = new Random();
                    x.SoPhieuDK = Convert.ToString(rd.Next(1, 1000));
                    x.NgayDangKy = dateTime.Value.Date;
                    x.TietBD = Convert.ToInt32(cboTietBD.Text);
                    x.SoTiet = Convert.ToInt32(cboSotiet.Text);
                    x.MaPhong = cboMaphong.Text;
                    x.ID_HP = Convert.ToInt32(cboIDHP.Text);
                    x.MaCB = cboMaCB.Text;
                    if (checkDK.Checked == true)
                        x.TinhTrangDK = "Đã duyệt";
                    else
                        x.TinhTrangDK = "Chưa duyệt";

                    int check = data.Them(x);
                    if (check == 0)
                        MessageBox.Show("Lỗi! Bỏ trống.");
                    else if (check == -1)
                        MessageBox.Show("Lỗi! Trùng mã.");
                    else
                        MessageBox.Show("Thêm thành công!!!", "Thông báo");

                    QL_DangKy_Load(sender, e);
                    ResetGridview();
                }                   
            }
            else if (flag == "edit")
            {
                if (dateTime.Value.Date < DateTime.Today.Date)
                {
                    MessageBox.Show("Ngày đăng ký không hợp lệ!!! \nNgày đăng ký phải lớn hơn hoặc là ngày hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    x.SoPhieuDK = txtSophieu.Text;
                    x.NgayDangKy = dateTime.Value.Date;
                    x.TietBD = Convert.ToInt32(cboTietBD.Text);
                    x.SoTiet = Convert.ToInt32(cboSotiet.Text);
                    x.MaPhong = cboMaphong.Text;
                    x.ID_HP = Convert.ToInt32(cboIDHP.Text);
                    x.MaCB = cboMaCB.Text;
                    if (checkDK.Checked == true)
                        x.TinhTrangDK = "Đã duyệt";
                    else
                        x.TinhTrangDK = "Chưa duyệt";

                    if (!data.Sua(x))
                        MessageBox.Show("Lỗi! Bỏ trống.");
                    else
                        MessageBox.Show("Sửa thành công!!!", "Thông báo");
                    QL_DangKy_Load(sender, e);
                    ResetGridview();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void QL_DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void linkHocPhan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HocPhan frm = new HocPhan();
            frm.Show();
        }
    }
}
