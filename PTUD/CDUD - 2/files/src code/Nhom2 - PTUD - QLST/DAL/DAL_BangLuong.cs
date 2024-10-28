using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BangLuong
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();

        // Methods
        //danh sách bảng l
        public IQueryable LayDSBangLuong()
        {
            try
            {
                return from lh in da.Db.BangLuongs
                       where lh.is_deleted == 0
                       select new { lh.id,lh.MaBangLuong, lh.ThangNam, lh.TongGioCong, lh.Luong };
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
           
        }
        //ds bảng lương co dieu kien
        public IQueryable LayDSBangLuong(int idNhanVien)
        {
            try
            {
                return (from b in da.Db.BangLuongs
                        join ct in da.Db.ChiTietBangLuongs on b.id equals ct.idBangLuong
                        where ct.idNhanVien == idNhanVien && ct.is_deleted == 0 && b.is_deleted == 0
                        group ct by new
                        {
                            b.id,
                            b.ThangNam,
                            b.TongGioCong,
                            b.Luong,
                            b.MaBangLuong,
                            ct.idNhanVien
                        } into g
                        select new
                        {
                            g.Key.id,
                            g.Key.MaBangLuong,
                            g.Key.ThangNam,
                            g.Key.TongGioCong,
                            g.Key.Luong,
                            g.Key.idNhanVien
                        });
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           
        }
        public void ThemBangLuong(DTO_BangLuong bangluong)
        {
            try
            {
                var data = da.Db.BangLuongs.SingleOrDefault(cn => cn.MaBangLuong == bangluong.MaBangLuong);
                if (data == null)
                {
                    da.Db.BangLuongs.InsertOnSubmit(new BangLuong
                    {
                        MaBangLuong = bangluong.MaBangLuong,
                        ThangNam = bangluong.ThangNam,
                        Luong = bangluong.Luong,
                        TongGioCong = bangluong.TongGioCong,
                        is_deleted = 0,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now,
                        updated_by = 0,
                        created_by = 0
                    });
                    da.Db.SubmitChanges();
                }
                else 
                {
                    throw new Exception("Mã bảng lương đã tồn tại");
                }
                    
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra: "+ex.Message);
            }
        }
        public IQueryable DSNhanVien()
        {
            return from nv in da.Db.NhanViens
                   where nv.is_deleted == 0
                   select nv;
        }
    }
}
