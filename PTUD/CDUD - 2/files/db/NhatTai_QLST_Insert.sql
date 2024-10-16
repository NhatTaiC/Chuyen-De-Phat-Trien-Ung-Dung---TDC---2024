USE QuanLySieuThi;
-- TaiKhoan
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Quyen, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
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