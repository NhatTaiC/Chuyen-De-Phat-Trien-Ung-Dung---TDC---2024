/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * frmTaiKhoan.cs
 * 21/10/2024
 */
using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        int quyen = -1;
        DataValidation dv = new DataValidation();
        BUS_Log bus_log = new BUS_Log();
        string data_olds = string.Empty;
        string data_news = string.Empty;

        public void LoadData()
        {
            // Others
            txtTenTaiKhoan.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTenTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            cboQuyen.SelectedIndex = 0;
            quyen = -1;
            data_olds = string.Empty;
            data_news = string.Empty;

            // dgvTaiKhoan
            dgvTaiKhoan.DataSource = bus_tk.GetListTK();
            dgvTaiKhoan.Columns["id"].Visible = false;
            dgvTaiKhoan.Columns["MaTaiKhoan"].Visible = false;
            dgvTaiKhoan.Columns[0].HeaderText = "Id";
            dgvTaiKhoan.Columns[1].HeaderText = "Mã tài khoản";
            dgvTaiKhoan.Columns[2].HeaderText = "Tên tài khoản";
            dgvTaiKhoan.Columns[3].HeaderText = "Mật khẩu";
            dgvTaiKhoan.Columns[4].HeaderText = "Quyền";

        }

        public void Reset()
        {
            LoadData();
        }

        public bool CheckData(string tenTK, string matKhau)
        {
            // Initialize Variables
            int count = 0;

            // Checked tenTK
            if (dv.CheckString(tenTK, 100))
            {
                count++;
            }
            else
            {
                MessageBox.Show($"Mã tài khoản không quá 100 kí tự!",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
            }

            // Checked tenTK
            if (dv.CheckString(matKhau, 100))
            {
                count++;
            }
            else
            {
                MessageBox.Show($"Mật khẩu không quá 100 kí tự!",
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

        private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmTaiKhoan_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            // cboQuyen
            if (cboQuyen.SelectedIndex == 0)
            {
                quyen = 0;
            }
            else
            {
                quyen = 1;
            }

            // Added new taikhoan
            try
            {
                if (CheckData(txtTenTaiKhoan.Text, txtMatKhau.Text))
                {
                    bus_tk.AddTK2(new DTO_TaiKhoan(txtTenTaiKhoan.Text, txtMatKhau.Text, quyen));

                    int model_id = bus_tk.GetMaxIdTK();
                    data_news = $"TenTaiKhoan: {txtTenTaiKhoan.Text} \n" +
                        $"MatKhau: {txtMatKhau.Text} \n" +
                        $"Quyen: {quyen}";

                    // Saved log
                    bus_log.AddLog3(new DTO_Log("TaiKhoan", model_id, "Add a new record TaiKhoan", data_olds, data_news));

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
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Initialize Variables
            int currentId = int.Parse(dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString());
            data_olds = "is_deleted = 0";
            data_news = "is_deleted = 1";

            // Deleted a current taikhoan
            try
            {
                if (CheckData(txtTenTaiKhoan.Text, txtMatKhau.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: [{txtTenTaiKhoan.Text}] không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_tk.DelTK(currentId);

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("TaiKhoan", currentId, "Delete a record TaiKhoan", data_olds, data_news)); ;

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
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // cboQuyen
            if (cboQuyen.SelectedIndex == 0)
            {
                quyen = 0;
            }
            else
            {
                quyen = 1;
            }

            // Initialize Variables
            int currentId = int.Parse(dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString());
            data_olds = $"TenTaiKhoan: {dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString()} \n" +
                $"MatKhau: {dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString()} \n" +
                $"Quyen: {dgvTaiKhoan.CurrentRow.Cells[4].Value.ToString()}";
            data_news = $"TenTaiKhoan: {txtTenTaiKhoan.Text} \n" +
               $"MatKhau: {txtMatKhau.Text} \n" +
               $"Quyen: {quyen}";

            // Added new taikhoan
            try
            {
                if (CheckData(txtTenTaiKhoan.Text, txtMatKhau.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn sửa thông tin: [{txtTenTaiKhoan.Text}] không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_tk.UpdateTK2(new DTO_TaiKhoan(currentId, txtTenTaiKhoan.Text, txtMatKhau.Text, quyen));

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("TaiKhoan", currentId, "Update a record TaiKhoan", data_olds, data_news));

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
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentCell != null)
            {
                // Get index row selected
                int n = dgvTaiKhoan.CurrentCell.RowIndex;
                //int n = dgvTaiKhoan.CurrentRow.Index;

                // Other
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[n].Cells[2].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[n].Cells[3].Value.ToString();

                // cboQuyen
                if (dgvTaiKhoan.Rows[n].Cells[4].Value.ToString() == "0")
                {
                    quyen = 0;
                    cboQuyen.SelectedIndex = 0;
                }
                else
                {
                    quyen = 1;
                    cboQuyen.SelectedIndex = 1;
                }
            }
            else
            {
                // Messaged
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}
