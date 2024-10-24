/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 16/10/2024
 * BUS_TaiKhoan.cs
 */
using DAL;
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

        public IQueryable LayDSTK()
        {
            return dal_tk.LayDSTK();
        }
        //làm mới lại database
        public void ResetData()
        {
            
        }
    }
}
