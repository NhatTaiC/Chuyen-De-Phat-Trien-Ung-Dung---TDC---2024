﻿/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 16/10/2024
 * DAL_TaiKhoan.cs
 */
using System.Linq;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();

        // Methods
        public bool CheckTaiKhoan(string taiKhoan, string matKhau)
        {
            var query = from tk in da.Db.TaiKhoans
                        where tk.TenTaiKhoan == taiKhoan && tk.MatKhau == matKhau
                        select tk;

            if (query.Count() == 1)
            {
                return true;
            }
            return false;
        }

        public IQueryable LayDSTK()
        {
            IQueryable query = from tk in da.Db.TaiKhoans
                               select tk;
            return query;
        }
    }
}