using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
	public class DAL_ChiTietPhieuNhap
	{
		// Fields
		private DatabaseAccess da = new DatabaseAccess();

		public DatabaseAccess Da { get => da; set => da = value; }

		// Methods
		// LayDSCaLam()
		public IQueryable LayDSChiTietPhieuNhap()
		{
			IQueryable temp = from cl in da.Db.ChiTietPhieuNhaps
							  select new
							  {
								  id = cl.id,
								  SoLuong = cl.SoLuong,
								  DonGia = cl.DonGia,
								  idPhieuNhap = cl.idPhieuNhap,
								  idSanPham = cl.idSanPham,
							  };
			return temp;
		}

		// ThemCaLam()
		public bool ThemCTPN(DTO_ChiTietPhieuNhap ctpn)
		{
			try
			{
				// Check khachHang.MaKH có != null hay không?
				
					//Check có KH trong DB KH hay chưa?
					var data = da.Db.ChiTietPhieuNhaps.FirstOrDefault(dt => dt.id == ctpn.Id && dt.is_deleted == 0);

					if (data == null)
					{
						// Tạo đối tượng KH
						ChiTietPhieuNhap ctpn_insert = new ChiTietPhieuNhap
						{
							SoLuong = ctpn.SoLuong,
							DonGia = ctpn.DonGia,
							idPhieuNhap = ctpn.IdPhieuNhap,
							idSanPham = ctpn.IdSanPham,
							created_at = DateTime.Now,
							created_by = 0,
							updated_at = DateTime.Now,
							updated_by = 0,
							is_deleted = 0
						};

						da.Db.ChiTietPhieuNhaps.InsertOnSubmit(ctpn_insert); // Them KH mới vào DB KH
						da.Db.SubmitChanges(); // Xác nhận thay đổi DB KH

						// Thông báo
						MessageBox.Show($"thêm sản phẩm +{ctpn.IdSanPham}+ thành công!", "Thông báo",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						return true;
					}
					else
					{
						// Thông báo
						MessageBox.Show($"Sản phẩm +{ctpn.IdSanPham}+ đã có trong danh sách chi tiết!", "Thông báo",
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

		// XoaCaLam()
		public void XoaChiTietPhieuNhap(int id)
		{
			try
			{
				//tìm loại hàng xóa
				var data = da.Db.ChiTietPhieuNhaps.FirstOrDefault(dt => dt.id == id && dt.is_deleted == 0);
				data.is_deleted = 1;
				da.Db.ChiTietPhieuNhaps.DeleteOnSubmit(data);
				da.Db.SubmitChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Có lỗi xảy ra: " + ex.Message);
			}
		}


		// SuaCaLam()
		public bool SuaChiTietPhieuNhap(DTO_ChiTietPhieuNhap ctpn)
		{
			try
			{
				//kiểm tra mã loại hàng có tồn tại chưa
				var kh = da.Db.ChiTietPhieuNhaps.FirstOrDefault(dt => dt.id == ctpn.Id);
				if (kh != null)
				{
					kh.SoLuong = ctpn.SoLuong;
					kh.DonGia = ctpn.DonGia;
					kh.idPhieuNhap = ctpn.IdPhieuNhap;
					kh.idSanPham = ctpn.IdSanPham;
					kh.updated_at = DateTime.Now;
					kh.updated_by = 0;
					da.Db.SubmitChanges();

					// Thông báo
					MessageBox.Show($"Sửa thông tin sản phẩm +{ctpn.IdSanPham}+ thành công!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					return true;
				}
				else
				{
					// Thông báo
					MessageBox.Show("Mã chi tiết hợp lệ!", "Thông báo",
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

		public IQueryable LayDSSP()
		{
			IQueryable temp = from ll in da.Db.SanPhams
							  select new
							  {
								  ll.id,
								  ll.TenSanPham,
							  };
			return temp;
		}

		// LayDSNCC_TheoTenNCC()
		public IQueryable LayDSSP(int maSP)
		{
			IQueryable temp = from nc in da.Db.SanPhams
							  where nc.id == maSP
							  select new
							  {
								  id = nc.id,
								  TenSanPham = nc.TenSanPham
							  };
			return temp;
		}

		public string LayDSSP1(int maSP)
		{
			string a = null ;
			IQueryable temp = from nc in da.Db.SanPhams
							  where nc.id == maSP
							  select new
							  {
								  id = nc.id,
								  TenSanPham = nc.TenSanPham,
								  a = nc.TenSanPham
							  };
			return a;
		}
	}
}
