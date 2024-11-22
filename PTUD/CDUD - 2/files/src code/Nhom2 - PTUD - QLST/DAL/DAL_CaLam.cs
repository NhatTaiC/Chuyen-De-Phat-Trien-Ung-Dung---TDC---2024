using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_CaLam
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();

        public DatabaseAccess Da { get => da; set => da = value; }

        // Methods
        // LayDSCaLam()
        public IQueryable LayDSCaLam()
        {
            IQueryable temp = from cl in da.Db.CaLams
                              where cl.is_deleted == 0
                              select new
                              {
                                  id = cl.id,
                                  MaCaLam = cl.MaCaLam,
                                  TenCaLam = cl.TenCaLam,
                                  GioBatDau = cl.GioBatDau,
                                  GioKetThuc = cl.GioKetThuc
                              };
            return temp;
        }

        // ThemCaLam()
        public bool ThemCaLam(DTO_CaLam caLam)
        {
            try
            {
                // Check macalam có != null hay không?
                if (caLam != null)
                {
                    // Check có calam trong DB CaLam hay chưa?
                    var query2 = da.Db.CaLams.OrderByDescending(l => l.id).FirstOrDefault();

                    da.Db.CaLams.InsertOnSubmit(new CaLam
                    {
                        MaCaLam = query2.id < 10 ? "CL0" + (query2.id + 1) : "CL" + (query2.id + 1),
                        TenCaLam = caLam.TenCaLam,
                        GioBatDau = caLam.GioBatDau,
                        GioKetThuc = caLam.GioKetThuc,
                        created_at = DateTime.Now,
                        created_by = 0,
                        updated_at = DateTime.Now,
                        updated_by = 0,
                        is_deleted = 0
                    });
                    da.Db.SubmitChanges(); // Xác nhận thay đổi DB CaLam

                    // Thông báo
                    MessageBox.Show($"Thêm ca làm +{caLam.MaCaLam}+ thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show($"Ca làm +{caLam.TenCaLam}+ đã có trong danh sách ca làm!", "Thông báo",
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
        public void XoaCaLam(int id)
        {
            try
            {
                //tìm ca làm
                var data = da.Db.CaLams.FirstOrDefault(dt => dt.id == id && dt.is_deleted == 0);
                data.is_deleted = 1;
                da.Db.CaLams.DeleteOnSubmit(data);
                da.Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra: " + ex.Message);
            }
        }


        // SuaCaLam()
        public bool SuaCaLam(DTO_CaLam caLam)
        {
            try
            {
                //kiểm tra mã ca lam có tồn tại chưa
                var kh = da.Db.CaLams.FirstOrDefault(dt => dt.id == caLam.Id);
                if (kh != null)
                {
                    kh.MaCaLam = caLam.MaCaLam;
                    kh.TenCaLam = caLam.TenCaLam;
                    kh.GioBatDau = caLam.GioBatDau;
                    kh.GioKetThuc = caLam.GioKetThuc;
                    kh.updated_at = DateTime.Now;
                    kh.updated_by = 0;
                    da.Db.SubmitChanges();

                    // Thông báo
                    MessageBox.Show($"Sửa thông tin ca làm {caLam.TenCaLam} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Mã ca làm không hợp lệ!", "Thông báo",
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

        public void XoaCL(int id)
        {
            try
            {
                // Initialize Variables
                string nameCL = string.Empty;

                // Checked id lnv saved in db lnv?
                var query = (from lnv in da.Db.CaLams
                             where lnv.id == id
                             select lnv).Count();

                if (query == 1)
                {
                    // Init LoaiNhanVien
                    CaLam lnv_update = da.Db.CaLams.Single(lnv => lnv.id == id);

                    // Updated is_deleted = 1 for loainhanvien -> hidden item (avoid conflict FK)
                    lnv_update.is_deleted = 1;
                    lnv_update.created_by = 0;
                    lnv_update.created_at = DateTime.Now;
                    lnv_update.updated_by = 0;
                    lnv_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameCL = lnv_update.TenCaLam;

                    // Messaged
                    MessageBox.Show($"Xóa ca làm: [{nameCL}] thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show($"Xóa ca làm: [{nameCL}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
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
