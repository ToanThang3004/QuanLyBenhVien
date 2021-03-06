USE [qlbenhvien]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBenhNhan] [nchar](20) NOT NULL,
	[TenBenhNhan] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](8) NULL,
	[DanToc] [nvarchar](20) NULL,
	[NgaySinh] [datetime] NULL,
	[MaBaoHiem] [nchar](20) NULL,
	[CMND] [nchar](20) NULL,
 CONSTRAINT [PK__BenhNhan__22A8B330315B31D3] PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BenhVien]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhVien](
	[MaBenhVien] [nchar](20) NOT NULL,
	[TenBenhVien] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nchar](20) NULL,
 CONSTRAINT [PK_BenhVien] PRIMARY KEY CLUSTERED 
(
	[MaBenhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BuonBenh]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuonBenh](
	[MaKhoa] [nchar](20) NOT NULL,
	[MaBuong] [nchar](20) NOT NULL,
 CONSTRAINT [PK_BuonBenh_1] PRIMARY KEY CLUSTERED 
(
	[MaBuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDonThuoc]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonThuoc](
	[MaChiTietDonThuoc] [nchar](20) NOT NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[SoLuongThuoc] [int] NULL,
	[GiaThuoc] [float] NULL,
	[MaDonThuoc] [nchar](20) NULL,
	[CachDung] [nvarchar](200) NULL,
	[MaThuoc] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietDonThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuDichVu]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuDichVu](
	[MaChiTietDichVu] [nchar](20) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
	[GiaDichVu] [float] NULL,
	[MaPhieuDichVu] [nchar](20) NULL,
	[MaDichVu] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [nchar](20) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
	[GiaDichVu] [float] NULL,
	[An] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonThuoc]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonThuoc](
	[MaDonThuoc] [nchar](20) NOT NULL,
	[MaPhieuKham] [nchar](20) NULL,
	[TongChiPhi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSThuoc]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSThuoc](
	[MaThuoc] [nchar](20) NOT NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[Gia] [float] NULL,
	[An] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiuongBenh]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiuongBenh](
	[MaBuong] [nchar](20) NOT NULL,
	[MaGiuong] [nchar](20) NOT NULL,
	[TrangThai] [nvarchar](20) NULL,
 CONSTRAINT [PK_GiuongBenh_1] PRIMARY KEY CLUSTERED 
(
	[MaGiuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoSoBenhAn]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoBenhAn](
	[MaHoSoBenhAn] [nchar](20) NOT NULL,
	[MaBN] [nchar](20) NULL,
	[Benh] [text] NULL,
	[MaPK] [nchar](20) NULL,
 CONSTRAINT [PK_HoSoBenhAn] PRIMARY KEY CLUSTERED 
(
	[MaHoSoBenhAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nchar](20) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
	[TruongKhoa] [nchar](20) NULL,
	[TonTai] [int] NULL,
	[SLNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LayMatKhau]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LayMatKhau](
	[ID] [int] NOT NULL,
	[MaTaiKhoan] [nchar](10) NULL,
	[MaXacNhan] [nchar](10) NULL,
 CONSTRAINT [PK_LayMatKhau] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [datetime] NULL,
	[MaKhoa] [nchar](20) NULL,
	[TonTai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuChuyenVien]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuChuyenVien](
	[MaPhieuChuyenVien] [nchar](10) NOT NULL,
	[MaPhieuNhapVien] [nvarchar](50) NULL,
	[NgayChuyenVien] [date] NULL,
	[TenBenhVienChuyenDi] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuChuyenVien] PRIMARY KEY CLUSTERED 
(
	[MaPhieuChuyenVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuDichVu]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDichVu](
	[MaPhieuDichVu] [nchar](20) NOT NULL,
	[TongChiPhiDichVu] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuKhamBenh]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuKhamBenh](
	[MaPhieuKham] [nchar](20) NOT NULL,
	[MaNV] [nchar](20) NULL,
	[MaPhieuDichVu] [nchar](20) NULL,
	[MaBenhNhan] [nchar](20) NULL,
	[NgayKham] [date] NULL,
	[TienKham] [float] NULL,
	[TrangThai] [nvarchar](50) NULL,
	[TrieuChung] [nvarchar](50) NULL,
	[ChuanDoan] [nvarchar](50) NULL,
 CONSTRAINT [PK__PhieuKha__FACA55DF684C9E4F] PRIMARY KEY CLUSTERED 
(
	[MaPhieuKham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhapVien]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapVien](
	[MaPhieuNhapVien] [nchar](20) NOT NULL,
	[NgayNhapVien] [date] NULL,
	[MaKhoa] [nchar](20) NULL,
	[MaGiuong] [nchar](20) NULL,
	[MaBN] [nchar](20) NULL,
	[TinhTrang] [nvarchar](20) NULL,
 CONSTRAINT [PK_PhieuNhapVien] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhapVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuatVien]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuatVien](
	[MaPhieuXuatVien] [nchar](20) NOT NULL,
	[MaPhieuNhapVien] [nchar](20) NULL,
	[NgayXuatVien] [date] NULL,
 CONSTRAINT [PK_PhieuXuatVien] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuatVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [nchar](10) NOT NULL,
	[MaNhanVien] [nchar](10) NULL,
	[TaiKhoan] [nchar](50) NULL,
	[MatKhau] [nchar](50) NULL,
	[Email] [nchar](100) NULL,
	[SDT] [nchar](20) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VienPhi]    Script Date: 1/16/2021 3:59:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VienPhi](
	[MaVienPhi] [nchar](20) NOT NULL,
	[MaBenhNhan] [nchar](20) NULL,
	[TienKham] [float] NULL,
	[TienDichVu] [float] NULL,
	[TienThuoc] [float] NULL,
	[TongTien] [float] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[NgayLap] [date] NULL,
	[NgayThanhToan] [date] NULL,
	[MaPK] [nchar](10) NULL,
 CONSTRAINT [PK_VienPhi] PRIMARY KEY CLUSTERED 
(
	[MaVienPhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [DiaChi], [GioiTinh], [DanToc], [NgaySinh], [MaBaoHiem], [CMND]) VALUES (N'BN1                 ', N'Truong', N'HCM', N'Nam', N'kinh', CAST(N'2020-12-02 00:00:00.000' AS DateTime), N'co                  ', N'123                 ')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [DiaChi], [GioiTinh], [DanToc], [NgaySinh], [MaBaoHiem], [CMND]) VALUES (N'BN2                 ', N'Tan', N'HCM Q7', N'Nu', N'kinh', CAST(N'2020-12-05 00:00:00.000' AS DateTime), N'co                  ', N'123456              ')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [DiaChi], [GioiTinh], [DanToc], [NgaySinh], [MaBaoHiem], [CMND]) VALUES (N'BN3                 ', N'Thang', N'Quan 8', N'Nam', N'Kinh', CAST(N'2020-12-05 00:00:00.000' AS DateTime), N' Co                 ', N'212121              ')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [DiaChi], [GioiTinh], [DanToc], [NgaySinh], [MaBaoHiem], [CMND]) VALUES (N'BN4                 ', N'Thang2', N'Quan 8', N'Nam', N'Kinh', CAST(N'2020-12-05 00:00:00.000' AS DateTime), N' Co                 ', N'2222                ')
