/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 08/11/2024
 * BUS_ChiTietHoaDon.cs
 */
using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        // Fields
        DAL_ChiTietHoaDon dal_cthd = new DAL_ChiTietHoaDon();

        // Methods
        public IQueryable GetListCTHD()
        {
            return dal_cthd.GetListCTHD();
        }

        public void AddCTHD(DTO_ChiTietHoaDon chiTietHoaDon)
        {
            dal_cthd.AddCTHD(chiTietHoaDon);
        }

        public void UpdateCTHD(DTO_ChiTietHoaDon chiTietHoaDon)
        {
            dal_cthd.UpdateCTHD(chiTietHoaDon);
        }

        public void DeleteCTHD(int id)
        {
            dal_cthd.DeleteCTHD(id);
        }

        public int GetMaxIdCTHD()
        {
            return dal_cthd.GetMaxIdCTHD();
        }

        public IQueryable GetListCTHDTheoMaHD(int idMaHD)
        {
            return dal_cthd.GetListCTHDTheoMaHD(idMaHD);
        }

        public bool CheckCTHDByIdHdIdSp(int idHd, int idSp)
        {
            return dal_cthd.CheckCTHDByIdHdIdSp(idHd, idSp);
        }

        public int GetSoLuongSpInCTHD(int idHd, int idSp)
        {
            return dal_cthd.GetSoLuongSpInCTHD(idHd, idSp);
        }

        public void UpdateSoLuongSpInCTHD(int soLuong, int idHD, int idSp)
        {
            dal_cthd.UpdateSoLuongSpInCTHD(soLuong, idHD, idSp);
        }

        public int GetSoLuongSpInCTHD2(int idHd, int idSp)
        {
            return dal_cthd.GetSoLuongSpInCTHD2(idHd, idSp);
        }

        public List<DTO_ThanhTien> GetListCTHDTheoMaHD2(int idMaHD)
        {
            return dal_cthd.GetListCTHDTheoMaHD2(idMaHD);
        }

        public IQueryable SearchListCTHDByMaHD(string maHD)
        {
            return dal_cthd.SearchListCTHDByMaHD(maHD);
        }

        public int GetTotalCashByIdHd(int idHd)
        {
            return dal_cthd.GetTotalCashByIdHd(idHd);
        }

        public void DeleteCTHD2(int id)
        {
            dal_cthd.DeleteCTHD2(id);
        }

        public void AddCTHD2(DTO_ChiTietHoaDon chiTietHoaDon)
        {
            dal_cthd.AddCTHD2(chiTietHoaDon);
        }
    }
}
