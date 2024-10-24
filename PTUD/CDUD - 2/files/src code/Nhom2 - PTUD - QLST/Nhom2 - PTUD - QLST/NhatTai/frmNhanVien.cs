/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * program.cs
 * 21/10/2024
 */
using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        BUS_LoaiNhanVien bus_lnv = new BUS_LoaiNhanVien();
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();

        public void LoadData()
        {
            // Others
            txtMaNhanVien.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // dgvNV
            dgvNV.DataSource = bus_nv.GetListNV();
            dgvNV.Columns["id"].Visible = false;
            //dgvNV.Columns["idLoaiNhanVien"].Visible = false;
            //dgvNV.Columns["idTaiKhoan"].Visible = false;
            dgvNV.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dgvNV.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvNV.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvNV.Columns["DiaChi"].HeaderText = "Địa chỉ";

            // cboMaLoaiNhanVien
            cboMaLoaiNhanVien.DataSource = bus_lnv.GetListAllLNVByTen();
            cboMaLoaiNhanVien.DisplayMember = "TenLoaiNhanVien";
            cboMaLoaiNhanVien.ValueMember = "Id";
            cboMaLoaiNhanVien.SelectedIndex = 0;

            // cboMaTaiKhoan
            cboMaTaiKhoan.DataSource = bus_tk.GetListAllTKByTenTK();
            cboMaTaiKhoan.DisplayMember = "TenTaiKhoan";
            cboMaTaiKhoan.ValueMember = "Id";
            cboMaTaiKhoan.SelectedIndex = 0;
        }

        public void Reset()
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();

            LoadData();
        }

        public bool CheckData(string maNhanVien, string tenNhanVien, string soDT, string diaChi)
        {
            // Initialize Variables
            int count = 0;

            // Checked maNhanVien
            if (CheckString(maNhanVien, 30))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Mã nhân viên: [{maNhanVien}] không quá 30 kí tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked tenNhanVien
            if (CheckString(tenNhanVien, 100))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Tên nhân viên: [{tenNhanVien}] không quá 100 kí tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked soDT
            if (CheckNumber(soDT))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Số điện thoại: [{soDT}] không quá 20 kí tự và phải nhập số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked diaChi
            if (CheckString(diaChi, 100))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Địa chỉ: [{diaChi}] không quá 100 kí tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (count == 4)
            {
                return true;
            }
            return false;
        }

        public bool CheckNumber(string name)
        {
            if (name == null)
            {
                return false;
            }

            if (name.Length > 20)
            {
                return false;
            }

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'a' && name[i] <= 'z' || name[i] >= 'A' && name[i] <= 'Z')
                {
                    return false;
                }
            }

            return true;
        }

        public bool CheckString(string name, int strlength)
        {
            if (name != string.Empty && name.Length <= strlength)
            {
                return true;
            }
            return false;
        }

        private void frmNhanVien_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvNV_Click(object sender, System.EventArgs e)
        {
            if (dgvNV.CurrentCell != null)
            {
                // Others
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                // Get row index selected
                int n = dgvNV.CurrentCell.RowIndex;

                txtMaNhanVien.Text = dgvNV.Rows[n].Cells[1].Value.ToString();
                txtTenNhanVien.Text = dgvNV.Rows[n].Cells[2].Value.ToString();
                txtSoDienThoai.Text = dgvNV.Rows[n].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNV.Rows[n].Cells[4].Value.ToString();

                //MessageBox.Show(dgvNV.Rows[n].Cells[5].Value.ToString());

                // cboMaLoaiNhanVien
                //cboMaLoaiNhanVien.SelectedIndex = int.Parse(dgvNV.Rows[n].Cells[5].Value.ToString());
                int idLoaiNhanVien = int.Parse(dgvNV.Rows[n].Cells[5].Value.ToString());
                cboMaLoaiNhanVien.DataSource = bus_lnv.GetListOneLNVByTen(idLoaiNhanVien);
                cboMaLoaiNhanVien.DisplayMember = "TenLoaiNhanVien";
                cboMaLoaiNhanVien.ValueMember = "Id";

                // cboMaTaiKhoan
                int idMaTaiKhoan = int.Parse(dgvNV.Rows[n].Cells[6].Value.ToString());
                cboMaTaiKhoan.DataSource = bus_tk.GetListOneTKByTenTK(idMaTaiKhoan);
                cboMaTaiKhoan.DisplayMember = "TenTaiKhoan";
                cboMaTaiKhoan.ValueMember = "Id";
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
                if (CheckData(txtMaNhanVien.Text, txtTenNhanVien.Text, txtSoDienThoai.Text, txtDiaChi.Text))
                {
                    bus_nv.AddNV(new DTO_NhanVien(
                    txtMaNhanVien.Text,
                    txtTenNhanVien.Text,
                    txtSoDienThoai.Text,
                    txtDiaChi.Text,
                    int.Parse(cboMaLoaiNhanVien.SelectedValue.ToString()),
                    int.Parse(cboMaTaiKhoan.SelectedValue.ToString())));

                    Reset();
                }
                else
                {
                    // Messaged
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
                int currentId = int.Parse(dgvNV.CurrentRow.Cells[0].Value.ToString());

                if (CheckData(txtMaNhanVien.Text, txtTenNhanVien.Text, txtSoDienThoai.Text, txtDiaChi.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: [{txtTenNhanVien.Text}] không?",
                  "Thông báo",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_nv.DelNV(currentId);

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
                int currentId = int.Parse(dgvNV.CurrentRow.Cells[0].Value.ToString());

                if (CheckData(txtMaNhanVien.Text, txtTenNhanVien.Text, txtSoDienThoai.Text, txtDiaChi.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn sửa thông tin: [{txtTenNhanVien.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_nv.UpdateNV(new DTO_NhanVien(
                        currentId,
                        txtMaNhanVien.Text,
                        txtTenNhanVien.Text,
                        txtSoDienThoai.Text,
                        txtDiaChi.Text,
                        int.Parse(cboMaLoaiNhanVien.SelectedValue.ToString()),
                        int.Parse(cboMaTaiKhoan.SelectedValue.ToString())));

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