INSERT [dbo].[BenhVien] ([MaBenhVien], [TenBenhVien], [DiaChi], [SDT]) VALUES (N'BV1                 ', N'3T', N'HCM - Quan 5', N'0968055555          ')
INSERT [dbo].[BuonBenh] ([MaKhoa], [MaBuong]) VALUES (N'KH1                 ', N'B1                  ')
INSERT [dbo].[BuonBenh] ([MaKhoa], [MaBuong]) VALUES (N'KH1                 ', N'B2                  ')
INSERT [dbo].[BuonBenh] ([MaKhoa], [MaBuong]) VALUES (N'KH2                 ', N'B3                  ')
INSERT [dbo].[BuonBenh] ([MaKhoa], [MaBuong]) VALUES (N'KH1                 ', N'B4                  ')
INSERT [dbo].[ChiTietDonThuoc] ([MaChiTietDonThuoc], [TenThuoc], [SoLuongThuoc], [GiaThuoc], [MaDonThuoc], [CachDung], [MaThuoc]) VALUES (N'CTDT1               ', N'Thuoc 1', 2, 100000, N'DT1                 ', N'uong', N'T5                  ')
INSERT [dbo].[ChiTietDonThuoc] ([MaChiTietDonThuoc], [TenThuoc], [SoLuongThuoc], [GiaThuoc], [MaDonThuoc], [CachDung], [MaThuoc]) VALUES (N'CTDT2               ', N'Thuoc 3', 1, 10000, N'DT2                 ', N'', N'T6                  ')
INSERT [dbo].[ChiTietDonThuoc] ([MaChiTietDonThuoc], [TenThuoc], [SoLuongThuoc], [GiaThuoc], [MaDonThuoc], [CachDung], [MaThuoc]) VALUES (N'CTDT3               ', N'Thuoc 1', 2, 100000, N'DT2                 ', N'', N'T5                  ')
INSERT [dbo].[ChiTietPhieuDichVu] ([MaChiTietDichVu], [TenDichVu], [GiaDichVu], [MaPhieuDichVu], [MaDichVu]) VALUES (N'CTDV1               ', N'Xét nghiệm máu', 100000, N'DV1                 ', N'DV2                 ')
INSERT [dbo].[ChiTietPhieuDichVu] ([MaChiTietDichVu], [TenDichVu], [GiaDichVu], [MaPhieuDichVu], [MaDichVu]) VALUES (N'CTDV2               ', N'X quan', 100000, N'DV1                 ', N'DV3                 ')
INSERT [dbo].[ChiTietPhieuDichVu] ([MaChiTietDichVu], [TenDichVu], [GiaDichVu], [MaPhieuDichVu], [MaDichVu]) VALUES (N'CTDV3               ', N'Siêu âm', 100000, N'DV2                 ', N'DV4                 ')
INSERT [dbo].[ChiTietPhieuDichVu] ([MaChiTietDichVu], [TenDichVu], [GiaDichVu], [MaPhieuDichVu], [MaDichVu]) VALUES (N'CTDV4               ', N'X quan', 100000, N'DV2                 ', N'DV3                 ')
INSERT [dbo].[ChiTietPhieuDichVu] ([MaChiTietDichVu], [TenDichVu], [GiaDichVu], [MaPhieuDichVu], [MaDichVu]) VALUES (N'CTDV5               ', N'Xét nghiệm máu', 100000, N'DV3                 ', N'DV2                 ')
INSERT [dbo].[ChiTietPhieuDichVu] ([MaChiTietDichVu], [TenDichVu], [GiaDichVu], [MaPhieuDichVu], [MaDichVu]) VALUES (N'CTDV6               ', N'Siêu âm', 100000, N'DV3                 ', N'DV4                 ')
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [An]) VALUES (N'DV1                 ', N'Chụp X Quang', 123, 0)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [An]) VALUES (N'DV2                 ', N'Xét nghiệm máu', 100000, 1)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [An]) VALUES (N'DV3                 ', N'X quan', 100000, 1)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu], [An]) VALUES (N'DV4                 ', N'Siêu âm', 100000, 1)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongChiPhi]) VALUES (N'DT1                 ', N'PK1                 ', 100000)
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [MaPhieuKham], [TongChiPhi]) VALUES (N'DT2                 ', N'PK1                 ', 110000)
INSERT [dbo].[DSThuoc] ([MaThuoc], [TenThuoc], [Gia], [An]) VALUES (N'T1                  ', N'para', 10, NULL)
INSERT [dbo].[DSThuoc] ([MaThuoc], [TenThuoc], [Gia], [An]) VALUES (N'T2                  ', N'para', 10, NULL)
INSERT [dbo].[DSThuoc] ([MaThuoc], [TenThuoc], [Gia], [An]) VALUES (N'T3                  ', N'thuoc1', 1000, NULL)
INSERT [dbo].[DSThuoc] ([MaThuoc], [TenThuoc], [Gia], [An]) VALUES (N'T4                  ', N'paradon', 1000, 1)
INSERT [dbo].[DSThuoc] ([MaThuoc], [TenThuoc], [Gia], [An]) VALUES (N'T5                  ', N'Thuoc 1', 50000, 1)
INSERT [dbo].[DSThuoc] ([MaThuoc], [TenThuoc], [Gia], [An]) VALUES (N'T6                  ', N'Thuoc 1', 10000, 1)
INSERT [dbo].[DSThuoc] ([MaThuoc], [TenThuoc], [Gia], [An]) VALUES (N'T7                  ', N'Thuoc ', 10000, 1)
INSERT [dbo].[DSThuoc] ([MaThuoc], [TenThuoc], [Gia], [An]) VALUES (N'T8                  ', N'Thuoc 12', 1000, 0)
INSERT [dbo].[DSThuoc] ([MaThuoc], [TenThuoc], [Gia], [An]) VALUES (N'T9                  ', N'Panadol', 1000, 0)
INSERT [dbo].[GiuongBenh] ([MaBuong], [MaGiuong], [TrangThai]) VALUES (N'B1                  ', N'G1                  ', N'Có bệnh nhân')
INSERT [dbo].[GiuongBenh] ([MaBuong], [MaGiuong], [TrangThai]) VALUES (N'B2                  ', N'G2                  ', N'Trống')
INSERT [dbo].[GiuongBenh] ([MaBuong], [MaGiuong], [TrangThai]) VALUES (N'B3                  ', N'G3                  ', N'Trống')
INSERT [dbo].[GiuongBenh] ([MaBuong], [MaGiuong], [TrangThai]) VALUES (N'B1                  ', N'G4                  ', N'Trống')
INSERT [dbo].[GiuongBenh] ([MaBuong], [MaGiuong], [TrangThai]) VALUES (N'B4                  ', N'G5                  ', N'Trống')
INSERT [dbo].[GiuongBenh] ([MaBuong], [MaGiuong], [TrangThai]) VALUES (N'B4                  ', N'G6                  ', N'Trống')
INSERT [dbo].[GiuongBenh] ([MaBuong], [MaGiuong], [TrangThai]) VALUES (N'B3                  ', N'G7                  ', N'Trống')
INSERT [dbo].[HoSoBenhAn] ([MaHoSoBenhAn], [MaBN], [Benh], [MaPK]) VALUES (N'BA1                 ', N'BN1                 ', N'{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}
\viewkind4\uc1\pard\f0\fs17 benh vkl\par
}
', N'PK4                 ')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [TruongKhoa], [TonTai], [SLNV]) VALUES (N'KH1                 ', N'Tay', N'NV2                 ', 1, 2)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [TruongKhoa], [TonTai], [SLNV]) VALUES (N'KH2                 ', N'Mat', N'NV3                 ', 1, 1)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [TruongKhoa], [TonTai], [SLNV]) VALUES (N'KH3                 ', N'Than Kinh', N'NV6                 ', 1, 0)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [TruongKhoa], [TonTai], [SLNV]) VALUES (N'KH4                 ', N'Mieng', N'NV5                 ', 1, 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNhanVien], [GioiTinh], [NgaySinh], [MaKhoa], [TonTai]) VALUES (N'NV1                 ', N'Ten nhan vien 1', N'Nữ', CAST(N'1999-02-20 00:00:00.000' AS DateTime), N'KH1                 ', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNhanVien], [GioiTinh], [NgaySinh], [MaKhoa], [TonTai]) VALUES (N'NV2                 ', N'Ten nhan viên 2', N'Nam', CAST(N'1999-11-20 00:00:00.000' AS DateTime), N'KH1                 ', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNhanVien], [GioiTinh], [NgaySinh], [MaKhoa], [TonTai]) VALUES (N'NV3                 ', N'Ten nhan vien 3', N'Nữ', CAST(N'1999-05-05 00:00:00.000' AS DateTime), N'KH2                 ', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNhanVien], [GioiTinh], [NgaySinh], [MaKhoa], [TonTai]) VALUES (N'NV4                 ', N'Ten nhan vien 4', N'Nam', CAST(N'1999-02-14 00:00:00.000' AS DateTime), N'KH1                 ', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNhanVien], [GioiTinh], [NgaySinh], [MaKhoa], [TonTai]) VALUES (N'NV5                 ', N'Ten nhan vien 5', N'Nữ', CAST(N'1999-02-20 00:00:00.000' AS DateTime), N'KH4                 ', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNhanVien], [GioiTinh], [NgaySinh], [MaKhoa], [TonTai]) VALUES (N'NV6                 ', N'Ten nhan vien 6', N'Nam', CAST(N'1999-02-20 00:00:00.000' AS DateTime), N'KH3                 ', 1)
INSERT [dbo].[PhieuChuyenVien] ([MaPhieuChuyenVien], [MaPhieuNhapVien], [NgayChuyenVien], [TenBenhVienChuyenDi]) VALUES (N'PC1       ', N'PN2                 ', CAST(N'2021-01-15' AS Date), N'1A')
INSERT [dbo].[PhieuDichVu] ([MaPhieuDichVu], [TongChiPhiDichVu]) VALUES (N'DV1                 ', 200000)
INSERT [dbo].[PhieuDichVu] ([MaPhieuDichVu], [TongChiPhiDichVu]) VALUES (N'DV2                 ', 200000)
INSERT [dbo].[PhieuDichVu] ([MaPhieuDichVu], [TongChiPhiDichVu]) VALUES (N'DV3                 ', 200000)
INSERT [dbo].[PhieuKhamBenh] ([MaPhieuKham], [MaNV], [MaPhieuDichVu], [MaBenhNhan], [NgayKham], [TienKham], [TrangThai], [TrieuChung], [ChuanDoan]) VALUES (N'PK1                 ', N'NV1                 ', N'DV3                 ', N'BN1                 ', CAST(N'2020-09-20' AS Date), 150000, N'Đã khám xong', N'Ho, Sổ mũi', N'Chua có')
INSERT [dbo].[PhieuKhamBenh] ([MaPhieuKham], [MaNV], [MaPhieuDichVu], [MaBenhNhan], [NgayKham], [TienKham], [TrangThai], [TrieuChung], [ChuanDoan]) VALUES (N'PK2                 ', N'NV2                 ', N'DV2                 ', N'BN2                 ', CAST(N'2020-12-01' AS Date), 150000, N'Đã khám xong', N'Sổ mũi, sốt', N'Chua có')
INSERT [dbo].[PhieuKhamBenh] ([MaPhieuKham], [MaNV], [MaPhieuDichVu], [MaBenhNhan], [NgayKham], [TienKham], [TrangThai], [TrieuChung], [ChuanDoan]) VALUES (N'PK3                 ', N'NV1                 ', N'DV1                 ', N'BN1                 ', CAST(N'2020-09-20' AS Date), 150000, N'Đã khám xong', N'Nóng', N'Sốt')
INSERT [dbo].[PhieuKhamBenh] ([MaPhieuKham], [MaNV], [MaPhieuDichVu], [MaBenhNhan], [NgayKham], [TienKham], [TrangThai], [TrieuChung], [ChuanDoan]) VALUES (N'PK4                 ', N'NV1                 ', NULL, N'BN1                 ', CAST(N'2021-01-15' AS Date), 150000, N'Đã khám xong', N'Nóng', N'ho sot')
INSERT [dbo].[PhieuNhapVien] ([MaPhieuNhapVien], [NgayNhapVien], [MaKhoa], [MaGiuong], [MaBN], [TinhTrang]) VALUES (N'PN1                 ', CAST(N'2021-01-01' AS Date), N'KH1                 ', N'G1                  ', N'BN1                 ', N'Xuất viện')
INSERT [dbo].[PhieuNhapVien] ([MaPhieuNhapVien], [NgayNhapVien], [MaKhoa], [MaGiuong], [MaBN], [TinhTrang]) VALUES (N'PN2                 ', CAST(N'2021-01-01' AS Date), N'KH2                 ', N'G3                  ', N'BN2                 ', N'Đã chuyển viện')
INSERT [dbo].[PhieuNhapVien] ([MaPhieuNhapVien], [NgayNhapVien], [MaKhoa], [MaGiuong], [MaBN], [TinhTrang]) VALUES (N'PN3                 ', CAST(N'2021-01-15' AS Date), N'KH1                 ', N'G1                  ', N'BN1                 ', N'Đang Điều Trị')
INSERT [dbo].[PhieuXuatVien] ([MaPhieuXuatVien], [MaPhieuNhapVien], [NgayXuatVien]) VALUES (N'PX1                 ', N'PN1                 ', CAST(N'2021-01-15' AS Date))
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [MaNhanVien], [TaiKhoan], [MatKhau], [Email], [SDT]) VALUES (N'TK1       ', N'NV1       ', N'admin                                             ', N'admin                                             ', N'leanhtruong19992017@gmail.com                                                                       ', N'1111111111          ')
INSERT [dbo].[VienPhi] ([MaVienPhi], [MaBenhNhan], [TienKham], [TienDichVu], [TienThuoc], [TongTien], [TinhTrang], [NgayLap], [NgayThanhToan], [MaPK]) VALUES (N'VP1                 ', N'BN1                 ', 150000, 200000, 110000, 460000, N'Đã thanh toán', CAST(N'2021-01-16' AS Date), CAST(N'2021-01-16' AS Date), N'PK1       ')
