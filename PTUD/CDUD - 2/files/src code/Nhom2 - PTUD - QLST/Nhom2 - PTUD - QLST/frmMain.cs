/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * frmMain.cs
 * 21/10/2024
 */
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

        public frmMain(string taiKhoan, int quyen)
        {
            this.tk = taiKhoan;
            this.q = quyen;
            InitializeComponent();
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
            // Check taikhoan da dc gui qua frmMain chua?
            if (tk != string.Empty)
            {
                this.Text = $"Màn hình chính - Xin chào {tk}!";
            }
            else
            {
                this.Text = $"Màn hình chính";
            }
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
    }
}
