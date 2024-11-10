/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 23/10/2024
 * BUS_KhuyenMai.cs
 */
using DAL;
using DTO;
using System.Linq;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        // Fields
        DAL_KhuyenMai dal_km = new DAL_KhuyenMai();

        // Methods
        public IQueryable GetListKM()
        {
            return dal_km.GetListKM();
        }

        public void AddKM(DTO_KhuyenMai khuyenMai)
        {
            dal_km.AddKM(khuyenMai);
        }

        public void UpdateKM(DTO_KhuyenMai khuyenMai)
        {
            dal_km.UpdateKM(khuyenMai);
        }

        public void DelKM(int id)
        {
            dal_km.DelKM(id);
        }

        public void AddKM2(DTO_KhuyenMai khuyenMai)
        {
            dal_km.AddKM2(khuyenMai);
        }

        public void UpdateKM2(DTO_KhuyenMai khuyenMai)
        {
            dal_km.UpdateKM2(khuyenMai);
        }

        public int GetMaxIdKM()
        {
            return dal_km.GetMaxIdKM();
        }
    }
}
