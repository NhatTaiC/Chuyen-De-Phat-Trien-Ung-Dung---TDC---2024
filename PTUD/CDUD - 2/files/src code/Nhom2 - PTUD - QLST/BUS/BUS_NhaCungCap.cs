using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class BUS_NhaCungCap
	{
		// Fields
		private DAL_NhaCungCap dal_ncc = new DAL_NhaCungCap();

		//Method
		// LayDSNCC()
		public IQueryable LayDSNCC()
		{
			return dal_ncc.LayDSNCC();
		}

		// ThemNCC()
		public bool ThemNCC(DTO_NhaCungCap ncc)
		{
			return dal_ncc.ThemNCC(ncc);
		}

		// XoaNCC()
		public void XoaNCC(int id)
		{
			dal_ncc.XoaNCC(id);
		}

		// SuaNCC()
		public bool SuaNCC(DTO_NhaCungCap ncc)
		{
			return dal_ncc.SuaNCC(ncc);
		}

		public void DellNCC(int id)
		{
			dal_ncc.DellNCC(id);
		}
	}
}
