USE [master]
GO
/****** Object:  Database [QuanLySieuThi]    Script Date: 11/12/2024 1:26:36 PM ******/
CREATE DATABASE [QuanLySieuThi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySieuThi', FILENAME = N'D:\PROGRAM\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLySieuThi.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLySieuThi_log', FILENAME = N'D:\PROGRAM\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLySieuThi_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLySieuThi] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySieuThi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySieuThi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLySieuThi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLySieuThi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLySieuThi] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLySieuThi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLySieuThi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLySieuThi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLySieuThi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLySieuThi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLySieuThi] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLySieuThi] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLySieuThi]
GO
/****** Object:  Table [dbo].[BangLuong]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangLuong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaBangLuong] [varchar](30) NULL,
	[ThangNam] [datetime] NULL,
	[TongGioCong] [float] NULL,
	[Luong] [float] NULL,
	[idNhanVien] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_BangLuong_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CaLam]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaLam](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaCaLam] [varchar](30) NULL,
	[TenCaLam] [nvarchar](100) NULL,
	[GioBatDau] [nvarchar](100) NULL,
	[GioKetThuc] [nvarchar](100) NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_CaLam] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaChiNhanh] [varchar](30) NULL,
	[TenChiNhanh] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietBangLuong]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietBangLuong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaChiTietBangLuong] [varchar](30) NULL,
	[SoGioCongThucTe] [float] NULL,
	[NgayLam] [datetime] NULL,
	[idBangLuong] [int] NULL,
	[idLichLam] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_ChiTietBangLuong] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SoLuong] [int] NULL,
	[idHoaDon] [int] NULL,
	[idSanPham] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[idPhieuNhap] [int] NULL,
	[idSanPham] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaHoaDon] [varchar](30) NULL,
	[NgayLapHD] [datetime] NULL,
	[GioLapHD] [datetime] NULL,
	[TongTien] [float] NULL,
	[ThanhTien] [float] NULL,
	[idKhachHang] [int] NULL,
	[idKhuyenMai] [int] NULL,
	[idNhanVien] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [varchar](30) NULL,
	[TenKhachHang] [nvarchar](100) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[Diem] [float] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SoLuong] [int] NULL,
	[idSanPham] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_KhoHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaKhuyenMai] [varchar](30) NULL,
	[TenKhuyenMai] [nvarchar](100) NULL,
	[GiaTri] [float] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichLam]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichLam](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaLichLam] [varchar](30) NULL,
	[NgayLam] [datetime] NULL,
	[idNhanVien] [int] NULL,
	[idCaLam] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_LichLam] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiHang] [varchar](30) NULL,
	[TenLoaiHang] [nvarchar](100) NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_NhomHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiNhanVien] [varchar](30) NULL,
	[TenLoaiNhanVien] [nvarchar](100) NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[log_name] [varchar](100) NULL,
	[model] [varchar](100) NULL,
	[model_id] [int] NULL,
	[action] [varchar](100) NULL,
	[data_olds] [varchar](100) NULL,
	[data_news] [varchar](100) NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNhaCungCap] [varchar](30) NULL,
	[TenNhaCungCap] [nvarchar](100) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [varchar](30) NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[idLoaiNhanVien] [int] NULL,
	[idTaiKhoan] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuNhap] [varchar](30) NULL,
	[NgayNhap] [datetime] NULL,
	[ThanhTien] [float] NULL,
	[idNhanVien] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaSanPham] [varchar](30) NULL,
	[TenSanPham] [nvarchar](100) NULL,
	[DonViTinh] [nvarchar](100) NULL,
	[DonGia] [float] NULL,
	[NgaySanXuat] [datetime] NULL,
	[HanSuDung] [datetime] NULL,
	[AnhSanPham] [varbinary](max) NULL,
	[idLoaiHang] [int] NULL,
	[idNhaCungCap] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaTaiKhoan] [varchar](30) NULL,
	[TenTaiKhoan] [varchar](100) NULL,
	[MatKhau] [varchar](100) NULL,
	[Quyen] [int] NULL,
	[is_deleted] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD  CONSTRAINT [FK_BangLuong_NhanVien] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[BangLuong] CHECK CONSTRAINT [FK_BangLuong_NhanVien]
GO
ALTER TABLE [dbo].[ChiTietBangLuong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBangLuong_BangLuong] FOREIGN KEY([idBangLuong])
REFERENCES [dbo].[BangLuong] ([id])
GO
ALTER TABLE [dbo].[ChiTietBangLuong] CHECK CONSTRAINT [FK_ChiTietBangLuong_BangLuong]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([idHoaDon])
REFERENCES [dbo].[HoaDon] ([id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([idSanPham])
REFERENCES [dbo].[SanPham] ([id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([idPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([id])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_SanPham] FOREIGN KEY([idSanPham])
REFERENCES [dbo].[SanPham] ([id])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_KhachHang] FOREIGN KEY([idKhachHang])
REFERENCES [dbo].[KhachHang] ([id])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_KhoHang_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_KhuyenMai] FOREIGN KEY([idKhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([id])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_KhoHang_KhuyenMai]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_NhanVien] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_KhoHang_NhanVien]
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_SanPham] FOREIGN KEY([idSanPham])
REFERENCES [dbo].[SanPham] ([id])
GO
ALTER TABLE [dbo].[KhoHang] CHECK CONSTRAINT [FK_KhoHang_SanPham]
GO
ALTER TABLE [dbo].[LichLam]  WITH CHECK ADD  CONSTRAINT [FK_LichLam_CaLam] FOREIGN KEY([idCaLam])
REFERENCES [dbo].[CaLam] ([id])
GO
ALTER TABLE [dbo].[LichLam] CHECK CONSTRAINT [FK_LichLam_CaLam]
GO
ALTER TABLE [dbo].[LichLam]  WITH CHECK ADD  CONSTRAINT [FK_LichLam_NhanVien] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[LichLam] CHECK CONSTRAINT [FK_LichLam_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_LoaiNhanVien] FOREIGN KEY([idLoaiNhanVien])
REFERENCES [dbo].[LoaiNhanVien] ([id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_LoaiNhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoan] FOREIGN KEY([idTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoan]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([id])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaCungCap] FOREIGN KEY([idNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([id])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaCungCap]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhomHang] FOREIGN KEY([idLoaiHang])
REFERENCES [dbo].[LoaiHang] ([id])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhomHang]
GO
/****** Object:  StoredProcedure [dbo].[abc]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[abc]
as
GO
/****** Object:  StoredProcedure [dbo].[sp_GetHdByMaHd]    Script Date: 11/12/2024 1:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_GetHdByMaHd](@maHoaDon VARCHAR(30))
AS
BEGIN
	WITH InvoiceDetails AS (
		SELECT
			ROW_NUMBER() OVER (ORDER BY hd.id) AS STT,
			hd.id AS Id,
			hd.MaHoaDon AS MaHoaDon,
			sp.TenSanPham AS TenSanPham,
			cthd.SoLuong AS SoLuong,
			sp.DonGia AS DonGia,
			(cthd.SoLuong * sp.DonGia) AS ThanhTien,
			hd.TongTien AS TongTienHoaDon,
			hd.NgayLapHD AS NgayLapHD,
			kh.TenKhachHang AS TenKhachHang,
			km.TenKhuyenMai AS TenKhuyenMai,
			nv.TenNhanVien AS TenNhanVien	
		FROM HoaDon AS hd
			JOIN ChiTietHoaDon AS cthd ON hd.id = cthd.idHoaDon
			JOIN SanPham AS sp ON cthd.idSanPham = sp.id
			JOIN KhoHang AS kho ON sp.id = kho.idSanPham
			JOIN NhanVien AS nv ON hd.idNhanVien = nv.id
			JOIN KhachHang AS kh ON hd.idKhachHang = kh.id
			JOIN KhuyenMai AS km ON hd.idKhuyenMai = km.id
		WHERE hd.MaHoaDon = @maHoaDon
	)
	SELECT *,
		MAX(STT) OVER () AS MaxSTT
	FROM InvoiceDetails a;
END;

GO
USE [master]
GO
ALTER DATABASE [QuanLySieuThi] SET  READ_WRITE 
GO
