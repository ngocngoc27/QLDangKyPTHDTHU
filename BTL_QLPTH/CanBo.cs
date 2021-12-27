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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace BTL_QLPTH
{    
    public partial class CanBo : MetroFramework.Forms.MetroForm
    {
        CanBo_BUS cb = new CanBo_BUS();
        CanBo_DTO x = new CanBo_DTO();
        string flag = "";

        public CanBo()
        {
            InitializeComponent();
        }
        private void CanBo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPTHDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.qLPTHDataSet.Khoa);
            dataCanBo.DataSource = cb.GetList();

            dataCanBo.DataSource = cb.GetList();
            txtMaCB.Enabled = false;
            txtHoTen.Enabled = false;
            radioNam.Enabled = false;
            radioNu.Enabled = false;
            dateTimeNS.Enabled = false;
            txtChucVu.Enabled = false;            
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
            cboMaKhoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dataCanBo.Columns[0].HeaderText = "Mã CB";
            dataCanBo.Columns[1].HeaderText = "Họ tên";
            dataCanBo.Columns[2].HeaderText = "Giới tính";
            dataCanBo.Columns[3].HeaderText = "Năm sinh";
            dataCanBo.Columns[4].HeaderText = "Chức vụ";
            dataCanBo.Columns[5].HeaderText = "Địa chỉ";
            dataCanBo.Columns[6].HeaderText = "SĐT";
            dataCanBo.Columns[7].HeaderText = "Email";
            dataCanBo.Columns[8].HeaderText = "Mã Khoa";
            dataCanBo.Columns[0].Width = 100;
            dataCanBo.Columns[1].Width = 150;
            dataCanBo.Columns[2].Width = 100;
            dataCanBo.Columns[3].Width = 150;
            dataCanBo.Columns[4].Width = 150;
            dataCanBo.Columns[5].Width = 150;
            dataCanBo.Columns[6].Width = 150;
            dataCanBo.Columns[7].Width = 150;
            dataCanBo.Columns[8].Width = 100;

            int iCount = 0;
            for (int i = 0; i <= dataCanBo.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            txtHoTen.Enabled = true;
            radioNam.Enabled = true;
            radioNu.Enabled = true;
            dateTimeNS.Enabled = true;
            txtChucVu.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            cboMaKhoa.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtHoTen.Clear();
            txtMaCB.Clear();
            txtChucVu.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            radioNam.Checked = false;
            radioNu.Checked = false;         
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = "edit";
            txtHoTen.Enabled = true;
            radioNam.Enabled = true;
            radioNu.Enabled = true;
            dateTimeNS.Enabled = true;
            txtChucVu.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtSDT.Enabled = true;
            cboMaKhoa.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaCB.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc muốn xoá không?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cb.Xoa(txtMaCB.Text);
                }
                MessageBox.Show("Xóa thành công!!!", "Thông báo");
                CanBo_Load(sender, e);
            }
        }
        private void dataCanBo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = dataCanBo.CurrentRow.Index;
            txtMaCB.Text = dataCanBo[0, chiso].Value.ToString();
            txtHoTen.Text = dataCanBo[1, chiso].Value.ToString();
            //radio button
            string gt = dataCanBo[2, chiso].Value.ToString();
            if (gt == "Nam")
                radioNam.Checked = true;
            else
                radioNu.Checked = true;
            dateTimeNS.Value = (DateTime)dataCanBo[3, chiso].Value;
            txtChucVu.Text = dataCanBo[4, chiso].Value.ToString();
            txtDiaChi.Text = dataCanBo[5, chiso].Value.ToString();
            txtSDT.Text = dataCanBo[6, chiso].Value.ToString();
            txtEmail.Text = dataCanBo[7, chiso].Value.ToString();
            cboMaKhoa.Text = dataCanBo[8, chiso].Value.ToString();
        }
        private void ResetGridview()
        {
            txtHoTen.Enabled = false;
            radioNam.Enabled = false;
            radioNu.Enabled = false;
            dateTimeNS.Enabled = false;
            txtChucVu.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtSDT.Enabled = false;
            cboMaKhoa.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtHoTen.Clear();
            txtMaCB.Clear();
            txtChucVu.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            radioNam.Checked = false;
            radioNu.Checked = false;

            int iCount = 0;
            for (int i = 0; i <= dataCanBo.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetGridview();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (txtHoTen.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập họ tên cán bộ!", "Thông báo");
                }
                else if (txtChucVu.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập chức vụ của cán bộ!", "Thông báo");
                }
                else if (txtDiaChi.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo");
                }
                else if (txtSDT.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại liên hệ!", "Thông báo");
                }
                else if (txtEmail.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập Email!", "Thông báo");
                }
                else if (isValidEmail(txtEmail.Text) != true)
                {
                    MessageBox.Show("Email không hợp lệ!!!", "Thông báo");
                }
                else
                {
                    int count = 0;
                    count = dataCanBo.Rows.Count;
                    string chuoi = "";
                    int chuoi2 = 0;
                    chuoi = Convert.ToString(dataCanBo.Rows[count - 1].Cells[0].Value);
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    if (chuoi2 + 1 < 10)
                        txtMaCB.Text = "CB00" + (chuoi2 + 1).ToString();
                    else if (chuoi2 + 1 < 100)
                        txtMaCB.Text = "CB0" + (chuoi2 + 1).ToString();

                    x.MaCB = txtMaCB.Text;
                    x.HoTen = txtHoTen.Text;
                    if (radioNam.Checked == true)
                        x.GioiTinh = "Nam";
                    else if (radioNu.Checked == true)
                        x.GioiTinh = "Nữ";
                    x.NamSinh = dateTimeNS.Value.Date;
                    x.ChucVu = txtChucVu.Text;
                    x.DiaChi = txtDiaChi.Text;
                    x.SDT = txtSDT.Text;
                    x.Email = txtEmail.Text;
                    x.MaKhoa = cboMaKhoa.Text;

                    int check = cb.Them(x);
                    if (check == 0)
                        MessageBox.Show("Lỗi! Bỏ trống.");
                    else if (check == -1)
                        MessageBox.Show("Lỗi! Trùng mã.");
                    else
                        MessageBox.Show("Thêm thành công!!!", "Thông báo");

                    CanBo_Load(sender, e);
                    ResetGridview();
                }
            }
            else if (flag == "edit")
            {
                if (txtHoTen.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập họ tên cán bộ!", "Thông báo");
                }
                else if (txtChucVu.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập chức vụ của cán bộ!", "Thông báo");
                }
                else if (txtDiaChi.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo");
                }
                else if (txtSDT.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại liên hệ!", "Thông báo");
                }
                else if (txtEmail.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập Email!", "Thông báo");
                }
                else
                {
                    x.MaCB = txtMaCB.Text;
                    x.HoTen = txtHoTen.Text;
                    if (radioNam.Checked == true)
                        x.GioiTinh = "Nam";
                    else if (radioNu.Checked == true)
                        x.GioiTinh = "Nữ";
                    x.NamSinh = dateTimeNS.Value.Date;
                    x.ChucVu = txtChucVu.Text;
                    x.DiaChi = txtDiaChi.Text;
                    x.SDT = txtSDT.Text;
                    x.Email = txtEmail.Text;
                    x.MaKhoa = cboMaKhoa.Text;

                    if (!cb.Sua(x))
                        MessageBox.Show("Lỗi! Bỏ trống.");
                    else
                        MessageBox.Show("Sửa thành công!!!","Thông báo");
                    CanBo_Load(sender, e);
                    ResetGridview();
                }
            }
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dataCanBo.DataSource = cb.GetList();
            }
            else
                dataCanBo.DataSource = cb.TimKiem(txtTimkiem.Text);
            int iCount = 0;
            for (int i = 0; i <= dataCanBo.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
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
                List<CanBo_DTO> y = new List<CanBo_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    x.MaCB = dt.Rows[i]["MaCB"].ToString();
                    x.HoTen = dt.Rows[i]["HoTen"].ToString();
                    x.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                    x.NamSinh = DateTime.Parse(dt.Rows[i]["NamSinh"].ToString());
                    x.ChucVu = dt.Rows[i]["ChucVu"].ToString();
                    x.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                    x.SDT = dt.Rows[i]["SDT"].ToString();
                    x.Email = dt.Rows[i]["Email"].ToString();
                    x.MaKhoa= dt.Rows[i]["MaKhoa"].ToString();
                    y.Add(x);
                }
                dataCanBo.DataSource = y;
            }
        }

        private void btnNhapDL_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog = QLPTH; Integrated Security = True";
                DapperPlusManager.Entity<CanBo_DTO>().Table("CanBo");
                List<CanBo_DTO> y = dataCanBo.DataSource as List<CanBo_DTO>;
                if (y != null)
                {
                    using (IDbConnection db = new SqlConnection(constr))
                    {
                        db.BulkInsert(y);
                    }
                }
                MessageBox.Show("Thêm dữ liệu thành công!!!", "Thông báo");
                CanBo_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CanBo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void linkKhoa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Khoa frm = new Khoa();
            frm.Show();
        }
    }
}
