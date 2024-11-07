/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 07/11/2024
 * DTO_HoaDon.cs
 */
using System;

namespace DTO
{
    public class DTO_HoaDon
    {
        // Fields
        private int id;
        private string maHoaDon;
        private DateTime ngayLapHD;
        private DateTime gioLapHD;
        private float tongTien;
        private float thanhTien;
        private int idKhachHang;
        private int idKhuyenMai;
        private int idNhanVien;
        private int is_deleted;
        private int created_by;
        private DateTime created_at;
        private int updated_by;
        private DateTime updated_at;

        public DTO_HoaDon(int id, string maHoaDon, DateTime ngayLapHD, DateTime gioLapHD, float tongTien, float thanhTien, int idKhachHang, int idKhuyenMai, int idNhanVien, int is_deleted, int created_by, DateTime created_at, int updated_by, DateTime updated_at)
        {
            this.id = id;
            this.maHoaDon = maHoaDon;
            this.ngayLapHD = ngayLapHD;
            this.gioLapHD = gioLapHD;
            this.tongTien = tongTien;
            this.thanhTien = thanhTien;
            this.idKhachHang = idKhachHang;
            this.idKhuyenMai = idKhuyenMai;
            this.idNhanVien = idNhanVien;
            this.is_deleted = is_deleted;
            this.created_by = created_by;
            this.created_at = created_at;
            this.updated_by = updated_by;
            this.updated_at = updated_at;
        }

        public DTO_HoaDon(int id, string maHoaDon, DateTime ngayLapHD, DateTime gioLapHD, float tongTien, float thanhTien, int idKhachHang, int idKhuyenMai, int idNhanVien)
        {
            this.id = id;
            this.maHoaDon = maHoaDon;
            this.ngayLapHD = ngayLapHD;
            this.gioLapHD = gioLapHD;
            this.tongTien = tongTien;
            this.thanhTien = thanhTien;
            this.idKhachHang = idKhachHang;
            this.idKhuyenMai = idKhuyenMai;
            this.idNhanVien = idNhanVien;
        }

        public DTO_HoaDon(int id, int idKhachHang, int idKhuyenMai, int idNhanVien)
        {
            this.id = id;
            this.idKhachHang = idKhachHang;
            this.idKhuyenMai = idKhuyenMai;
            this.idNhanVien = idNhanVien;
        }

        public DTO_HoaDon(int idKhachHang, int idKhuyenMai, int idNhanVien)
        {
            this.idKhachHang = idKhachHang;
            this.idKhuyenMai = idKhuyenMai;
            this.idNhanVien = idNhanVien;
        }

        // Properites
        public int Id { get => id; set => id = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public DateTime NgayLapHD { get => ngayLapHD; set => ngayLapHD = value; }
        public DateTime GioLapHD { get => gioLapHD; set => gioLapHD = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        public int IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public int IdKhuyenMai { get => idKhuyenMai; set => idKhuyenMai = value; }
        public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public int Is_deleted { get => is_deleted; set => is_deleted = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Updated_by { get => updated_by; set => updated_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
