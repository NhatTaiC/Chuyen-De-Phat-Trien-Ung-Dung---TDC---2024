using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBangLuong : Form
    {
        //bus bang lương
        BUS_BangLuong bus_bangluong = new BUS_BangLuong();
        //bus chi tiết bảng lương
        BUS_ChiTietBangLuong bus_chitietbangluong = new BUS_ChiTietBangLuong();
        //bus NhanVien
        //id bang lương đang chọn
        int currentIDBangLuong = 0;
        //check them
        bool checkbtn;

        public frmBangLuong()
        {
            InitializeComponent();

        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            //Tải dữ liệu bang lương
            LoadDSBangLuong();
            //tải dữ liệu chi tiết bảng lương
            LoadDSChiTietBangLuong();
            //load combobox
            LoadCbNhanVien();
            //btn luu
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //cb lich lam
            LoadCBLichLam();

        }
        //load cb lich làm
        private void LoadCBLichLam()
        {
            cbLichLam.DataSource = bus_chitietbangluong.LayDSLichLam();
            cbLichLam.DisplayMember = "MaLichLam";
            cbLichLam.ValueMember = "id";
        }
        //lay danh sách bảng lương ko có điều kiện
        private void LoadDSBangLuong()
        {
            //lay danh sách bảng lương ko có điều kiện
            dgvBangLuong.DataSource = bus_bangluong.LayDSBangLuong();
            //dổi tên cột
            dgvBangLuong.Columns["id"].HeaderText = "Mã bảng lương";
            dgvBangLuong.Columns["TongGioCong"].HeaderText = "Tổng giờ công";
            dgvBangLuong.Columns["Luong"].HeaderText = "Lương";
            dgvBangLuong.Columns["ThangNam"].HeaderText = "Tháng/Năm";
            //format
            dgvBangLuong.Columns["ThangNam"].DefaultCellStyle.Format = "MM/yyyy";
            //ẩn cột
            dgvBangLuong.Columns["id"].Visible = false;

        }
        //lay danh sách bảng lương có điều kiện
        private void LoadDSBangLuong(int idNhanVien)
        {
            dgvBangLuong.DataSource = bus_bangluong.LayDSBangLuong(idNhanVien);
            //dổi tên cột
            dgvBangLuong.Columns["id"].HeaderText = "Mã bảng lương";
            dgvBangLuong.Columns["TongGioCong"].HeaderText = "Tổng giờ công";
            dgvBangLuong.Columns["Luong"].HeaderText = "Lương";
            dgvBangLuong.Columns["ThangNam"].HeaderText = "Tháng/Năm";
            //format
            dgvBangLuong.Columns["ThangNam"].DefaultCellStyle.Format = "MM/yyyy";
            //dgvBangLuong.Columns["id"].Visible = false;
            //ẩn cột

        }
        //lay danh sách chi tiết bảng lương ko có điều kiện
        private void LoadDSChiTietBangLuong()
        {
            dgvChiTietBangLuong.DataSource = bus_chitietbangluong.LayDSCTBangLuong();
            //dổi tên cột
            dgvChiTietBangLuong.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvChiTietBangLuong.Columns["NgayLam"].HeaderText = "Ngày làm";
            dgvChiTietBangLuong.Columns["SoGioCongThucTe"].HeaderText = "Giờ công thực tế";
            //format
            dgvChiTietBangLuong.Columns["NgayLam"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dgvBangLuong.Columns["ThangNam"].DefaultCellStyle.Format = "MM/yyyy";
            //ẩn cột
            dgvChiTietBangLuong.Columns["id"].Visible = false;
            dgvChiTietBangLuong.Columns["idBangLuong"].Visible = false;
        }
        //lay danh sách chi tiết bảng lương có điều kiện
        private void LoadDSChiTietBangLuong(int idBangLuong)
        {
            dgvChiTietBangLuong.DataSource = bus_chitietbangluong.LayDSCTBangLuong(idBangLuong);
            //dổi tên cột
            dgvChiTietBangLuong.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvChiTietBangLuong.Columns["NgayLam"].HeaderText = "Ngày làm";
            dgvChiTietBangLuong.Columns["SoGioCongThucTe"].HeaderText = "Giờ công thực tế";
            //format
            dgvChiTietBangLuong.Columns["NgayLam"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dgvBangLuong.Columns["ThangNam"].DefaultCellStyle.Format = "MM/yyyy";
            //ẩn cột
            dgvChiTietBangLuong.Columns["id"].Visible = false;
            dgvChiTietBangLuong.Columns["idBangLuong"].Visible = false;
        }
        private void LamMoi()
        {
            //load danh sách bảng lương k điều kiện
            LoadDSBangLuong();
            //load danh sách bảng lương k điều kiện
            LoadDSChiTietBangLuong();
            //resrt check box
            cbLoc.Checked = false;
            //btn luu
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //btn thêm, thêm chi tiết
            btnThem.Enabled = true;
            btnThemChiTiet.Enabled = true;
            //txt
            txtGioCong.Enabled = true;
            txtLuong.Enabled = true;
            cbLichLam.Enabled = true;
            cbNhanVien.Enabled = true;
            txtMaPhieuNhap.ReadOnly = false;

        }

        private void dgvBangLuong_Click(object sender, EventArgs e)
        {

            if (dgvBangLuong.Rows.Count > 0)
            {
                //lấy dòng đang click
                int dong = dgvBangLuong.CurrentRow.Index;
                //điền thông tin lên textbox
                txtLuong.Text = dgvBangLuong.Rows[dong].Cells["Luong"].Value.ToString();
                //txtTenChiNhanh.Text = dgvChiNhanh.Rows[dong].Cells["TenChiNhanh"].Value.ToString();
                //txtDiaChi.Text = dgvChiNhanh.Rows[dong].Cells["DiaChi"].Value.ToString();
                //txtSoDienThoai.Text = dgvChiNhanh.Rows[dong].Cells["SoDienThoai"].Value.ToString();
                //gán id cho currnentID
                currentIDBangLuong = int.Parse(dgvBangLuong.Rows[dong].Cells["id"].Value.ToString());
                //load danh sách chi tiet bang lương có điều kiện
                LoadDSChiTietBangLuong(currentIDBangLuong);
                txtMaPhieuNhap.Text = dgvBangLuong.Rows[dong].Cells["MaBangLuong"].Value.ToString();
            }





        }
        private void LoadCbNhanVien()
        {
            //cb nhan vien
            cbNhanVien.DataSource = bus_bangluong.DSNhanVien();
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "id";
            //cb loc
            cbLocBangLuong.DataSource = bus_bangluong.DSNhanVien();
            cbLocBangLuong.DisplayMember = "TenNhanVien";
            cbLocBangLuong.ValueMember = "id";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //hàm làm mới
            LamMoi();
        }

        private void cbLocBangLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoc.Checked)
            {
                //load danh sách bảng lương có điều kiện
                LoadDSBangLuong(int.Parse(cbLocBangLuong.SelectedValue.ToString()));
            }

        }

        private void cbLoc_CheckedChanged(object sender, EventArgs e)
        {
            //load danh sách bảng lương có điều kiện
            LoadDSBangLuong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGioCong.Enabled = false;
            txtLuong.Enabled = false;
            cbLichLam.Enabled = false;
            cbNhanVien.Enabled = false;
            btnThemChiTiet.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            checkbtn = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //thêm bảng lương
                if (checkbtn)
                {
                    if (txtMaPhieuNhap.Text.Length > 0)
                    {
                        bus_bangluong.ThemBangLuong(new DTO_BangLuong(txtMaPhieuNhap.Text, dtNgayNhap.Value, 0, 0));
                        MessageBox.Show("Thêm thành công!!");
                        LamMoi();
                    }
                    else
                    {
                        //thông báo khi chưa đầy đủ dữ liệu
                        MessageBox.Show("Chưa nhập dữ liệu!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                //thêm chi tiết
                else
                {
                    if (txtMaPhieuNhap.Text.Length > 0 && txtGioCong.Text.Length > 0)
                    {
                        bus_chitietbangluong.ThemChiTietbangLuong(new DTO_ChiTietBangLuong(float.Parse(txtGioCong.Text), currentIDBangLuong, int.Parse(cbLichLam.SelectedValue.ToString()), int.Parse(cbNhanVien.SelectedValue.ToString()), dtNgayNhap.Value));
                        MessageBox.Show("Thêm thành công!!");
                        LamMoi();
                    }
                    else
                    {
                        //thông báo khi chưa đầy đủ dữ liệu
                        MessageBox.Show("Chưa nhập dữ liệu!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            checkbtn = false;
            txtMaPhieuNhap.ReadOnly = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void txtGioCong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Back && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                txtGioCong.Focus();
            }
        }
    }
}
