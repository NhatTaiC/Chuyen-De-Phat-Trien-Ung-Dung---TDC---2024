using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_LoaiHang
    {
        // DAL_LoaiHang
        private DAL_LoaiHang dal_lh = new DAL_LoaiHang();

        // Methods
        //danh sách loại hàng
        public IQueryable LayDSLoaiHang()
        {
            return dal_lh.LayDSLoaiHang();
        }
        //thêm loại hàng
        public void ThemLoaiHang(DTO_LoaiHang loaihangdto)
        {
            dal_lh.ThemLoaiHang(loaihangdto);
        }
        //xóa loại hàng
        public void XoaLoaiHang(int id)
        {
            dal_lh.XoaLoaiHang(id);
        }
        //sửa loại hàng
        public void SuaLoaHang(DTO_LoaiHang loaihang)
        {
            dal_lh.SuaLoaiHang(loaihang);
        }
    }
}
