/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 05/05/2024
* frmFlashForm.cs
*/
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmFlash : Form
    {
        public frmFlash()
        {
            InitializeComponent();
        }

        // frmFlashForm_Load
        private void frmFlashForm_Load(object sender, EventArgs e)
        {
        }

        // timer1_Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            timer1.Enabled = false;
        }
    }
}
