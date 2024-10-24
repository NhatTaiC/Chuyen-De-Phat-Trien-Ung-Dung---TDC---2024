using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SanPham
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();
        // Methods
        //làm dỡ để load cb nhà cung cấp ()
        public IQueryable LoadNhaCungCap()
        {
            return from sl in da.Db.NhaCungCaps
                   where sl.is_deleted == 0
                   select sl;
        }
        //danh sách loại hàng
        //load danh sách sản phẩm
        public IQueryable LayDSSanPham()
        {
            try
            {
                return from sp in da.Db.SanPhams
                       where sp.is_deleted == 0
                       select sp;
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }

        }
        //thêm sản phẩm
        public void ThemSanPham(DTO_SanPham sanpham)
        {
            try
            {
                //kiểm tra mã sản phẩm có tồn tại chưa
                var data = da.Db.SanPhams.FirstOrDefault(dt => dt.MaSanPham == sanpham.MaSanPham && dt.is_deleted == 0);
                if (data == null)
                {
                    //Sản phẩm được thêm
                    SanPham sp = new SanPham();
                    sp.MaSanPham = sanpham.MaSanPham;
                    sp.TenSanPham = sanpham.TenSanPham;
                    sp.DonViTinh = sanpham.DonViTinh;
                    sp.DonGia = sanpham.DonGia;
                    sp.NgaySanXuat = sanpham.NgaySanXuat;
                    sp.HanSuDung = sanpham.HanSuDung;
                    sp.idLoaiHang = sanpham.IdLoaiHang;
                    sp.idNhaCungCap = sanpham.IdNhaCungCap;
                    sp.AnhSanPham = sanpham.AnhSanPham;
                    sp.created_at = DateTime.Now;                 
                    sp.created_by = 0;
                    sp.updated_at = DateTime.Now;
                    sp.updated_by = 0;
                    da.Db.SanPhams.InsertOnSubmit(sp);
                    da.Db.SubmitChanges();
                }
                else
                {
                    //quăng lỗi
                    throw new Exception("Mã sản phẩm đã tồn tại!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }

            //}
            //xóa loại hàng
            //public void XoaLoaiHang(int id)
            //{
            //    try
            //    {
            //        //tìm loại hàng xóa
            //        var data = da.Db.LoaiHangs.FirstOrDefault(dt => dt.id == id);
            //        da.Db.LoaiHangs.DeleteOnSubmit(data);
            //        da.Db.SubmitChanges();
            //    }
            //    catch (Exception ex)
            //    {

            //        throw new Exception("Có lỗi xảy ra: " + ex.Message);
            //    }
            //}
        }
        //xóa sản phẩm
        public void XoaSanPham(int id)
        {
            try
            {
                //tìm sản phẩm xóa
                var data = da.Db.SanPhams.FirstOrDefault(dt => dt.id == id && dt.is_deleted == 0);
                data.is_deleted = 1;
                da.Db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }
        }
        //sửa sản phẩm
        public void SuaSanPham(DTO_SanPham sanphamdto)
        {
            try
            {
                //kiểm tra mã loại hàng có tồn tại chưa
                var sp = da.Db.SanPhams.FirstOrDefault(dt => dt.id == sanphamdto.Id);
                if (sp != null)
                {
                    sp.MaSanPham = sanphamdto.MaSanPham;
                    sp.TenSanPham = sanphamdto.TenSanPham;
                    sp.DonViTinh = sanphamdto.DonViTinh;
                    sp.DonGia = sanphamdto.DonGia;
                    sp.NgaySanXuat = sanphamdto.NgaySanXuat;
                    sp.HanSuDung = sanphamdto.HanSuDung;
                    sp.idLoaiHang = sanphamdto.IdLoaiHang;
                    sp.idNhaCungCap = sanphamdto.IdNhaCungCap;
                    sp.AnhSanPham = sanphamdto.AnhSanPham;
                    sp.updated_at = DateTime.Now;
                    sp.updated_by = 0;
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
