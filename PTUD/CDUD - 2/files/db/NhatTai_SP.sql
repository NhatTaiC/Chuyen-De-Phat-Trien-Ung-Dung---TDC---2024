/*
Nhóm 2 - PTUD
Châu Nhật Tài
Nguyễn Quốc Lượng
Lê Văn Toàn
10/11/2024
NhatTai_SP.sql
*/

USE QuanLySieuThi;
GO


CREATE PROCEDURE sp_GetHdByMaHd(@maHoaDon VARCHAR(30) = 'HD001')
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
			ROUND(((km.GiaTri) / 100) * hd.TongTien, 0) as TienKhuyenMai,
			hd.TongTien - ROUND(((km.GiaTri) / 100) * hd.TongTien, 0) as TienPhaiTra,
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

-- EXEC sp_GetHdByMaHd 'HD001'
-- DROP PROC sp_GetHdByMaHd