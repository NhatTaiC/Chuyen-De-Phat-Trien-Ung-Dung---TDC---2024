using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiNhanh
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();
        // Methods
        //danh sách chi nhánh
        public IQueryable LoadDSChiNhanh()
        {
            //load kho hàng
            return from cn in da.Db.ChiNhanhs
                   where cn.is_deleted == 0
                   select new {cn.id,cn.MaChiNhanh,cn.TenChiNhanh,cn.DiaChi,cn.SoDienThoai};
        }
        //thêm chi nhánh
        public void ThemChiNhanh(DTO_ChiNhanh chiNhanh)
        {
            try
            {
                var data = da.Db.ChiNhanhs.SingleOrDefault(cn => cn.MaChiNhanh == chiNhanh.MaChiNhanh);
                if (data == null) 
                {
                    ChiNhanh chi = new ChiNhanh();
                    chi.MaChiNhanh = chiNhanh.MaChiNhanh;
                    chi.TenChiNhanh = chiNhanh.TenChiNhanh;
                    chi.SoDienThoai = chiNhanh.SoDienThoai;
                    chi.DiaChi = chiNhanh.DiaChi;
                    chi.created_at = DateTime.Now;
                    chi.updated_at = DateTime.Now;
                    chi.created_by = 0;
                    chi.updated_by = 0;
                    da.Db.ChiNhanhs.InsertOnSubmit(chi);
                    da.Db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Thêm thất bại! Mã chi nhánh đã tồn tại");
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("có lỗi xảy ra: " + ex.Message);
            }
            
        }
        //xóa chi nhánh
        public void XoaChiNhanh(int id)
        {
            try
            {
                //tìm sản phẩm xóa
                var data = da.Db.ChiNhanhs.FirstOrDefault(dt => dt.id == id && dt.is_deleted == 0);
                data.is_deleted = 1;
                da.Db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }
        }
        //sửa chi nhánh
        public void SuaChiNhanh(DTO_ChiNhanh chiNhanh)
        {
            try
            {
                var data = da.Db.ChiNhanhs.FirstOrDefault(dt => dt.id == chiNhanh.Id && dt.is_deleted == 0);
                data.MaChiNhanh = chiNhanh.MaChiNhanh;
                data.TenChiNhanh = chiNhanh.TenChiNhanh;
                data.SoDienThoai = chiNhanh.SoDienThoai;
                data.DiaChi = chiNhanh.DiaChi;
                data.updated_at = DateTime.Now;
                data.updated_by = 0;
                da.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("có lỗi xảy ra: " + ex.Message);
            }

        }
    }
}
