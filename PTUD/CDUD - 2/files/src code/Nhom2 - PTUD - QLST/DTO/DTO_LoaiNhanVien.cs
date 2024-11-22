/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 23/10/2024
 * DTO_LoaiNhanVien.cs
 */
using System;

namespace DTO
{
    public class DTO_LoaiNhanVien
    {
        // Fields
        private int id;
        private string maLoaiNV;
        private string tenLoaiNV;
        private int is_deleted;
        private int created_by;
        private DateTime created_at;
        private int updated_by;
        private DateTime updated_at;

        // Constructors
        public DTO_LoaiNhanVien(int id, string maLoaiNV, string tenLoaiNV, int is_deleted, int created_by, DateTime created_at, int updated_by, DateTime updated_at)
        {
            this.id = id;
            this.maLoaiNV = maLoaiNV;
            this.tenLoaiNV = tenLoaiNV;
            this.is_deleted = is_deleted;
            this.created_by = created_by;
            this.created_at = created_at;
            this.updated_by = updated_by;
            this.updated_at = updated_at;
        }

        public DTO_LoaiNhanVien(int id, string maLoaiNV, string tenLoaiNV)
        {
            this.id = id;
            this.maLoaiNV = maLoaiNV;
            this.tenLoaiNV = tenLoaiNV;
        }

        public DTO_LoaiNhanVien(string maLoaiNV, string tenLoaiNV)
        {
            this.maLoaiNV = maLoaiNV;
            this.tenLoaiNV = tenLoaiNV;
        }

        public DTO_LoaiNhanVien(int id, string tenLoaiNV)
        {
            this.id = id;
            this.tenLoaiNV = tenLoaiNV;
        }

        public DTO_LoaiNhanVien(string tenLoaiNV)
        {
            this.tenLoaiNV = tenLoaiNV;
        }

        // Properties
        public int Id { get => id; set => id = value; }
        public string MaLoaiNV { get => maLoaiNV; set => maLoaiNV = value; }
        public string TenLoaiNV { get => tenLoaiNV; set => tenLoaiNV = value; }
        public int Is_deleted { get => is_deleted; set => is_deleted = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Updated_by { get => updated_by; set => updated_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
