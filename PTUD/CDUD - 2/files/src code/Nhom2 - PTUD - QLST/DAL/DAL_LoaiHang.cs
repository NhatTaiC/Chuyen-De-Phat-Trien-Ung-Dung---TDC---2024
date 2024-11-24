using DTO;
using System;
using System.Linq;
namespace DAL
{
    public class DAL_LoaiHang
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();

        // Methods
        //danh sách loại hàng
        public IQueryable LayDSLoaiHang()
        {
            return from lh in da.Db.LoaiHangs
                   where lh.is_deleted == 0
                   select new { lh.id, lh.MaLoaiHang, lh.TenLoaiHang };
        }
        //thêm loại hàng
        public void ThemLoaiHang(DTO_LoaiHang loaihangdto)
        {
            try
            {
                //kiểm tra mã loại hàng có tồn tại chưa
                var data = da.Db.LoaiHangs.FirstOrDefault(dt => dt.MaLoaiHang == loaihangdto.MaLoaiHang && dt.is_deleted == 0);
                if (data == null)
                {
                    //loại hàng được thêm
                    if (loaihangdto.MaLoaiHang.Length > 30)
                    {
                        throw new Exception("Mã loại hàng không quá 30 kí tự!");
                    }
                    if (loaihangdto.TenLoaiHang.Length > 50)
                    {
                        throw new Exception("Tên loại hàng không quá 50 kí tự!");
                    }
                    LoaiHang lh = new LoaiHang();
                    lh.MaLoaiHang = loaihangdto.MaLoaiHang;
                    lh.TenLoaiHang = loaihangdto.TenLoaiHang;
                    lh.is_deleted = 0;
                    lh.created_at = DateTime.Now;
                    lh.updated_at = DateTime.Now;
                    lh.created_by = 0;
                    lh.updated_by = 0;
                    da.Db.LoaiHangs.InsertOnSubmit(lh);
                    da.Db.SubmitChanges();


                }
                else
                {
                    //quăng lỗi
                    throw new Exception("Mã loại hàng đã tồn tại!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }

        }
        //xóa loại hàng
        public void XoaLoaiHang(int id)
        {
            try
            {
                //tìm loại hàng xóa
                var data = da.Db.LoaiHangs.FirstOrDefault(dt => dt.id == id && dt.is_deleted == 0);
                data.is_deleted = 1;
                da.Db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }
        }
        //sửa loại hàng
        public void SuaLoaiHang(DTO_LoaiHang loaihangdto)
        {
            try
            {
                //kiểm tra mã loại hàng có tồn tại chưa
                var lh = da.Db.LoaiHangs.FirstOrDefault(dt => dt.id == loaihangdto.Id);
                if (lh != null)
                {
                    //loại hàng được thêm
                    if (loaihangdto.MaLoaiHang.Length > 30)
                    {
                        throw new Exception("Mã loại hàng không quá 30 kí tự!");
                    }

                    if (loaihangdto.TenLoaiHang.Length > 50)
                    {
                        throw new Exception("Tên loại hàng không quá 50 kí tự!");
                    }

                    lh.MaLoaiHang = loaihangdto.MaLoaiHang;
                    lh.TenLoaiHang = loaihangdto.TenLoaiHang;
                    lh.updated_at = DateTime.Now;
                    lh.updated_by = 0;
                    da.Db.SubmitChanges();
                }
                else
                {
                    //quăng lỗi
                    throw new Exception("Không tìm thấy!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }

        }
    }
}
