/*
Nhóm 2 - PTUD
Châu Nhật Tài
Nguyễn Quốc Lượng
Lê Văn Toàn
10/11/2024
NhatTai_SP.sql
*/

use QuanLySieuThi
go

create proc sp_GetHdByMaHd(@maHoaDon varchar(30))
as
	select
	hd.id as Id,
	hd.MaHoaDon as MaHoaDon,
	sp.TenSanPham as TenSanPham,
	cthd.SoLuong as SoLuong,
	sp.DonGia as DonGia,
	(cthd.SoLuong * sp.DonGia) as ThanhTien,
	hd.TongTien as TongTienHoaDon,
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
go

-- exec sp_GetHdByMaHd 'HD001'
-- drop proc sp_GetHdByMaHd