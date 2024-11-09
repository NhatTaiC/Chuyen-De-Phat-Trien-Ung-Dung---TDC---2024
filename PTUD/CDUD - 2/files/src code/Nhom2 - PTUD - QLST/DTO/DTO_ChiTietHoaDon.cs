/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 08/11/2024
 * DTO_ChiTietHoaDon.cs
 */
using System;

namespace DTO
{
    public class DTO_ChiTietHoaDon
    {
        // Fields
        private int id;
        private int soLuong;
        private int idHoaDon;
        private int idSanPham;
        private int is_deleted;
        private int created_by;
        private DateTime created_at;
        private int updated_by;
        private DateTime updated_at;

        // Constructors
        public DTO_ChiTietHoaDon(int id, int soLuong, int idHoaDon, int idSanPham, int is_deleted, int created_by, DateTime created_at, int updated_by, DateTime updated_at)
        {
            this.id = id;
            this.soLuong = soLuong;
            this.idHoaDon = idHoaDon;
            this.idSanPham = idSanPham;
            this.is_deleted = is_deleted;
            this.created_by = created_by;
            this.created_at = created_at;
            this.updated_by = updated_by;
            this.updated_at = updated_at;
        }

        public DTO_ChiTietHoaDon(int id, int soLuong, int idHoaDon, int idSanPham)
        {
            this.id = id;
            this.soLuong = soLuong;
            this.idHoaDon = idHoaDon;
            this.idSanPham = idSanPham;
        }

        public DTO_ChiTietHoaDon(int soLuong, int idHoaDon, int idSanPham)
        {
            this.soLuong = soLuong;
            this.idHoaDon = idHoaDon;
            this.idSanPham = idSanPham;
        }

        public DTO_ChiTietHoaDon()
        {
            this.id = 0;
            this.soLuong = 0;
            this.idHoaDon = 0;
            this.idSanPham = 0;
            this.is_deleted = 0;
            this.created_by = 0;
            this.created_at = DateTime.Now;
            this.updated_by = 0;
            this.updated_at = DateTime.Now;
        }

        // Properties
        public int Id { get => id; set => id = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdSanPham { get => idSanPham; set => idSanPham = value; }
        public int Is_deleted { get => is_deleted; set => is_deleted = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Updated_by { get => updated_by; set => updated_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
