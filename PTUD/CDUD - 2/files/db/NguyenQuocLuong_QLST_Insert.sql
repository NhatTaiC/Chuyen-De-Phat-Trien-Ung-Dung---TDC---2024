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
INSERT INTO SanPham (MaSanPham, TenSanPham, idNhomHang, DonViTinh, DonGia, idNhaCungCap, NgaySanXuat, HanSuDung, AnhSanPham, is_deleted, created_by, created_at, updated_by, updated_at)
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