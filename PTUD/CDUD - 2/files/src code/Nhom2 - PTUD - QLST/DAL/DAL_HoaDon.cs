/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 07/11/2024
 * DAL_HoaDon.cs
 */
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_HoaDon
    {
        // Initialize Variable
        DatabaseAccess da = new DatabaseAccess();

        // Methods
        public IQueryable GetListHD()
        {
            var query = from hd in da.Db.HoaDons
                        where hd.is_deleted == 0
                        select new
                        {
                            hd.id,
                            hd.MaHoaDon,
                            hd.NgayLapHD,
                            hd.GioLapHD,
                            hd.TongTien,
                            hd.ThanhTien,
                            hd.idKhachHang,
                            hd.idKhuyenMai,
                            hd.idNhanVien
                        };
            return query;
        }

        // AddHD not have MaHoaDon, NgayLapHD, GioLapHD, TongTien, ThanhTien
        public void AddHD(DTO_HoaDon hoaDon)
        {
            try
            {
                // Checked hoaDon is saved in table HoaDon?
                var query = (from hd in da.Db.HoaDons
                             where hd.id == hoaDon.Id
                             select hd).FirstOrDefault();


                if (query == null)
                {
                    // Get max(id) in table HoaDon
                    var query2 = da.Db.HoaDons.OrderByDescending(hd => hd.id).FirstOrDefault();

                    // Added new record HoaDon
                    da.Db.HoaDons.InsertOnSubmit(new HoaDon
                    {
                        MaHoaDon = query2.id < 10 ? "HD00" + (query2.id + 1) : "HD0" + (query2.id + 1),
                        NgayLapHD = DateTime.Now,
                        GioLapHD = DateTime.Now,
                        TongTien = 0,
                        ThanhTien = 0,
                        idKhachHang = hoaDon.IdKhachHang == 0 ? (int?)null : hoaDon.IdKhachHang,
                        idKhuyenMai = hoaDon.IdKhuyenMai == 0 ? (int?)null : hoaDon.IdKhuyenMai,
                        idNhanVien = hoaDon.IdNhanVien == 0 ? (int?)null : hoaDon.IdNhanVien,
                        is_deleted = 0,
                        created_by = 0,
                        created_at = DateTime.Now,
                        updated_by = 0,
                        updated_at = DateTime.Now
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm hoá đơn mới thành công!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Hóa đơn mới đã có trong dữ liệu.", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // UpdateHD not have MaHoaDon, NgayLapHD, GioLapHD, TongTien, ThanhTien
        public void UpdateHD(DTO_HoaDon hoaDon)
        {
            try
            {
                // Initialize Variables
                string maHD = string.Empty;

                // Checked hoaDon != null
                if (hoaDon != null)
                {
                    HoaDon hd_update = da.Db.HoaDons.Single(hd => hd.id == hoaDon.Id);

                    hd_update.idKhachHang = hoaDon.IdKhachHang;
                    hd_update.idKhuyenMai = hoaDon.IdKhuyenMai;
                    hd_update.idNhanVien = hoaDon.IdNhanVien;
                    hd_update.is_deleted = 0;
                    hd_update.created_by = 0;
                    hd_update.created_at = DateTime.Now;
                    hd_update.updated_by = 0;
                    hd_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    maHD = hd_update.MaHoaDon;

                    // Messaged
                    MessageBox.Show($"Sửa thông tin hóa đơn: [{maHD}] thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Sửa thông tin hóa đơn: [{maHD}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // DeleteHD not have MaHoaDon, NgayLapHD, GioLapHD, TongTien, ThanhTien
        public void DeleteHD(int id)
        {
            try
            {
                // Initialize Variables
                string maHD = string.Empty;

                // Checked id is saved in table HoaDon
                var query = (from hd in da.Db.HoaDons
                             where hd.id == id
                             select hd).Count();

                if (query == 1)
                {
                    HoaDon hd_update = da.Db.HoaDons.Single(hd => hd.id == id);

                    hd_update.is_deleted = 1;
                    hd_update.created_by = 0;
                    hd_update.created_at = DateTime.Now;
                    hd_update.updated_by = 0;
                    hd_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    maHD = hd_update.MaHoaDon;

                    // Messaged
                    MessageBox.Show($"Xóa hóa đơn: [{maHD}] thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Xóa hóa đơn: [{maHD}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // GetMaxIdHD
        public int GetMaxIdHD()
        {
            var query = da.Db.HoaDons.OrderByDescending(hd => hd.id).FirstOrDefault();
            return (int)query.id;
        }

        // UpdateTotalCash from ChiTietHoaDon
        public void UpdateTotalCash(int idHd, int toTalCash)
        {
            var hd_update = da.Db.HoaDons.SingleOrDefault(hd => hd.id == idHd);
            hd_update.TongTien = toTalCash;

            // Saved
            da.Db.SubmitChanges();

            MessageBox.Show("Lưu tổng tiền vào hóa đơn thành công!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public IQueryable GetListHD2()
        {
            var query = from hd in da.Db.HoaDons
                        join km in da.Db.KhuyenMais
                        on hd.idKhuyenMai equals km.id
                        join kh in da.Db.KhachHangs
                        on hd.idKhachHang equals kh.id
                        join nv in da.Db.NhanViens
                        on hd.idNhanVien equals nv.id
                        where hd.is_deleted == 0
                        select new
                        {
                            hd.id,
                            hd.MaHoaDon,
                            hd.NgayLapHD,
                            hd.GioLapHD,
                            hd.TongTien,
                            hd.ThanhTien,
                            hd.idKhachHang,
                            hd.idKhuyenMai,
                            hd.idNhanVien,
                            kh.TenKhachHang,
                            km.TenKhuyenMai,
                            nv.TenNhanVien
                        };
            return query;
        }

        public IQueryable SearchHdByMaHD(string maHD)
        {
            var query = from hd in da.Db.HoaDons
                        where hd.MaHoaDon.ToLower().Contains(maHD.ToLower())
                        select new
                        {
                            hd.id,
                            hd.MaHoaDon,
                            hd.NgayLapHD,
                            hd.GioLapHD,
                            hd.TongTien,
                            hd.ThanhTien
                        };

            return query;

        }

        public IQueryable SearchHdByMaHD_Exact(string maHD)
        {
            var query = from hd in da.Db.HoaDons
                        where hd.MaHoaDon.ToLower().Equals(maHD.ToLower())
                        select new
                        {
                            hd.id,
                            hd.MaHoaDon,
                            hd.NgayLapHD,
                            hd.GioLapHD,
                            hd.TongTien,
                            hd.ThanhTien
                        };

            return query;

        }
        //tìm idhoadon bang MaHoaDon
        public string TimMaHoaDon(int id)
        {
            var query = (from hd in da.Db.HoaDons
                        where hd.id == id
                        select new
                        {
                            hd.id,
                            hd.MaHoaDon,
              
                        }).FirstOrDefault();
            string maHoaDon = "";
            if (query == null)
            {
                maHoaDon = "";
            }
            else
            {
              maHoaDon = query.MaHoaDon;
            }
            

            return maHoaDon;

        }

        public IQueryable GetListHD3()
        {
            var query = from hd in da.Db.HoaDons
                        where hd.is_deleted == 0
                        select new
                        {
                            hd.id,
                            hd.MaHoaDon,
                            hd.NgayLapHD,
                            hd.GioLapHD,
                            hd.TongTien,
                            hd.ThanhTien,
                        };

            return query;
        }

        // Check id saved in table HoaDon by maHd
        public bool CheckHd(string maHd)
        {
            var query = (from hd in da.Db.HoaDons
                         where hd.MaHoaDon.ToLower().Equals(maHd.ToLower())
                         select new
                         {
                             hd.id,
                             hd.NgayLapHD,
                             hd.GioLapHD,
                             hd.TongTien,
                             hd.ThanhTien
                         }).Count();

            if (query == 1)
            {
                return true;
            }
            return false;

        }
    }
}
