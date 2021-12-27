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
    public partial class PhieuThongKe : MetroFramework.Forms.MetroForm
    {
        PhieuTK_BUS data = new PhieuTK_BUS();
        PhieuTK_DTO x = new PhieuTK_DTO();
        string flag = "";
        public PhieuThongKe()
        {
            InitializeComponent();
        }
        private void PhieuThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMAYTINH.MayTinh' table. You can move, or remove it, as needed.
            this.mayTinhTableAdapter1.Fill(this.dataSetMAYTINH.MayTinh);
            // TODO: This line of code loads data into the 'qLPTHDataSet.MayTinh' table. You can move, or remove it, as needed.
            this.mayTinhTableAdapter.Fill(this.qLPTHDataSet.MayTinh);
            // TODO: This line of code loads data into the 'qLPTHDataSet.CanBo' table. You can move, or remove it, as needed.
            this.canBoTableAdapter.Fill(this.qLPTHDataSet.CanBo);

            dataPhieuTK.DataSource = data.GetList();
            txtSophieu.Enabled = false;
            dateTime.Enabled = false;
            txtGhichu.Enabled = false;
            cboMaCB.Enabled = false;
            cboMaMT.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dataPhieuTK.Columns[0].HeaderText = "Số phiếu";
            dataPhieuTK.Columns[1].HeaderText = "Ngày lập";
            dataPhieuTK.Columns[2].HeaderText = "Ghi chú";
            dataPhieuTK.Columns[3].HeaderText = "Mã cán bộ";
            dataPhieuTK.Columns[4].HeaderText = "Mã máy tính";
            dataPhieuTK.Columns[0].Width = 100;
            dataPhieuTK.Columns[1].Width = 120;
            dataPhieuTK.Columns[2].Width = 430;
            dataPhieuTK.Columns[3].Width = 120;
            dataPhieuTK.Columns[4].Width = 130;

            int iCount = 0;
            for (int i = 0; i <= dataPhieuTK.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void dataPhieuTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataPhieuTK.CurrentRow.Index;
            txtSophieu.Text = dataPhieuTK[0, chiso].Value.ToString();
            dateTime.Value = (DateTime)dataPhieuTK[1, chiso].Value;
            txtGhichu.Text = dataPhieuTK[2, chiso].Value.ToString();
            cboMaCB.Text = dataPhieuTK[3, chiso].Value.ToString();
            cboMaMT.Text = dataPhieuTK[4, chiso].Value.ToString();
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dataPhieuTK.DataSource = data.GetList();
            }
            else
                dataPhieuTK.DataSource = data.TimKiem(txtTimkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataPhieuTK.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            txtGhichu.Enabled = true;
            cboMaCB.Enabled = true;
            cboMaMT.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtSophieu.Clear();
            txtGhichu.Clear();
            cboMaCB.SelectedIndex = 0;
            cboMaMT.SelectedIndex = 0;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            txtGhichu.Enabled = true;
            cboMaCB.Enabled = true;
            cboMaMT.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
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
                PhieuThongKe_Load(sender, e);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                Random rd = new Random();
                x.SoPhieuTK = Convert.ToString(rd.Next(1, 1000));
                x.NgayLap = dateTime.Value.Date;
                x.GhiChu = txtGhichu.Text;
                x.MaCB = cboMaCB.Text;
                x.MaMT = cboMaMT.Text;

                int check = data.Them(x);
                if (check == 0)
                    MessageBox.Show("Lỗi! Bỏ trống.");
                else if (check == -1)
                    MessageBox.Show("Lỗi! Trùng mã.");
                else
                    MessageBox.Show("Thêm thành công!!!", "Thông báo");

                PhieuThongKe_Load(sender, e);
                ResetGridview();
            }
            else if (flag == "edit")
            {
                x.SoPhieuTK = txtSophieu.Text;
                x.NgayLap = dateTime.Value.Date;
                x.GhiChu = txtGhichu.Text;
                x.MaCB = cboMaCB.Text;
                x.MaMT = cboMaMT.Text;

                if (!data.Sua(x))
                    MessageBox.Show("Lỗi! Bỏ trống.");
                else
                    MessageBox.Show("Sửa thành công!!!", "Thông báo");
                PhieuThongKe_Load(sender, e);
                ResetGridview();
            }
        }
        private void ResetGridview()
        {
            txtGhichu.Enabled = false;
            cboMaCB.Enabled = false;
            cboMaMT.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtSophieu.Clear();
            txtGhichu.Clear();
            cboMaCB.SelectedIndex = 0;
            cboMaMT.SelectedIndex = 0;

            int iCount = 0;
            for (int i = 0; i <= dataPhieuTK.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }
        private void PhieuThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
