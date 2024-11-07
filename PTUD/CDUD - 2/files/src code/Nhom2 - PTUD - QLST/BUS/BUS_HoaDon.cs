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
    }
}
