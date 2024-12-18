USE [QuanLySieuThi]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetHdByMaHd]    Script Date: 11/21/2024 5:18:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DoanhThuTheoNam]
(@nam int )
as
begin
SELECT 
    MONTH(NgayLapHD) AS Thang, 
    YEAR(NgayLapHD) AS Nam, 
    SUM(TongTien) AS DoanhThu,
    SUM(SUM(TongTien)) OVER (PARTITION BY YEAR(NgayLapHD)) AS TongDoanhThuNam
FROM 
    HoaDon
WHERE 
    YEAR(NgayLapHD) = @nam -- Thay 2024 bằng năm cụ thể bạn muốn lấy
GROUP BY 
    MONTH(NgayLapHD), 
    YEAR(NgayLapHD)
ORDER BY 
    Nam, Thang;
end
go

-- exec [sp_DoanhThuTheoNam] 2022

create proc sp_BaoCaoDoanhThuTheoThang(@nam int = 2024, @thang int = 10)
as
begin
SELECT 
	Day(NgayLapHD) AS Ngay,
    MONTH(NgayLapHD) AS Thang, 
    YEAR(NgayLapHD) AS Nam, 
    SUM(TongTien) AS DoanhThu,
	SUM(SUM(TongTien)) OVER (PARTITION BY YEAR(NgayLapHD)) AS TongDoanhThang
FROM 
    HoaDon
WHERE 
    YEAR(NgayLapHD) = @nam and MONTH(NgayLapHD) = @thang-- Thay @Nam bằng năm cụ thể bạn muốn lấy
GROUP BY 
    DAY(NgayLapHD),
	MONTH(NgayLapHD),
	YEAR(NgayLapHD)
ORDER BY 
    Ngay,Thang, Nam;
end
go

create PROCEDURE sp_BaoCaoBangLuong
    @idBangLuong INT = 1
AS
BEGIN
    -- Tắt thông báo lỗi tạm thời nếu có
    SET NOCOUNT ON;

    -- Lấy báo cáo bảng lương
    SELECT 
        nv.TenNhanVien,  -- Tên nhân viên từ bảng nhân viên
        ctl.NgayLam AS NgayLam,  -- Ngày làm việc
        ctl.SoGioCongThucTe AS GioCong,  -- Số giờ công thực tế
        bl.TongGioCong,  -- Tổng giờ công từ bảng lương
        bl.Luong,  -- Lương từ bảng lương
		Month(NgayLam) as Thang,
		DAY(NgayLam) as Ngay
    FROM BangLuong bl
    INNER JOIN ChiTietBangLuong ctl ON bl.id = ctl.idBangLuong
    INNER JOIN NhanVien nv ON bl.idNhanVien = nv.id
    WHERE 
        ctl.idBangLuong = @idBangLuong; -- Không lấy dữ liệu chi tiết bị xóa
END;



