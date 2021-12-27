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
    public partial class BaoCao : MetroFramework.Forms.MetroForm
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport.PhieuDangKy' table. You can move, or remove it, as needed.
            
        }

        private void btnXuatbc_Click(object sender, EventArgs e)
        {
            this.PhieuDangKyTableAdapter.Fill(this.DataSetReport.PhieuDangKy, Convert.ToString(dateTimeBD.Value.Date), Convert.ToString(dateTimeKT.Value.Date));
            this.reportViewer1.RefreshReport();
        }

        private void BaoCao_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
