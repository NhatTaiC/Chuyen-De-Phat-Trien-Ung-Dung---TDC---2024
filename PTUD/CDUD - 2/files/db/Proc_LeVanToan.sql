-- select * from ChiTietPhieuNhap
use QuanLySieuThi;
go

CREATE PROCEDURE sp_TinhLoiNhuanTheoThang
    @Thang INT,
    @Nam INT
AS
BEGIN
    -- Tính tổng chi phí từ bảng PhieuNhap
    DECLARE @TongChiPhi FLOAT;
    SELECT @TongChiPhi = ISNULL(SUM(ThanhTien), 0)
    FROM PhieuNhap
    WHERE 
        MONTH(NgayNhap) = @Thang 
        AND YEAR(NgayNhap) = @Nam
        AND is_deleted = 0;

    -- Tính tổng doanh thu từ bảng HoaDon
    DECLARE @TongDoanhThu FLOAT;
    SELECT @TongDoanhThu = ISNULL(SUM(ThanhTien), 0)
    FROM HoaDon
    WHERE 
        MONTH(NgayLapHD) = @Thang 
        AND YEAR(NgayLapHD) = @Nam
        AND is_deleted = 0;

    -- Tính lợi nhuận
    DECLARE @LoiNhuan FLOAT;
    SET @LoiNhuan = @TongDoanhThu - @TongChiPhi;

    -- Kết quả trả về
    SELECT 
        @TongChiPhi AS TongChiPhi,
        @TongDoanhThu AS TongDoanhThu,
        @LoiNhuan AS LoiNhuan;
END;
GO

CREATE PROCEDURE sp_ThongKeSanPhamTrongKho
AS
BEGIN
    -- Truy xuất danh sách sản phẩm còn lại trong kho với số lượng > 0
    SELECT 
        sp.id AS SanPhamID,
        sp.TenSanPham,
        kh.SoLuong AS SoLuongTonKho,
        kh.updated_at AS NgayCapNhatCuoi
    FROM KhoHang kh
    JOIN SanPham sp ON kh.idSanPham = sp.id
    WHERE 
        kh.is_deleted = 0 -- Chỉ lấy sản phẩm chưa bị xóa
        AND kh.SoLuong > 0 -- Chỉ lấy sản phẩm có số lượng > 0
    ORDER BY kh.updated_at DESC; -- Sắp xếp theo ngày cập nhật gần nhất
END;
GO

-- EXEC sp_ThongKeSanPhamTrongKho;


-- EXEC sp_TinhLoiNhuanTheoThang @Thang = 11, @Nam = 2024;
