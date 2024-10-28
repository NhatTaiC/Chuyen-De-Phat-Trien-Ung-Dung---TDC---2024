using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class BUS_ChiTietPhieuNhap
	{
		// Fields
		private DAL_ChiTietPhieuNhap dal_ctpn = new DAL_ChiTietPhieuNhap();

		//Method
		// LayDSCaLam()
		public IQueryable LayDSCTPN()
		{
			return dal_ctpn.LayDSChiTietPhieuNhap();
		}

		// ThemCaLam()
		public bool ThemChiTietPhieuNhap(DTO_ChiTietPhieuNhap ctpn)
		{
			return dal_ctpn.ThemCTPN(ctpn);
		}

		// XoaNCC()
		public void XoaChiTietPhieuNhap(int id)
		{
			dal_ctpn.XoaChiTietPhieuNhap(id);
		}

		// SuaNCC()
		public bool SuaChiTietPhieuNhap(DTO_ChiTietPhieuNhap ctpn)
		{
			return dal_ctpn.SuaChiTietPhieuNhap(ctpn);
		}

		public IQueryable DSSP()
		{
			return dal_ctpn.LayDSSP();
		}

		public IQueryable LayDSSP(int maSP)
		{
			return dal_ctpn.LayDSSP(maSP);
		}

		public string LayDSSP1(int maSP)
		{
			return dal_ctpn.LayDSSP1(maSP);
		}
	}
}
