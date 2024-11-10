/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * program.cs
 * 21/10/2024
 */
using BUS;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();

        // function LoadData()
        private void LoadData()
        {
            // txtTaiKhoan
            txtTaiKhoan.Focus();
        }

        // frmDangNhap loading
        private void frmDangNhap_Load(object sender, System.EventArgs e)
        {
            // LoadData
            LoadData();
        }

        // btnDangNhap_Click
        private void btnDangNhap_Click(object sender, System.EventArgs e)
        {
            // Initialize Variables
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Verify Account
            if (bus_tk.CheckTaiKhoan(taiKhoan, matKhau))
            {
                int quyen = bus_tk.GetRole(taiKhoan, matKhau);

                // Mở frmMain
                frmMain f = new frmMain(taiKhoan, quyen);
                f.ShowDialog();

                // Đóng frmDangNhap
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // frmDangNhap_FormClosing
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form không?", "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
