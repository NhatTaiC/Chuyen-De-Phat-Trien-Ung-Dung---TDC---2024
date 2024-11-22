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
							  join pn in da.Db.PhieuNhaps
							  on cl.idPhieuNhap equals pn.id
							  join sp in da.Db.SanPhams
							  on cl.idSanPham equals sp.id
							  where cl.is_deleted == 0
							  select new
							  {
								  id = cl.id,
								  SoLuong = cl.SoLuong,
								  DonGia = cl.DonGia,
								  idPhieuNhap = pn.MaPhieuNhap,
								  idSanPham = sp.TenSanPham,
								  idpn = cl.idPhieuNhap,
								  idsp = cl.idSanPham
							  };
			return temp;
		}

		// ThemCaLam()
		public void ThemCTPN(DTO_ChiTietPhieuNhap ctpn)
		{
			try
            {
                // Checked chiTietHoaDon is saved in table ChiTietHoaDon?
                var query = (from cthd in da.Db.ChiTietPhieuNhaps
                             where cthd.idPhieuNhap == ctpn.IdPhieuNhap &&
                             cthd.idSanPham == ctpn.IdSanPham
                             select cthd).FirstOrDefault();


                if (query == null)
                {
                    // Added new record ChiTietHoaDon
                    da.Db.ChiTietPhieuNhaps.InsertOnSubmit(new ChiTietPhieuNhap
                    {
                        SoLuong = ctpn.SoLuong,
						DonGia = ctpn.DonGia,
                        idPhieuNhap = ctpn.IdPhieuNhap,
                        idSanPham = ctpn.IdSanPham,
                        is_deleted = 0,
                        created_by = 0,
                        created_at = DateTime.Now,
                        updated_by = 0,
                        updated_at = DateTime.Now
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm chi tiết hoá đơn mới thành công!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Đã có dữ liệu sản phẩm (ẩn) trong chi tiết hóa đơn mới.", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
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

        public void DellPN(int idChiTietPhieuNhap)
        {
            var chiTiet = da.Db.ChiTietPhieuNhaps.SingleOrDefault(ct => ct.id == idChiTietPhieuNhap);

            if (chiTiet != null)
            {
                // Lấy phiếu nhập liên quan
                var phieuNhap = da.Db.PhieuNhaps.SingleOrDefault(pn => pn.id == chiTiet.idPhieuNhap);

                if (phieuNhap != null)
                {
                    // Trừ tổng tiền trong phiếu nhập
                    phieuNhap.ThanhTien -= chiTiet.SoLuong * chiTiet.DonGia;
                }

                // Xóa chi tiết phiếu nhập
                da.Db.ChiTietPhieuNhaps.DeleteOnSubmit(chiTiet);
                da.Db.SubmitChanges();
            }
            else
            {
                throw new Exception("Không tìm thấy bản ghi cần xóa.");
            }
        }


        public bool CheckCTHDByIdpnIdSp(int idpn, int idsp)
        {
            var query = (from ctpn in da.Db.ChiTietPhieuNhaps
                         where ctpn.idPhieuNhap == idpn
                         && ctpn.idSanPham == idsp
                         && ctpn.is_deleted == 0
                         select ctpn).Count();

            if (query == 1)
            {
                return true;
            }
            return false;
        }

        public int GetSoLuongSpInCTPN(int idpn, int idsp)
        {
            var query = (from ctpn in da.Db.ChiTietPhieuNhaps
                         where ctpn.idPhieuNhap == idpn &&
                         ctpn.idSanPham == idsp &&
                         ctpn.is_deleted == 0
                         select ctpn).FirstOrDefault();

            return (int)query.SoLuong;
        }

        public void UpdateSoLuongSpInCTPN(int soLuong, int idpn, int idsp)
        {
            var ctpn_update = da.Db.ChiTietPhieuNhaps.SingleOrDefault(cthd => cthd.idPhieuNhap == idpn && cthd.idSanPham == idsp && cthd.is_deleted==0);
            
			if(ctpn_update == null)
			{
				MessageBox.Show("rỗng");
			}
			else
			{
                ctpn_update.SoLuong += soLuong;
            }
            // Saved
            da.Db.SubmitChanges();
        }

        public void UpdateThanhTien(int idPhieuNhap, float thanhTienMoi)
        {
            var phieuNhap = da.Db.PhieuNhaps.SingleOrDefault(pn => pn.id == idPhieuNhap && pn.is_deleted == 0);
            if (phieuNhap != null)
            {
                phieuNhap.ThanhTien += thanhTienMoi;

                // Lưu thay đổi vào cơ sở dữ liệu
                da.Db.SubmitChanges();
            }
        }

    }
}
