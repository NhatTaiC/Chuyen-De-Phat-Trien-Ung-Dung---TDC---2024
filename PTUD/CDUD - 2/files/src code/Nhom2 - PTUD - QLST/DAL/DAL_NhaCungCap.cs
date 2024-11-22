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
    public class DAL_NhaCungCap
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();
        public DatabaseAccess Da { get => da; set => da = value; }

        // Methods
        // LayDSNCC()
        public IQueryable LayDSNCC()
        {
            IQueryable temp = from ncc in da.Db.NhaCungCaps
                              where ncc.is_deleted == 0
                              select new
                              {
                                  id = ncc.id,
                                  MaNCC = ncc.MaNhaCungCap,
                                  TenNCC = ncc.TenNhaCungCap,
                                  SDT = ncc.SoDienThoai,
                                  DiaChi = ncc.DiaChi
                              };
            return temp;
        }

        // ThemNCC()
        public bool ThemNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                // Check mã nhà cung cấp có != null hay không?
                if (ncc != null)
                {

                    var query2 = da.Db.NhaCungCaps.OrderByDescending(l => l.id).FirstOrDefault();

                    da.Db.NhaCungCaps.InsertOnSubmit(new NhaCungCap
                    {
                        MaNhaCungCap = query2.id < 10 ? "NCC0" + (query2.id + 1) : "NCC" + (query2.id + 1),
                        TenNhaCungCap = ncc.TenNhaCungCap,
                        SoDienThoai = ncc.SoDienThoai,
                        DiaChi = ncc.DiaChi,
                        created_at = DateTime.Now,
                        created_by = 0,
                        updated_at = DateTime.Now,
                        updated_by = 0,
                        is_deleted = 0
                    });


                    da.Db.SubmitChanges(); // Xác nhận thay đổi DB NhaCungCap

                    // Thông báo
                    MessageBox.Show($"Thêm nhà cung cấp +{ncc.TenNhaCungCap}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show($"Nhà cung cấp +{ncc.TenNhaCungCap}+ đã có trong danh sách khách hàng!", "Thông báo",
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

        // XoaNCC()
        public void XoaNCC(int id)
        {
            try
            {
                //tìm nhà cung cấp
                var data = da.Db.NhaCungCaps.FirstOrDefault(dt => dt.id == id && dt.is_deleted == 0);
                data.is_deleted = 1;
                da.Db.NhaCungCaps.DeleteOnSubmit(data);
                da.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }
        }

        // SuaNCC()
        public bool SuaNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                //kiểm tra nahf cung cấp có tồn tại chưa
                var nccc = da.Db.NhaCungCaps.FirstOrDefault(dt => dt.id == ncc.Id);
                if (nccc != null)
                {
                    nccc.MaNhaCungCap = ncc.MaNhaCungCap;
                    nccc.TenNhaCungCap = ncc.TenNhaCungCap;
                    nccc.SoDienThoai = ncc.SoDienThoai;
                    nccc.DiaChi = ncc.DiaChi;
                    nccc.updated_at = DateTime.Now;
                    nccc.updated_by = 0;
                    da.Db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show($"Sửa thông tin khách hàng +{ncc.TenNhaCungCap}+ thành công!", "Thông báo",
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

        public void DellNCC(int id)
        {
            try
            {
                // Initialize Variables
                //string nameCL = string.Empty;

                // Checked id lnv saved in db lnv?
                var query = (from lnv in da.Db.NhaCungCaps
                             where lnv.id == id
                             select lnv).Count();

                if (query == 1)
                {
                    // Init LoaiNhanVien
                    NhaCungCap lnv_update = da.Db.NhaCungCaps.Single(lnv => lnv.id == id);

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
