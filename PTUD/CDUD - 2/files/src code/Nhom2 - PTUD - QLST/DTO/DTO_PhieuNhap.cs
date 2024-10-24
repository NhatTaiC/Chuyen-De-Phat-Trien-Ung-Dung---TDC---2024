using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DTO_PhieuNhap
	{
		//Fields
		private int id;
		private string maPhieuNhap;
		private DateTime ngayNhap;
		private float thanhTien;
		private int idNhanVien;
		private int is_deleted;
		private int created_by;
		private DateTime created_at;
		private int update_by;
		private DateTime updated_at;

		//Constructors
		public DTO_PhieuNhap(string maPhieuNhap, DateTime ngayNhap, float thanhTien, int idNhanVien)
		{
			this.MaPhieuNhap = maPhieuNhap;
			this.NgayNhap = ngayNhap;
			this.ThanhTien = thanhTien;
			this.IdNhanVien = idNhanVien;
		}

		public DTO_PhieuNhap(int id, string maPhieuNhap, DateTime ngayNhap, float thanhTien, int idNhanVien, int is_deleted, int created_by, DateTime created_at, int update_by, DateTime updated_at)
		{
			this.Id = id;
			this.MaPhieuNhap = maPhieuNhap;
			this.NgayNhap = ngayNhap;
			this.ThanhTien = thanhTien;
			this.IdNhanVien = idNhanVien;
			this.Is_deleted = is_deleted;
			this.Created_by = created_by;
			this.Created_at = created_at;
			this.Update_by = update_by;
			this.Updated_at = updated_at;
		}

		public DTO_PhieuNhap(int id, string maPhieuNhap, DateTime ngayNhap, float thanhTien, int idNhanVien)
		{
			this.Id = id;
			this.MaPhieuNhap = maPhieuNhap;
			this.NgayNhap = ngayNhap;
			this.ThanhTien = thanhTien;
			this.IdNhanVien = idNhanVien;
		}

		// Properties
		public int Id { get => id; set => id = value; }
		public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
		public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
		public float ThanhTien { get => thanhTien; set => thanhTien = value; }
		public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
		public int Is_deleted { get => is_deleted; set => is_deleted = value; }
		public int Created_by { get => created_by; set => created_by = value; }
		public DateTime Created_at { get => created_at; set => created_at = value; }
		public int Update_by { get => update_by; set => update_by = value; }
		public DateTime Updated_at { get => updated_at; set => updated_at = value; }
	}
}
