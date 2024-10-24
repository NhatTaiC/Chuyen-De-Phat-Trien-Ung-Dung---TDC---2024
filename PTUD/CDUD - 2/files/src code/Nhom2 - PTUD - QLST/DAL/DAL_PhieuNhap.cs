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
				if (pn.MaPhieuNhap != string.Empty)
				{
					// Check có KH trong DB KH hay chưa?
					var data = da.Db.PhieuNhaps.FirstOrDefault(dt => dt.MaPhieuNhap == pn.MaPhieuNhap && dt.is_deleted == 0);

					if (data == null)
					{
						// Tạo đối tượng KH
						PhieuNhap pn_insert = new PhieuNhap
						{
							MaPhieuNhap = pn.MaPhieuNhap,
							NgayNhap = pn.NgayNhap,
							ThanhTien = pn.ThanhTien,
							idNhanVien = pn.IdNhanVien,
							created_at = DateTime.Now,
							created_by = 0,
							updated_at = DateTime.Now,
							updated_by = 0,
							is_deleted = 0
						};

						da.Db.PhieuNhaps.InsertOnSubmit(pn_insert); // Them KH mới vào DB KH
						da.Db.SubmitChanges(); // Xác nhận thay đổi DB KH

						// Thông báo
						MessageBox.Show($"Thêm ca làm +{pn.MaPhieuNhap}+ thành công!", "Thông báo",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						return true;
					}
					else
					{
						// Thông báo
						MessageBox.Show($"khách hàng +{pn.MaPhieuNhap}+ đã có trong danh sách khách hàng!", "Thông báo",
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
					pnn.MaPhieuNhap = pn.MaPhieuNhap;
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
	}
}

