using DTO;
using System;
using System.Linq;
using System.Windows.Forms;
namespace DAL
{
    public class DAL_KhoHang
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();
        // Methods
        public IQueryable LoadDSKhoHang()
        {
            //load kho hàng
            return from kh in da.Db.KhoHangs
                   join sp in da.Db.SanPhams
                   on kh.idSanPham equals sp.id
                   where sp.is_deleted == 0
                   select new { kh.id, kh.idSanPham, sp.TenSanPham, kh.SoLuong };
        }
        //sửa kho
        public void SuaKhoHang(DTO_KhoHang khohang)
        {
            try
            {
                var upp = da.Db.KhoHangs.FirstOrDefault(k => k.id == khohang.Id);
                if (upp != null)
                {
                    upp.SoLuong = khohang.SoLuong;
                    da.Db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        // Updated SoLuongSP by frmCTHD in table KhoHang
        public void UpdateSoLuongSP(int idSanPham, int soLuong)
        {
            // Get Sp by idSanPham
            var kho_update = da.Db.KhoHangs.SingleOrDefault(kho => kho.idSanPham == idSanPham);

            if (kho_update != null)
            {
                if (soLuong > 0)
                {
                    kho_update.SoLuong -= soLuong;
                }
                else
                {
                    kho_update.SoLuong += Math.Abs(soLuong);

                }
            }
            else
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Saved
            da.Db.SubmitChanges();
        }
    }
}
