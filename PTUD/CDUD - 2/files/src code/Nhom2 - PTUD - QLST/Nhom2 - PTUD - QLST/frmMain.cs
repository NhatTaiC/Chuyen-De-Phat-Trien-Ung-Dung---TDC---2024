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

        public frmMain(string taiKhoan, int quyen)
        {
            this.tk = taiKhoan;
            this.q = quyen;
            InitializeComponent();
        }

        // frmMain_FormClosing
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

        // thoátToolStripMenuItem_Click
        private void thoátToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // Thoát app
            Application.Exit();
        }

        // frmMain_Load
        private void frmMain_Load(object sender, System.EventArgs e)
        {
            gunaLabelWelcome.Text = $"Xin chào {tk}!";
        }
    }
}
