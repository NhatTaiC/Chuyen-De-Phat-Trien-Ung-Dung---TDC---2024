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
	public class DAL_LichLam
	{
		// Fields
		private DatabaseAccess da = new DatabaseAccess();

		public DatabaseAccess Da { get => da; set => da = value; }

		// Methods
		// LayDSLichLam()
		public IQueryable LayDSLichLam()
		{
            try
            {
                return (from b in da.Db.LichLams
                        join nv in da.Db.NhanViens
                        on b.idNhanVien equals nv.id
                        where b.is_deleted == 0
                        select new
                        {
                            b.id,
							MaLichLam =  b.MaLichLam,
                            NgayLam = b.NgayLam,
                            TenNhanVien = nv.TenNhanVien,
                            TenCaLam = b.idCaLam,
                        });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

		// ThemLichLam()
		public bool ThemLichLam(DTO_LichLam lichLam)
		{
			try
			{
				// Check mã lịch làm có != null hay không?
				if (lichLam != null)
				{
					// Check có lịch làm trong DB LichLam hay chưa?
					var query2 = da.Db.LichLams.OrderByDescending(l => l.id).FirstOrDefault();

					da.Db.LichLams.InsertOnSubmit(new LichLam {
						MaLichLam = query2.id < 10 ? "LL0" + (query2.id + 1) : "LL" + (query2.id + 1),
						NgayLam = lichLam.NgayLam,
						idNhanVien = lichLam.IdNhanVien,
						idCaLam = lichLam.IdCaLam,
						created_at = DateTime.Now,
						created_by = 0,
						updated_at = DateTime.Now,
						updated_by = 0,
						is_deleted = 0
					});


					da.Db.SubmitChanges(); // Xác nhận thay đổi DB LichLam

					// Thông báo
					MessageBox.Show($"Thêm lịch làm +{lichLam.MaLichLam}+ thành công!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					return true;
				}
				else
				{
					// Thông báo
					MessageBox.Show($"lịch làm +{lichLam.MaLichLam}+ đã có trong danh sách khách hàng!", "Thông báo",
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

		// XoaLichLam()
		public void XoaLichLam(int id)
		{
			try
			{
				try
				{
					//tìm lịch làm
					var data = da.Db.LichLams.FirstOrDefault(dt => dt.id == id && dt.is_deleted == 0);
					data.is_deleted = 1;
					da.Db.LichLams.DeleteOnSubmit(data);
					da.Db.SubmitChanges();
				}
				catch (Exception ex)
				{
					throw new Exception("Có lỗi xảy ra: " + ex.Message);
				}
			}
			catch (Exception ex)
			{
				// Throw Exception
				MessageBox.Show(ex.Message);
				throw;
			}
		}

		// SuaLichLam()
		public bool SuaLichLam(DTO_LichLam lichLam)
		{
			try
			{
				//kiểm tra mã lịch làm có tồn tại chưa
				var ll = da.Db.LichLams.FirstOrDefault(dt => dt.id == lichLam.Id);
				if (ll != null)
				{
					ll.MaLichLam = lichLam.MaLichLam;
					ll.NgayLam = lichLam.NgayLam;
					ll.idNhanVien = lichLam.IdNhanVien;
					ll.idCaLam = lichLam.IdCaLam;
					ll.updated_at = DateTime.Now;
					ll.updated_by = 0;
					da.Db.SubmitChanges();

					// Thông báo
					MessageBox.Show($"Sửa thông tin lịch làm +{lichLam.MaLichLam}+ thành công!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					return true;
				}
				else
				{
					// Thông báo
					MessageBox.Show("Mã lịch làm không hợp lệ!", "Thông báo",
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

        //Tìm kiếm theo tên
        public IQueryable timkiemTheoTen(string ten)
        {
            return from b in da.Db.LichLams
                   join nv in da.Db.NhanViens
                   on b.idNhanVien equals nv.id
                   where nv.TenNhanVien.Contains(ten) // Điều kiện tìm kiếm theo tên
                   select new
				   {
					   id = b.id,
                       MaLichLam = b.MaLichLam,
                       NgayLam = b.NgayLam,
                       TenNhanVien = nv.TenNhanVien,
                       TenCaLam = b.idCaLam,
				   }; // Trả về đối tượng LichLam
        }


        //Tìm kiếm theo số điện thoại
        public IQueryable timkiemTheoNgay(DateTime ngay)
        {
			return from b in da.Db.LichLams
                   join nv in da.Db.NhanViens
                   on b.idNhanVien equals nv.id
                   where b.NgayLam.Value.Date == ngay.Date
                   select new
				   {
					   id = b.id,
					   MaLichLam = b.MaLichLam,
					   NgayLam = b.NgayLam,
					   TenNhanVien = nv.TenNhanVien,
					   TenCaLam = b.idCaLam,
				   };
        }

		public void DellLL(int id)
		{
            try
            {
                // Initialize Variables
                //string nameCL = string.Empty;

                // Checked id lnv saved in db lnv?
                var query = (from lnv in da.Db.LichLams
                             where lnv.id == id
                             select lnv).Count();

                if (query == 1)
                {
                    // Init LoaiNhanVien
                    LichLam lnv_update = da.Db.LichLams.Single(lnv => lnv.id == id);

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
