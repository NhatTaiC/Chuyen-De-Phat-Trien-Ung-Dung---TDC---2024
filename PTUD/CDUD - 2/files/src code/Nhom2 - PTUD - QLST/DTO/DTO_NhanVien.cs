﻿/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 23/10/2024
 * DTO_NhanVien.cs
 */
using System;

namespace DTO
{
    public class DTO_NhanVien
    {
        // Fields
        private int id { get; set; }
        private string maNV { get; set; }
        private string tenNV { get; set; }
        private string soDT { get; set; }
        private string diaChi { get; set; }
        private int idLNV { get; set; }
        private int idTK { get; set; }
        private int is_deleted { get; set; }
        private int created_by { get; set; }
        private DateTime created_at { get; set; }
        private int updated_by { get; set; }
        private DateTime updated_at { get; set; }

        // Constructors
        public DTO_NhanVien()
        { }
            public DTO_NhanVien(int id, string maNV, string tenNV, string soDT, string diaChi, int idLNV, int idTK, int is_deleted, int created_by, DateTime created_at, int updated_by, DateTime updated_at)
        {
            this.id = id;
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.soDT = soDT;
            this.diaChi = diaChi;
            this.idLNV = idLNV;
            this.idTK = idTK;
            this.is_deleted = is_deleted;
            this.created_by = created_by;
            this.created_at = created_at;
            this.updated_by = updated_by;
            this.updated_at = updated_at;
        }

        public DTO_NhanVien(int id, string maNV, string tenNV, string soDT, string diaChi, int idLNV, int idTK)
        {
            this.id = id;
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.soDT = soDT;
            this.diaChi = diaChi;
            this.idLNV = idLNV;
            this.idTK = idTK;
        }

        public DTO_NhanVien(string maNV, string tenNV, string soDT, string diaChi, int idLNV, int idTK)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.soDT = soDT;
            this.diaChi = diaChi;
            this.idLNV = idLNV;
            this.idTK = idTK;
        }

        public DTO_NhanVien(int id, string tenNV, string soDT, string diaChi, int idLNV, int idTK)
        {
            this.id = id;
            this.tenNV = tenNV;
            this.soDT = soDT;
            this.diaChi = diaChi;
            this.idLNV = idLNV;
            this.idTK = idTK;
        }

        public DTO_NhanVien(string tenNV, string soDT, string diaChi, int idLNV, int idTK)
        {
            this.tenNV = tenNV;
            this.soDT = soDT;
            this.diaChi = diaChi;
            this.idLNV = idLNV;
            this.idTK = idTK;
        }

        // Properties
        public int Id { get => id; set => id = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int IdLNV { get => idLNV; set => idLNV = value; }
        public int IdTK { get => idTK; set => idTK = value; }
        public int Is_deleted { get => is_deleted; set => is_deleted = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Updated_by { get => updated_by; set => updated_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
