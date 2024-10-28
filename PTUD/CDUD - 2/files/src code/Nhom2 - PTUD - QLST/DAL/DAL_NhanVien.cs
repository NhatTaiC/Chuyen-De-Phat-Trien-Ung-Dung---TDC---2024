/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 23/10/2024
 * DAL_NhanVien.cs
 */
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_NhanVien
    {
        // Initialize Variables
        DatabaseAccess da = new DatabaseAccess();

        // Methods
        public IQueryable GetListNV()
        {
            IQueryable query = from nv in da.Db.NhanViens
                               where nv.is_deleted == 0
                               select new
                               {
                                   nv.id,
                                   nv.MaNhanVien,
                                   nv.TenNhanVien,
                                   nv.SoDienThoai,
                                   nv.DiaChi,
                                   nv.idLoaiNhanVien,
                                   nv.idTaiKhoan
                               };
            return query;
        }

        public void AddNV(DTO_NhanVien nhanVien)
        {
            try
            {
                // Checked nhanVien saved in db NhanVien?
                var query = (from nv in da.Db.NhanViens
                             where nv.MaNhanVien == nhanVien.MaNV
                             select nv).FirstOrDefault();

                if (query == null)
                {
                    // Added new record nhanvien in db NhanVien
                    da.Db.NhanViens.InsertOnSubmit(new NhanVien
                    {
                        MaNhanVien = nhanVien.MaNV,
                        TenNhanVien = nhanVien.TenNV,
                        SoDienThoai = nhanVien.SoDT,
                        DiaChi = nhanVien.DiaChi,
                        idLoaiNhanVien = nhanVien.IdLNV,
                        idTaiKhoan = nhanVien.IdTK,
                        is_deleted = 0,
                        created_by = 0,
                        created_at = DateTime.Now,
                        updated_by = 0,
                        updated_at = DateTime.Now
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Nhân viên mới đã có trong dữ liệu.", "Thông báo",
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

        public void UpdateNV(DTO_NhanVien nhanVien)
        {
            try
            {
                // Initialize Variables
                string nameNV = string.Empty;

                // Checked nhanVien != null
                if (nhanVien != null)
                {
                    // Init NhanVien
                    NhanVien nv_update = da.Db.NhanViens.Single(nv => nv.id == nhanVien.Id);

                    // Updated nv_update
                    nv_update.MaNhanVien = nhanVien.MaNV;
                    nv_update.TenNhanVien = nhanVien.TenNV;
                    nv_update.SoDienThoai = nhanVien.SoDT;
                    nv_update.DiaChi = nhanVien.DiaChi;
                    nv_update.idLoaiNhanVien = nhanVien.IdLNV;
                    nv_update.idTaiKhoan = nhanVien.IdTK;
                    nv_update.is_deleted = nhanVien.Is_deleted;
                    nv_update.created_by = 0;
                    nv_update.created_at = DateTime.Now;
                    nv_update.updated_by = 0;
                    nv_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameNV = nv_update.TenNhanVien;

                    // Messaged
                    MessageBox.Show($"Sửa thông tin nhân viên: [{nameNV}] thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Sửa thông tin nhân viên: [{nameNV}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void DelNV(int id)
        {
            try
            {
                // Initialize Variables
                string nameNV = string.Empty;

                // Checked id nhanvien is saved in db NhanVien
                var query = (from nv in da.Db.NhanViens
                             where nv.id == id
                             select nv).Count();

                if (query == 1)
                {
                    // Init NhanVien
                    NhanVien nv_update = da.Db.NhanViens.Single(nv => nv.id == id);

                    // Updated is_deleted = 1 for nhanvien -> hidden item (avoid conflict FK)
                    nv_update.is_deleted = 1;
                    nv_update.created_by = 0;
                    nv_update.created_at = DateTime.Now;
                    nv_update.updated_by = 0;
                    nv_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameNV = nv_update.TenNhanVien;

                    // Messaged
                    MessageBox.Show($"Xóa nhân viên: [{nameNV}] thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Xóa nhân viên: [{nameNV}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
