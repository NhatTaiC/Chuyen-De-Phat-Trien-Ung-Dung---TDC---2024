/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * frmLoaiNhanVien.cs
 * 21/10/2024
 */
using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmLoaiNhanVien : Form
    {
        public frmLoaiNhanVien()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_LoaiNhanVien bus_lnv = new BUS_LoaiNhanVien();

        public void LoadData()
        {
            // Others
            txtMaLNV.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // dgvLNV
            dgvLNV.DataSource = bus_lnv.GetListLNV();
            dgvLNV.Columns["id"].Visible = false;
            dgvLNV.Columns["Id"].HeaderText = "Id";
            dgvLNV.Columns["MaLoaiNhanVien"].HeaderText = "Mã loại nhân viên";
            dgvLNV.Columns["TenLoaiNhanVien"].HeaderText = "Tên loại nhân viên";
        }

        public void Reset()
        {
            txtMaLNV.Clear();
            txtTenLoaiNhanVien.Text = string.Empty;

            LoadData();
        }

        public bool CheckData(string maLNV, string tenLNV)
        {
            // Initialize Variables
            int count = 0;

            // Checked maLNV
            if (CheckString(maLNV, 30))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Mã loại nhân viên: [{maLNV}] không quá 30 kí tự!",
                   "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }

            // Checked tenLNV
            if (CheckString(tenLNV, 100))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Tên loại nhân viên: [{tenLNV}] không quá 100 kí tự!",
                   "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }

            if (count == 2)
            {
                return true;
            }
            return false;
        }

        public bool CheckString(string name, int strlength)
        {
            if (name != string.Empty && name.Length <= strlength)
            {
                return true;
            }
            return false;
        }

        private void frmLoaiNhanVien_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void frmLoaiNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form không?", "Thông báo",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Warning);

            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, System.EventArgs e)
        {
            Reset();
        }

        private void dgvLNV_Click(object sender, System.EventArgs e)
        {
            if (dgvLNV.CurrentCell != null)
            {
                // Get row index selected
                int n = dgvLNV.CurrentCell.RowIndex;

                // Other
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                txtMaLNV.Text = dgvLNV.Rows[n].Cells[1].Value.ToString();
                txtTenLoaiNhanVien.Text = dgvLNV.Rows[n].Cells[2].Value.ToString();
            }
            else
            {
                // Messaged
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (CheckData(txtMaLNV.Text, txtTenLoaiNhanVien.Text))
                {
                    bus_lnv.AddLNV(new DTO_LoaiNhanVien(txtMaLNV.Text, txtTenLoaiNhanVien.Text));

                    Reset();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize Variables
                int currentId = int.Parse(dgvLNV.CurrentRow.Cells[0].Value.ToString());

                if (CheckData(txtMaLNV.Text, txtTenLoaiNhanVien.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: [{txtTenLoaiNhanVien.Text}] không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_lnv.DelLNV(currentId);

                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!", "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize Variables
                int currentId = int.Parse(dgvLNV.CurrentRow.Cells[0].Value.ToString());

                if (CheckData(txtMaLNV.Text, txtTenLoaiNhanVien.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn sửa thông tin: [{txtTenLoaiNhanVien.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_lnv.UpdateLNV(new DTO_LoaiNhanVien(currentId, txtMaLNV.Text, txtTenLoaiNhanVien.Text));

                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
