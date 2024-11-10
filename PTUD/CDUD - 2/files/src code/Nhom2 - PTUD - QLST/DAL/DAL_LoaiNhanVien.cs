/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 23/10/2024
 * DAL_LoaiNhanVien.cs
 */
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_LoaiNhanVien
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();

        // Methods
        public IQueryable GetListLNV()
        {
            IQueryable query = from lnv in da.Db.LoaiNhanViens
                               where lnv.is_deleted == 0
                               select new
                               {
                                   lnv.id,
                                   lnv.MaLoaiNhanVien,
                                   lnv.TenLoaiNhanVien
                               };
            return query;
        }

        public IQueryable GetListAllLNVByTen()
        {
            IQueryable query = from lnv in da.Db.LoaiNhanViens
                               select new
                               {
                                   Id = lnv.id,
                                   TenLoaiNhanVien = lnv.TenLoaiNhanVien
                               };
            return query;
        }

        public IQueryable GetListOneLNVByTen(int id)
        {
            IQueryable query = from lnv in da.Db.LoaiNhanViens
                               where lnv.id == id
                               select new
                               {
                                   Id = lnv.id,
                                   TenLoaiNhanVien = lnv.TenLoaiNhanVien
                               };
            return query;
        }

        public void AddLNV(DTO_LoaiNhanVien loaiNhanVien)
        {
            try
            {
                // Checked new record loainhanvien saved in db LoaiNhanVien
                var query = (from lnv in da.Db.LoaiNhanViens
                             where lnv.MaLoaiNhanVien == loaiNhanVien.MaLoaiNV
                             select lnv).FirstOrDefault();

                // Added new record loainhanvien
                if (query == null)
                {
                    da.Db.LoaiNhanViens.InsertOnSubmit(new LoaiNhanVien
                    {
                        MaLoaiNhanVien = loaiNhanVien.MaLoaiNV,
                        TenLoaiNhanVien = loaiNhanVien.TenLoaiNV,
                        is_deleted = 0,
                        created_at = DateTime.Now,
                        created_by = 0,
                        updated_at = DateTime.Now,
                        updated_by = 0,
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm loại nhân viên mới thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Loại nhân viên mới đã có trong dữ liệu.",
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

        public void UpdateLNV(DTO_LoaiNhanVien loaiNhanVien)
        {
            try
            {
                // Initialize Variables
                string nameLNV = string.Empty;

                // Checked loainhanvien != null
                if (loaiNhanVien != null)
                {
                    // Init LoaiNhanVien
                    LoaiNhanVien lnv_update = da.Db.LoaiNhanViens.Single(lnv => lnv.id == loaiNhanVien.Id);

                    // Updated lnv_update
                    lnv_update.MaLoaiNhanVien = loaiNhanVien.MaLoaiNV;
                    lnv_update.TenLoaiNhanVien = loaiNhanVien.TenLoaiNV;
                    lnv_update.is_deleted = loaiNhanVien.Is_deleted;
                    lnv_update.created_by = 0;
                    lnv_update.created_at = DateTime.Now;
                    lnv_update.updated_by = 0;
                    lnv_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameLNV = loaiNhanVien.TenLoaiNV;

                    // Messaged
                    MessageBox.Show($"Sửa thông tin loại nhân viên: [{nameLNV}] thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Sửa thông tin loại nhân viên: [{nameLNV}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

        public void DelLNV(int id)
        {
            try
            {
                // Initialize Variables
                string nameLNV = string.Empty;

                // Checked id lnv saved in db lnv?
                var query = (from lnv in da.Db.LoaiNhanViens
                             where lnv.id == id
                             select lnv).Count();

                if (query == 1)
                {
                    // Init LoaiNhanVien
                    LoaiNhanVien lnv_update = da.Db.LoaiNhanViens.Single(lnv => lnv.id == id);

                    // Updated is_deleted = 1 for loainhanvien -> hidden item (avoid conflict FK)
                    lnv_update.is_deleted = 1;
                    lnv_update.created_by = 0;
                    lnv_update.created_at = DateTime.Now;
                    lnv_update.updated_by = 0;
                    lnv_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameLNV = lnv_update.TenLoaiNhanVien;

                    // Messaged
                    MessageBox.Show($"Xóa loại nhân viên: [{nameLNV}] thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Xóa loại nhân viên: [{nameLNV}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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
