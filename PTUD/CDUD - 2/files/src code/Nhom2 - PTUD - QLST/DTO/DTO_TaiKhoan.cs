/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 16/10/2024
 * DTO_TaiKhoan.cs
 */
using System;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        // Fields
        private int id;
        private string maTaiKhoan;
        private string tenTaiKhoan;
        private string matKhau;
        private int quyen;
        private int is_deleted;
        private int created_by;
        private DateTime created_at;
        private int update_by;
        private DateTime updated_at;

        // Constructors
        public DTO_TaiKhoan(int id, string maTaiKhoan, string tenTaiKhoan, string matKhau, int quyen, int is_deleted, int created_by, DateTime created_at, int update_by, DateTime updated_at)
        {
            this.id = id;
            this.maTaiKhoan = maTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.quyen = quyen;
            this.is_deleted = is_deleted;
            this.created_by = created_by;
            this.created_at = created_at;
            this.update_by = update_by;
            this.updated_at = updated_at;
        }

        public DTO_TaiKhoan(string maTaiKhoan, string tenTaiKhoan, string matKhau, int quyen)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.quyen = quyen;
        }

        public DTO_TaiKhoan(int id, string maTaiKhoan, string tenTaiKhoan, string matKhau, int quyen)
        {
            this.id = id;
            this.maTaiKhoan = maTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.quyen = quyen;
        }

        public DTO_TaiKhoan(string tenTaiKhoan, string matKhau, int quyen)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.quyen = quyen;
        }

        public DTO_TaiKhoan(int id, string tenTaiKhoan, string matKhau, int quyen)
        {
            this.id = id;
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
            this.quyen = quyen;
        }

        // Properties
        public int Id { get => id; set => id = value; }
        public string MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int Quyen { get => quyen; set => quyen = value; }
        public int Is_deleted { get => is_deleted; set => is_deleted = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Update_by { get => update_by; set => update_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
