using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietBangLuong
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();

        // Methods
        //danh sách bảng l
        public IQueryable LayDSChiTietBangLuong()
        {
            try
            {
                return (from ct in da.Db.ChiTietBangLuongs
                        join nv in da.Db.NhanViens
                        on ct.idNhanVien equals nv.id
                        where ct.is_deleted == 0
                        select new { ct.id, ct.idBangLuong, nv.TenNhanVien,ct.NgayLam, ct.SoGioCongThucTe });
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        //ds bảng lương co dieu kien
        public IQueryable LayDSChiTietBangLuong(int idBangLuong)
        {
            try
            {
                return (from ct in da.Db.ChiTietBangLuongs
                        join nv in da.Db.NhanViens
                        on ct.idNhanVien equals nv.id
                        where ct.is_deleted == 0 && ct.idBangLuong == idBangLuong
                        select new { ct.id, ct.idBangLuong,nv.TenNhanVien, ct.NgayLam, ct.SoGioCongThucTe});
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public IQueryable LayDSLichLam()
        {
            return from ll in da.Db.LichLams select ll;
        }
        public void ThemChiTietBangLuong(DTO_ChiTietBangLuong ctbl)
        {
            try
            {
                    ChiTietBangLuong chi = new ChiTietBangLuong{ 
                        idBangLuong = ctbl.IdBangLuong,
                        idNhanVien = ctbl.IdNhanVien,
                        idLichLam = ctbl.IdLichLam,
                        SoGioCongThucTe = ctbl.SoGioCongThucTe,
                        NgayLam = ctbl.NgayLam,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now,
                        created_by = 0,
                        updated_by = 0,
                        is_deleted = 0
                    };
                da.Db.ChiTietBangLuongs.InsertOnSubmit(chi);
                da.Db.SubmitChanges();
                var bangluongcapnhat = da.Db.BangLuongs.FirstOrDefault(bl => bl.id == ctbl.IdBangLuong);
                var tongGioCong = da.Db.ChiTietBangLuongs
                         .Where(ct => ct.idBangLuong == ctbl.IdBangLuong)
                         .Sum(ct => ct.SoGioCongThucTe);

                // Cập nhật tổng số giờ công cho bảng lương tương ứng
                bangluongcapnhat.TongGioCong = tongGioCong;

                // Cập nhật lương (ví dụ với hệ số lương là 100.000 VND cho mỗi giờ làm)
                bangluongcapnhat.Luong = tongGioCong * 100000;

                da.Db.SubmitChanges();
              

            }
            catch (Exception ex)
            {
                throw new Exception("có lỗi xảy ra: " + ex.Message);
            }

        }
    }
}
