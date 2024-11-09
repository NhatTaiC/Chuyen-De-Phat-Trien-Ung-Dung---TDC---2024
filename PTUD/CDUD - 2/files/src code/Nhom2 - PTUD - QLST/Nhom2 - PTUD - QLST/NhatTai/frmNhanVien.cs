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
        DataValidation dv = new DataValidation();
        BUS_Log bus_log = new BUS_Log();
        string data_olds = string.Empty;
        string data_news = string.Empty;

        public void LoadData()
        {
            // Others
            txtTenNhanVien.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTenNhanVien.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            data_olds = string.Empty;
            data_news = string.Empty;

            // dgvNV
            dgvNV.DataSource = bus_nv.GetListNV();
            dgvNV.Columns["id"].Visible = false;
            dgvNV.Columns["idLoaiNhanVien"].Visible = false;
            dgvNV.Columns["idTaiKhoan"].Visible = false;
            dgvNV.Columns["MaNhanVien"].Visible = false;
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
            LoadData();
        }

        public bool CheckData(string tenNhanVien, string soDT, string diaChi)
        {
            // Initialize Variables
            int count = 0;

            // Checked tenNhanVien
            if (dv.CheckString(tenNhanVien, 100))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Tên nhân viên không quá 100 kí tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked soDT
            if (dv.CheckNumber(soDT, 10))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Số điện thoại không quá 10 kí tự và phải nhập số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked diaChi
            if (dv.CheckString(diaChi, 100))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Địa chỉ không quá 100 kí tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (count == 3)
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

                txtTenNhanVien.Text = dgvNV.Rows[n].Cells[2].Value.ToString();
                txtSoDienThoai.Text = dgvNV.Rows[n].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNV.Rows[n].Cells[4].Value.ToString();

                //MessageBox.Show(dgvNV.Rows[n].Cells[5].Value.ToString());

                // cboMaLoaiNhanVien
                int idLoaiNhanVien = int.Parse(dgvNV.Rows[n].Cells[5].Value.ToString());
                //cboMaLoaiNhanVien.DataSource = bus_lnv.GetListOneLNVByTen(idLoaiNhanVien);
                //cboMaLoaiNhanVien.DisplayMember = "TenLoaiNhanVien";
                //cboMaLoaiNhanVien.ValueMember = "Id";
                cboMaLoaiNhanVien.SelectedIndex = idLoaiNhanVien - 1;

                // cboMaTaiKhoan
                int idMaTaiKhoan = int.Parse(dgvNV.Rows[n].Cells[6].Value.ToString());
                cboMaTaiKhoan.DataSource = bus_tk.GetListOneTKByTenTK(idMaTaiKhoan);
                cboMaTaiKhoan.DisplayMember = "TenTaiKhoan";
                cboMaTaiKhoan.ValueMember = "Id";
                //cboMaTaiKhoan.SelectedIndex = idMaTaiKhoan - 1;
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
                if (CheckData(txtTenNhanVien.Text, txtSoDienThoai.Text, txtDiaChi.Text))
                {
                    bus_nv.AddNV2(new DTO_NhanVien(
                    txtTenNhanVien.Text,
                    txtSoDienThoai.Text,
                    txtDiaChi.Text,
                    int.Parse(cboMaLoaiNhanVien.SelectedValue.ToString()),
                    int.Parse(cboMaTaiKhoan.SelectedValue.ToString())));

                    int model_id = bus_nv.GetMaxIdNV();
                    data_news = $"TenNhanVien: {txtTenNhanVien.Text} \n" +
                        $"SoDienThoai: {txtSoDienThoai.Text} \n" +
                        $"DiaChi: {txtDiaChi.Text} \n" +
                        $"MaLoaiNhanVien: {cboMaLoaiNhanVien.SelectedValue.ToString()} \n" +
                        $"MaTaiKhoan: {cboMaTaiKhoan.SelectedValue.ToString()}";

                    // Saved log
                    bus_log.AddLog3(new DTO_Log("NhanVien", model_id, "Add a new record NhanVien", data_olds, data_news));

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
                data_olds = "is_deleted = 0";
                data_news = "is_deleted = 1";

                if (CheckData(txtTenNhanVien.Text, txtSoDienThoai.Text, txtDiaChi.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: [{txtTenNhanVien.Text}] không?",
                  "Thông báo",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_nv.DelNV(currentId);

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("NhanVien", currentId, "Delete a record NhanVien", data_olds, data_news));

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
                data_olds = $"TenNhanVien: {dgvNV.CurrentRow.Cells[2].Value.ToString()} \n" +
                    $"SoDienThoai: {dgvNV.CurrentRow.Cells[3].Value.ToString()} \n" +
                    $"DiaChi: {dgvNV.CurrentRow.Cells[4].Value.ToString()} \n" +
                    $"MaLoaiNhanVien: {dgvNV.CurrentRow.Cells[5].Value.ToString()} \n" +
                    $"MaTaiKhoan: {dgvNV.CurrentRow.Cells[6].Value.ToString()}";

                data_news = $"TenNhanVien: {txtTenNhanVien.Text} \n" +
                        $"SoDienThoai: {txtSoDienThoai.Text} \n" +
                        $"DiaChi: {txtDiaChi.Text} \n" +
                        $"MaLoaiNhanVien: {cboMaLoaiNhanVien.SelectedValue.ToString()} \n" +
                        $"MaTaiKhoan: {cboMaTaiKhoan.SelectedValue.ToString()}";

                if (CheckData(txtTenNhanVien.Text, txtSoDienThoai.Text, txtDiaChi.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn sửa thông tin: [{txtTenNhanVien.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_nv.UpdateNV2(new DTO_NhanVien(
                        currentId,
                        txtTenNhanVien.Text,
                        txtSoDienThoai.Text,
                        txtDiaChi.Text,
                        int.Parse(cboMaLoaiNhanVien.SelectedValue.ToString()),
                        int.Parse(cboMaTaiKhoan.SelectedValue.ToString())));

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("NhanVien", currentId, "Update a record NhanVien", data_olds, data_news));

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
