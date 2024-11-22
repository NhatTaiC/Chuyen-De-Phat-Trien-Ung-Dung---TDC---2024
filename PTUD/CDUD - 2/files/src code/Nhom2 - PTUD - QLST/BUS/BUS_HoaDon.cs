/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 07/11/2024
 * BUS_HoaDon.cs
 */
using DAL;
using DTO;
using System.Linq;

namespace BUS
{
    public class BUS_HoaDon
    {
        // Initialize Variables
        DAL_HoaDon dal_hd = new DAL_HoaDon();

        // Methods
        public IQueryable GetListHD()
        {
            return dal_hd.GetListHD();
        }

        public string TimMaHoaDon(int id)
        {
            return dal_hd.TimMaHoaDon(id);
        }

        public void AddHD(DTO_HoaDon hoaDon)
        {
            dal_hd.AddHD(hoaDon);
        }

        public void UpdateHD(DTO_HoaDon hoaDon)
        {
            dal_hd.UpdateHD(hoaDon);
        }

        public void DeleteHD(int id)
        {
            dal_hd.DeleteHD(id);
        }

        public int GetMaxIdHD()
        {
            return dal_hd.GetMaxIdHD();
        }

        public void UpdateTotalCash(int idHd, int toTalCash)
        {
            dal_hd.UpdateTotalCash(idHd, toTalCash);
        }

        public IQueryable GetListHD2()
        {
            return dal_hd.GetListHD2();
        }

        public IQueryable SearchHdByMaHD(string maHD)
        {
            return dal_hd.SearchHdByMaHD(maHD);
        }

        public IQueryable SearchHdByMaHD_Exact(string maHD)
        {
            return dal_hd.SearchHdByMaHD_Exact(maHD);
        }

        public IQueryable GetListHD3()
        {
            return dal_hd.GetListHD3();
        }

        public bool CheckHd(string maHd)
        {
            return dal_hd.CheckHd(maHd);
        }

        public void AddHD2(DTO_HoaDon hoaDon)
        {
            dal_hd.AddHD2(hoaDon);
        }

        public void UpdateTotalCash2(int idHd, int toTalCash)
        {
            dal_hd.UpdateTotalCash2(idHd, toTalCash);
        }

        public string SearchHDById(int idHD)
        {
            return dal_hd.SearchHDById(idHD);
        }
    }
}
