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

		// ThemKH()
		public bool ThemKH(DTO_KhachHang khachHang)
		{
			try
			{
				// Check khachHang.MaKH có != null hay không?
				if (khachHang.MaKhachHang != string.Empty)
				{
					// Check có KH trong DB KH hay chưa?
					var data = da.Db.KhachHangs.FirstOrDefault(dt => dt.MaKhachHang == khachHang.MaKhachHang && dt.is_deleted == 0);

					if (data == null)
					{
						// Tạo đối tượng KH
						KhachHang kh_insert = new KhachHang
						{
							MaKhachHang = khachHang.MaKhachHang,
							TenKhachHang = khachHang.TenKhachHang,
							SoDienThoai = khachHang.SoDienThoai,
							Diem = khachHang.Diem,
							created_at = DateTime.Now,
							created_by = 0,
							updated_at = DateTime.Now,
							updated_by = 0,
							is_deleted = 0
						};

						da.Db.KhachHangs.InsertOnSubmit(kh_insert); // Them KH mới vào DB KH
						da.Db.SubmitChanges(); // Xác nhận thay đổi DB KH

						// Thông báo
						MessageBox.Show($"Thêm khách hàng +{khachHang.MaKhachHang}+ thành công!", "Thông báo",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						return true;
					}
					else
					{
						// Thông báo
						MessageBox.Show($"khách hàng +{khachHang.MaKhachHang}+ đã có trong danh sách khách hàng!", "Thông báo",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
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
					MessageBox.Show($"Sửa thông tin khách hàng +{kh.MaKhachHang}+ thành công!", "Thông báo",
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
	}
}
