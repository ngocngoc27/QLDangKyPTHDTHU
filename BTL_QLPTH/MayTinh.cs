using BTL_QLPTH.BUS;
using BTL_QLPTH.DTO;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace BTL_QLPTH
{
    public partial class MayTinh : MetroFramework.Forms.MetroForm
    {
        MayTinh_BUS data = new MayTinh_BUS();
        MayTinh_DTO x = new MayTinh_DTO();
        string flag = "";
        public MayTinh()
        {
            InitializeComponent();
        } 
        private void MayTinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPTHDataSet.PhongThucHanh' table. You can move, or remove it, as needed.
            this.phongThucHanhTableAdapter.Fill(this.qLPTHDataSet.PhongThucHanh);

            dataMT.DataSource = data.GetList();
            txtMaMT.Enabled = false;
            txtHieumay.Enabled = false;
            cboMaphong.Enabled = false;
            txtNSX.Enabled = false;
            cboTinhtrang.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            cboTinhtrang.SelectedIndex = 0;
            cboMaphong.SelectedIndex = 0;
            dataMT.Columns[0].HeaderText = "Mã MT";
            dataMT.Columns[1].HeaderText = "Hiệu máy";
            dataMT.Columns[2].HeaderText = "Nhà sản xuất";
            dataMT.Columns[3].HeaderText = "Tình trạng máy";
            dataMT.Columns[4].HeaderText = "Mã phòng";
            dataMT.Columns[0].Width = 100;
            dataMT.Columns[1].Width = 145;
            dataMT.Columns[2].Width = 150;
            dataMT.Columns[3].Width = 150;
            dataMT.Columns[4].Width = 150;

            int iCount = 0;
            for (int i = 0; i <= dataMT.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            txtHieumay.Enabled = true;
            txtNSX.Enabled = true;
            cboMaphong.Enabled = true;
            cboTinhtrang.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaMT.Clear();
            txtMaMT.Clear();
            txtHieumay.Clear();
            txtNSX.Clear();
            cboTinhtrang.SelectedIndex = 0;
            cboMaphong.SelectedIndex = 0;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            txtHieumay.Enabled = true;
            txtNSX.Enabled = true;
            cboMaphong.Enabled = true;
            cboTinhtrang.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMT.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    data.Xoa(txtMaMT.Text);
                }
                MessageBox.Show("Xóa thành công!!!", "Thông báo");
                MayTinh_Load(sender, e);
            }
        }
        private void ResetGridview()
        {
            txtMaMT.Enabled = false;
            txtMaMT.Enabled = false;
            txtHieumay.Enabled = false;
            cboMaphong.Enabled = false;
            txtNSX.Enabled = false;
            cboTinhtrang.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaMT.Clear();
            txtMaMT.Clear();
            txtHieumay.Clear();
            txtNSX.Clear();
            cboTinhtrang.SelectedIndex = 0;
            cboMaphong.SelectedIndex = 0;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }
        private void dataMT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataMT.CurrentRow.Index;
            txtMaMT.Text = dataMT[0, chiso].Value.ToString();
            txtHieumay.Text = dataMT[1, chiso].Value.ToString();
            txtNSX.Text = dataMT[2, chiso].Value.ToString();
            cboTinhtrang.Text = dataMT[3, chiso].Value.ToString();
            cboMaphong.Text = dataMT[4, chiso].Value.ToString();
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dataMT.DataSource = data.GetList();
            }
            else
                dataMT.DataSource = data.TimKiem(txtTimkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataMT.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                int count = 0;
                count = dataMT.Rows.Count;
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dataMT.Rows[count - 1].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txtMaMT.Text = "MT00" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaMT.Text = "MT0" + (chuoi2 + 1).ToString(); 

                x.MaMT = txtMaMT.Text;
                x.HieuMay = txtHieumay.Text;
                x.NhaSX = txtNSX.Text;
                x.TinhTrangMay = cboTinhtrang.Text;
                x.MaPhong = cboMaphong.Text;

                int check = data.Them(x);
                if (check == 0)
                    MessageBox.Show("Lỗi! Bỏ trống.");
                else if (check == -1)
                    MessageBox.Show("Lỗi! Trùng mã.");
                else
                    MessageBox.Show("Thêm thành công!!!", "Thông báo");

                MayTinh_Load(sender, e);
                ResetGridview();
            }
            else if (flag == "edit")
            {
                x.MaMT = txtMaMT.Text;
                x.HieuMay = txtHieumay.Text;
                x.NhaSX = txtNSX.Text;
                x.TinhTrangMay = cboTinhtrang.Text;
                x.MaPhong = cboMaphong.Text;

                if (!data.Sua(x))
                    MessageBox.Show("Lỗi! Bỏ trống.");
                else
                    MessageBox.Show("Sửa thành công!!!", "Thông báo");
                MayTinh_Load(sender, e);
                ResetGridview();
            }
        }

        private void MayTinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /*----------------------------------------------------------------*/
        DataTableCollection tableCollection;
        private void btnMofile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            btnHuy.Enabled = true;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                cboSheet.Items.Add(table.TableName);//them sheet vao combo
                            }
                        }
                    }
                }
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                List<MayTinh_DTO> y = new List<MayTinh_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    x.MaMT = dt.Rows[i]["MaMT"].ToString();
                    x.HieuMay = dt.Rows[i]["HieuMay"].ToString();
                    x.NhaSX = dt.Rows[i]["NhaSX"].ToString();
                    x.TinhTrangMay = dt.Rows[i]["TinhTrangMay"].ToString();
                    x.MaPhong = dt.Rows[i]["MaPhong"].ToString();
                    y.Add(x);
                }
                dataMT.DataSource = y;
            }
        }

        private void btnNhapDL_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog = QLPTH; Integrated Security = True";
                DapperPlusManager.Entity<MayTinh_DTO>().Table("MayTinh");
                List<MayTinh_DTO> y = dataMT.DataSource as List<MayTinh_DTO>;
                if (y != null)
                {
                    using (IDbConnection db = new SqlConnection(constr))
                    {
                        db.BulkInsert(y);
                    }
                }
                MessageBox.Show("Thêm dữ liệu thành công!!!", "Thông báo");
                MayTinh_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
