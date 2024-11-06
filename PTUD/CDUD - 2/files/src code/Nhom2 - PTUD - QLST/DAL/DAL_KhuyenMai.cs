/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 23/10/2024
 * DAL_KhuyenMai.cs
 */
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_KhuyenMai
    {
        // Initialize Variables
        DatabaseAccess da = new DatabaseAccess();

        // Methods
        public IQueryable GetListKM()
        {
            IQueryable query = from km in da.Db.KhuyenMais
                               where km.is_deleted == 0
                               select new
                               {
                                   km.id,
                                   km.MaKhuyenMai,
                                   km.TenKhuyenMai,
                                   km.GiaTri
                               };
            return query;
        }

        public void AddKM(DTO_KhuyenMai khuyenMai)
        {
            try
            {
                // Checked new record khuyenMai saved in db KhuyenMai
                var query = (from km in da.Db.KhuyenMais
                             where km.MaKhuyenMai == khuyenMai.MaKhuyenMai
                             select km).FirstOrDefault();

                if (query == null)
                {
                    da.Db.KhuyenMais.InsertOnSubmit(new KhuyenMai
                    {
                        MaKhuyenMai = khuyenMai.MaKhuyenMai,
                        TenKhuyenMai = khuyenMai.TenKhuyenMai,
                        GiaTri = khuyenMai.GiaTri,
                        is_deleted = 0,
                        created_at = DateTime.Now,
                        created_by = 0,
                        updated_at = DateTime.Now,
                        updated_by = 0,
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm khuyến mãi mới thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Khuyến mãi mới đã có trong dữ liệu.",
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

        public void UpdateKM(DTO_KhuyenMai khuyenMai)
        {
            try
            {
                // Initialize Variables
                string nameKM = string.Empty;

                if (khuyenMai != null)
                {
                    KhuyenMai km_update = da.Db.KhuyenMais.Single(km => km.id == khuyenMai.Id);

                    // Updated km_update
                    km_update.MaKhuyenMai = khuyenMai.MaKhuyenMai;
                    km_update.TenKhuyenMai = khuyenMai.TenKhuyenMai;
                    km_update.GiaTri = khuyenMai.GiaTri;
                    km_update.is_deleted = khuyenMai.Is_deleted;
                    km_update.created_by = 0;
                    km_update.created_at = DateTime.Now;
                    km_update.updated_by = 0;
                    km_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameKM = km_update.TenKhuyenMai;

                    // Messaged
                    MessageBox.Show($"Sửa thông tin khuyến mãi: [{nameKM}] thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Sửa thông tin khuyến mãi: [{nameKM}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

        public void DelKM(int id)
        {
            try
            {
                // Initialize Variables
                string nameKM = string.Empty;

                // Checked id khuyenMai saved in db KhuyenMai
                var query = (from km in da.Db.KhuyenMais
                             where km.id == id
                             select km).Count();

                if (query == 1)
                {
                    KhuyenMai km_update = da.Db.KhuyenMais.Single(km => km.id == id);

                    // Updated km_update
                    km_update.is_deleted = 1;
                    km_update.created_by = 0;
                    km_update.created_at = DateTime.Now;
                    km_update.updated_by = 0;
                    km_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameKM = km_update.TenKhuyenMai;

                    // Messaged
                    MessageBox.Show($"Xóa khuyến mãi: [{nameKM}] thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Xóa khuyến mãi: [{nameKM}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

        // AddKM2 not have maKM
        public void AddKM2(DTO_KhuyenMai khuyenMai)
        {
            try
            {
                // Checked new record khuyenMai saved in db KhuyenMai
                var query = (from km in da.Db.KhuyenMais
                             where km.MaKhuyenMai == khuyenMai.MaKhuyenMai
                             select km).FirstOrDefault();

                if (query == null)
                {
                    // Get max(id) record in table KhuyenMai
                    var query1 = da.Db.KhuyenMais.OrderByDescending(km => km.id).FirstOrDefault();

                    da.Db.KhuyenMais.InsertOnSubmit(new KhuyenMai
                    {
                        MaKhuyenMai = query1.id < 10 ? "KM00" + (query1.id + 1) : "KM0" + (query1.id + 1),
                        TenKhuyenMai = khuyenMai.TenKhuyenMai,
                        GiaTri = khuyenMai.GiaTri,
                        is_deleted = 0,
                        created_at = DateTime.Now,
                        created_by = 0,
                        updated_at = DateTime.Now,
                        updated_by = 0,
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm khuyến mãi mới thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Khuyến mãi mới đã có trong dữ liệu.",
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

        // UpdateKM2 not have maKM
        public void UpdateKM2(DTO_KhuyenMai khuyenMai)
        {
            try
            {
                // Initialize Variables
                string nameKM = string.Empty;

                if (khuyenMai != null)
                {
                    KhuyenMai km_update = da.Db.KhuyenMais.Single(km => km.id == khuyenMai.Id);

                    // Updated km_update
                    km_update.TenKhuyenMai = khuyenMai.TenKhuyenMai;
                    km_update.GiaTri = khuyenMai.GiaTri;
                    km_update.is_deleted = khuyenMai.Is_deleted;
                    km_update.created_by = 0;
                    km_update.created_at = DateTime.Now;
                    km_update.updated_by = 0;
                    km_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameKM = km_update.TenKhuyenMai;

                    // Messaged
                    MessageBox.Show($"Sửa thông tin khuyến mãi: [{nameKM}] thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Sửa thông tin khuyến mãi: [{nameKM}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

        // Get max(id) KhuyenMai
        public int GetMaxIdKM()
        {
            var query = da.Db.KhuyenMais.OrderByDescending(km => km.id).FirstOrDefault();

            return (int)query.id;
        }
    }
}
