using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DTO_LichLam
	{
		//Fields
		private int id;
		private string maLichLam;
		private DateTime ngayLam;
		private int idNhanVien;
		private int idCaLam;
		private int is_deleted;
		private int created_by;
		private DateTime created_at;
		private int update_by;
		private DateTime updated_at;

		public DTO_LichLam(int id, string maLichLam, DateTime ngayLam, int idNhanVien, int idCaLam, int is_deleted, int created_by, DateTime created_at, int update_by, DateTime updated_at)
		{
			this.Id = id;
			this.MaLichLam = maLichLam;
			this.NgayLam = ngayLam;
			this.IdNhanVien = idNhanVien;
			this.IdCaLam = idCaLam;
			this.Is_deleted = is_deleted;
			this.Created_by = created_by;
			this.Created_at = created_at;
			this.Update_by = update_by;
			this.Updated_at = updated_at;
		}

		public DTO_LichLam(string maLichLam, DateTime ngayLam, int idNhanVien, int idCaLam)
		{
			this.MaLichLam = maLichLam;
			this.NgayLam = ngayLam;
			this.IdNhanVien = idNhanVien;
			this.IdCaLam = idCaLam;
		}

		public DTO_LichLam(int id, string maLichLam, DateTime ngayLam, int idNhanVien, int idCaLam)
		{
			this.Id = id;
			this.MaLichLam = maLichLam;
			this.NgayLam = ngayLam;
			this.IdNhanVien = idNhanVien;
			this.IdCaLam = idCaLam;
		}

		public int Id { get => id; set => id = value; }
		public string MaLichLam { get => maLichLam; set => maLichLam = value; }
		public DateTime NgayLam { get => ngayLam; set => ngayLam = value; }
		public int IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
		public int IdCaLam { get => idCaLam; set => idCaLam = value; }
		public int Is_deleted { get => is_deleted; set => is_deleted = value; }
		public int Created_by { get => created_by; set => created_by = value; }
		public DateTime Created_at { get => created_at; set => created_at = value; }
		public int Update_by { get => update_by; set => update_by = value; }
		public DateTime Updated_at { get => updated_at; set => updated_at = value; }
	}
}
