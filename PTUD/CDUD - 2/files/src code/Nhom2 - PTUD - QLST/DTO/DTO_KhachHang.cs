using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DTO_KhachHang
	{
		//Fields
		private int id;
		private string maKhachHang;
		private string tenKhachHang;
		private string soDienThoai;
		private int diem;
		private int is_deleted;
		private int created_by;
		private DateTime created_at;
		private int update_by;
		private DateTime updated_at;

		//Constructor
		public DTO_KhachHang(int id, string maKhachHang, string tenKhachHang, string soDienThoai, int diem, int is_deleted, int created_by, DateTime created_at, int update_by, DateTime updated_at)
		{
			this.Id = id;
			this.MaKhachHang = maKhachHang;
			this.TenKhachHang = tenKhachHang;
			this.SoDienThoai = soDienThoai;
			this.Diem = diem;
			this.Is_deleted = is_deleted;
			this.Created_by = created_by;
			this.Created_at = created_at;
			this.Update_by = update_by;
			this.Updated_at = updated_at;
		}

		public DTO_KhachHang(string maKhachHang, string tenKhachHang, string soDienThoai, int diem)
		{
			this.Id = id;
			this.MaKhachHang = maKhachHang;
			this.TenKhachHang = tenKhachHang;
			this.SoDienThoai = soDienThoai;
			this.Diem = diem;
			this.Is_deleted = is_deleted;
			this.Created_by = created_by;
			this.Created_at = created_at;
			this.Update_by = update_by;
			this.Updated_at = updated_at;
		}

		public DTO_KhachHang(int id, string maKhachHang, string tenKhachHang, string soDienThoai, int diem)
		{
			this.Id = id;
			this.MaKhachHang = maKhachHang;
			this.TenKhachHang = tenKhachHang;
			this.SoDienThoai = soDienThoai;
			this.Diem = diem;
		}

        public DTO_KhachHang(string tenKhachHang, string soDienThoai, int diem)
        {
            this.Id = id;
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.SoDienThoai = soDienThoai;
            this.Diem = diem;
        }

        public DTO_KhachHang(int id,string tenKhachHang, string soDienThoai, int diem)
        {
            this.Id = id;
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.SoDienThoai = soDienThoai;
            this.Diem = diem;
        }

        // Properties
        public int Id { get => id; set => id = value; }
		public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
		public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
		public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
		public int Diem { get => diem; set => diem = value; }
		public int Is_deleted { get => is_deleted; set => is_deleted = value; }
		public int Created_by { get => created_by; set => created_by = value; }
		public DateTime Created_at { get => created_at; set => created_at = value; }
		public int Update_by { get => update_by; set => update_by = value; }
		public DateTime Updated_at { get => updated_at; set => updated_at = value; }
	}
}
