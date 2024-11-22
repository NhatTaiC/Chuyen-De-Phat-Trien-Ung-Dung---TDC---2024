use QuanLySieuThi

select * from HoaDon

select * from ChiTietHoaDon
where idHoaDon = 1 and idSanPham = 7 and is_deleted = 0

select Id = sp.id, TenSanPham = sp.TenSanPham, SoLuong = kh.SoLuong from SanPham as sp
join KhoHang as kh
on sp.id = kh.idSanPham
where sp.is_deleted = 0 and sp.id = 1

select hd.MaHoaDon, sp.TenSanPham, cthd.SoLuong, sp.DonGia,
cthd.SoLuong * sp.DonGia as ThanhTien from ChiTietHoaDon as cthd
join SanPham as sp
on cthd.idSanPham = sp.id
join HoaDon as hd
on cthd.idHoaDon = hd.id
where cthd.idHoaDon = 1

select * from SanPham as sp
where sp.DonViTinh = N'Chai'

select
	hd.id as Id,
	hd.MaHoaDon as MaHoaDon,
	sp.TenSanPham as TenSanPham,
	cthd.SoLuong as SoLuong,
	sp.DonGia as DonGia,
	(cthd.SoLuong * sp.DonGia) as ThanhTien,
	hd.TongTien as TongTienHoaDon
		from HoaDon as hd
			join ChiTietHoaDon as cthd
			on hd.id = cthd.idHoaDon
			join SanPham as sp
			on cthd.idSanPham = sp.id
			join KhoHang as kho
			on sp.id = kho.idSanPham
			where hd.id = 1

select * from HoaDon
where MaHoaDon = 'HD001'

select * from Log
go