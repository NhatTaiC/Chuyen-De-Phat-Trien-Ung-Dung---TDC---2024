USE QuanLySieuThi;
-- TaiKhoan
INSERT INTO TaiKhoan (MaTaiKhoan, TenTaiKhoan, MatKhau, Quyen, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('admin', 'admin', '123456', 0, 0, 0, GETDATE(), 0, GETDATE()),
('user', 'user', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK001', 'TK001', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK002', 'TK002', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK003', 'TK003', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK004', 'TK004', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK005', 'TK005', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK006', 'TK006', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK007', 'TK007', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK008', 'TK008', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK009', 'TK009', '123456', 1, 0, 0, GETDATE(), 0, GETDATE()),
('TK010', 'TK010', '123456', 1, 0, 0, GETDATE(), 0, GETDATE());
GO

-- LoaiNhanVien
INSERT INTO LoaiNhanVien (MaLoaiNhanVien, TenLoaiNhanVien, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES 
('LNV001', N'Quản lý', 0, 0, GETDATE(), 0, GETDATE()),
('LNV002', N'Nhân viên', 0, 0, GETDATE(), 0, GETDATE()),
('LNV003', N'Giám đốc', 0, 0, GETDATE(), 0, GETDATE()),
('LNV004', N'Trưởng phòng', 0, 0, GETDATE(), 0, GETDATE()),
('LNV005', N'Phó phòng', 0, 0, GETDATE(), 0, GETDATE()),
('LNV006', N'Chuyên viên', 0, 0, GETDATE(), 0, GETDATE()),
('LNV007', N'Thực tập sinh', 0, 0, GETDATE(), 0, GETDATE()),
('LNV008', N'Nhân viên kinh doanh', 0, 0, GETDATE(), 0, GETDATE()),
('LNV009', N'Kỹ sư', 0, 0, GETDATE(), 0, GETDATE()),
('LNV010', N'Hỗ trợ kỹ thuật', 0, 0, GETDATE(), 0, GETDATE());
GO

-- NhanVien
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, idLoaiNhanVien, SoDienThoai, DiaChi, idTaiKhoan, is_deleted, created_by, created_at, updated_by, updated_at) VALUES
('NV001', N'Nguyễn Văn A', 5, '0974292158', N'Số 920 đường ABC, Quận 2', 1, 0, 0, GETDATE(), 0, GETDATE()),
('NV002', N'Trần Thị B', 4, '0944077427', N'Số 455 đường ABC, Quận 3', 2, 0, 0, GETDATE(), 0, GETDATE()),
('NV003', N'Phạm Văn C', 4, '0921630367', N'Số 659 đường ABC, Quận 7', 3, 0, 0, GETDATE(), 0, GETDATE()),
('NV004', N'Lê Thị D', 2, '0968827256', N'Số 263 đường ABC, Quận 6', 4, 0, 0, GETDATE(), 0, GETDATE()),
('NV005', N'Hoàng Văn E', 4, '0995479869', N'Số 813 đường ABC, Quận 3', 5, 0, 0, GETDATE(), 0, GETDATE()),
('NV006', N'Đỗ Thị F', 8, '0977245967', N'Số 683 đường ABC, Quận 6', 6, 0, 0, GETDATE(), 0, GETDATE()),
('NV007', N'Ngô Văn G', 8, '0932092448', N'Số 221 đường ABC, Quận 5', 7, 0, 0, GETDATE(), 0, GETDATE()),
('NV008', N'Huỳnh Thị H', 1, '0948131639', N'Số 554 đường ABC, Quận 6', 8, 0, 0, GETDATE(), 0, GETDATE()),
('NV009', N'Vũ Văn I', 1, '0913751930', N'Số 466 đường ABC, Quận 1', 9, 0, 0, GETDATE(), 0, GETDATE()),
('NV010', N'Bùi Thị K', 10, '0961054267', N'Số 909 đường ABC, Quận 2', 10, 0, 0, GETDATE(), 0, GETDATE());
GO