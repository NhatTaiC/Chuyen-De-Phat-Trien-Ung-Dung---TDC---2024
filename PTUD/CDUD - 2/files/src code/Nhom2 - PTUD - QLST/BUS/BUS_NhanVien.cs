/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 23/10/2024
 * BUS_NhanVien.cs
 */
using DAL;
using DTO;
using System.Linq;

namespace BUS
{
    public class BUS_NhanVien
    {
        // Fields
        DAL_NhanVien dal_nv = new DAL_NhanVien();

        // Methods
        public IQueryable GetListNV()
        {
            return dal_nv.GetListNV();
        }
        public DTO_NhanVien getNhanVien(int idTaiKhoan)
        {
            return dal_nv.getNhanVien(idTaiKhoan);
        }

        public void AddNV(DTO_NhanVien nv)
        {
            dal_nv.AddNV(nv);
        }

        public void UpdateNV(DTO_NhanVien nv)
        {
            dal_nv.UpdateNV(nv);
        }

        public void DelNV(int id)
        {
            dal_nv.DelNV(id);
        }

        public void AddNV2(DTO_NhanVien nv)
        {
            dal_nv.AddNV2(nv);
        }

        public void UpdateNV2(DTO_NhanVien nv)
        {
            dal_nv.UpdateNV2(nv);
        }

        public int GetMaxIdNV()
        {
            return dal_nv.GetMaxIdNV();
        }

        public IQueryable SearchNvByMaNV(string maNV)
        {
            return dal_nv.SearchNvByMaNV(maNV);
        }

        public IQueryable SearchNvBytenNV(string tenNV)
        {
            return dal_nv.SearchNvBytenNV(tenNV);
        }

        public IQueryable GetListNV2()
        {
            return dal_nv.GetListNV2();
        }
    }
}
