/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 08/11/2024
 * DAL_ChiTietHoaDon.cs
 */
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_ChiTietHoaDon
    {
        // Fields
        DatabaseAccess da = new DatabaseAccess();

        // Methods
        public IQueryable GetListCTHD()
        {
            var query = from cthd in da.Db.ChiTietHoaDons
                        where cthd.is_deleted == 0
                        select new
                        {
                            cthd.id,
                            cthd.SoLuong,
                            cthd.idHoaDon,
                            cthd.idSanPham
                        };

            return query;
        }

        public void AddCTHD(DTO_ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                // Checked chiTietHoaDon is saved in table ChiTietHoaDon?
                var query = (from cthd in da.Db.ChiTietHoaDons
                             where cthd.idHoaDon == chiTietHoaDon.IdHoaDon &&
                             cthd.idSanPham == chiTietHoaDon.IdSanPham
                             select cthd).FirstOrDefault();


                if (query == null)
                {
                    // Added new record ChiTietHoaDon
                    da.Db.ChiTietHoaDons.InsertOnSubmit(new ChiTietHoaDon
                    {
                        SoLuong = chiTietHoaDon.SoLuong,
                        idHoaDon = chiTietHoaDon.IdHoaDon,
                        idSanPham = chiTietHoaDon.IdSanPham,
                        is_deleted = 0,
                        created_by = 0,
                        created_at = DateTime.Now,
                        updated_by = 0,
                        updated_at = DateTime.Now
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm chi tiết hoá đơn mới thành công!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Đã có dữ liệu sản phẩm (ẩn) trong chi tiết hóa đơn mới.", "Thông báo",
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

        public void UpdateCTHD(DTO_ChiTietHoaDon chiTietHoaDon)
        {
            try
            {

                // Checked chiTietHoaDon != null
                if (chiTietHoaDon != null)
                {
                    ChiTietHoaDon cthd_update = da.Db.ChiTietHoaDons.SingleOrDefault(cthd => cthd.id == chiTietHoaDon.Id);
                    cthd_update.SoLuong = chiTietHoaDon.SoLuong;
                    cthd_update.idHoaDon = chiTietHoaDon.IdHoaDon;
                    cthd_update.idSanPham = chiTietHoaDon.IdSanPham;
                    cthd_update.is_deleted = chiTietHoaDon.Is_deleted;
                    cthd_update.created_by = 0;
                    cthd_update.created_at = DateTime.Now;
                    cthd_update.updated_by = 0;
                    cthd_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Sửa thông tin chi tiết hoá đơn thành công!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Sửa thông tin chi tiết hóa đơn không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

        public void DeleteCTHD(int id)
        {
            try
            {
                // Checked id saved in table ChiTietHoaDon
                var query = (from cthd in da.Db.ChiTietHoaDons where cthd.id == id select cthd).Count();

                if (query == 1)
                {
                    ChiTietHoaDon cthd_update = da.Db.ChiTietHoaDons.SingleOrDefault(cthd => cthd.id == id);
                    cthd_update.SoLuong = 0;
                    cthd_update.is_deleted = 1;
                    cthd_update.created_by = 0;
                    cthd_update.created_at = DateTime.Now;
                    cthd_update.updated_by = 0;
                    cthd_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Xóa chi tiết hoá đơn thành công!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Xóa chi tiết hóa đơn không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

        public int GetMaxIdCTHD()
        {
            var query = da.Db.ChiTietHoaDons.OrderByDescending(cthd => cthd.id).FirstOrDefault();

            return (int)query.id;
        }

        public IQueryable GetListCTHDTheoMaHD(int idMaHD)
        {
            var query = from cthd in da.Db.ChiTietHoaDons
                        join hd in da.Db.HoaDons
                        on cthd.idHoaDon equals hd.id
                        join sp in da.Db.SanPhams
                        on cthd.idSanPham equals sp.id
                        where cthd.idHoaDon == idMaHD && cthd.is_deleted == 0
                        select new
                        {
                            cthd.id,
                            hd.MaHoaDon,
                            sp.TenSanPham,
                            cthd.SoLuong,
                            sp.DonGia,
                            ThanhTien = cthd.SoLuong * sp.DonGia,
                            cthd.idHoaDon,
                            cthd.idSanPham,
                        };

            return query;
        }

        // Check CTHD saved in table CTHD By IdHd, IdSp
        public bool CheckCTHDByIdHdIdSp(int idHd, int idSp)
        {
            var query = (from cthd in da.Db.ChiTietHoaDons
                         where cthd.idHoaDon == idHd
                         && cthd.idSanPham == idSp
                         && cthd.is_deleted == 0
                         select cthd).Count();

            if (query == 1)
            {
                return true;
            }

            return false;
        }

        // Get SoLuongSP in table CTHD by idHd, idSp, is_deleted = 0
        public int GetSoLuongSpInCTHD(int idHd, int idSp)
        {
            var query = (from cthd in da.Db.ChiTietHoaDons
                         where cthd.idHoaDon == idHd &&
                         cthd.idSanPham == idSp &&
                         cthd.is_deleted == 0
                         select cthd).FirstOrDefault();

            return (int)query.SoLuong;
        }

        // Get SoLuongSP in table CTHD by idHd, idSp, is_deleted = 1
        public int GetSoLuongSpInCTHD2(int idHd, int idSp)
        {
            var query = (from cthd in da.Db.ChiTietHoaDons
                         where cthd.idHoaDon == idHd &&
                         cthd.idSanPham == idSp &&
                         cthd.is_deleted == 1
                         select cthd).FirstOrDefault();

            return (int)query.SoLuong;
        }

        // Update SoLuongSP in table CTHD by soLuong, idHd, idSp
        public void UpdateSoLuongSpInCTHD(int soLuong, int idHD, int idSp)
        {
            var cthd_update = da.Db.ChiTietHoaDons.SingleOrDefault(cthd => cthd.idHoaDon == idHD && cthd.idSanPham == idSp);
            cthd_update.SoLuong += soLuong;

            // Saved
            da.Db.SubmitChanges();
        }

        public List<DTO_ThanhTien> GetListCTHDTheoMaHD2(int idMaHD)
        {
            var query = (from cthd in da.Db.ChiTietHoaDons
                         join hd in da.Db.HoaDons
                         on cthd.idHoaDon equals hd.id
                         join sp in da.Db.SanPhams
                         on cthd.idSanPham equals sp.id
                         where cthd.idHoaDon == idMaHD && cthd.is_deleted == 0
                         select new
                         {
                             cthd.id,
                             hd.MaHoaDon,
                             sp.TenSanPham,
                             cthd.SoLuong,
                             sp.DonGia,
                             ThanhTien = cthd.SoLuong * sp.DonGia,
                             cthd.idHoaDon,
                             cthd.idSanPham,
                         }).ToList();

            var list = new List<DTO_ThanhTien>();

            foreach (var item in query)
            {
                DTO_ThanhTien tt = new DTO_ThanhTien();
                tt.ThanhTien = (int)item.ThanhTien;
                list.Add(tt);
            }

            return list;
        }

        public IQueryable SearchListCTHDByMaHD(string maHD)
        {
            var query = from cthd in da.Db.ChiTietHoaDons
                        join hd in da.Db.HoaDons
                        on cthd.idHoaDon equals hd.id
                        join sp in da.Db.SanPhams
                        on cthd.idSanPham equals sp.id
                        where hd.MaHoaDon.ToLower().Contains(maHD.ToLower()) && cthd.is_deleted == 0
                        select new
                        {
                            cthd.id,
                            hd.MaHoaDon,
                            sp.TenSanPham,
                            cthd.SoLuong,
                            sp.DonGia,
                            ThanhTien = cthd.SoLuong * sp.DonGia,
                            cthd.idHoaDon,
                            cthd.idSanPham,
                        };

            return query;
        }

        // Tinh tong tien by idHd
        public int GetTotalCashByIdHd(int idHd)
        {
            // Initialize Variables
            var list = this.GetListCTHDTheoMaHD2(idHd);
            int totalCash = 0;

            foreach (var item in list)
            {
                totalCash += item.ThanhTien;
            }

            return totalCash;

        }

        // Remove CTHD by Id
        public void DeleteCTHD2(int id)
        {
            try
            {
                // Checked id saved in table ChiTietHoaDon
                var query = (from cthd in da.Db.ChiTietHoaDons where cthd.id == id select cthd).FirstOrDefault();

                if (query != null)
                {
                    //ChiTietHoaDon cthd_update = da.Db.ChiTietHoaDons.SingleOrDefault(cthd => cthd.id == id);
                    //cthd_update.SoLuong = 0;
                    //cthd_update.is_deleted = 1;
                    //cthd_update.created_by = 0;
                    //cthd_update.created_at = DateTime.Now;
                    //cthd_update.updated_by = 0;
                    //cthd_update.updated_at = DateTime.Now;

                    // Remove cthd by id
                    da.Db.ChiTietHoaDons.DeleteOnSubmit(query);

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Xóa chi tiết hoá đơn thành công!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Xóa chi tiết hóa đơn không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

        public void AddCTHD2(DTO_ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                // Checked chiTietHoaDon is saved in table ChiTietHoaDon?
                var query = (from cthd in da.Db.ChiTietHoaDons
                             where cthd.idHoaDon == chiTietHoaDon.IdHoaDon &&
                             cthd.idSanPham == chiTietHoaDon.IdSanPham
                             select cthd).FirstOrDefault();


                if (query == null)
                {
                    // Added new record ChiTietHoaDon
                    da.Db.ChiTietHoaDons.InsertOnSubmit(new ChiTietHoaDon
                    {
                        SoLuong = chiTietHoaDon.SoLuong,
                        idHoaDon = chiTietHoaDon.IdHoaDon,
                        idSanPham = chiTietHoaDon.IdSanPham,
                        is_deleted = 0,
                        created_by = 0,
                        created_at = DateTime.Now,
                        updated_by = 0,
                        updated_at = DateTime.Now
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    //// Messaged
                    //MessageBox.Show("Thêm chi tiết hoá đơn mới thành công!", "Thông báo",
                    //MessageBoxButtons.OK,
                    //MessageBoxIcon.Information);
                }
                //else
                //{
                //    // Messaged
                //    MessageBox.Show("Thêm không thành công! Đã có dữ liệu sản phẩm (ẩn) trong chi tiết hóa đơn mới.", "Thông báo",
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Warning);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


    }
}
