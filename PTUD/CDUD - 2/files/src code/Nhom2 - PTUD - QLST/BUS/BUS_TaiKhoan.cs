/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 16/10/2024
 * BUS_TaiKhoan.cs
 */
using DAL;
using DTO;
using System.Linq;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        // Fields
        private DAL_TaiKhoan dal_tk = new DAL_TaiKhoan();
        private DatabaseAccess dbAccess = new DatabaseAccess();
        // Methods
        public bool CheckTaiKhoan(string taiKhoan, string matKhau)
        {
            return dal_tk.CheckTaiKhoan(taiKhoan, matKhau);
        }
        public int getIdTaiKhoan(string taiKhoan, string matKhau)
        {
            
            return dal_tk.getIdTaiKhoan(taiKhoan,matKhau);
        }

        public int GetRole(string taiKhoan, string matKhau)
        {
            return dal_tk.GetRole(taiKhoan, matKhau);
        }

        public IQueryable GetListTK()
        {
            return dal_tk.GetListTK();
        }

        public IQueryable GetListTKByQuyen()
        {
            return dal_tk.GetListTKByQuyen();
        }

        public IQueryable GetListAllTKByTenTK()
        {
            return dal_tk.GetListAllTKByTenTK();
        }

        public IQueryable GetListOneTKByTenTK(int id)
        {
            return dal_tk.GetListOneTKByTenTK(id);
        }

        public void AddTK(DTO_TaiKhoan taiKhoan)
        {
            dal_tk.AddTK(taiKhoan);
        }

        public void UpdateTK(DTO_TaiKhoan taiKhoan)
        {
            dal_tk.UpdateTK(taiKhoan);
        }

        public void DelTK(int id)
        {
            dal_tk.DelTK(id);
        }

        public void AddTK2(DTO_TaiKhoan taiKhoan)
        {
            dal_tk.AddTK2(taiKhoan);
        }

        public void UpdateTK2(DTO_TaiKhoan taiKhoan)
        {
            dal_tk.UpdateTK2(taiKhoan);
        }

        public int GetMaxIdTK()
        {
            return dal_tk.GetMaxIdTK();
        }
    }
}
