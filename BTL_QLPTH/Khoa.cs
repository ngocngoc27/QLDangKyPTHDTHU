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
    public partial class Khoa : MetroFramework.Forms.MetroForm
    {
        Khoa_BUS khoa = new Khoa_BUS();
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            dataKhoa.DataSource = khoa.GetList();

            dataKhoa.Columns[0].HeaderText = "Mã khoa";
            dataKhoa.Columns[1].HeaderText = "Tên khoa";
            dataKhoa.Columns[0].Width = 100;
            dataKhoa.Columns[1].Width = 400;
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dataKhoa.DataSource = khoa.GetList();
            }
            else
                dataKhoa.DataSource = khoa.TimKiem(txtTimkiem.Text);
        }

        private void Khoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
