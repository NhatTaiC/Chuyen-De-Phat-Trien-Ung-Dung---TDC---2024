/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 23/10/2024
 * BUS_LoaiNhanVien.cs
 */
using DAL;
using DTO;
using System.Linq;

namespace BUS
{
    public class BUS_LoaiNhanVien
    {
        // Fields
        DAL_LoaiNhanVien dal_lnv = new DAL_LoaiNhanVien();

        // Methods
        public IQueryable GetListLNV()
        {
            return dal_lnv.GetListLNV();
        }

        public IQueryable GetListAllLNVByTen()
        {
            return dal_lnv.GetListAllLNVByTen();
        }

        public IQueryable GetListOneLNVByTen(int id)
        {
            return dal_lnv.GetListOneLNVByTen(id);
        }

        public void AddLNV(DTO_LoaiNhanVien loaiNhanVien)
        {
            dal_lnv.AddLNV(loaiNhanVien);
        }

        public void UpdateLNV(DTO_LoaiNhanVien loaiNhanVien)
        {
            dal_lnv.UpdateLNV(loaiNhanVien);
        }

        public void DelLNV(int id)
        {
            dal_lnv.DelLNV(id);
        }

        public void AddLNV2(DTO_LoaiNhanVien loaiNhanVien)
        {
            dal_lnv.AddLNV2(loaiNhanVien);
        }

        public void UpdateLNV2(DTO_LoaiNhanVien loaiNhanVien)
        {
            dal_lnv.UpdateLNV2(loaiNhanVien);
        }
    }
}
