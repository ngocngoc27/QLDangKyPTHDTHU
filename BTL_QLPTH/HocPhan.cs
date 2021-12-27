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
    public partial class HocPhan : MetroFramework.Forms.MetroForm
    {
        LopHP_BUS hp = new LopHP_BUS();
        public HocPhan()
        {
            InitializeComponent();
        }

        private void HocPhan_Load(object sender, EventArgs e)
        {
            dataLopHP.DataSource = hp.GetList();
            dataLopHP.Columns[0].HeaderText = "ID_HP";
            dataLopHP.Columns[1].HeaderText = "Mã HP";
            dataLopHP.Columns[2].HeaderText = "Tên HP";
            dataLopHP.Columns[3].HeaderText = "Số tín chỉ";
            dataLopHP.Columns[4].HeaderText = "Học kì";
            dataLopHP.Columns[5].HeaderText = "Niên khóa";
            dataLopHP.Columns[0].Width = 90;
            dataLopHP.Columns[1].Width = 120;
            dataLopHP.Columns[2].Width = 282;
            dataLopHP.Columns[3].Width = 120;
            dataLopHP.Columns[4].Width = 95;
            dataLopHP.Columns[5].Width = 130;
        }

        private void HocPhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dataLopHP.DataSource = hp.GetList();
            }
            else
                dataLopHP.DataSource = hp.TimKiem(txtTimkiem.Text);
        }
    }
}
