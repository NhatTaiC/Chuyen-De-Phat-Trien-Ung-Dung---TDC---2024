using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_PhieuNhap
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();

        public DatabaseAccess Da { get => da; set => da = value; }

        // Methods
        // LayDSPhieuNhap()
        public IQueryable LayDSPhieuNhap()
        {
            IQueryable temp = from pn in da.Db.PhieuNhaps
                              where pn.is_deleted == 0
                              select new
                              {
                                  id = pn.id,
                                  MaPhieuNhap = pn.MaPhieuNhap,
                                  NgayNhap = pn.NgayNhap,
                                  ThanhTien = pn.ThanhTien,
                                  MaNhanVien = pn.idNhanVien
                              };
            return temp;
        }

        // ThemPhieuNhap()
        public bool ThemPhieuNhap(DTO_PhieuNhap pn)
        {
            try
            {
                // Check khachHang.MaKH có != null hay không?
                if (pn != null)
                {

                    var query2 = da.Db.PhieuNhaps.OrderByDescending(l => l.id).FirstOrDefault();

                    da.Db.PhieuNhaps.InsertOnSubmit(new PhieuNhap
                    {
                        MaPhieuNhap = query2.id < 10 ? "PN0" + (query2.id + 1) : "PN" + (query2.id + 1),
                        NgayNhap = pn.NgayNhap,
                        ThanhTien = pn.ThanhTien,
                        idNhanVien = pn.IdNhanVien,
                        created_at = DateTime.Now,
                        created_by = 0,
                        updated_at = DateTime.Now,
                        updated_by = 0,
                        is_deleted = 0
                    });;


                    da.Db.SubmitChanges(); // Xác nhận thay đổi DB KH

                    // Thông báo
                    MessageBox.Show($"Thêm phiếu nhập +{pn.MaPhieuNhap}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show($"Phiếu nhập +{pn.MaPhieuNhap}+ đã có trong danh sách Phiếu nhập!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
                throw;
            }
            return false;
        }

        // XoaPhieuNhap()
        public void XoaPhieuNhap(int id)
        {
            try
            {
                //tìm loại hàng xóa
                var data = da.Db.PhieuNhaps.FirstOrDefault(dt => dt.id == id && dt.is_deleted == 0);
                data.is_deleted = 1;
                da.Db.PhieuNhaps.DeleteOnSubmit(data);
                da.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }
        }

        // SuaPhieuNhap()
        public bool SuaPhieuNhap(DTO_PhieuNhap pn)
        {
            try
            {
                //kiểm tra mã loại hàng có tồn tại chưa
                var pnn = da.Db.PhieuNhaps.FirstOrDefault(dt => dt.id == pn.Id);
                if (pnn != null)
                {
                    //pnn.MaPhieuNhap = pn.MaPhieuNhap;
                    pnn.NgayNhap = pn.NgayNhap;
                    pnn.ThanhTien = pn.ThanhTien;
                    pnn.idNhanVien = pn.IdNhanVien;
                    pnn.updated_at = DateTime.Now;
                    pnn.updated_by = 0;
                    da.Db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show($"Sửa thông tin khách hàng +{pn.MaPhieuNhap}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Throw Exception
                MessageBox.Show(ex.Message);
                throw;
            }
            return false;
        }
        public IQueryable LayDSanPham()
        {
            IQueryable temp = from pn in da.Db.SanPhams
                              select new
                              {
                                  pn.id,
                                  pn.TenSanPham
                              };
            return temp;
        }

        public IQueryable LayDSNV()
        {
            IQueryable temp = from ll in da.Db.NhanViens
                              select new
                              {
                                  ll.id,
                                  ll.TenNhanVien,
                              };
            return temp;
        }

        public void DellPN(int id)
        {
            try
            {
                // Initialize Variables
                //string nameCL = string.Empty;

                // Checked id lnv saved in db lnv?
                var query = (from lnv in da.Db.PhieuNhaps
                             where lnv.id == id
                             select lnv).Count();

                if (query == 1)
                {
                    // Init LoaiNhanVien
                    PhieuNhap lnv_update = da.Db.PhieuNhaps.Single(lnv => lnv.id == id);

                    // Updated is_deleted = 1 for loainhanvien -> hidden item (avoid conflict FK)
                    lnv_update.is_deleted = 1;
                    lnv_update.created_by = 0;
                    lnv_update.created_at = DateTime.Now;
                    lnv_update.updated_by = 0;
                    lnv_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    //nameCL = lnv_update.ten;

                    // Messaged
                    MessageBox.Show($"Xóa thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Xóa không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Messaged
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}

