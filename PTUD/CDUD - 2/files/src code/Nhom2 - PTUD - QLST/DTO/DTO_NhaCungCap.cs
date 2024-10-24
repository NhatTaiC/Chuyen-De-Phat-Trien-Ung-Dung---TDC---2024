using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DTO_NhaCungCap
	{
		//Fields
		private int id;
		private string maNhaCungCap;
		private string tenNhaCungCap;
		private string soDienThoai;
		private string diaChi;
		private int is_deleted;
		private int created_by;
		private DateTime created_at;
		private int update_by;
		private DateTime updated_at;

		//Constructor
		public DTO_NhaCungCap(int id, string maNhaCungCap, string tenNhaCungCap, string soDienThoai, string diaChi, int is_deleted, int created_by, DateTime created_at, int update_by, DateTime updated_at)
		{
			this.id = id;
			this.maNhaCungCap = maNhaCungCap;
			this.tenNhaCungCap = tenNhaCungCap;
			this.soDienThoai = soDienThoai;
			this.diaChi = diaChi;
			this.is_deleted = is_deleted;
			this.created_by = created_by;
			this.created_at = created_at;
			this.update_by = update_by;
			this.updated_at = updated_at;
		}

		public DTO_NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string soDienThoai, string diaChi)
		{
			this.maNhaCungCap = maNhaCungCap;
			this.tenNhaCungCap = tenNhaCungCap;
			this.soDienThoai = soDienThoai;
			this.diaChi = diaChi;
		}

		public DTO_NhaCungCap(int id, string maNhaCungCap, string tenNhaCungCap, string soDienThoai, string diaChi)
		{
			this.id = id;
			this.maNhaCungCap = maNhaCungCap;
			this.tenNhaCungCap = tenNhaCungCap;
			this.soDienThoai = soDienThoai;
			this.diaChi = diaChi;
		}

		public int Id { get => id; set => id = value; }
		public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
		public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }
		public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
		public string DiaChi { get => diaChi; set => diaChi = value; }
		public int Is_deleted { get => is_deleted; set => is_deleted = value; }
		public int Created_by { get => created_by; set => created_by = value; }
		public DateTime Created_at { get => created_at; set => created_at = value; }
		public int Update_by { get => update_by; set => update_by = value; }
		public DateTime Updated_at { get => updated_at; set => updated_at = value; }
	}
}
