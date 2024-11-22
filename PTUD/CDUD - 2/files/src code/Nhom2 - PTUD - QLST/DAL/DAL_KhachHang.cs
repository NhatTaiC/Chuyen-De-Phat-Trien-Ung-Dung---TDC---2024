using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_KhachHang
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();

        public DatabaseAccess Da { get => da; set => da = value; }

        // Methods
        // LayDSKH()
        public IQueryable LayDSKH()
        {
            IQueryable temp = from kh in da.Db.KhachHangs
                              where kh.is_deleted == 0
                              select new
                              {
                                  id = kh.id,
                                  MaKH = kh.MaKhachHang,
                                  TenKH = kh.TenKhachHang,
                                  SDT = kh.SoDienThoai,
                                  Diem = kh.Diem
                              };
            return temp;
        }
        public DTO_KhachHang LayKhachHang(string sodienthoai)
        {
            var linqKH = da.Db.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == sodienthoai);
            if (linqKH == null)
            {

                return null;
            }

            DTO_KhachHang khachhang = new DTO_KhachHang
            {
                Id = linqKH.id,
                TenKhachHang = linqKH.TenKhachHang,
                MaKhachHang = linqKH.MaKhachHang,
                SoDienThoai = linqKH.SoDienThoai,
                Diem = (double)linqKH.Diem,
                Created_at = DateTime.Now,
                Created_by = 0,
                Updated_at = DateTime.Now,
                Update_by = 0,
                Is_deleted = 0
            };
            return khachhang;
        }
        public bool ThemKH(DTO_KhachHang khachHang)
        {
            try
            {
                // Check khachHang có != null hay không?
                if (khachHang != null)
                {
                    // Check có KH trong DB KH hay chưa?
                    var query2 = da.Db.KhachHangs.OrderByDescending(l => l.id).FirstOrDefault();

                    da.Db.KhachHangs.InsertOnSubmit(new KhachHang
                    {
                        MaKhachHang = query2.id < 10 ? "KH0" + (query2.id + 1) : "KH" + (query2.id + 1),
                        TenKhachHang = khachHang.TenKhachHang,
                        SoDienThoai = khachHang.SoDienThoai,
                        Diem = khachHang.Diem,
                        created_at = DateTime.Now,
                        created_by = 0,
                        updated_at = DateTime.Now,
                        updated_by = 0,
                        is_deleted = 0
                    });
                    da.Db.SubmitChanges(); // Xác nhận thay đổi DB KH

                    // Thông báo
                    MessageBox.Show($"Thêm khách hàng +{khachHang.TenKhachHang}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                else
                {
                    // Thông báo
                    MessageBox.Show("Khách hàng đã tồn tại trong danh sách!", "Thông báo",
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

        // XoaKH()
        public void XoaKH(int id)
        {
            try
            {
                //tìm Khách hàng
                var data = da.Db.KhachHangs.FirstOrDefault(dt => dt.id == id && dt.is_deleted == 0);
                data.is_deleted = 1;
                da.Db.KhachHangs.DeleteOnSubmit(data);
                da.Db.SubmitChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }
        }

        // SuaKH()
        public bool SuaKH(DTO_KhachHang khachHang)
        {
            try
            {
                //kiểm tra ma khách hàng có tồn tại chưa
                var kh = da.Db.KhachHangs.FirstOrDefault(dt => dt.id == khachHang.Id);
                if (kh != null)
                {
                    kh.MaKhachHang = khachHang.MaKhachHang;
                    kh.TenKhachHang = khachHang.TenKhachHang;
                    kh.SoDienThoai = khachHang.SoDienThoai;
                    kh.Diem = khachHang.Diem;
                    kh.updated_at = DateTime.Now;
                    kh.updated_by = 0;
                    da.Db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show($"Sửa thông tin khách hàng +{kh.TenKhachHang}+ thành công!", "Thông báo",
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

            //Tìm kiếm theo tên
            public IQueryable timkiemTheoTen(string ten)
            {
                return da.Db.KhachHangs
                    .Where(kh => kh.TenKhachHang.Contains(ten))
                    .Select(kh => new
                    {
                        id = kh.id,
                        MaKH = kh.MaKhachHang,
                        TenKH = kh.TenKhachHang,
                        SDT = kh.SoDienThoai,
                        Diem = kh.Diem
                    });
            }

            //Tìm kiếm theo số điện thoại
            public IQueryable timkiemTheoSDT(string sdt)
            {
                return da.Db.KhachHangs
                    .Where(kh => kh.SoDienThoai.Contains(sdt))
                    .Select(kh => new
                    {
                        id = kh.id,
                        MaKH = kh.MaKhachHang,
                        TenKH = kh.TenKhachHang,
                        SDT = kh.SoDienThoai,
                        Diem = kh.Diem
                    });
            }
        }

        public void DellKH(int id)
        {
            try
            {
                // Initialize Variables
                string nameCL = string.Empty;

                // Checked id lnv saved in db lnv?
                var query = (from lnv in da.Db.KhachHangs
                             where lnv.id == id
                             select lnv).Count();

                if (query == 1)
                {
                    // Init LoaiNhanVien
                    KhachHang lnv_update = da.Db.KhachHangs.Single(lnv => lnv.id == id);

                    // Updated is_deleted = 1 for loainhanvien -> hidden item (avoid conflict FK)
                    lnv_update.is_deleted = 1;
                    lnv_update.created_by = 0;
                    lnv_update.created_at = DateTime.Now;
                    lnv_update.updated_by = 0;
                    lnv_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameCL = lnv_update.TenKhachHang;

                    // Messaged
                    MessageBox.Show($"Xóa khách hàng: [{nameCL}] thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Xóa khách hàng: [{nameCL}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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

