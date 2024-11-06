USE QuanLySieuThi;
GO

-- 1. TaiKhoan
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

-- 2. LoaiNhanVien
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

-- 3. NhanVien
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

-- 4. LoaiHang
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
GO

-- 5. NhaCungCap
INSERT INTO NhaCungCap(MaNhaCungCap, TenNhaCungCap, SoDienThoai, DiaChi,is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('NCC01',N'LG','0123456789',N'23/7 Võ Văn Ngân',0, 0, GETDATE(), 0, GETDATE()),
('NCC02',N'LeNoVo','0123456789',N'7/11 Hoàng Diệu 2',0, 0, GETDATE(), 0, GETDATE()),
('NCC03',N'SamSung','0123456789',N'50/7 Trần Phú',0, 0, GETDATE(), 0, GETDATE()),
('NCC04',N'Dell','0123456789',N'16 Đặng Văn Bi',0, 0, GETDATE(), 0, GETDATE()),
('NCC05',N'CellsPhone','0123456789',N'16/3 Võ Nguên Giáp',0, 0, GETDATE(), 0, GETDATE()),
('NCC06',N'Family Mart','0123456789',N'25/16 đường số 25',0, 0, GETDATE(), 0, GETDATE()),
('NCC07',N'GS25','0123456789',N'29/16 Hiệp Bình',0, 0, GETDATE(), 0, GETDATE()),
('NCC08',N'Xiaomi','0123456789',N'12/3 D2',0, 0, GETDATE(), 0, GETDATE()),
('NCC09',N'Vissan','0123456789',N'27 Đường 16',0, 0, GETDATE(), 0, GETDATE()),
('NCC010',N'Sạch','0123456789',N'2 Đường 21',0, 0, GETDATE(), 0, GETDATE());
GO

-- 6. SanPham
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
GO

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
GO

-- 7. KhoHang
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
GO

-- 8. KhachHang
INSERT INTO KhachHang (MaKhachHang, TenKhachHang, SoDienThoai, Diem, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES 
('KH00',N'Khách vãng lai','0123456789', 0, 0, 0, GETDATE(), 0, GETDATE()),
('KH01',N'Hồ Nhật Tâm','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE()),
('KH02',N'Trần Hoàng Diệu','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE()),
('KH03',N'Võ Nguyên Giáp','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE()),
('KH04',N'Phạm Ngũ Lão','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE()),
('KH05',N'Nguyễn Thị Thập','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE()),
('KH06',N'Lư Gia Khang','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE()),
('KH07',N'Phạm Kim Ngân','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE()),
('KH08',N'Hồ Hải','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE()),
('KH09',N'Nguyễn Thị Thủy','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE()),
('KH010',N'Khuất Văn Khang','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE()),
('KH011',N'Hoàng Anh Tuấn','0123456789', 100, 0, 0, GETDATE(), 0, GETDATE());
GO

-- 9. PhieuNhap
INSERT INTO PhieuNhap(MaPhieuNhap, NgayNhap, ThanhTien, idNhanVien, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('PN01', '2024-10-15', 30000, 1, 0, 0, '2024-10-15', 0, '2024-10-15'),
('PN02', '2024-10-15', 50000, 1, 0, 0, '2024-10-15', 0, '2024-10-15'),
('PN03', '2024-10-15', 300000, 1, 0, 0, '2024-10-15', 0, '2024-10-15'),
('PN04', '2024-10-15', 3000000, 1, 0, 0, '2024-10-15', 0, '2024-10-15'),
('PN05', '2024-10-15', 30000, 1, 0, 0, '2024-10-15', 0, '2024-10-15'),
('PN06', '2024-10-15', 30000, 1, 0, 0, '2024-10-15', 0, '2024-10-15'),
('PN07', '2024-10-15', 30000, 1, 0, 0, '2024-10-15', 0, '2024-10-15'),
('PN08', '2024-10-15', 30000, 1, 0, 0, '2024-10-15', 0, '2024-10-15'),
('PN09', '2024-10-15', 30000, 1, 0, 0, '2024-10-15', 0, '2024-10-15'),
('PN10', '2024-10-15', 30000, 1, 0, 0, '2024-10-15', 0, '2024-10-15');
GO

-- 10. ChiTietPhieuNhap
INSERT INTO [dbo].[ChiTietPhieuNhap] (SoLuong, DonGia, idPhieuNhap, idSanPham, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
(10, 15000, 1, 1, 0, 1, GETDATE(), 1, GETDATE()),
(20, 20000, 2, 2, 0, 1, GETDATE(), 1, GETDATE()),
(15, 30000, 3, 3, 0, 1, GETDATE(), 1, GETDATE()),
(5, 50000, 4, 4, 0, 1, GETDATE(), 1, GETDATE()),
(8, 10000, 5, 5, 0, 1, GETDATE(), 1, GETDATE());
GO

-- 11. CaLam
INSERT INTO [dbo].[CaLam] (MaCaLam, TenCaLam, GioBatDau, GioKetThuc, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('CL01', N'Ca Sáng', '06:00', '14:00', 0, 1, GETDATE(), 1, GETDATE()),
('CL02', N'Ca Chiều', '14:00', '22:00', 0, 1, GETDATE(), 1, GETDATE()),
('CL03', N'Ca Đêm', '22:00', '06:00', 0, 1, GETDATE(), 1, GETDATE()),
('CL04', N'Ca Hành Chính', '08:00', '17:00', 0, 1, GETDATE(), 1, GETDATE());
GO

-- 12. LichLam
INSERT INTO [dbo].[LichLam] (MaLichLam, NgayLam, idNhanVien, idCaLam, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('LL01', '2024-10-25', 1, 1, 0, 1, GETDATE(), 1, GETDATE()),
('LL02', '2024-10-25', 2, 2, 0, 1, GETDATE(), 1, GETDATE()),
('LL03', '2024-10-26', 3, 3, 0, 1, GETDATE(), 1, GETDATE()),
('LL04', '2024-10-27', 4, 4, 0, 1, GETDATE(), 1, GETDATE());
GO

-- 13. KhuyenMai
INSERT INTO KhuyenMai (MaKhuyenMai, TenKhuyenMai, GiaTri, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES 
('KM001', N'Giảm giá 10%', 10.0, 0, 0, GETDATE(), 0, GETDATE()),
('KM002', N'Giảm giá 20%', 20.0, 0, 0, GETDATE(), 0, GETDATE()),
('KM003', N'Khuyến mãi đặc biệt', 30.0, 0, 0, GETDATE(), 0, GETDATE()),
('KM004', N'Ưu đãi mùa hè', 40.0, 0, 0, GETDATE(), 0, GETDATE()),
('KM005', N'Mua 1 tặng 1', 50.0, 0, 0, GETDATE(), 0, GETDATE()),
('KM006', N'Giảm giá cuối tuần', 60.0, 0, 0, GETDATE(), 0, GETDATE()),
('KM007', N'Ưu đãi sinh nhật', 70.0, 0, 0, GETDATE(), 0, GETDATE()),
('KM008', N'Giảm giá Black Friday', 80.0, 0, 0, GETDATE(), 0, GETDATE()),
('KM009', N'Khuyến mãi tháng 10', 90.0, 0, 0, GETDATE(), 0, GETDATE()),
('KM010', N'Giảm giá kỷ niệm', 100.0, 0, 0, GETDATE(), 0, GETDATE());
GO

-- 14. HoaDon
INSERT INTO HoaDon (MaHoaDon, NgayLapHD, GioLapHD, TongTien, ThanhTien, idKhachHang, idKhuyenMai, idNhanVien, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('HD001', GETDATE(), GETDATE(), 0, 0, 1, 5, 3, 0, 0, GETDATE(), 0, GETDATE()),
('HD002', GETDATE(), GETDATE(), 0, 0, 1, 6, 7, 0, 0, GETDATE(), 0, GETDATE()),
('HD003', GETDATE(), GETDATE(), 0, 0, 1, 4, 2, 0, 0, GETDATE(), 0, GETDATE()),
('HD004', GETDATE(), GETDATE(), 0, 0, 1, 9, 8, 0, 0, GETDATE(), 0, GETDATE()),
('HD005', GETDATE(), GETDATE(), 0, 0, 1, 3, 6, 0, 0, GETDATE(), 0, GETDATE()),
('HD006', GETDATE(), GETDATE(), 0, 0, 1, 1, 9, 0, 0, GETDATE(), 0, GETDATE()),
('HD007', GETDATE(), GETDATE(), 0, 0, 1, 10, 4, 0, 0, GETDATE(), 0, GETDATE()),
('HD008', GETDATE(), GETDATE(), 0, 0, 1, 2, 5, 0, 0, GETDATE(), 0, GETDATE()),
('HD009', GETDATE(), GETDATE(), 0, 0, 1, 8, 1, 0, 0, GETDATE(), 0, GETDATE()),
('HD010', GETDATE(), GETDATE(), 0, 0, 1, 7, 10, 0, 0, GETDATE(), 0, GETDATE());
GO

-- 15. ChiTietHoaDon
INSERT INTO ChiTietHoaDon (SoLuong, idHoaDon, idSanPham, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
(5, 3, 7, 0, 0, GetDate(), 0, GetDate()),
(2, 1, 4, 0, 0, GetDate(), 0, GetDate()),
(7, 4, 1, 0, 0, GetDate(), 0, GetDate()),
(3, 6, 8, 0, 0, GetDate(), 0, GetDate()),
(9, 2, 3, 0, 0, GetDate(), 0, GetDate()),
(6, 7, 5, 0, 0, GetDate(), 0, GetDate()),
(1, 5, 9, 0, 0, GetDate(), 0, GetDate()),
(4, 8, 2, 0, 0, GetDate(), 0, GetDate()),
(10, 10, 6, 0, 0, GetDate(), 0, GetDate()),
(8, 9, 10, 0, 0, GetDate(), 0, GetDate());
GO

-- 16. BangLuong
-- Thêm dữ liệu tổng lương cho tháng 9/2024
INSERT INTO BangLuong (MaBangLuong,idNhanVien,ThangNam, TongGioCong, Luong, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('BL001',1,'2024-09-01', 176, 15000000, 0, 0, GETDATE(), 0, GETDATE()),  -- Nhân viên 1, 22 ngày * 8 giờ
('BL002',2,'2024-09-01', 160, 14000000, 0, 0, GETDATE(), 0, GETDATE()),  -- Nhân viên 2, 20 ngày * 8 giờ
('BL003',3,'2024-09-01', 144, 13000000, 0, 0, GETDATE(), 0, GETDATE());  -- Nhân viên 3, 18 ngày * 8 giờ
GO

-- 17. ChiTietBangLuong
-- Nhân viên 1, làm đủ 22 ngày
INSERT INTO ChiTietBangLuong (SoGioCongThucTe, idBangLuong, idLichLam, NgayLam, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
(8, 1, 101, '2024-09-01', 0, 0, GETDATE(), 0, GETDATE()),  -- 01/09/2024
(8, 1, 102, '2024-09-02', 0, 0, GETDATE(), 0, GETDATE()),  -- 02/09/2024
(8, 1, 103, '2024-09-03', 0, 0, GETDATE(), 0, GETDATE()),  -- 03/09/2024
(8, 1, 104, '2024-09-04', 0, 0, GETDATE(), 0, GETDATE()),  -- 04/09/2024
(8, 1, 105, '2024-09-05', 0, 0, GETDATE(), 0, GETDATE()),  -- 05/09/2024
(8, 1, 106, '2024-09-06', 0, 0, GETDATE(), 0, GETDATE()),  -- 06/09/2024
(8, 1, 107, '2024-09-07', 0, 0, GETDATE(), 0, GETDATE()),  -- 07/09/2024
(8, 1, 108, '2024-09-08', 0, 0, GETDATE(), 0, GETDATE()),  -- 08/09/2024
(8, 1, 109, '2024-09-09', 0, 0, GETDATE(), 0, GETDATE()),  -- 09/09/2024
(8, 1, 110, '2024-09-10', 0, 0, GETDATE(), 0, GETDATE()),  -- 10/09/2024
(8, 1, 111, '2024-09-11', 0, 0, GETDATE(), 0, GETDATE()),  -- 11/09/2024
(8, 1, 112, '2024-09-12', 0, 0, GETDATE(), 0, GETDATE()),  -- 12/09/2024
(8, 1, 113, '2024-09-13', 0, 0, GETDATE(), 0, GETDATE()),  -- 13/09/2024
(8, 1, 114, '2024-09-14', 0, 0, GETDATE(), 0, GETDATE()),  -- 14/09/2024
(8, 1, 115, '2024-09-15', 0, 0, GETDATE(), 0, GETDATE()),  -- 15/09/2024
(8, 1, 116, '2024-09-16', 0, 0, GETDATE(), 0, GETDATE()),  -- 16/09/2024
(8, 1, 117, '2024-09-17', 0, 0, GETDATE(), 0, GETDATE()),  -- 17/09/2024
(8, 1, 118, '2024-09-18', 0, 0, GETDATE(), 0, GETDATE()),  -- 18/09/2024
(8, 1, 119, '2024-09-19', 0, 0, GETDATE(), 0, GETDATE()),  -- 19/09/2024
(8, 1, 120, '2024-09-20', 0, 0, GETDATE(), 0, GETDATE()),  -- 20/09/2024
(8, 1, 121, '2024-09-21', 0, 0, GETDATE(), 0, GETDATE()),  -- 21/09/2024
(8, 1, 122, '2024-09-22', 0, 0, GETDATE(), 0, GETDATE());  -- 22/09/2024
GO

-- Nhân viên 2, nghỉ 2 ngày, làm 20 ngày
INSERT INTO ChiTietBangLuong (SoGioCongThucTe, idBangLuong, idLichLam, NgayLam, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
(8, 2, 101, '2024-09-01', 0, 0, GETDATE(), 0, GETDATE()),  -- 01/09/2024
-- nghỉ ngày 02/09/2024
(8, 2, 103, '2024-09-03', 0, 0, GETDATE(), 0, GETDATE()),  -- 03/09/2024
(8, 2, 104, '2024-09-04', 0, 0, GETDATE(), 0, GETDATE()),  -- 04/09/2024
(8, 2, 105, '2024-09-05', 0, 0, GETDATE(), 0, GETDATE()),  -- 05/09/2024
(8, 2, 106, '2024-09-06', 0, 0, GETDATE(), 0, GETDATE()),  -- 06/09/2024
(8, 2, 107, '2024-09-07', 0, 0, GETDATE(), 0, GETDATE()),  -- 07/09/2024
(8, 2, 108, '2024-09-08', 0, 0, GETDATE(), 0, GETDATE()),  -- 08/09/2024
(8, 2, 109, '2024-09-09', 0, 0, GETDATE(), 0, GETDATE()),  -- 09/09/2024
(8, 2, 110, '2024-09-10', 0, 0, GETDATE(), 0, GETDATE()),  -- 10/09/2024
(8, 2, 111, '2024-09-11', 0, 0, GETDATE(), 0, GETDATE()),  -- 11/09/2024
(8, 2, 112, '2024-09-12', 0, 0, GETDATE(), 0, GETDATE()),  -- 12/09/2024
(8, 2, 113, '2024-09-13', 0, 0, GETDATE(), 0, GETDATE()),  -- 13/09/2024
(8, 2, 114, '2024-09-14', 0, 0, GETDATE(), 0, GETDATE()),  -- 14/09/2024
(8, 2, 115, '2024-09-15', 0, 0, GETDATE(), 0, GETDATE()),  -- 15/09/2024
(8, 2, 116, '2024-09-16', 0, 0, GETDATE(), 0, GETDATE()),  -- 16/09/2024
(8, 2, 117, '2024-09-17', 0, 0, GETDATE(), 0, GETDATE()),  -- 17/09/2024
(8, 2, 118, '2024-09-18', 0, 0, GETDATE(), 0, GETDATE()),  -- 18/09/2024
(8, 2, 119, '2024-09-19', 0, 0, GETDATE(), 0, GETDATE()),  -- 19/09/2024
(8, 2, 120, '2024-09-20', 0, 0, GETDATE(), 0, GETDATE()),  -- 20/09/2024
(8, 2, 121, '2024-09-21', 0, 0, GETDATE(), 0, GETDATE());  -- 21/09/2024
GO

-- Nhân viên 3, nghỉ 4 ngày, làm 18 ngày
INSERT INTO ChiTietBangLuong (SoGioCongThucTe, idBangLuong, idLichLam, NgayLam, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
(8, 3, 101, '2024-09-01', 0, 0, GETDATE(), 0, GETDATE()),  -- 01/09/2024
-- nghỉ ngày 02/09/2024, 03/09/2024
(8, 3, 104, '2024-09-04', 0, 0, GETDATE(), 0, GETDATE()),  -- 04/09/2024
(8, 3, 105, '2024-09-05', 0, 0, GETDATE(), 0, GETDATE()),  -- 05/09/2024
(8, 3, 106, '2024-09-06', 0, 0, GETDATE(), 0, GETDATE()),  -- 06/09/2024
(8, 3, 107, '2024-09-07', 0, 0, GETDATE(), 0, GETDATE()),  -- 07/09/2024
(8, 3, 108, '2024-09-08', 0, 0, GETDATE(), 0, GETDATE()),  -- 08/09/2024
(8, 3, 109, '2024-09-09', 0, 0, GETDATE(), 0, GETDATE()),  -- 09/09/2024
(8, 3, 110, '2024-09-10', 0, 0, GETDATE(), 0, GETDATE()),  -- 10/09/2024
(8, 3, 111, '2024-09-11', 0, 0, GETDATE(), 0, GETDATE()),  -- 11/09/2024
(8, 3, 112, '2024-09-12', 0, 0, GETDATE(), 0, GETDATE()),  -- 12/09/2024
(8, 3, 113, '2024-09-13', 0, 0, GETDATE(), 0, GETDATE()),  -- 13/09/2024
(8, 3, 114, '2024-09-14', 0, 0, GETDATE(), 0, GETDATE()),  -- 14/09/2024
(8, 3, 115, '2024-09-15', 0, 0, GETDATE(), 0, GETDATE()),  -- 15/09/2024
-- nghỉ ngày 16/09/2024
(8, 3, 117, '2024-09-17', 0, 0, GETDATE(), 0, GETDATE()),  -- 17/09/2024
(8, 3, 118, '2024-09-18', 0, 0, GETDATE(), 0, GETDATE()),  -- 18/09/2024
(8, 3, 119, '2024-09-19', 0, 0, GETDATE(), 0, GETDATE()),  -- 19/09/2024
(8, 3, 120, '2024-09-20', 0, 0, GETDATE(), 0, GETDATE());  -- 20/09/2024
Go

-- 18. ChiNhanh
INSERT INTO ChiNhanh ( MaChiNhanh, TenChiNhanh, DiaChi, SoDienThoai, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('CN001', N'Chi Nhánh Hà Nội', N'Số 1 Đường A, Hà Nội', '0123456789', 0, 0, GETDATE(), 0, GETDATE()),
('CN002', N'Chi Nhánh Hồ Chí Minh', N'Số 10 Đường B, Hồ Chí Minh', '0987654321', 0, 0, GETDATE(), 0, GETDATE()),
('CN003', N'Chi Nhánh Đà Nẵng', N'Số 15 Đường C, Đà Nẵng', '0912345678', 0, 0, GETDATE(), 0, GETDATE()),
('CN004', N'Chi Nhánh Hải Phòng', N'Số 20 Đường D, Hải Phòng', '0901234567', 0, 0, GETDATE(), 0, GETDATE()),
('CN005', N'Chi Nhánh Cần Thơ', N'Số 25 Đường E, Cần Thơ', '0998765432', 0, 0, GETDATE(), 0, GETDATE());
GO

-- 19. Log
INSERT INTO Log (log_name, model, model_id, action, data_olds, data_news, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('LOG_NAME_01', 'MODEL_01', 1, 'TEST', 'DATA_OLDS_01', 'DATA_NEWS_01', 0, 0, GETDATE(), 0, GETDATE()),
('LOG_NAME_02', 'MODEL_02', 2, 'TEST', 'DATA_OLDS_02', 'DATA_NEWS_02', 0, 0, GETDATE(), 0, GETDATE()),
('LOG_NAME_03', 'MODEL_03', 3, 'TEST', 'DATA_OLDS_03', 'DATA_NEWS_03', 0, 0, GETDATE(), 0, GETDATE()),
('LOG_NAME_04', 'MODEL_04', 4, 'TEST', 'DATA_OLDS_04', 'DATA_NEWS_04', 0, 0, GETDATE(), 0, GETDATE()),
('LOG_NAME_05', 'MODEL_05', 5, 'TEST', 'DATA_OLDS_05', 'DATA_NEWS_05', 0, 0, GETDATE(), 0, GETDATE()),
('LOG_NAME_06', 'MODEL_06', 6, 'TEST', 'DATA_OLDS_06', 'DATA_NEWS_06', 0, 0, GETDATE(), 0, GETDATE()),
('LOG_NAME_07', 'MODEL_07', 7, 'TEST', 'DATA_OLDS_07', 'DATA_NEWS_07', 0, 0, GETDATE(), 0, GETDATE()),
('LOG_NAME_08', 'MODEL_08', 8, 'TEST', 'DATA_OLDS_08', 'DATA_NEWS_08', 0, 0, GETDATE(), 0, GETDATE()),
('LOG_NAME_09', 'MODEL_09', 9, 'TEST', 'DATA_OLDS_09', 'DATA_NEWS_09', 0, 0, GETDATE(), 0, GETDATE()),
('LOG_NAME_10', 'MODEL_10', 10, 'TEST', 'DATA_OLDS_10', 'DATA_NEWS_10', 0, 0, GETDATE(), 0, GETDATE());
GO
