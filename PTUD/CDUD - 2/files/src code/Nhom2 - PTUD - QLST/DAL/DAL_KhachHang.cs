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
    }

