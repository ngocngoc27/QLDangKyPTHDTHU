USE [QLPTH]
GO
/****** Object:  Table [dbo].[CanBo]    Script Date: 12/25/2021 9:31:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanBo](
	[MaCB] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[NamSinh] [date] NOT NULL,
	[ChucVu] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[MaKhoa] [varchar](10) NOT NULL,
 CONSTRAINT [PK_CanBo] PRIMARY KEY CLUSTERED 
(
	[MaCB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/25/2021 9:31:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](10) NOT NULL,
	[TenKhoa] [nvarchar](100) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHP]    Script Date: 12/25/2021 9:31:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHP](
	[ID_HP] [int] NOT NULL,
	[MaHP] [varchar](10) NOT NULL,
	[TenHP] [nvarchar](100) NULL,
	[SoTC] [int] NOT NULL,
	[HocKi] [nvarchar](5) NOT NULL,
	[NienKhoa] [varchar](15) NOT NULL,
 CONSTRAINT [PK_LopHP_1] PRIMARY KEY CLUSTERED 
(
	[ID_HP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MayTinh]    Script Date: 12/25/2021 9:31:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MayTinh](
	[MaMT] [varchar](10) NOT NULL,
	[HieuMay] [varchar](20) NULL,
	[NhaSX] [nvarchar](20) NULL,
	[TinhTrangMay] [nvarchar](50) NOT NULL,
	[MaPhong] [varchar](10) NOT NULL,
 CONSTRAINT [PK_MayTinh] PRIMARY KEY CLUSTERED 
(
	[MaMT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDangKy]    Script Date: 12/25/2021 9:31:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDangKy](
	[SoPhieuDK] [varchar](10) NOT NULL,
	[NgayDangKy] [date] NOT NULL,
	[TietBD] [int] NOT NULL,
	[SoTiet] [int] NOT NULL,
	[MaPhong] [varchar](10) NOT NULL,
	[ID_HP] [int] NOT NULL,
	[MaCB] [varchar](10) NOT NULL,
	[TinhTrangDK] [nvarchar](20) NULL,
 CONSTRAINT [PK_PhieuDangKy] PRIMARY KEY CLUSTERED 
(
	[SoPhieuDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThongKe]    Script Date: 12/25/2021 9:31:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThongKe](
	[SoPhieuTK] [varchar](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
	[MaCB] [varchar](10) NOT NULL,
	[MaMT] [varchar](10) NOT NULL,
 CONSTRAINT [PK_PhieuThongKe] PRIMARY KEY CLUSTERED 
(
	[SoPhieuTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongThucHanh]    Script Date: 12/25/2021 9:31:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongThucHanh](
	[MaPhong] [varchar](10) NOT NULL,
	[ViTri] [nvarchar](50) NULL,
	[TinhTrangPhong] [nvarchar](20) NOT NULL,
	[SoLuongMay] [int] NULL,
 CONSTRAINT [PK_PhongThucHanh] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/25/2021 9:31:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenTaiKhoan] [varchar](10) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
	[QuyenDN] [int] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CanBo] ([MaCB], [HoTen], [GioiTinh], [NamSinh], [ChucVu], [DiaChi], [SDT], [Email], [MaKhoa]) VALUES (N'CB002', N'Võ Thị Bích Trăm', N'Nữ', CAST(N'2021-12-19' AS Date), N'Giảng viên', N'Hồng Ngự', N'0328420146', N'tram@gmail.com', N'K02')
INSERT [dbo].[CanBo] ([MaCB], [HoTen], [GioiTinh], [NamSinh], [ChucVu], [DiaChi], [SDT], [Email], [MaKhoa]) VALUES (N'CB003', N'Dương Nguyễn Cẩm Thu', N'Nữ', CAST(N'2000-01-02' AS Date), N'Giảng viên', N'Tân Nghĩa', N'0123456789', N'thu@gmail.ccom', N'K04')
INSERT [dbo].[CanBo] ([MaCB], [HoTen], [GioiTinh], [NamSinh], [ChucVu], [DiaChi], [SDT], [Email], [MaKhoa]) VALUES (N'CB005', N'Nguyễn Thị Hồng Ngọc', N'Nữ', CAST(N'2000-07-02' AS Date), N'Cán bộ phụ trách phòng thực hành', N'Hồng Ngự', N'0868669711', N'ngoc@gmail.com', N'K12')
INSERT [dbo].[CanBo] ([MaCB], [HoTen], [GioiTinh], [NamSinh], [ChucVu], [DiaChi], [SDT], [Email], [MaKhoa]) VALUES (N'CB006', N'Thanh Duy', N'Nam', CAST(N'2000-12-10' AS Date), N'Giảng viên', N'Sa Ðéc', N'0146213255', N'duy@gmail.com', N'K05')
INSERT [dbo].[CanBo] ([MaCB], [HoTen], [GioiTinh], [NamSinh], [ChucVu], [DiaChi], [SDT], [Email], [MaKhoa]) VALUES (N'CB007', N'Lê Duy Khang', N'Nam', CAST(N'2000-01-07' AS Date), N'Giảng viên', N'Bến Tre', N'0865441201', N'khang@gmail.com', N'K07')
INSERT [dbo].[CanBo] ([MaCB], [HoTen], [GioiTinh], [NamSinh], [ChucVu], [DiaChi], [SDT], [Email], [MaKhoa]) VALUES (N'CB008', N'Trần Kim Hương', N'Nữ', CAST(N'1986-10-15' AS Date), N'Giảng viên', N'Cao Lãnh', N'0865412053', N'tkhuong@dthu.edu.vn', N'K02')
INSERT [dbo].[CanBo] ([MaCB], [HoTen], [GioiTinh], [NamSinh], [ChucVu], [DiaChi], [SDT], [Email], [MaKhoa]) VALUES (N'CB009', N'Lê Minh Thư', N'Nữ', CAST(N'1985-07-10' AS Date), N'Giảng viên', N'Cao Lãnh', N'0856961555', N'lmthu@dthu.edu.vn', N'K04')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K01', N'Khoa Ngoại Ngữ')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K02', N'Khoa Sư Phạm Toán Tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K03', N'Khoa Sư Phạm Khoa Học Tự Nhiên')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K04', N'Khoa Sư Phạm Ngữ Văn')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K05', N'Khoa Sư Phạm Nghệ Thuật')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K06', N'Khoa Sư Phạm Khoa Học Xã Hội')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K07', N'Khoa GDTC QPAN')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K08', N'Khoa GDTH Mầm Non')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K09', N'Khoa Kinh Tế')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K10', N'Khoa Nông Nghiệp và Tài Nguyên Môi Trường')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K11', N'Khoa Văn Hóa Du Lịch và CTXH')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K12', N'Trung Tâm Ngoại Ngữ và Tin Học')
GO
INSERT [dbo].[LopHP] ([ID_HP], [MaHP], [TenHP], [SoTC], [HocKi], [NienKhoa]) VALUES (94, N'IN4119', N'Lập trình DotNet', 3, N'1', N'2020-2021')
INSERT [dbo].[LopHP] ([ID_HP], [MaHP], [TenHP], [SoTC], [HocKi], [NienKhoa]) VALUES (121, N'IN4002', N'Cấu trúc dữ liệu và Giải thuật', 3, N'1', N'2019-2020')
INSERT [dbo].[LopHP] ([ID_HP], [MaHP], [TenHP], [SoTC], [HocKi], [NienKhoa]) VALUES (202, N'IN4142', N'Quản trị hệ thống mạng Windows', 2, N'2', N'2020-2021')
INSERT [dbo].[LopHP] ([ID_HP], [MaHP], [TenHP], [SoTC], [HocKi], [NienKhoa]) VALUES (266, N'IN4124', N'Lập trình Web', 3, N'2', N'2020-2021')
INSERT [dbo].[LopHP] ([ID_HP], [MaHP], [TenHP], [SoTC], [HocKi], [NienKhoa]) VALUES (452, N'IN4152', N'Xử lý ảnh', 3, N'1', N'2021-2022')
INSERT [dbo].[LopHP] ([ID_HP], [MaHP], [TenHP], [SoTC], [HocKi], [NienKhoa]) VALUES (535, N'IN4127', N'Mạng máy tính', 3, N'1', N'2020-2021')
INSERT [dbo].[LopHP] ([ID_HP], [MaHP], [TenHP], [SoTC], [HocKi], [NienKhoa]) VALUES (670, N'IN4134', N'Phân tích và thiết kế hệ thống', 3, N'1', N'2020-2021')
INSERT [dbo].[LopHP] ([ID_HP], [MaHP], [TenHP], [SoTC], [HocKi], [NienKhoa]) VALUES (693, N'IN4203', N'Lập trình cho thiết bị di động', 3, N'1', N'2021-2022')
INSERT [dbo].[LopHP] ([ID_HP], [MaHP], [TenHP], [SoTC], [HocKi], [NienKhoa]) VALUES (803, N'IN4201', N'Khai phá dữ liệu', 2, N'1', N'2021-2020')
INSERT [dbo].[LopHP] ([ID_HP], [MaHP], [TenHP], [SoTC], [HocKi], [NienKhoa]) VALUES (984, N'IN4107', N'Cơ sở dữ liệu', 3, N'2', N'2019-2020')
GO
INSERT [dbo].[MayTinh] ([MaMT], [HieuMay], [NhaSX], [TinhTrangMay], [MaPhong]) VALUES (N'MT001', N'Dell', N'Trung Quốc', N'Hư hỏng', N'101B4')
INSERT [dbo].[MayTinh] ([MaMT], [HieuMay], [NhaSX], [TinhTrangMay], [MaPhong]) VALUES (N'MT002', N'Dell', N'Trung Quốc', N'Tốt ', N'101B4')
INSERT [dbo].[MayTinh] ([MaMT], [HieuMay], [NhaSX], [TinhTrangMay], [MaPhong]) VALUES (N'MT003', N'Asus', N'Mỹ', N'Tốt ', N'102B4')
INSERT [dbo].[MayTinh] ([MaMT], [HieuMay], [NhaSX], [TinhTrangMay], [MaPhong]) VALUES (N'MT004', N'Asus', N'Canada', N'Tốt ', N'102B4')
INSERT [dbo].[MayTinh] ([MaMT], [HieuMay], [NhaSX], [TinhTrangMay], [MaPhong]) VALUES (N'MT005', N'Acer', N'Nga', N'Hư hỏng', N'102B4')
INSERT [dbo].[MayTinh] ([MaMT], [HieuMay], [NhaSX], [TinhTrangMay], [MaPhong]) VALUES (N'MT006', N'Dell', N'Mỹ', N'Tốt ', N'102B4')
INSERT [dbo].[MayTinh] ([MaMT], [HieuMay], [NhaSX], [TinhTrangMay], [MaPhong]) VALUES (N'MT007', N'HP', N'Trung Quốc', N'Tốt ', N'202B4')
INSERT [dbo].[MayTinh] ([MaMT], [HieuMay], [NhaSX], [TinhTrangMay], [MaPhong]) VALUES (N'MT008', N'HP', N'Trung Quốc', N'Tốt ', N'301B4')
INSERT [dbo].[MayTinh] ([MaMT], [HieuMay], [NhaSX], [TinhTrangMay], [MaPhong]) VALUES (N'MT009', N'Dell', N'Trung Quốc', N'Tốt', N'101B4')
GO
INSERT [dbo].[PhieuDangKy] ([SoPhieuDK], [NgayDangKy], [TietBD], [SoTiet], [MaPhong], [ID_HP], [MaCB], [TinhTrangDK]) VALUES (N'224', CAST(N'2020-10-20' AS Date), 10, 3, N'302B4', 670, N'CB006', N'Chưa duyệt')
INSERT [dbo].[PhieuDangKy] ([SoPhieuDK], [NgayDangKy], [TietBD], [SoTiet], [MaPhong], [ID_HP], [MaCB], [TinhTrangDK]) VALUES (N'247', CAST(N'2020-10-20' AS Date), 10, 3, N'101B4', 984, N'CB007', N'Đã duyệt')
INSERT [dbo].[PhieuDangKy] ([SoPhieuDK], [NgayDangKy], [TietBD], [SoTiet], [MaPhong], [ID_HP], [MaCB], [TinhTrangDK]) VALUES (N'28', CAST(N'2021-10-15' AS Date), 4, 2, N'201B4', 452, N'CB008', N'Đã duyệt')
INSERT [dbo].[PhieuDangKy] ([SoPhieuDK], [NgayDangKy], [TietBD], [SoTiet], [MaPhong], [ID_HP], [MaCB], [TinhTrangDK]) VALUES (N'411', CAST(N'2020-11-10' AS Date), 7, 2, N'101B4', 670, N'CB002', N'Đã duyệt')
INSERT [dbo].[PhieuDangKy] ([SoPhieuDK], [NgayDangKy], [TietBD], [SoTiet], [MaPhong], [ID_HP], [MaCB], [TinhTrangDK]) VALUES (N'414', CAST(N'2021-12-19' AS Date), 1, 3, N'104B2', 452, N'CB005', N'Chưa duyệt')
INSERT [dbo].[PhieuDangKy] ([SoPhieuDK], [NgayDangKy], [TietBD], [SoTiet], [MaPhong], [ID_HP], [MaCB], [TinhTrangDK]) VALUES (N'56', CAST(N'2021-12-20' AS Date), 6, 4, N'101B4', 693, N'CB009', N'Đã duyệt')
INSERT [dbo].[PhieuDangKy] ([SoPhieuDK], [NgayDangKy], [TietBD], [SoTiet], [MaPhong], [ID_HP], [MaCB], [TinhTrangDK]) VALUES (N'565', CAST(N'2021-09-30' AS Date), 2, 4, N'103B4', 693, N'CB003', N'Đã duyệt')
INSERT [dbo].[PhieuDangKy] ([SoPhieuDK], [NgayDangKy], [TietBD], [SoTiet], [MaPhong], [ID_HP], [MaCB], [TinhTrangDK]) VALUES (N'608', CAST(N'2019-12-20' AS Date), 7, 2, N'302B4', 121, N'CB005', N'Đã duyệt')
INSERT [dbo].[PhieuDangKy] ([SoPhieuDK], [NgayDangKy], [TietBD], [SoTiet], [MaPhong], [ID_HP], [MaCB], [TinhTrangDK]) VALUES (N'965', CAST(N'2021-12-19' AS Date), 2, 2, N'102B4', 452, N'CB002', N'Chưa duyệt')
GO
INSERT [dbo].[PhieuThongKe] ([SoPhieuTK], [NgayLap], [GhiChu], [MaCB], [MaMT]) VALUES (N'103', CAST(N'2021-12-10' AS Date), N'Máy quá nóng', N'CB003', N'MT003')
INSERT [dbo].[PhieuThongKe] ([SoPhieuTK], [NgayLap], [GhiChu], [MaCB], [MaMT]) VALUES (N'298', CAST(N'2021-12-18' AS Date), N'Hư main', N'CB007', N'MT005')
INSERT [dbo].[PhieuThongKe] ([SoPhieuTK], [NgayLap], [GhiChu], [MaCB], [MaMT]) VALUES (N'341', CAST(N'2020-11-01' AS Date), N'Lỗi màn hình xanh với thông báo Dumping RAM rồi tắt ngay', N'CB009', N'MT007')
INSERT [dbo].[PhieuThongKe] ([SoPhieuTK], [NgayLap], [GhiChu], [MaCB], [MaMT]) VALUES (N'533', CAST(N'2020-12-11' AS Date), N'Hư CPU, bàn phím, chuột', N'CB006', N'MT004')
INSERT [dbo].[PhieuThongKe] ([SoPhieuTK], [NgayLap], [GhiChu], [MaCB], [MaMT]) VALUES (N'590', CAST(N'2021-12-17' AS Date), N'Không kết nối được wifi', N'CB007', N'MT006')
INSERT [dbo].[PhieuThongKe] ([SoPhieuTK], [NgayLap], [GhiChu], [MaCB], [MaMT]) VALUES (N'687', CAST(N'2020-01-11' AS Date), N'Hư màn hình', N'CB002', N'MT001')
INSERT [dbo].[PhieuThongKe] ([SoPhieuTK], [NgayLap], [GhiChu], [MaCB], [MaMT]) VALUES (N'71', CAST(N'2021-12-10' AS Date), N'Lỗi ổ cứng', N'CB005', N'MT002')
INSERT [dbo].[PhieuThongKe] ([SoPhieuTK], [NgayLap], [GhiChu], [MaCB], [MaMT]) VALUES (N'848', CAST(N'2021-12-20' AS Date), N'Lỗi ổ cứng', N'CB002', N'MT008')
GO
INSERT [dbo].[PhongThucHanh] ([MaPhong], [ViTri], [TinhTrangPhong], [SoLuongMay]) VALUES (N'101B4', N'Tầng trệt dãy B4', N'Tốt ', 40)
INSERT [dbo].[PhongThucHanh] ([MaPhong], [ViTri], [TinhTrangPhong], [SoLuongMay]) VALUES (N'102B4', N'Tầng trệt dãy B4', N'Hư hỏng', 32)
INSERT [dbo].[PhongThucHanh] ([MaPhong], [ViTri], [TinhTrangPhong], [SoLuongMay]) VALUES (N'103B4', N'Tầng trệt dãy B4', N'Tốt ', 30)
INSERT [dbo].[PhongThucHanh] ([MaPhong], [ViTri], [TinhTrangPhong], [SoLuongMay]) VALUES (N'104B2', N'Tầng 1 dãy B4', N'Hư hỏng', 40)
INSERT [dbo].[PhongThucHanh] ([MaPhong], [ViTri], [TinhTrangPhong], [SoLuongMay]) VALUES (N'201B4', N'Tầng 1 dãy B4', N'Tốt ', 35)
INSERT [dbo].[PhongThucHanh] ([MaPhong], [ViTri], [TinhTrangPhong], [SoLuongMay]) VALUES (N'202B4', N'Tầng 1 dãy B4', N'Tốt ', 40)
INSERT [dbo].[PhongThucHanh] ([MaPhong], [ViTri], [TinhTrangPhong], [SoLuongMay]) VALUES (N'203B4', N'Tầng 1 dãy B4', N'Tốt ', 35)
INSERT [dbo].[PhongThucHanh] ([MaPhong], [ViTri], [TinhTrangPhong], [SoLuongMay]) VALUES (N'301B4', N'Tầng 2 dãy B4', N'Tốt ', 33)
INSERT [dbo].[PhongThucHanh] ([MaPhong], [ViTri], [TinhTrangPhong], [SoLuongMay]) VALUES (N'302B4', N'Tầng 2 dãy B4', N'Tốt ', 36)
GO
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [QuyenDN]) VALUES (N'CB001', N'4QrcOUm6Wau+VuBX8g+IPg==', 0)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [QuyenDN]) VALUES (N'CB002', N'hYkV8dLUJZWf1NqGe6a1mQ==', 1)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [QuyenDN]) VALUES (N'CB003', N'4QrcOUm6Wau+VuBX8g+IPg==', 1)
INSERT [dbo].[TaiKhoan] ([TenTaiKhoan], [MatKhau], [QuyenDN]) VALUES (N'CB004', N'4QrcOUm6Wau+VuBX8g+IPg==', 1)
GO
ALTER TABLE [dbo].[CanBo]  WITH CHECK ADD  CONSTRAINT [FK_CanBo_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[CanBo] CHECK CONSTRAINT [FK_CanBo_Khoa]
GO
ALTER TABLE [dbo].[MayTinh]  WITH CHECK ADD  CONSTRAINT [FK_MayTinh_PhongThucHanh] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongThucHanh] ([MaPhong])
GO
ALTER TABLE [dbo].[MayTinh] CHECK CONSTRAINT [FK_MayTinh_PhongThucHanh]
GO
ALTER TABLE [dbo].[PhieuDangKy]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDangKy_CanBo] FOREIGN KEY([MaCB])
REFERENCES [dbo].[CanBo] ([MaCB])
GO
ALTER TABLE [dbo].[PhieuDangKy] CHECK CONSTRAINT [FK_PhieuDangKy_CanBo]
GO
ALTER TABLE [dbo].[PhieuDangKy]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDangKy_LopHP] FOREIGN KEY([ID_HP])
REFERENCES [dbo].[LopHP] ([ID_HP])
GO
ALTER TABLE [dbo].[PhieuDangKy] CHECK CONSTRAINT [FK_PhieuDangKy_LopHP]
GO
ALTER TABLE [dbo].[PhieuDangKy]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDangKy_PhongThucHanh] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PhongThucHanh] ([MaPhong])
GO
ALTER TABLE [dbo].[PhieuDangKy] CHECK CONSTRAINT [FK_PhieuDangKy_PhongThucHanh]
GO
ALTER TABLE [dbo].[PhieuThongKe]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThongKe_CanBo] FOREIGN KEY([MaCB])
REFERENCES [dbo].[CanBo] ([MaCB])
GO
ALTER TABLE [dbo].[PhieuThongKe] CHECK CONSTRAINT [FK_PhieuThongKe_CanBo]
GO
ALTER TABLE [dbo].[PhieuThongKe]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThongKe_MayTinh] FOREIGN KEY([MaMT])
REFERENCES [dbo].[MayTinh] ([MaMT])
GO
ALTER TABLE [dbo].[PhieuThongKe] CHECK CONSTRAINT [FK_PhieuThongKe_MayTinh]
GO
