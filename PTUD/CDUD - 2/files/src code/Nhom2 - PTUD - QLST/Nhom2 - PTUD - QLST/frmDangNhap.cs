/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * program.cs
 * 21/10/2024
 */
using BUS;
using DTO;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmDangNhap : Form
    {
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        DTO_NhanVien nvLogin;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        //public static DTO_NhanVien getNhanVien()
        //{
        //    return bus_NhanVien.getNhanVien();
        //}
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
                try
                {
                    //this.FormClosing -= frmDangNhap_FormClosing;
                    int quyen = bus_tk.GetRole(taiKhoan, matKhau);
                    int Idtk = bus_TaiKhoan.getIdTaiKhoan(taiKhoan, matKhau);
                    nvLogin = bus_NhanVien.getNhanVien(Idtk);
                    // Đóng frmDangNhap
                    this.Close();
                    // Mở frmMain //Truyen nhan vien  
                    frmMain f = new frmMain(taiKhoan, quyen, nvLogin);
                    f.ShowDialog();
                }
                finally
                {
                    //this.FormClosing += FrmDangNhap_FormClosing;
                }
                
              
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        // frmDangNhap_FormClosing
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form không?", "Thông báo",
            //    MessageBoxButtons.OKCancel,
            //    MessageBoxIcon.Warning);

            //if (dr == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
