using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class BUS_PhieuNhap
	{
		// Fields
		private DAL_PhieuNhap dal_pn = new DAL_PhieuNhap();

		//Method
		// LayDSPhieuNhap()
		public IQueryable LayDSPhieuNhap()
		{
			return dal_pn.LayDSPhieuNhap();
		}

		// ThemPhieuNhap()
		public bool ThemPhieuNhap(DTO_PhieuNhap pn)
		{
			return dal_pn.ThemPhieuNhap(pn);
		}

		// XoaPhieuNhap()
		public void XoaPhieuNhap(int id)
		{
			dal_pn.XoaPhieuNhap(id);
		}

		// SuaNCC()
		public bool SuaPN(DTO_PhieuNhap pn)
		{
			return dal_pn.SuaPhieuNhap(pn);
		}
		//lay ds sanpham
		public IQueryable DSSanPham()
		{

			return dal_pn.LayDSanPham();
		}

		public IQueryable DSNV()
		{

			return dal_pn.LayDSNV();
		}
	}
}
