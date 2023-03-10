USE [master]
GO
/****** Object:  Database [QuanLyChuyenBay]    Script Date: 11/4/2022 10:29:25 AM ******/
CREATE DATABASE [QuanLyChuyenBay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyChuyenBay', FILENAME = N'D:\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyChuyenBay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyChuyenBay_log', FILENAME = N'D:\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyChuyenBay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyChuyenBay] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
GO
ALTER DATABASE [QuanLyChuyenBay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyChuyenBay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyChuyenBay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyChuyenBay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyChuyenBay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyChuyenBay] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyChuyenBay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyChuyenBay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyChuyenBay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyChuyenBay] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyChuyenBay] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyChuyenBay] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyChuyenBay', N'ON'
GO
ALTER DATABASE [QuanLyChuyenBay] SET QUERY_STORE = OFF
GO
USE [QuanLyChuyenBay]
GO
/****** Object:  Table [dbo].[ChuyenBay]    Script Date: 11/4/2022 10:29:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenBay](
	[macb] [nvarchar](10) NOT NULL,
	[sbdi] [nvarchar](50) NULL,
	[sbden] [nvarchar](50) NULL,
	[giodi] [time](0) NULL,
	[gioden] [time](0) NULL,
	[ngaydi] [date] NULL,
	[ngayden] [date] NULL,
	[sohieu] [nvarchar](10) NULL,
 CONSTRAINT [PK_ChuyenBay] PRIMARY KEY CLUSTERED 
(
	[macb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatCho]    Script Date: 11/4/2022 10:29:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatCho](
	[soghe] [nvarchar](10) NOT NULL,
	[makh] [nvarchar](10) NULL,
	[macb] [nvarchar](10) NULL,
	[thoigiandi] [date] NULL,
 CONSTRAINT [PK_DatCho] PRIMARY KEY CLUSTERED 
(
	[soghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/4/2022 10:29:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[makh] [nvarchar](10) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[cmt] [nvarchar](50) NULL,
	[ten_dn] [varchar](20) NULL,
	[dadatcho] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichBay]    Script Date: 11/4/2022 10:29:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichBay](
	[ngaydi] [date] NOT NULL,
	[macb] [nvarchar](10) NULL,
	[sohieu] [nvarchar](10) NULL,
 CONSTRAINT [PK_LichBay] PRIMARY KEY CLUSTERED 
(
	[ngaydi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMayBay]    Script Date: 11/4/2022 10:29:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMayBay](
	[maloai] [nvarchar](10) NOT NULL,
	[hang_sx] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiMayBY] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MayBay]    Script Date: 11/4/2022 10:29:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MayBay](
	[sohieu] [nvarchar](10) NOT NULL,
	[maloai] [nvarchar](10) NULL,
 CONSTRAINT [PK_MayBay] PRIMARY KEY CLUSTERED 
(
	[sohieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 11/4/2022 10:29:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[ten_dn] [varchar](20) NOT NULL,
	[matkhau] [varchar](20) NULL,
	[loainguoidung] [int] NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[ten_dn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChuyenBay] ([macb], [sbdi], [sbden], [giodi], [gioden], [ngaydi], [ngayden], [sohieu]) VALUES (N'cb01', N'Nội Bài', N'Đà Nẵng', CAST(N'17:14:20' AS Time), CAST(N'19:14:20' AS Time), CAST(N'2022-10-30' AS Date), CAST(N'2022-10-30' AS Date), N'sh01')
INSERT [dbo].[ChuyenBay] ([macb], [sbdi], [sbden], [giodi], [gioden], [ngaydi], [ngayden], [sohieu]) VALUES (N'cb02', N'Cần Thơ', N'Đà Nẵng', CAST(N'06:14:20' AS Time), CAST(N'07:14:20' AS Time), CAST(N'2022-10-30' AS Date), CAST(N'2022-10-30' AS Date), N'sh02')
INSERT [dbo].[ChuyenBay] ([macb], [sbdi], [sbden], [giodi], [gioden], [ngaydi], [ngayden], [sohieu]) VALUES (N'cb03', N'Nội Bài', N'Cần Thơ 2', CAST(N'16:14:20' AS Time), CAST(N'19:14:20' AS Time), CAST(N'2022-10-30' AS Date), CAST(N'2022-10-30' AS Date), N'sh03')
GO
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A01', N'kh01', N'cb01', CAST(N'2022-10-09' AS Date))
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A02', N'kh02', N'cb01', CAST(N'2022-10-09' AS Date))
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A03', N'kh05', N'cb01', CAST(N'2022-11-01' AS Date))
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A04', N'kh03', N'cb01', CAST(N'2022-11-04' AS Date))
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A05', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A06', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A07', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A08', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A09', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A10', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A11', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A12', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A13', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A14', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A15', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A16', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A17', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A18', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A19', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'A20', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'B01', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'B02', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'B03', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'B04', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'B05', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'B06', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'B07', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'B08', NULL, NULL, NULL)
INSERT [dbo].[DatCho] ([soghe], [makh], [macb], [thoigiandi]) VALUES (N'B09', NULL, NULL, NULL)
GO
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'admin', N'Đỗ Quang', N'Ha Nội', N'0972533708', N'0342010000717', N'admin', 0)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh01', N'Đỗ Văn Quang', N'Hà Nội', N'0972533708', N'034201000717', N'dvquang2001', 1)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh02', N'Nguyễn Văn Mạnh', N'Hà Nam', N'0932843212', N'032432443333', N'user', 1)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh03', N'Trần Văn Tú', N'Hà Nội', N'0984329323', N'023435454532', N'nguoivohinh', 1)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh04', N'Hoàng Gia Bảo', N'Nam Định', N'0989833321', N'035322312342', N'chuechxanh222', 0)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh05', N'Hoàng Minh Quân', N'Thái Bình', N'0983983232', N'043343455645', N'conchimnon', 1)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh06', N'Trần Văn Nhân', N'Hà Nội', N'0984343243', N'034344343222', N'user01', 1)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh07', N'Nguyễn Văn Lâm', N'Hưng Yên', N'0342345433', N'034678687282', N'codon', 0)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh08', N'Đào Văn Hùng', N'Vĩnh Phúc', N'0972512353', N'034657578213', N'quang2021', 0)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh09', N'Lê Thanh Tùng', N'Hải Phòng', N'0987643787', N'034423987857', N'nam2022', 1)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh10', N'Trần Minh Hoàng', N'Quảng Ninh', N'0872347690', N'034898342333', N'gacon111', 1)
INSERT [dbo].[KhachHang] ([makh], [ten], [diachi], [sdt], [cmt], [ten_dn], [dadatcho]) VALUES (N'kh11', N'Nguyễn Thanh Tâm', N'Ninh Bình', N'0947364739', N'034334734289', N'vitcon222', 1)
GO
INSERT [dbo].[LichBay] ([ngaydi], [macb], [sohieu]) VALUES (CAST(N'2022-09-08' AS Date), N'cb03', N'sh04')
INSERT [dbo].[LichBay] ([ngaydi], [macb], [sohieu]) VALUES (CAST(N'2022-09-30' AS Date), N'cb02', N'sh02')
INSERT [dbo].[LichBay] ([ngaydi], [macb], [sohieu]) VALUES (CAST(N'2022-10-30' AS Date), N'cb01', N'sh01')
GO
INSERT [dbo].[LoaiMayBay] ([maloai], [hang_sx]) VALUES (N'm1', N'Airbus')
INSERT [dbo].[LoaiMayBay] ([maloai], [hang_sx]) VALUES (N'm2', N'Antonov')
INSERT [dbo].[LoaiMayBay] ([maloai], [hang_sx]) VALUES (N'm3', N'Comac')
INSERT [dbo].[LoaiMayBay] ([maloai], [hang_sx]) VALUES (N'm4', N'Bombadier')
INSERT [dbo].[LoaiMayBay] ([maloai], [hang_sx]) VALUES (N'm5', N'Embraer')
GO
INSERT [dbo].[MayBay] ([sohieu], [maloai]) VALUES (N'r3r3s', N'm1')
INSERT [dbo].[MayBay] ([sohieu], [maloai]) VALUES (N'sh01', N'm3')
INSERT [dbo].[MayBay] ([sohieu], [maloai]) VALUES (N'sh02', N'm2')
INSERT [dbo].[MayBay] ([sohieu], [maloai]) VALUES (N'sh03', N'm5')
INSERT [dbo].[MayBay] ([sohieu], [maloai]) VALUES (N'sh04', N'm1')
GO
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'admin', N'admin', 1)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'chuechxanh222', N'12345678', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'codon', N'12345678', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'conchimnon', N'123456789', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'dvquang2001', N'12345678', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'gacon111', N'12345678', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'nam2022', N'12345678', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'nguoivohinh', N'12345678', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'quang2001', N'12345678', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'quang2021', N'12345678', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'user', N'12345678', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'user01', N'12345678', 0)
INSERT [dbo].[NguoiDung] ([ten_dn], [matkhau], [loainguoidung]) VALUES (N'vitcon222', N'12345678', 0)
GO
ALTER TABLE [dbo].[ChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenBay_MayBay] FOREIGN KEY([sohieu])
REFERENCES [dbo].[MayBay] ([sohieu])
GO
ALTER TABLE [dbo].[ChuyenBay] CHECK CONSTRAINT [FK_ChuyenBay_MayBay]
GO
ALTER TABLE [dbo].[DatCho]  WITH CHECK ADD  CONSTRAINT [FK_DatCho_ChuyenBay] FOREIGN KEY([macb])
REFERENCES [dbo].[ChuyenBay] ([macb])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[DatCho] CHECK CONSTRAINT [FK_DatCho_ChuyenBay]
GO
ALTER TABLE [dbo].[DatCho]  WITH CHECK ADD  CONSTRAINT [FK_DatCho_KhachHang] FOREIGN KEY([makh])
REFERENCES [dbo].[KhachHang] ([makh])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[DatCho] CHECK CONSTRAINT [FK_DatCho_KhachHang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_NguoiDung] FOREIGN KEY([ten_dn])
REFERENCES [dbo].[NguoiDung] ([ten_dn])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_NguoiDung]
GO
ALTER TABLE [dbo].[LichBay]  WITH CHECK ADD  CONSTRAINT [FK_LichBay_ChuyenBay] FOREIGN KEY([macb])
REFERENCES [dbo].[ChuyenBay] ([macb])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[LichBay] CHECK CONSTRAINT [FK_LichBay_ChuyenBay]
GO
ALTER TABLE [dbo].[LichBay]  WITH CHECK ADD  CONSTRAINT [FK_LichBay_MayBay] FOREIGN KEY([sohieu])
REFERENCES [dbo].[MayBay] ([sohieu])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[LichBay] CHECK CONSTRAINT [FK_LichBay_MayBay]
GO
ALTER TABLE [dbo].[MayBay]  WITH CHECK ADD  CONSTRAINT [FK_MayBay_LoaiMayBay] FOREIGN KEY([maloai])
REFERENCES [dbo].[LoaiMayBay] ([maloai])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[MayBay] CHECK CONSTRAINT [FK_MayBay_LoaiMayBay]
GO
USE [master]
GO
ALTER DATABASE [QuanLyChuyenBay] SET  READ_WRITE 
GO
