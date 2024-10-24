/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 23/10/2024
 * frmGioiThieu.cs
 */
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmGioiThieu : Form
    {
        public frmGioiThieu()
        {
            InitializeComponent();
        }

        // btnThoat_Click
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // frmGioiThieu_FormClosing
        private void frmGioiThieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.No) { e.Cancel = true; }
        }
    }
}
