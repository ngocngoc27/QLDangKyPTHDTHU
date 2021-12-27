using BTL_QLPTH.BUS;
using Microsoft.Office.Interop.Excel;
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
    public partial class TraCuuTTThongKe : MetroFramework.Forms.MetroForm
    {
        TraCuuTT_BUS data = new TraCuuTT_BUS();
        public TraCuuTTThongKe()
        {
            InitializeComponent();
        }
        private void TraCuuTTThongKe_Load(object sender, EventArgs e)
        {

            dataTTThongKe.DataSource = data.GetList2();
            dataTTThongKe.Columns[0].HeaderText = "Số phiếu";
            dataTTThongKe.Columns[1].HeaderText = "Ngày lập";
            dataTTThongKe.Columns[2].HeaderText = "Mã phòng";
            dataTTThongKe.Columns[3].HeaderText = "Mã máy tính";
            dataTTThongKe.Columns[4].HeaderText = "Hiệu máy";
            dataTTThongKe.Columns[5].HeaderText = "Nhà sản xuất";
            dataTTThongKe.Columns[6].HeaderText = "Ghi chú";
            dataTTThongKe.Columns[7].HeaderText = "Mã cán bộ";
            dataTTThongKe.Columns[8].HeaderText = "Tên cán bộ";
            dataTTThongKe.Columns[0].Width = 90;
            dataTTThongKe.Columns[1].Width = 115;
            dataTTThongKe.Columns[2].Width = 105;
            dataTTThongKe.Columns[3].Width = 110;
            dataTTThongKe.Columns[4].Width = 95;
            dataTTThongKe.Columns[5].Width = 115;
            dataTTThongKe.Columns[6].Width = 250;
            dataTTThongKe.Columns[7].Width = 100;
            dataTTThongKe.Columns[8].Width = 150;

            int iCount = 0;
            for (int i = 0; i <= dataTTThongKe.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                dataTTThongKe.DataSource = data.GetList2();
            }
            else
            {
                if (radioHoTen.Checked == true)
                    dataTTThongKe.DataSource = data.TimKiem2(txtTimkiem.Text, "HoTen");
                else if (radioMaPhong.Checked == true)
                    dataTTThongKe.DataSource = data.TimKiem2(txtTimkiem.Text, "MaPhong");
                else if (radioSoPhieu.Checked == true)
                    dataTTThongKe.DataSource = data.TimKiem2(txtTimkiem.Text, "SoPhieuTK");
                else if (radioMaMT.Checked == true)
                    dataTTThongKe.DataSource = data.TimKiem2(txtTimkiem.Text, "PhieuThongKe.MaMT");
                else if (radioNgayLap.Checked == true)
                    dataTTThongKe.DataSource = data.TimKiem2(txtTimkiem.Text, "NgayLap");
            }
            int iCount = 0;
            for (int i = 0; i <= dataTTThongKe.RowCount; i++)
            {
                this.txtTS.Text = iCount.ToString();
                iCount++;
            }
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
            row1_TieuDe_ThongKeDoiTuong.Value2 = "THỐNG KÊ DANH SÁCH TÌNH TRẠNG MÁY TÍNH HƯ HỎNG CỦA PHÒNG THỰC HÀNH DTHU";
            row1_TieuDe_ThongKeDoiTuong.Font.Bold = true;
            row1_TieuDe_ThongKeDoiTuong.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Red);
            //Tạo Số phiếu
            Range SoPhieuTK = worksheet.get_Range("A2", "A2");
            SoPhieuTK.Font.Size = fontSizeTenTruong;
            SoPhieuTK.Font.Name = fontName;
            SoPhieuTK.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            SoPhieuTK.Value2 = "Số phiếu";
            SoPhieuTK.ColumnWidth = 10;
            //Tạo ngày lập
            Range NgayLap = worksheet.get_Range("B2", "B2");
            NgayLap.Font.Size = fontSizeTenTruong;
            NgayLap.Font.Name = fontName;
            NgayLap.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            NgayLap.Value2 = "Ngày lập";
            NgayLap.ColumnWidth = 10;
            //Tạo Mã phòng
            Range MaPhong = worksheet.get_Range("C2", "C2");
            MaPhong.Font.Size = fontSizeTenTruong;
            MaPhong.Font.Name = fontName;
            MaPhong.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            MaPhong.Value2 = "Mã phòng";
            MaPhong.ColumnWidth = 13;
            //Tạo Mã máy tính
            Range MaMT = worksheet.get_Range("D2", "D2");
            MaMT.Font.Size = fontSizeTenTruong;
            MaMT.Font.Name = fontName;
            MaMT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            MaMT.Value2 = "Mã máy tính";
            MaMT.ColumnWidth = 15;
            //Tạo hiệu máy
            Range HieuMay = worksheet.get_Range("E2", "E2");
            HieuMay.Font.Size = fontSizeTenTruong;
            HieuMay.Font.Name = fontName;
            HieuMay.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            HieuMay.Value2 = "Hiệu máy";
            HieuMay.ColumnWidth = 12;
            //Tạo nhà sản xuất
            Range NSX = worksheet.get_Range("F2", "F2");
            NSX.Font.Size = fontSizeTenTruong;
            NSX.Font.Name = fontName;
            NSX.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            NSX.Value2 = "Nhà sản xuất";
            NSX.ColumnWidth = 15;
            //Tạo ghi chú
            Range GhiChu = worksheet.get_Range("G2", "G2");
            GhiChu.Font.Size = fontSizeTenTruong;
            GhiChu.Font.Name = fontName;
            GhiChu.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            GhiChu.Value2 = "Ghi chú";
            GhiChu.ColumnWidth = 30;
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

            //Tô nền vàng các cột tiêu đề:
            Range row2_CotTieuDe = worksheet.get_Range("A2", "I2");
            //nền vàng
            row2_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            //in đậm
            row2_CotTieuDe.Font.Bold = true;
            //chữ đen
            row2_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            // đổ dữ liệu vào sheet
            for (int i = 0; i < dataTTThongKe.RowCount; i++)
            {
                for (int j = 0; j < dataTTThongKe.ColumnCount; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = dataTTThongKe.Rows[i].Cells[j].Value;
                }
            }
            //Kẻ khung toàn bộ
            BorderAround(worksheet.get_Range("A2", "I" + row));
        }

        private void TraCuuTTThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
