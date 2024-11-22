/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * frmTraCuuNV.cs
 * 09/11/2024
 */
using BUS;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST.NhatTai
{
    public partial class frmTraCuuNV : Form
    {
        public frmTraCuuNV()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_NhanVien bus_nv = new BUS_NhanVien();

        public void LoadData()
        {
            // dgvTim
            dgvTim.DataSource = bus_nv.GetListNV2();
            dgvTim.Columns[0].HeaderText = "Id";
            dgvTim.Columns[1].HeaderText = "Mã nhân viên";
            dgvTim.Columns[2].HeaderText = "Tên nhân viên";
            dgvTim.Columns[3].HeaderText = "Số điện thoại";
            dgvTim.Columns[4].HeaderText = "Địa chỉ";
            dgvTim.Columns[0].Visible = false;

            // Others
            txtTim.Text = string.Empty;
            txtTim.Focus();
            cboTim.SelectedIndex = 0;

        }

        public void Reset()
        {
            LoadData();
        }

        private void frmTraCuuNV_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, System.EventArgs e)
        {
            Reset();
        }

        private void frmTraCuuNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form không?", "Thông báo",
             MessageBoxButtons.OKCancel,
             MessageBoxIcon.Warning);

            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void txtTim_TextChanged(object sender, System.EventArgs e)
        {
            if (cboTim.SelectedIndex == 0)
            {
                // dgvTim
                dgvTim.DataSource = bus_nv.SearchNvByMaNV(txtTim.Text);
                dgvTim.Columns[0].HeaderText = "Id";
                dgvTim.Columns[1].HeaderText = "Mã nhân viên";
                dgvTim.Columns[2].HeaderText = "Tên nhân viên";
                dgvTim.Columns[3].HeaderText = "Số điện thoại";
                dgvTim.Columns[4].HeaderText = "Địa chỉ";
                dgvTim.Columns[0].Visible = false;
            }
            else
            {
                // dgvTim
                dgvTim.DataSource = bus_nv.SearchNvBytenNV(txtTim.Text);
                dgvTim.Columns[0].HeaderText = "Id";
                dgvTim.Columns[1].HeaderText = "Mã nhân viên";
                dgvTim.Columns[2].HeaderText = "Tên nhân viên";
                dgvTim.Columns[3].HeaderText = "Số điện thoại";
                dgvTim.Columns[4].HeaderText = "Địa chỉ";
                dgvTim.Columns[0].Visible = false;
            }
        }
    }
}
