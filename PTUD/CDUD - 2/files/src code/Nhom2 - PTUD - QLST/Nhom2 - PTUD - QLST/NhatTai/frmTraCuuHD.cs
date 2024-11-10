/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * frmTraCuuHD.cs
 * 09/11/2024
 */
using BUS;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST.NhatTai
{
    public partial class frmTraCuuHD : Form
    {
        public frmTraCuuHD()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_HoaDon bus_hd = new BUS_HoaDon();
        DataValidation dv = new DataValidation();

        public void LoadData()
        {
            // dgvTim
            dgvTim.DataSource = bus_hd.GetListHD3();
            dgvTim.Columns[0].HeaderText = "Id";
            dgvTim.Columns[1].HeaderText = "Mã hóa đơn";
            dgvTim.Columns[2].HeaderText = "Ngày lập hóa đơn";
            dgvTim.Columns[3].HeaderText = "Giờ lập hóa đơn";
            dgvTim.Columns[4].HeaderText = "Tổng tiền";
            dgvTim.Columns[5].HeaderText = "Thành tiền";
            dgvTim.Columns[0].Visible = false;
            dgvTim.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvTim.Columns[3].DefaultCellStyle.Format = "HH:mm:ss";
            //dgvTim.Columns[4].DefaultCellStyle.Format = "#,###";

            // Others
            txtTim.Text = string.Empty;
            txtTim.Focus();
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

        private void dgvTim_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Others
                txtTim.TextChanged -= txtTim_TextChanged;

                if (dgvTim.CurrentCell != null)
                {
                    // Get row index selected
                    int n = dgvTim.CurrentCell.RowIndex;

                    txtTim.Text = dgvTim.Rows[n].Cells[1].Value.ToString();
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            finally
            {
                // Others
                txtTim.TextChanged += txtTim_TextChanged;
            }
        }

        private void btnIn_Click(object sender, System.EventArgs e)
        {
            if (dv.IsValidString2(txtTim.Text))
            {
                // Checked hd saved in table HoaDon
                if (bus_hd.CheckHd(txtTim.Text))
                {
                    //MessageBox.Show($"MaHd: {dgvTim.CurrentRow.Cells[1].Value.ToString()}");

                    frmInHD f = new frmInHD(dgvTim.CurrentRow.Cells[1].Value.ToString());
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Mã hóa đơn không có trong dữ liệu, không thể in hóa đơn!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"Vui lòng nhập nội dung tìm kiếm hợp lệ!\n" +
                    $"Không để trống, chỉ chứa chữ và số!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
            }
        }

        private void txtTim_TextChanged(object sender, System.EventArgs e)
        {
            // dgvTim
            dgvTim.DataSource = bus_hd.SearchHdByMaHD(txtTim.Text);
            dgvTim.Columns[0].HeaderText = "Id";
            dgvTim.Columns[1].HeaderText = "Mã hóa đơn";
            dgvTim.Columns[2].HeaderText = "Ngày lập hóa đơn";
            dgvTim.Columns[3].HeaderText = "Giờ lập hóa đơn";
            dgvTim.Columns[4].HeaderText = "Tổng tiền";
            dgvTim.Columns[5].HeaderText = "Thành tiền";
            dgvTim.Columns[0].Visible = false;
            dgvTim.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvTim.Columns[3].DefaultCellStyle.Format = "HH:mm:ss";
        }
    }
}
