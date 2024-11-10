use QuanLySieuThi

select * from KhuyenMai
	where id = (
	select max(id) from KhuyenMai)
go