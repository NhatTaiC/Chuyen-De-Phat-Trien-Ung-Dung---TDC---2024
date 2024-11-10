using DAL;
using DTO;
using System.Linq;
namespace BUS
{
    public class BUS_KhoHang
    {
        //dal
        DAL_KhoHang dal_khohang = new DAL_KhoHang();
        //load kho hàng
        public IQueryable LoadKhoHang()
        {
            return dal_khohang.LoadDSKhoHang();
        }
        public void SuaKhoHang(DTO_KhoHang khohang)
        {
            dal_khohang.SuaKhoHang(khohang);
        }

        public void UpdateSoLuongSP(int idSanPham, int soLuong)
        {
            dal_khohang.UpdateSoLuongSP(idSanPham, soLuong);
        }
        public void CapNhatSoLuong(int id, int soluong)
        {
            dal_khohang.CapNhatSoLuong(id, soluong);
        }

    }
}
