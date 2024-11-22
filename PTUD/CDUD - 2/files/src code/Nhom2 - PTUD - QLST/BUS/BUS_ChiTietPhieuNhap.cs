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
		public void ThemChiTietPhieuNhap(DTO_ChiTietPhieuNhap ctpn)
		{
			dal_ctpn.ThemCTPN(ctpn);
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

		public void DellPN(int id)
		{
			dal_ctpn.DellPN(id);
		}

        public bool CheckCTHDByIdpnIdSp(int idpn, int idsp)
		{
			return dal_ctpn.CheckCTHDByIdpnIdSp(idpn, idsp);
		}

        public int GetSoLuongSpInCTPN(int idpn, int idsp)
		{
			return dal_ctpn.GetSoLuongSpInCTPN(idpn, idsp);
		}

        public void UpdateSoLuongSpInCTPN(int soLuong, int idpn, int idsp)
		{
			dal_ctpn.UpdateSoLuongSpInCTPN(soLuong, idpn, idsp);
		}

        public void UpdateThanhTien(int idPhieuNhap, float thanhTienMoi)
		{
			dal_ctpn.UpdateThanhTien(idPhieuNhap, thanhTienMoi);
		}
    }
}
