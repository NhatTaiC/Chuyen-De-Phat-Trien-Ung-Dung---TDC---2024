USE [QuanLySieuThi]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetHdByMaHd]    Script Date: 11/21/2024 5:18:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[sp_GetHdByMaHd](@maHoaDon varchar(30) = 'HD021')
as
	select
	hd.id as Id,
	hd.MaHoaDon as MaHoaDon,
	sp.TenSanPham as TenSanPham,
	cthd.SoLuong as SoLuong,
	sp.DonGia as DonGia,
	(cthd.SoLuong * sp.DonGia) as ThanhTien,
	hd.TongTien as TongTienHoaDon,
	ROUND(((km.GiaTri) / 100) * hd.TongTien, 0) as TienKhuyenMai,
	hd.TongTien - ROUND(((km.GiaTri) / 100) * hd.TongTien, 0) as TienPhaiTra,
	hd.NgayLapHD as NgayLapHD,
	kh.TenKhachHang as TenKhachHang,
	km.TenKhuyenMai as TenKhuyenMai,
	nv.TenNhanVien as TenNhanVien
		from HoaDon as hd
			join ChiTietHoaDon as cthd
			on hd.id = cthd.idHoaDon
			join SanPham as sp
			on cthd.idSanPham = sp.id
			join KhoHang as kho
			on sp.id = kho.idSanPham
			join NhanVien as nv
			on hd.idNhanVien = nv.id
			join KhachHang as kh
			on hd.idKhachHang = kh.id
			join KhuyenMai as km
			on hd.idKhuyenMai = km.id
			where hd.MaHoaDon = @maHoaDon

