using BUS;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            if (bus_tk.CheckTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                MessageBox.Show("Dang nhap thanh cong!");
            }
            else
            {
                MessageBox.Show("Wrong!");

            }
        }
    }
}
