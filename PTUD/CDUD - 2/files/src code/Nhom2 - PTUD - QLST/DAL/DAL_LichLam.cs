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
			IQueryable temp = from ll in da.Db.LichLams
							  select new
							  {
								  id = ll.id,
								  MaLichLam = ll.MaLichLam,
								  NgayLam = ll.NgayLam,
								  TenNhanVien = ll.idNhanVien,
								  TenCaLam = ll.idCaLam,
							  };
			return temp;
		}

		// ThemLichLam()
		public bool ThemLichLam(DTO_LichLam lichLam)
		{
			try
			{
				// Check mã lịch làm có != null hay không?
				if (lichLam.MaLichLam != string.Empty)
				{
					// Check có lịch làm trong DB LichLam hay chưa?
					var data = da.Db.LichLams.FirstOrDefault(dt => dt.MaLichLam == lichLam.MaLichLam && dt.is_deleted == 0);

					if (data == null)
					{
						// Tạo đối tượng ll
						LichLam ll_insert = new LichLam
						{
							MaLichLam = lichLam.MaLichLam,
							NgayLam = lichLam.NgayLam,
							idNhanVien = lichLam.IdNhanVien,
							idCaLam = lichLam.IdCaLam,
							created_at = DateTime.Now,
							created_by = 0,
							updated_at = DateTime.Now,
							updated_by = 0,
							is_deleted = 0
						};

						da.Db.LichLams.InsertOnSubmit(ll_insert); // Them ll mới vào DB LichLam
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
	}
}
