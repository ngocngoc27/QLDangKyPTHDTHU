using BTL_QLPTH.BUS;
using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_QLPTH
{
    public partial class TraCuuTTDangKy : MetroFramework.Forms.MetroForm
    {
        TraCuuTT_BUS data = new TraCuuTT_BUS();
        public TraCuuTTDangKy()
        {
            InitializeComponent();
        }
        private void TraCuuTTDangKy_Load(object sender, EventArgs e)
        {
            dataTTDangKy.DataSource = data.GetList();
            dataTTDangKy.Columns[0].HeaderText = "Số phiếu";
            dataTTDangKy.Columns[1].HeaderText = "Ngày đăng ký";
            dataTTDangKy.Columns[2].HeaderText = "Tiết bắt đầu";
            dataTTDangKy.Columns[3].HeaderText = "Số tiết";
            dataTTDangKy.Columns[4].HeaderText = "Mã phòng";
            dataTTDangKy.Columns[5].HeaderText = "Mã học phần";
            dataTTDangKy.Columns[6].HeaderText = "Tên học phần";
            dataTTDangKy.Columns[7].HeaderText = "Mã cán bộ";
            dataTTDangKy.Columns[8].HeaderText = "Tên cán bộ";
            dataTTDangKy.Columns[9].HeaderText = "Tình trạng đăng ký";
            dataTTDangKy.Columns[0].Width = 85;
            dataTTDangKy.Columns[1].Width = 115;
            dataTTDangKy.Columns[2].Width = 105;
            dataTTDangKy.Columns[3].Width = 80;
            dataTTDangKy.Columns[4].Width = 95;
            dataTTDangKy.Columns[5].Width = 110;
            dataTTDangKy.Columns[6].Width = 180;
            dataTTDangKy.Columns[7].Width = 95;
            dataTTDangKy.Columns[8].Width = 150;
            dataTTDangKy.Columns[9].Width = 150;

            int iCount = 0;
            for (int i = 0; i <= dataTTDangKy.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // khởi tạo excel
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            // khởi tạo workbook
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            // khởi tạo workshet
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;

            int row = 1;
            string fontName = "Times New Roman";
            int fontSizeTieuDe = 16;
            int fontSizeTenTruong = 12;
            //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
            Range row1_TieuDe_ThongKeDoiTuong = worksheet.get_Range("A1", "I1");
            row1_TieuDe_ThongKeDoiTuong.Merge();
            row1_TieuDe_ThongKeDoiTuong.Font.Size = fontSizeTieuDe;
            row1_TieuDe_ThongKeDoiTuong.Font.Name = fontName;
            row1_TieuDe_ThongKeDoiTuong.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row1_TieuDe_ThongKeDoiTuong.Value2 = "THỐNG KÊ DANH SÁCH ĐĂNG KÝ MƯỢN PHÒNG THỰC HÀNH DTHU";
            row1_TieuDe_ThongKeDoiTuong.Font.Bold = true;
            row1_TieuDe_ThongKeDoiTuong.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Red);
            //Tạo Số phiếu
            Range row2_SoPhieuDK = worksheet.get_Range("A2", "A2");
            row2_SoPhieuDK.Font.Size = fontSizeTenTruong;
            row2_SoPhieuDK.Font.Name = fontName;
            row2_SoPhieuDK.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row2_SoPhieuDK.Value2 = "Số phiếu";
            row2_SoPhieuDK.ColumnWidth = 10;
            //Tạo ngày đăng ký
            Range NgayDangKy = worksheet.get_Range("B2", "B2");
            NgayDangKy.Font.Size = fontSizeTenTruong;
            NgayDangKy.Font.Name = fontName;
            NgayDangKy.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            NgayDangKy.Value2 = "Ngày đăng ký";
            NgayDangKy.ColumnWidth = 15;
            //Tạo tiết bắt đầu
            Range TietBD = worksheet.get_Range("C2", "C2");
            TietBD.Font.Size = fontSizeTenTruong;
            TietBD.Font.Name = fontName;
            TietBD.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            TietBD.Value2 = "Tiết bắt đầu";
            TietBD.ColumnWidth = 13;
            //Tạo Số tiết
            Range SoTiet = worksheet.get_Range("D2", "D2");
            SoTiet.Font.Size = fontSizeTenTruong;
            SoTiet.Font.Name = fontName;
            SoTiet.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            SoTiet.Value2 = "Số tiết";
            SoTiet.ColumnWidth = 10;
            //Tạo mã phòng
            Range MaPhong = worksheet.get_Range("E2", "E2");
            MaPhong.Font.Size = fontSizeTenTruong;
            MaPhong.Font.Name = fontName;
            MaPhong.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            MaPhong.Value2 = "Mã phòng";
            MaPhong.ColumnWidth = 12;
            //Tạo mã học phần
            Range MaHP = worksheet.get_Range("F2", "F2");
            MaHP.Font.Size = fontSizeTenTruong;
            MaHP.Font.Name = fontName;
            MaHP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            MaHP.Value2 = "Mã học phần";
            MaHP.ColumnWidth = 15;
            //Tạo tên học phần
            Range TenHP = worksheet.get_Range("G2", "G2");
            TenHP.Font.Size = fontSizeTenTruong;
            TenHP.Font.Name = fontName;
            TenHP.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            TenHP.Value2 = "Tên học phần";
            TenHP.ColumnWidth = 20;
            //Tạo mã cán bộ
            Range MaCB = worksheet.get_Range("H2", "H2");
            MaCB.Font.Size = fontSizeTenTruong;
            MaCB.Font.Name = fontName;
            MaCB.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            MaCB.Value2 = "Mã cán bộ";
            MaCB.ColumnWidth = 12;
            //Tạo Họ tên
            Range HoTen = worksheet.get_Range("I2", "I2");
            HoTen.Font.Size = fontSizeTenTruong;
            HoTen.Font.Name = fontName;
            HoTen.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            HoTen.Value2 = "Họ Tên";
            HoTen.ColumnWidth = 25;
            //Tạo Tình trạng đăng ký
            Range TinhTrangDK = worksheet.get_Range("J2", "J2");
            TinhTrangDK.Font.Size = fontSizeTenTruong;
            TinhTrangDK.Font.Name = fontName;
            TinhTrangDK.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            TinhTrangDK.Value2 = "Tình trạng đăng ký";
            TinhTrangDK.ColumnWidth = 20;

            //Tô nền vàng các cột tiêu đề:
            Range row2_CotTieuDe = worksheet.get_Range("A2", "J2");
            //nền vàng
            row2_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            //in đậm
            row2_CotTieuDe.Font.Bold = true;

            //chữ đen
            row2_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

            // đổ dữ liệu vào sheet
            for (int i = 0; i < dataTTDangKy.RowCount; i++)
            {
                for (int j = 0; j < dataTTDangKy.ColumnCount; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = dataTTDangKy.Rows[i].Cells[j].Value;
                }
            }

            //Kẻ khung toàn bộ
            BorderAround(worksheet.get_Range("A2", "J" + row));
        }
        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dataTTDangKy.DataSource = data.GetList();
            }
            else
            {
                if (radioHoTen.Checked == true)
                    dataTTDangKy.DataSource = data.TimKiem(txtTimkiem.Text, "HoTen");
                else if (radioMaPhong.Checked == true)
                    dataTTDangKy.DataSource = data.TimKiem(txtTimkiem.Text, "MaPhong");
                else if (radioSoPhieu.Checked == true)
                    dataTTDangKy.DataSource = data.TimKiem(txtTimkiem.Text, "SoPhieuDK");
                else if (radioTenHP.Checked == true)
                    dataTTDangKy.DataSource = data.TimKiem(txtTimkiem.Text, "TenHP");
                else if (radioTinhTrang.Checked == true)
                    dataTTDangKy.DataSource = data.TimKiem(txtTimkiem.Text, "TinhTrangDK");
                else if (radioNgayDK.Checked == true)
                    dataTTDangKy.DataSource = data.TimKiem(txtTimkiem.Text, "NgayDangKy");
            }
            int iCount = 0;
            for (int i = 0; i <= dataTTDangKy.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }

        private void TraCuuTTDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
