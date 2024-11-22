using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class BUS_CaLam
	{
		// Fields
		private DAL_CaLam dal_cl = new DAL_CaLam();

		//Method
		// LayDSCaLam()
		public IQueryable LayDSCaLam()
		{
			return dal_cl.LayDSCaLam();
		}

		// ThemCaLam()
		public bool ThemCaLam(DTO_CaLam caLam)
		{
			return dal_cl.ThemCaLam(caLam);
		}

		// XoaCaLam()
		public void XoaCaLam(int maCL)
		{
			dal_cl.XoaCaLam(maCL);
		}

		// SuaCaLam()
		public bool SuaCaLam(DTO_CaLam caLam)
		{
			return dal_cl.SuaCaLam(caLam);
		}

		//XoaCL
		public void DellCL(int id)
		{
			dal_cl.XoaCL(id);
		}
	}
}
