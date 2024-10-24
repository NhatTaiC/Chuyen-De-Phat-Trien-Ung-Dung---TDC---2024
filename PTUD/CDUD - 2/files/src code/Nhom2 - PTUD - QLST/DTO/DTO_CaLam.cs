using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DTO_CaLam
	{
		//Fields
		private int id;
		private string maCaLam;
		private string tenCaLam;
		private string gioBatDau;
		private string gioKetThuc;
		private int is_deleted;
		private int created_by;
		private DateTime created_at;
		private int update_by;
		private DateTime updated_at;

		public DTO_CaLam(int id, string maCaLam, string tenCaLam, string gioBatDau, string gioKetThuc, int is_deleted, int created_by, DateTime created_at, int update_by, DateTime updated_at)
		{
			this.Id = id;
			this.MaCaLam = maCaLam;
			this.TenCaLam = tenCaLam;
			this.GioBatDau = gioBatDau;
			this.GioKetThuc = gioKetThuc;
			this.Is_deleted = is_deleted;
			this.Created_by = created_by;
			this.Created_at = created_at;
			this.Update_by = update_by;
			this.Updated_at = updated_at;
		}

		public DTO_CaLam(string maCaLam, string tenCaLam, string gioBatDau, string gioKetThuc)
		{
			this.MaCaLam = maCaLam;
			this.TenCaLam = tenCaLam;
			this.GioBatDau = gioBatDau;
			this.GioKetThuc = gioKetThuc;
		}

		public DTO_CaLam(int id, string maCaLam, string tenCaLam, string gioBatDau, string gioKetThuc)
		{
			this.Id = id;
			this.MaCaLam = maCaLam;
			this.TenCaLam = tenCaLam;
			this.GioBatDau = gioBatDau;
			this.GioKetThuc = gioKetThuc;
		}

		public int Id { get => id; set => id = value; }
		public string MaCaLam { get => maCaLam; set => maCaLam = value; }
		public string TenCaLam { get => tenCaLam; set => tenCaLam = value; }
		public string GioBatDau { get => gioBatDau; set => gioBatDau = value; }
		public string GioKetThuc { get => gioKetThuc; set => gioKetThuc = value; }
		public int Is_deleted { get => is_deleted; set => is_deleted = value; }
		public int Created_by { get => created_by; set => created_by = value; }
		public DateTime Created_at { get => created_at; set => created_at = value; }
		public int Update_by { get => update_by; set => update_by = value; }
		public DateTime Updated_at { get => updated_at; set => updated_at = value; }
	}
}
