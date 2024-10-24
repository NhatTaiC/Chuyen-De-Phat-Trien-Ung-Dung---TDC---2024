using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_ChiNhanh
    {
        //properties
        DAL_ChiNhanh dal_chinhanh = new DAL_ChiNhanh();
        //method
        //load danh sach
        public IQueryable LoadDSChiNhanh()
        {
            return dal_chinhanh.LoadDSChiNhanh();
        }
        //thêm chi nhánh
        public void ThemChiNhanh(DTO_ChiNhanh chiNhanh)
        {
           dal_chinhanh.ThemChiNhanh(chiNhanh);
        }
        //xóa chi nhánh
        public void XoaChiNhanh(int id)
        {
            dal_chinhanh.XoaChiNhanh(id);
        }
        public void SuaChinhNhanh(DTO_ChiNhanh chinhanh)
        {
            dal_chinhanh.SuaChiNhanh(chinhanh);
        }
    }
}
