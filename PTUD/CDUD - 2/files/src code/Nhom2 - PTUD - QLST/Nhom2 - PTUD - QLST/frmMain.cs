/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * frmMain.cs
 * 21/10/2024
 */
using DTO;
using GUI;
using Nhom2___PTUD___QLST.NhatTai;
using Nhom2___PTUD___QLST.QuocLuong;
using Nhom2___PTUD___QLST.VanToan;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Initialize Variables
        private string tk = string.Empty;
        private int q = 0;
        private Form frmOld = null;
        public static DTO_NhanVien nhanVien = null;

        public DTO_NhanVien NhanVien { get => nhanVien; set => nhanVien = value; }

        public frmMain(string taiKhoan, int quyen, DTO_NhanVien nhanVien)
        {
            this.tk = taiKhoan;
            this.NhanVien = nhanVien;
            this.q = quyen;
            InitializeComponent();
        }
        public static DTO_NhanVien getNhanVien()
        {
            return nhanVien;
        }

        public bool CheckFormExit(string name)
        {

            foreach (Form item in MdiChildren)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }


        public void ActForm(string name)
        {
            foreach (Form item in MdiChildren)
            {
                if (item.Name == name)
                {
                    item.Activate();
                    break;
                }
            }
        }

        public void OpenForm(Form frm)
        {
            if (frmOld != null)
            {
                frm.MdiParent = this;
                frm.ControlBox = false;
                frm.Show();
                frmOld = frm;
                frmOld.Close();
            }
            else
            {
                frm.MdiParent = this;
                frm.ControlBox = false;
                frm.Show();
                frmOld = frm;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form không?", "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // Thoát app
            this.Close();
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            //MessageBox.Show(NhanVien.TenNV);
            // Check taikhoan da dc gui qua frmMain chua?
            if (tk != string.Empty)
            {
                this.Text = $"Màn hình chính - Xin chào {tk}!";
            }
            else
            {
                this.Text = $"Màn hình chính";
            }

            // Others
            logToolStripMenuItem.Enabled = false;
            logToolStripMenuItem.Visible = false;
            logToolStripMenuItem1.Enabled = false;
            logToolStripMenuItem1.Visible = false;
            nhânViênToolStripMenuItem1.Enabled = false;
            nhânViênToolStripMenuItem1.Visible = false;
            //hóaĐơnToolStripMenuItem.Enabled = false;
            //hóaĐơnToolStripMenuItem.Visible = false;
            chiTiếtHóaĐơnToolStripMenuItem.Enabled = false;
            chiTiếtHóaĐơnToolStripMenuItem.Visible = false;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // Đóng frmMain
            this.Close();

            // Mở frmDangNhap
            frmDangNhap f = new frmDangNhap();
            f.Show();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmGioiThieu"))
            {
                // Mở frmFlash
                frmGioiThieu f = new frmGioiThieu();
                f.MdiParent = this;
                f.Show();
                //OpenForm(f);
            }
            else
            {
                ActForm("frmGioiThieu");
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmTaiKhoan"))
            {
                frmTaiKhoan f = new frmTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmTaiKhoan");
            }
        }

        private void loạiNhânViênToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmLoaiNhanVien"))
            {
                frmLoaiNhanVien f = new frmLoaiNhanVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmLoaiNhanVien");
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmNhanVien"))
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmNhanVien");
            }
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmKhuyenMai"))
            {
                frmKhuyenMai f = new frmKhuyenMai();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmKhuyenMai");
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmSanPham"))
            {
                frmSanPham f = new frmSanPham();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmSanPham");
            }
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmLoaiHang"))
            {
                frmLoaiHang f = new frmLoaiHang();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmLoaiHang");
            }
        }

        private void bảngLươngToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmBangLuong"))
            {
                frmBangLuong f = new frmBangLuong();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmBangLuong");
            }
        }

        private void chiNhánhToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmChiNhanh"))
            {
                frmChiNhanh f = new frmChiNhanh();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmChiNhanh");
            }
        }

        private void khoHàngToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmKhoHang"))
            {
                frmKhoHang f = new frmKhoHang();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmKhoHang");
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmNhaCungCap"))
            {
                frmNhaCungCap f = new frmNhaCungCap();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmNhaCungCap");
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmKhachHang"))
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmKhachHang");
            }
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmPhieuNhap"))
            {
                frmPhieuNhap f = new frmPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmPhieuNhap");
            }
        }

        private void chiTiếtPhiếuNhậpToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmChiTietPhieuNhap"))
            {
                frmChiTietPhieuNhap f = new frmChiTietPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmChiTietPhieuNhap");
            }
        }

        private void caLàmToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmCaLam"))
            {
                frmCaLam f = new frmCaLam();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmCaLam");
            }
        }

        private void lịchLàmToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmLichLam"))
            {
                frmLichLam f = new frmLichLam();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmLichLam");
            }
        }

        private void logToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmLog"))
            {
                frmLog f = new frmLog();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmLog");
            }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmHoaDon"))
            {
                frmHoaDon f = new frmHoaDon();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmHoaDon");
            }
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmChiTietHoaDon"))
            {
                frmChiTietHoaDon f = new frmChiTietHoaDon();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmChiTietHoaDon");
            }
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmTraCuuNV"))
            {
                frmTraCuuNV f = new frmTraCuuNV();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmTraCuuNV");
            }
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmTraCuuHD"))
            {
                frmTraCuuHD f = new frmTraCuuHD();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmTraCuuHD");
            }
        }

        private void bánHàngToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmBanHang"))
            {
                frmBanHang f = new frmBanHang();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmBanHang");
            }
        }

        private void hóaĐơnChiTiếtToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmHoaDonChiTiet"))
            {
                frmHoaDonChiTiet f = new frmHoaDonChiTiet();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmHoaDonChiTiet");
            }
        }

        private void doanhThuTheoThángToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frmBaoCaoDoanhthuTheoThang"))
            {
                frmBaoCaoDoanhthuTheoThang f = new frmBaoCaoDoanhthuTheoThang();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frmBaoCaoDoanhthuTheoThang");
            }
        }

        private void doanhThuTheoNămToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (!CheckFormExit("frm_DoanhThuTheoNam"))
            {
                frm_DoanhThuTheoNam f = new frm_DoanhThuTheoNam();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                ActForm("frm_DoanhThuTheoNam");
            }
        }
    }
}
