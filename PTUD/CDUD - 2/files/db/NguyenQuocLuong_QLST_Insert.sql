--LoaiHang
INSERT INTO LoaiHang (MaLoaiHang, TenLoaiHang, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES 
('LH001', N'Rau củ quả', 0, 0, GETDATE(), 0, GETDATE()),
('LH002', N'Đồ uống', 0, 0, GETDATE(), 0, GETDATE()),
('LH003', N'Sữa và các sản phẩm từ sữa', 0, 0, GETDATE(), 0, GETDATE()),
('LH004', N'Thịt tươi sống', 0, 0, GETDATE(), 0, GETDATE()),
('LH005', N'Đồ hộp', 0, 0, GETDATE(), 0, GETDATE()),
('LH006', N'Gia vị', 0, 0, GETDATE(), 0, GETDATE()),
('LH007', N'Hóa mỹ phẩm', 0, 0, GETDATE(), 0, GETDATE()),
('LH008', N'Dụng cụ gia đình', 0, 0, GETDATE(), 0, GETDATE()),
('LH009', N'Bánh kẹo', 0, 0, GETDATE(), 0, GETDATE()),
('LH010', N'Đồ ăn nhanh', 0, 0, GETDATE(), 0, GETDATE());

-- Insert into NhaCungCap
INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, SoDienThoai, DiaChi, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES 
('NCC001', N'Công ty Thực Phẩm Sạch', '0901234567', N'123 Đường ABC, Quận 1, TP.HCM', 0, 0, GETDATE(), 0, GETDATE());

-- Insert into SanPham
INSERT INTO SanPham (MaSanPham, TenSanPham, idLoaiHang, DonViTinh, DonGia, idNhaCungCap, NgaySanXuat, HanSuDung, AnhSanPham, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES 
-- Rau củ quả (idNhomHang = 1)
('SP001', N'Cà chua', 1, N'Kg', 20000, 1, '2024-09-01', '2024-09-15', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP002', N'Dưa leo', 1, N'Kg', 18000, 1, '2024-09-03', '2024-09-20', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP003', N'Cà rốt', 1, N'Kg', 22000, 1, '2024-09-05', '2024-09-25', NULL, 0, 0, GETDATE(), 0, GETDATE()),

-- Đồ uống (idNhomHang = 2)
('SP004', N'Nước suối', 2, N'Chai', 5000, 1, '2024-08-01', '2025-08-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP005', N'Nước ngọt có gas', 2, N'Lốc', 45000, 1, '2024-07-15', '2025-07-15', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP006', N'Nước trái cây', 2, N'Chai', 30000, 1, '2024-08-10', '2025-08-10', NULL, 0, 0, GETDATE(), 0, GETDATE()),

-- Sữa và các sản phẩm từ sữa (idNhomHang = 3)
('SP007', N'Sữa tươi', 3, N'Hộp', 12000, 1, '2024-08-20', '2025-08-20', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP008', N'Sữa chua', 3, N'Lốc', 60000, 1, '2024-09-01', '2024-10-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP009', N'Phô mai', 3, N'Hộp', 45000, 1, '2024-08-25', '2025-02-25', NULL, 0, 0, GETDATE(), 0, GETDATE()),

-- Thịt tươi sống (idNhomHang = 4)
('SP010', N'Thịt bò', 4, N'Kg', 250000, 1, '2024-10-01', '2024-10-10', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP011', N'Thịt gà', 4, N'Kg', 150000, 1, '2024-10-03', '2024-10-15', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP012', N'Thịt heo', 4, N'Kg', 130000, 1, '2024-10-05', '2024-10-12', NULL, 0, 0, GETDATE(), 0, GETDATE()),

-- Đồ hộp (idNhomHang = 5)
('SP013', N'Cá hộp', 5, N'Hộp', 40000, 1, '2024-05-10', '2025-05-10', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP014', N'Thịt hộp', 5, N'Hộp', 60000, 1, '2024-06-01', '2025-06-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP015', N'Rau hộp', 5, N'Hộp', 35000, 1, '2024-07-15', '2025-07-15', NULL, 0, 0, GETDATE(), 0, GETDATE());

-- Insert into SanPham
INSERT INTO SanPham (MaSanPham, TenSanPham, idLoaiHang, DonViTinh, DonGia, idNhaCungCap, NgaySanXuat, HanSuDung, AnhSanPham, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES 
-- Gia vị (idNhomHang = 6)
('SP016', N'Muối', 6, N'Gói', 5000, 1, '2024-08-01', '2025-08-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP017', N'Tiêu', 6, N'Hộp', 25000, 1, '2024-07-01', '2025-07-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP018', N'Nước mắm', 6, N'Chai', 35000, 1, '2024-06-01', '2025-06-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),

-- Hóa mỹ phẩm (idNhomHang = 7)
('SP019', N'Bột giặt', 7, N'Túi', 120000, 1, '2024-04-01', '2025-04-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP020', N'Nước rửa chén', 7, N'Chai', 45000, 1, '2024-05-10', '2025-05-10', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP021', N'Kem đánh răng', 7, N'Tuýp', 35000, 1, '2024-07-01', '2025-07-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),

-- Dụng cụ gia đình (idNhomHang = 8)
('SP022', N'Chảo chống dính', 8, N'Cái', 250000, 1, '2024-02-15', '2026-02-15', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP023', N'Bình nước', 8, N'Cái', 75000, 1, '2024-03-01', '2026-03-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP024', N'Nồi cơm điện', 8, N'Cái', 1200000, 1, '2024-01-10', '2026-01-10', NULL, 0, 0, GETDATE(), 0, GETDATE()),

-- Bánh kẹo (idNhomHang = 9)
('SP025', N'Bánh quy', 9, N'Hộp', 60000, 1, '2024-08-20', '2025-08-20', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP026', N'Kẹo dẻo', 9, N'Gói', 25000, 1, '2024-09-01', '2025-09-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP027', N'Chocolate', 9, N'Thanh', 55000, 1, '2024-07-15', '2025-07-15', NULL, 0, 0, GETDATE(), 0, GETDATE()),

-- Đồ ăn nhanh (idNhomHang = 10)
('SP028', N'Mì gói', 10, N'Gói', 5000, 1, '2024-08-01', '2025-08-01', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP029', N'Pizza đông lạnh', 10, N'Hộp', 95000, 1, '2024-07-20', '2025-01-20', NULL, 0, 0, GETDATE(), 0, GETDATE()),
('SP030', N'Xúc xích', 10, N'Kg', 120000, 1, '2024-08-10', '2025-08-10', NULL, 0, 0, GETDATE(), 0, GETDATE());

-- dữ liệu kho hàng
INSERT INTO KhoHang(idSanPham, SoLuong, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES 
(1, 100, 0, 0, GETDATE(), 0, GETDATE()),
(2, 150, 0, 0, GETDATE(), 0, GETDATE()),
(3, 200, 0, 0, GETDATE(), 0, GETDATE()),
(4, 300, 0, 0, GETDATE(), 0, GETDATE()),
(5, 250, 0, 0, GETDATE(), 0, GETDATE()),
(6, 400, 0, 0, GETDATE(), 0, GETDATE()),
(7, 180, 0, 0, GETDATE(), 0, GETDATE()),
(8, 220, 0, 0, GETDATE(), 0, GETDATE()),
(9, 140, 0, 0, GETDATE(), 0, GETDATE()),
(10, 500, 0, 0, GETDATE(), 0, GETDATE()),
(11, 600, 0, 0, GETDATE(), 0, GETDATE()),
(12, 320, 0, 0, GETDATE(), 0, GETDATE()),
(13, 170, 0, 0, GETDATE(), 0, GETDATE()),
(14, 260, 0, 0, GETDATE(), 0, GETDATE()),
(15, 130, 0, 0, GETDATE(), 0, GETDATE()),
(16, 210, 0, 0, GETDATE(), 0, GETDATE()),
(17, 230, 0, 0, GETDATE(), 0, GETDATE()),
(18, 240, 0, 0, GETDATE(), 0, GETDATE()),
(19, 270, 0, 0, GETDATE(), 0, GETDATE()),
(20, 350, 0, 0, GETDATE(), 0, GETDATE()),
(21, 450, 0, 0, GETDATE(), 0, GETDATE()),
(22, 490, 0, 0, GETDATE(), 0, GETDATE()),
(23, 330, 0, 0, GETDATE(), 0, GETDATE()),
(24, 370, 0, 0, GETDATE(), 0, GETDATE()),
(25, 280, 0, 0, GETDATE(), 0, GETDATE()),
(26, 310, 0, 0, GETDATE(), 0, GETDATE()),
(27, 410, 0, 0, GETDATE(), 0, GETDATE()),
(28, 290, 0, 0, GETDATE(), 0, GETDATE()),
(29, 460, 0, 0, GETDATE(), 0, GETDATE()),
(30, 470, 0, 0, GETDATE(), 0, GETDATE())

--AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
----------------------BỎ CA LÀM VỚI LỊCH LÀM VÀO CHỖ NÀY Loai NhanVienNhan Vien nua----------------------------------------------
--AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
-- TaiKhoan
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Quyen, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('admin', '123456', 0, 0, 0, GETDATE(), 0, GETDATE()),
('user', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK001', '123456', 0, 0, 0, GETDATE(), 0, GETDATE()),
('TK002', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK003', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK004', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK005', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK006', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK007', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK008', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK009', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK010', '123456', 1, 0, 0, GETDATE(), 0, GETDATE());
GO

-- LoaiNhanVien
INSERT INTO LoaiNhanVien (TenLoaiNhanVien, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES 
(N'Quản lý', 0, 0, GETDATE(), 0, GETDATE()),
(N'Nhân viên', 0, 0, GETDATE(), 0, GETDATE()),
(N'Giám đốc', 0, 0, GETDATE(), 0, GETDATE()),
(N'Trưởng phòng', 0, 0, GETDATE(), 0, GETDATE()),
(N'Phó phòng', 0, 0, GETDATE(), 0, GETDATE()),
(N'Chuyên viên', 0, 0, GETDATE(), 0, GETDATE()),
(N'Thực tập sinh', 0, 0, GETDATE(), 0, GETDATE()),
(N'Nhân viên kinh doanh', 0, 0, GETDATE(), 0, GETDATE()),
(N'Kỹ sư', 0, 0, GETDATE(), 0, GETDATE()),
(N'Hỗ trợ kỹ thuật', 0, 0, GETDATE(), 0, GETDATE());
GO

-- NhanVien
INSERT INTO NhanVien (TenNhanVien, idLoaiNhanVien, SoDienThoai, DiaChi, idTaiKhoan, is_deleted, created_by, created_at, updated_by, updated_at) VALUES
(N'Nguyễn Văn A', 5, '0974292158', N'Số 920 đường ABC, Quận 2', 2, 0, 0, GETDATE(), 0, GETDATE()),
(N'Trần Thị B', 4, '0944077427', N'Số 455 đường ABC, Quận 3', 9, 0, 0, GETDATE(), 0, GETDATE()),
(N'Phạm Văn C', 4, '0921630367', N'Số 659 đường ABC, Quận 7', 8, 0, 0, GETDATE(), 0, GETDATE()),
(N'Lê Thị D', 2, '0968827256', N'Số 263 đường ABC, Quận 6', 7, 0, 0, GETDATE(), 0, GETDATE()),
(N'Hoàng Văn E', 4, '0995479869', N'Số 813 đường ABC, Quận 3', 2, 0, 0, GETDATE(), 0, GETDATE()),
(N'Đỗ Thị F', 8, '0977245967', N'Số 683 đường ABC, Quận 6', 1, 0, 0, GETDATE(), 0, GETDATE()),
(N'Ngô Văn G', 8, '0932092448', N'Số 221 đường ABC, Quận 5', 1, 0, 0, GETDATE(), 0, GETDATE()),
(N'Huỳnh Thị H', 1, '0948131639', N'Số 554 đường ABC, Quận 6', 7, 0, 0, GETDATE(), 0, GETDATE()),
(N'Vũ Văn I', 1, '0913751930', N'Số 466 đường ABC, Quận 1', 6, 0, 0, GETDATE(), 0, GETDATE()),
(N'Bùi Thị K', 10, '0961054267', N'Số 909 đường ABC, Quận 2', 4, 0, 0, GETDATE(), 0, GETDATE()),
(N'Phan Văn L', 9, '0918522539', N'Số 217 đường ABC, Quận 6', 1, 0, 0, GETDATE(), 0, GETDATE()),
(N'Đinh Thị M', 4, '0934127483', N'Số 265 đường ABC, Quận 5', 2, 0, 0, GETDATE(), 0, GETDATE()),
(N'Hà Văn N', 9, '0915641153', N'Số 90 đường ABC, Quận 5', 7, 0, 0, GETDATE(), 0, GETDATE()),
(N'Lý Thị O', 2, '0933574529', N'Số 612 đường ABC, Quận 3', 8, 0, 0, GETDATE(), 0, GETDATE()),
(N'Cao Văn P', 10, '0966176694', N'Số 370 đường ABC, Quận 7', 3, 0, 0, GETDATE(), 0, GETDATE()),
(N'Vương Thị Q', 5, '0991408863', N'Số 511 đường ABC, Quận 8', 2, 0, 0, GETDATE(), 0, GETDATE()),
(N'Tô Văn R', 8, '0975212045', N'Số 973 đường ABC, Quận 9', 4, 0, 0, GETDATE(), 0, GETDATE()),
(N'Trương Thị S', 1, '0933739892', N'Số 23 đường ABC, Quận 12', 4, 0, 0, GETDATE(), 0, GETDATE()),
(N'Trịnh Văn T', 5, '0914681172', N'Số 132 đường ABC, Quận 8', 8, 0, 0, GETDATE(), 0, GETDATE()),
(N'Đặng Thị U', 5, '0915365891', N'Số 831 đường ABC, Quận 2', 6, 0, 0, GETDATE(), 0, GETDATE()),
(N'Lưu Văn V', 7, '0974006580', N'Số 745 đường ABC, Quận 5', 4, 0, 0, GETDATE(), 0, GETDATE()),
(N'Chu Thị W', 10, '0956736423', N'Số 691 đường ABC, Quận 9', 7, 0, 0, GETDATE(), 0, GETDATE()),
(N'Dương Văn X', 10, '0945849462', N'Số 256 đường ABC, Quận 8', 6, 0, 0, GETDATE(), 0, GETDATE()),
(N'Đoàn Thị Y', 1, '0919195456', N'Số 662 đường ABC, Quận 12', 4, 0, 0, GETDATE(), 0, GETDATE()),
(N'Mai Văn Z', 1, '0925874634', N'Số 514 đường ABC, Quận 10', 3, 0, 0, GETDATE(), 0, GETDATE()),
(N'Nguyễn Thị AA', 1, '0911994042', N'Số 782 đường ABC, Quận 12', 1, 0, 0, GETDATE(), 0, GETDATE()),
(N'Trần Văn BB', 5, '0927507664', N'Số 406 đường ABC, Quận 8', 2, 0, 0, GETDATE(), 0, GETDATE()),
(N'Phạm Thị CC', 3, '0934333086', N'Số 175 đường ABC, Quận 2', 10, 0, 0, GETDATE(), 0, GETDATE()),
(N'Lê Văn DD', 3, '0947359026', N'Số 788 đường ABC, Quận 5', 2, 0, 0, GETDATE(), 0, GETDATE()),
(N'Hoàng Thị EE', 8, '0914910203', N'Số 131 đường ABC, Quận 6', 7, 0, 0, GETDATE(), 0, GETDATE());
GO
INSERT INTO [dbo].[CaLam] (MaCaLam, TenCaLam, GioBatDau, GioKetThuc, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('CL01', N'Ca Sáng', '06:00', '14:00', 0, 1, GETDATE(), 1, GETDATE()),
('CL02', N'Ca Chiều', '14:00', '22:00', 0, 1, GETDATE(), 1, GETDATE()),
('CL03', N'Ca Đêm', '22:00', '06:00', 0, 1, GETDATE(), 1, GETDATE()),
('CL04', N'Ca Hành Chính', '08:00', '17:00', 0, 1, GETDATE(), 1, GETDATE());

INSERT INTO [dbo].[LichLam] (MaLichLam, NgayLam, idNhanVien, idCaLam, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('LL01', '2024-10-25', 1, 1, 0, 1, GETDATE(), 1, GETDATE()),
('LL02', '2024-10-25', 2, 2, 0, 1, GETDATE(), 1, GETDATE()),
('LL03', '2024-10-26', 3, 3, 0, 1, GETDATE(), 1, GETDATE()),
('LL04', '2024-10-27', 4, 4, 0, 1, GETDATE(), 1, GETDATE());
--Bảng lương
-- Thêm dữ liệu tổng lương cho tháng 9/2024
INSERT INTO BangLuong (MaBangLuong,ThangNam, TongGioCong, Luong, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('BL001','2024-09-01', 176, 15000000, 0, 0, GETDATE(), 0, GETDATE()),  -- Nhân viên 1, 22 ngày * 8 giờ
('BL002','2024-09-01', 160, 14000000, 0, 0, GETDATE(), 0, GETDATE()),  -- Nhân viên 2, 20 ngày * 8 giờ
('BL003','2024-09-01', 144, 13000000, 0, 0, GETDATE(), 0, GETDATE());  -- Nhân viên 3, 18 ngày * 8 giờ
-- chi tiết bảng lương
-- Nhân viên 1, làm đủ 22 ngày
INSERT INTO ChiTietBangLuong (SoGioCongThucTe, idBangLuong, idNhanVien, idLichLam, NgayLam, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
(8, 1, 1, 101, '2024-09-01', 0, 0, GETDATE(), 0, GETDATE()),  -- 01/09/2024
(8, 1, 1, 102, '2024-09-02', 0, 0, GETDATE(), 0, GETDATE()),  -- 02/09/2024
(8, 1, 1, 103, '2024-09-03', 0, 0, GETDATE(), 0, GETDATE()),  -- 03/09/2024
(8, 1, 1, 104, '2024-09-04', 0, 0, GETDATE(), 0, GETDATE()),  -- 04/09/2024
(8, 1, 1, 105, '2024-09-05', 0, 0, GETDATE(), 0, GETDATE()),  -- 05/09/2024
(8, 1, 1, 106, '2024-09-06', 0, 0, GETDATE(), 0, GETDATE()),  -- 06/09/2024
(8, 1, 1, 107, '2024-09-07', 0, 0, GETDATE(), 0, GETDATE()),  -- 07/09/2024
(8, 1, 1, 108, '2024-09-08', 0, 0, GETDATE(), 0, GETDATE()),  -- 08/09/2024
(8, 1, 1, 109, '2024-09-09', 0, 0, GETDATE(), 0, GETDATE()),  -- 09/09/2024
(8, 1, 1, 110, '2024-09-10', 0, 0, GETDATE(), 0, GETDATE()),  -- 10/09/2024
(8, 1, 1, 111, '2024-09-11', 0, 0, GETDATE(), 0, GETDATE()),  -- 11/09/2024
(8, 1, 1, 112, '2024-09-12', 0, 0, GETDATE(), 0, GETDATE()),  -- 12/09/2024
(8, 1, 1, 113, '2024-09-13', 0, 0, GETDATE(), 0, GETDATE()),  -- 13/09/2024
(8, 1, 1, 114, '2024-09-14', 0, 0, GETDATE(), 0, GETDATE()),  -- 14/09/2024
(8, 1, 1, 115, '2024-09-15', 0, 0, GETDATE(), 0, GETDATE()),  -- 15/09/2024
(8, 1, 1, 116, '2024-09-16', 0, 0, GETDATE(), 0, GETDATE()),  -- 16/09/2024
(8, 1, 1, 117, '2024-09-17', 0, 0, GETDATE(), 0, GETDATE()),  -- 17/09/2024
(8, 1, 1, 118, '2024-09-18', 0, 0, GETDATE(), 0, GETDATE()),  -- 18/09/2024
(8, 1, 1, 119, '2024-09-19', 0, 0, GETDATE(), 0, GETDATE()),  -- 19/09/2024
(8, 1, 1, 120, '2024-09-20', 0, 0, GETDATE(), 0, GETDATE()),  -- 20/09/2024
(8, 1, 1, 121, '2024-09-21', 0, 0, GETDATE(), 0, GETDATE()),  -- 21/09/2024
(8, 1, 1, 122, '2024-09-22', 0, 0, GETDATE(), 0, GETDATE());  -- 22/09/2024

-- Nhân viên 2, nghỉ 2 ngày, làm 20 ngày
INSERT INTO ChiTietBangLuong (SoGioCongThucTe, idBangLuong, idNhanVien, idLichLam, NgayLam, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
(8, 2, 2, 101, '2024-09-01', 0, 0, GETDATE(), 0, GETDATE()),  -- 01/09/2024
-- nghỉ ngày 02/09/2024
(8, 2, 2, 103, '2024-09-03', 0, 0, GETDATE(), 0, GETDATE()),  -- 03/09/2024
(8, 2, 2, 104, '2024-09-04', 0, 0, GETDATE(), 0, GETDATE()),  -- 04/09/2024
(8, 2, 2, 105, '2024-09-05', 0, 0, GETDATE(), 0, GETDATE()),  -- 05/09/2024
(8, 2, 2, 106, '2024-09-06', 0, 0, GETDATE(), 0, GETDATE()),  -- 06/09/2024
(8, 2, 2, 107, '2024-09-07', 0, 0, GETDATE(), 0, GETDATE()),  -- 07/09/2024
(8, 2, 2, 108, '2024-09-08', 0, 0, GETDATE(), 0, GETDATE()),  -- 08/09/2024
(8, 2, 2, 109, '2024-09-09', 0, 0, GETDATE(), 0, GETDATE()),  -- 09/09/2024
(8, 2, 2, 110, '2024-09-10', 0, 0, GETDATE(), 0, GETDATE()),  -- 10/09/2024
(8, 2, 2, 111, '2024-09-11', 0, 0, GETDATE(), 0, GETDATE()),  -- 11/09/2024
(8, 2, 2, 112, '2024-09-12', 0, 0, GETDATE(), 0, GETDATE()),  -- 12/09/2024
(8, 2, 2, 113, '2024-09-13', 0, 0, GETDATE(), 0, GETDATE()),  -- 13/09/2024
(8, 2, 2, 114, '2024-09-14', 0, 0, GETDATE(), 0, GETDATE()),  -- 14/09/2024
(8, 2, 2, 115, '2024-09-15', 0, 0, GETDATE(), 0, GETDATE()),  -- 15/09/2024
(8, 2, 2, 116, '2024-09-16', 0, 0, GETDATE(), 0, GETDATE()),  -- 16/09/2024
(8, 2, 2, 117, '2024-09-17', 0, 0, GETDATE(), 0, GETDATE()),  -- 17/09/2024
(8, 2, 2, 118, '2024-09-18', 0, 0, GETDATE(), 0, GETDATE()),  -- 18/09/2024
(8, 2, 2, 119, '2024-09-19', 0, 0, GETDATE(), 0, GETDATE()),  -- 19/09/2024
(8, 2, 2, 120, '2024-09-20', 0, 0, GETDATE(), 0, GETDATE()),  -- 20/09/2024
(8, 2, 2, 121, '2024-09-21', 0, 0, GETDATE(), 0, GETDATE());  -- 21/09/2024
-- Nhân viên 3, nghỉ 4 ngày, làm 18 ngày
INSERT INTO ChiTietBangLuong (SoGioCongThucTe, idBangLuong, idNhanVien, idLichLam, NgayLam, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
(8, 3, 3, 101, '2024-09-01', 0, 0, GETDATE(), 0, GETDATE()),  -- 01/09/2024
-- nghỉ ngày 02/09/2024, 03/09/2024
(8, 3, 3, 104, '2024-09-04', 0, 0, GETDATE(), 0, GETDATE()),  -- 04/09/2024
(8, 3, 3, 105, '2024-09-05', 0, 0, GETDATE(), 0, GETDATE()),  -- 05/09/2024
(8, 3, 3, 106, '2024-09-06', 0, 0, GETDATE(), 0, GETDATE()),  -- 06/09/2024
(8, 3, 3, 107, '2024-09-07', 0, 0, GETDATE(), 0, GETDATE()),  -- 07/09/2024
(8, 3, 3, 108, '2024-09-08', 0, 0, GETDATE(), 0, GETDATE()),  -- 08/09/2024
(8, 3, 3, 109, '2024-09-09', 0, 0, GETDATE(), 0, GETDATE()),  -- 09/09/2024
-- nghỉ ngày 10/09/2024
(8, 3, 3, 111, '2024-09-11', 0, 0, GETDATE(), 0, GETDATE()),  -- 11/09/2024
(8, 3, 3, 112, '2024-09-12', 0, 0, GETDATE(), 0, GETDATE()),  -- 12/09/2024
(8, 3, 3, 113, '2024-09-13', 0, 0, GETDATE(), 0, GETDATE()),  -- 13/09/2024
(8, 3, 3, 114, '2024-09-14', 0, 0, GETDATE(), 0, GETDATE()),  -- 14/09/2024
(8, 3, 3, 115, '2024-09-15', 0, 0, GETDATE(), 0, GETDATE()),  -- 15/09/2024
(8, 3, 3, 116, '2024-09-16', 0, 0, GETDATE(), 0, GETDATE()),  -- 16/09/2024
(8, 3, 3, 117, '2024-09-17', 0, 0, GETDATE(), 0, GETDATE()),  -- 17/09/2024
(8, 3, 3, 118, '2024-09-18', 0, 0, GETDATE(), 0, GETDATE()),  -- 18/09/2024
(8, 3, 3, 119, '2024-09-19', 0, 0, GETDATE(), 0, GETDATE()),  -- 19/09/2024
(8, 3, 3, 120, '2024-09-20', 0, 0, GETDATE(), 0, GETDATE());  -- 20/09/2024









