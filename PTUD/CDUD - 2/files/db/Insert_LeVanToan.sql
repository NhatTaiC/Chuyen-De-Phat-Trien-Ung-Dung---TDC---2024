INSERT INTO KhachHang (id,MaKhachHang, TenKhachHang, SoDienThoai, Diem, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES 
(0,'KH01',N'Hồ Nhật Tâm','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15),
(1,'KH02',N'Trần Hoàng Diệu','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15),
(2,'KH03',N'Võ Nguyên Giáp','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15),
(3,'KH04',N'Phạm Ngũ Lão','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15),
(4,'KH05',N'Nguyễn Thị Thập','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15),
(5,'KH06',N'Lư Gia Khang','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15),
(6,'KH07',N'Phạm Kim Ngân','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15),
(7,'KH08',N'Hồ Hải','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15),
(8,'KH09',N'Nguyễn Thị Thủy','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15),
(9,'KH010',N'Khuất Văn Khang','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15),
(10,'KH011',N'Hoàng Anh Tuấn','0123456789', 100, 0, 0, 2024-10-15, 0, 2024-10-15);
go
select * from KhachHang

go
INSERT INTO NhaCungCap(MaNhaCungCap, TenNhaCungCap, SoDienThoai, DiaChi,is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
('NCC01',N'LG','0123456789',N'23/7 Võ Văn Ngân',0, 0, 2024-10-15, 0, 2024-10-15),
('NCC02',N'LeNoVo','0123456789',N'7/11 Hoàng Diệu 2',0, 0, 2024-10-15, 0, 2024-10-15),
('NCC03',N'SamSung','0123456789',N'50/7 Trần Phú',0, 0, 2024-10-15, 0, 2024-10-15),
('NCC04',N'Dell','0123456789',N'16 Đặng Văn Bi',0, 0, 2024-10-15, 0, 2024-10-15),
('NCC05',N'CellsPhone','0123456789',N'16/3 Võ Nguên Giáp',0, 0, 2024-10-15, 0, 2024-10-15),
('NCC06',N'Family Mart','0123456789',N'25/16 đường số 25',0, 0, 2024-10-15, 0, 2024-10-15),
('NCC07',N'GS25','0123456789',N'29/16 Hiệp Bình',0, 0, 2024-10-15, 0, 2024-10-15),
('NCC08',N'Xiaomi','0123456789',N'12/3 D2',0, 0, 2024-10-15, 0, 2024-10-15),
('NCC09',N'Vissan','0123456789',N'27 Đường 16',0, 0, 2024-10-15, 0, 2024-10-15),
('NCC010',N'Sạch','0123456789',N'2 Đường 21',0, 0, 2024-10-15, 0, 2024-10-15);
go
select * from NhaCungCap
go
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

go
select * from PhieuNhap

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


INSERT INTO [dbo].[ChiTietPhieuNhap] (SoLuong, DonGia, idPhieuNhap, idSanPham, is_deleted, created_by, created_at, updated_by, updated_at)
VALUES
(10, 15000, 1, 1, 0, 1, GETDATE(), 1, GETDATE()),
(20, 20000, 2, 2, 0, 1, GETDATE(), 1, GETDATE()),
(15, 30000, 3, 3, 0, 1, GETDATE(), 1, GETDATE()),
(5, 50000, 4, 4, 0, 1, GETDATE(), 1, GETDATE()),
(8, 10000, 5, 5, 0, 1, GETDATE(), 1, GETDATE());
