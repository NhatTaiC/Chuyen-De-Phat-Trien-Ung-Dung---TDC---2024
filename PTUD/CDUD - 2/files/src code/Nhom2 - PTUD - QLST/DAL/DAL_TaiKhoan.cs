/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 16/10/2024
 * DAL_TaiKhoan.cs
 */
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();

        // Methods
        public bool CheckTaiKhoan(string taiKhoan, string matKhau)
        {
            var query = from tk in da.Db.TaiKhoans
                        where tk.TenTaiKhoan == taiKhoan && tk.MatKhau == matKhau
                        select tk;

            if (query.Count() == 1)
            {
                return true;
            }
            return false;
        }

        public int getIdTaiKhoan(string taiKhoan, string matKhau)
        {
            var query = (from tk in da.Db.TaiKhoans
                         where tk.TenTaiKhoan == taiKhoan && tk.MatKhau == matKhau
                         select tk).FirstOrDefault();
            return query.id;
        }

        public IQueryable GetListTK()
        {
            IQueryable query = from tk in da.Db.TaiKhoans
                               where tk.is_deleted == 0
                               select new
                               {
                                   tk.id,
                                   tk.MaTaiKhoan,
                                   tk.TenTaiKhoan,
                                   tk.MatKhau,
                                   tk.Quyen
                               };
            return query;
        }

        public IQueryable GetListTKByQuyen()
        {
            IQueryable query = from tk in da.Db.TaiKhoans
                               group tk by tk.Quyen into q
                               select new
                               {
                                   Quyen = q.Key
                               };
            return query;
        }

        public IQueryable GetListAllTKByTenTK()
        {
            IQueryable query = from tk in da.Db.TaiKhoans
                               where tk.is_deleted == 0
                               select new
                               {
                                   Id = tk.id,
                                   TenTaiKhoan = tk.TenTaiKhoan
                               };
            return query;
        }

        public IQueryable GetListOneTKByTenTK(int id)
        {
            IQueryable query = from tk in da.Db.TaiKhoans
                               where tk.id == id
                               select new
                               {
                                   Id = tk.id,
                                   TenTaiKhoan = tk.TenTaiKhoan
                               };
            return query;
        }

        public int GetRole(string taiKhoan, string matKhau)
        {
            var query = (from tk in da.Db.TaiKhoans
                         where tk.TenTaiKhoan == taiKhoan && tk.MatKhau == matKhau
                         select new
                         {
                             Quyen = tk.Quyen
                         }).FirstOrDefault();
            return (int)query.Quyen;
        }

        public void AddTK(DTO_TaiKhoan taiKhoan)
        {
            try
            {
                // Checked new record taikhoan saved in db TaiKhoan
                var query = (from tk in da.Db.TaiKhoans
                             where tk.MaTaiKhoan == taiKhoan.MaTaiKhoan
                             select tk).FirstOrDefault();

                // Add new record taikhoan in dbTaiKhoan
                if (query == null)
                {
                    da.Db.TaiKhoans.InsertOnSubmit(new TaiKhoan
                    {
                        MaTaiKhoan = taiKhoan.MaTaiKhoan,
                        TenTaiKhoan = taiKhoan.TenTaiKhoan,
                        MatKhau = taiKhoan.MatKhau,
                        Quyen = taiKhoan.Quyen,
                        is_deleted = 0,
                        created_at = DateTime.Now,
                        created_by = 0,
                        updated_at = DateTime.Now,
                        updated_by = 0,
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm tài khoản mới thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Tài khoản đã có trong dữ liệu.",
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

        public void UpdateTK(DTO_TaiKhoan taiKhoan)
        {
            try
            {
                // Initialize Variables
                string nameTK = string.Empty;

                // Checked DTO_TaiKhoan != null
                if (taiKhoan != null)
                {
                    // Init TaiKhoan obj
                    TaiKhoan tk_update = da.Db.TaiKhoans.Single(t => t.id == taiKhoan.Id);

                    // Updated tk_update
                    tk_update.MaTaiKhoan = taiKhoan.MaTaiKhoan;
                    tk_update.TenTaiKhoan = taiKhoan.TenTaiKhoan;
                    tk_update.MatKhau = taiKhoan.MatKhau;
                    tk_update.Quyen = taiKhoan.Quyen;
                    tk_update.is_deleted = taiKhoan.Is_deleted;
                    tk_update.created_by = 0;
                    tk_update.created_at = DateTime.Now;
                    tk_update.updated_by = 0;
                    tk_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameTK = taiKhoan.TenTaiKhoan;

                    // Messaged
                    MessageBox.Show($"Sửa thông tin tài khoản: [{nameTK}] thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Sửa thông tin tài khoản: [{nameTK}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

        public void DelTK(int id)
        {
            try
            {
                // Initialize Variables
                string tenTK = string.Empty;

                // Checked id taikhoan saved in db TaiKhoan?
                var query = (from tk in da.Db.TaiKhoans
                             where tk.id == id
                             select tk).Count();

                if (query == 1)
                {
                    // Init TaiKhoan
                    TaiKhoan tk_update = da.Db.TaiKhoans.Single(tk => tk.id == id);

                    // Updated is_deleted = 1 for taikhoan => hidden item (avoid conflict FK)
                    tk_update.is_deleted = 1;
                    tk_update.created_by = 0;
                    tk_update.created_at = DateTime.Now;
                    tk_update.updated_by = 0;
                    tk_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    tenTK = tk_update.TenTaiKhoan;

                    // Messaged
                    MessageBox.Show($"Xóa tài khoản: [{tenTK}] thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Xóa tài khoản: [{tenTK}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

        // AddTK not have maTK
        public void AddTK2(DTO_TaiKhoan taiKhoan)
        {
            try
            {
                // Checked new record taikhoan saved in db TaiKhoan
                var query = (from tk in da.Db.TaiKhoans
                             where tk.MaTaiKhoan == taiKhoan.MaTaiKhoan
                             select tk).FirstOrDefault();

                // Add new record taikhoan in dbTaiKhoan
                if (query == null)
                {
                    // Get max(id) in table TaiKhoan
                    var query2 = da.Db.TaiKhoans.OrderByDescending(tk => tk.id).FirstOrDefault();

                    da.Db.TaiKhoans.InsertOnSubmit(new TaiKhoan
                    {
                        MaTaiKhoan = query2.id < 10 ? "TK00" + (query2.id + 1) : "TK0" + (query2.id + 1),
                        TenTaiKhoan = taiKhoan.TenTaiKhoan,
                        MatKhau = taiKhoan.MatKhau,
                        Quyen = taiKhoan.Quyen,
                        is_deleted = 0,
                        created_at = DateTime.Now,
                        created_by = 0,
                        updated_at = DateTime.Now,
                        updated_by = 0,
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm tài khoản mới thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Tài khoản đã có trong dữ liệu.",
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

        // UpdateTK2 not have maTK
        public void UpdateTK2(DTO_TaiKhoan taiKhoan)
        {
            try
            {
                // Initialize Variables
                string nameTK = string.Empty;

                // Checked DTO_TaiKhoan != null
                if (taiKhoan != null)
                {
                    // Init TaiKhoan obj
                    TaiKhoan tk_update = da.Db.TaiKhoans.Single(t => t.id == taiKhoan.Id);

                    // Updated tk_update
                    tk_update.TenTaiKhoan = taiKhoan.TenTaiKhoan;
                    tk_update.MatKhau = taiKhoan.MatKhau;
                    tk_update.Quyen = taiKhoan.Quyen;
                    tk_update.is_deleted = taiKhoan.Is_deleted;
                    tk_update.created_by = 0;
                    tk_update.created_at = DateTime.Now;
                    tk_update.updated_by = 0;
                    tk_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameTK = taiKhoan.TenTaiKhoan;

                    // Messaged
                    MessageBox.Show($"Sửa thông tin tài khoản: [{nameTK}] thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Sửa thông tin tài khoản: [{nameTK}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

        // Get max(id) in table TaiKhoan
        public int GetMaxIdTK()
        {
            var query = da.Db.TaiKhoans.OrderByDescending(tk => tk.id).FirstOrDefault();

            return (int)query.id;
        }
    }
}
