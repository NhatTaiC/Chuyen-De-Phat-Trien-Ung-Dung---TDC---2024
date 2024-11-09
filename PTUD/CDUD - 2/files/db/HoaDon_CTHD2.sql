use QuanLySieuThi

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

go