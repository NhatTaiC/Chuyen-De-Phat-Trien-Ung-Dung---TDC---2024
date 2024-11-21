using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class BUS_KhachHang
	{
		// Fields
		private DAL_KhachHang dal_kh = new DAL_KhachHang();
		public DTO_KhachHang LayKhachHang(string sodienthoai)
		{
			return dal_kh.LayKhachHang(sodienthoai);
		}
            //Method
            // LayDSKH()
            public IQueryable LayDSKH()
		{
			return dal_kh.LayDSKH();
		}

		// ThemKH()
		public bool ThemKH(DTO_KhachHang kh)
		{
			return dal_kh.ThemKH(kh);
		}

		// XoaKH()
		public void XoaKH(int maKH)
		{
			dal_kh.XoaKH(maKH);
		}

		// SuaKH()
		public bool SuaKH(DTO_KhachHang kh)
		{
			return dal_kh.SuaKH(kh);
		}

        public IQueryable timkiemTheoTen(string ten)
        {
			return dal_kh.timkiemTheoTen(ten);
        }

        public IQueryable timkiemTheoSDT(string sdt)
        {
            return dal_kh.timkiemTheoSDT(sdt);
        }
    }
}
