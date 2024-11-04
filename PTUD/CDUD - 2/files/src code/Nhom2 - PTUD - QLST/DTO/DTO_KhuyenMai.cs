/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 23/10/2024
 * DTO_KhuyenMai.cs
 */
using System;

namespace DTO
{
    public class DTO_KhuyenMai
    {
        // Fields
        private int id;
        private string maKhuyenMai;
        private string tenKhuyenMai;
        private float giaTri;
        private int is_deleted;
        private int created_by;
        private DateTime created_at;
        private int updated_by;
        private DateTime updated_at;

        // Constructors
        public DTO_KhuyenMai(int id, string maKhuyenMai, string tenKhuyenMai, float giaTri, int is_deleted, int created_by, DateTime created_at, int updated_by, DateTime updated_at)
        {
            this.id = id;
            this.maKhuyenMai = maKhuyenMai;
            this.tenKhuyenMai = tenKhuyenMai;
            this.giaTri = giaTri;
            this.is_deleted = is_deleted;
            this.created_by = created_by;
            this.created_at = created_at;
            this.updated_by = updated_by;
            this.updated_at = updated_at;
        }

        public DTO_KhuyenMai(int id, string maKhuyenMai, string tenKhuyenMai, float giaTri)
        {
            this.id = id;
            this.maKhuyenMai = maKhuyenMai;
            this.tenKhuyenMai = tenKhuyenMai;
            this.giaTri = giaTri;
        }

        public DTO_KhuyenMai(int id, string tenKhuyenMai, float giaTri)
        {
            this.id = id;
            this.tenKhuyenMai = tenKhuyenMai;
            this.giaTri = giaTri;
        }

        public DTO_KhuyenMai(string maKhuyenMai, string tenKhuyenMai, float giaTri)
        {
            this.maKhuyenMai = maKhuyenMai;
            this.tenKhuyenMai = tenKhuyenMai;
            this.giaTri = giaTri;
        }

        public DTO_KhuyenMai(string tenKhuyenMai, float giaTri)
        {
            this.tenKhuyenMai = tenKhuyenMai;
            this.giaTri = giaTri;
        }

        // Properties
        public int Id { get => id; set => id = value; }
        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public string TenKhuyenMai { get => tenKhuyenMai; set => tenKhuyenMai = value; }
        public float GiaTri { get => giaTri; set => giaTri = value; }
        public int Is_deleted { get => is_deleted; set => is_deleted = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Updated_by { get => updated_by; set => updated_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
