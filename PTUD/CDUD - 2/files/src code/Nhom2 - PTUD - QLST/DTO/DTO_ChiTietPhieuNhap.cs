using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DTO_ChiTietPhieuNhap
	{
		//Fields
		private int id;
		private int soLuong;
		private float donGia;
		private int idPhieuNhap;
		private int idSanPham;
		private int is_deleted;
		private int created_by;
		private DateTime created_at;
		private int update_by;
		private DateTime updated_at;

		public DTO_ChiTietPhieuNhap(int id, int soLuong, float donGia, int idPhieuNhap, int idSanPham, int is_deleted, int created_by, DateTime created_at, int update_by, DateTime updated_at)
		{
			this.Id = id;
			this.SoLuong = soLuong;
			this.DonGia = donGia;
			this.IdPhieuNhap = idPhieuNhap;
			this.IdSanPham = idSanPham;
			this.Is_deleted = is_deleted;
			this.Created_by = created_by;
			this.Created_at = created_at;
			this.Update_by = update_by;
			this.Updated_at = updated_at;
		}

		public DTO_ChiTietPhieuNhap(int id, int soLuong, float donGia, int idPhieuNhap, int idSanPham)
		{
			this.Id = id;
			this.SoLuong = soLuong;
			this.DonGia = donGia;
			this.IdPhieuNhap = idPhieuNhap;
			this.IdSanPham = idSanPham;
		}

		public DTO_ChiTietPhieuNhap(int soLuong, float donGia, int idPhieuNhap, int idSanPham)
		{
			this.SoLuong = soLuong;
			this.DonGia = donGia;
			this.IdPhieuNhap = idPhieuNhap;
			this.IdSanPham = idSanPham;
		}

		public int Id { get => id; set => id = value; }
		public int SoLuong { get => soLuong; set => soLuong = value; }
		public float DonGia { get => donGia; set => donGia = value; }
		public int IdPhieuNhap { get => idPhieuNhap; set => idPhieuNhap = value; }
		public int IdSanPham { get => idSanPham; set => idSanPham = value; }
		public int Is_deleted { get => is_deleted; set => is_deleted = value; }
		public int Created_by { get => created_by; set => created_by = value; }
		public DateTime Created_at { get => created_at; set => created_at = value; }
		public int Update_by { get => update_by; set => update_by = value; }
		public DateTime Updated_at { get => updated_at; set => updated_at = value; }
	}
}
