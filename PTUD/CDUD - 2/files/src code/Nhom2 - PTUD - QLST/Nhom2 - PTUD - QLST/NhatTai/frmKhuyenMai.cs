/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * frmKhuyenMai.cs
 * 21/10/2024
 */
using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_KhuyenMai bus_km = new BUS_KhuyenMai();
        DataValidation dv = new DataValidation();
        BUS_Log bus_log = new BUS_Log();
        string data_olds = string.Empty;
        string data_news = string.Empty;

        public void LoadData()
        {
            // Others
            txtTenKhuyenMai.Focus();
            txtTenKhuyenMai.Text = string.Empty;
            txtGiaTri.Text = "0";
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            data_olds = string.Empty;
            data_news = string.Empty;

            // dgvKM
            dgvKM.DataSource = bus_km.GetListKM();
            dgvKM.Columns["id"].Visible = false;
            dgvKM.Columns["id"].HeaderText = "Id";
            dgvKM.Columns["MaKhuyenMai"].Visible = true;
            dgvKM.Columns["MaKhuyenMai"].HeaderText = "Mã khuyến mãi";
            dgvKM.Columns["TenKhuyenMai"].HeaderText = "Tên khuyến mãi";
            dgvKM.Columns["GiaTri"].HeaderText = "Giá trị";
        }

        public void Reset()
        {
            LoadData();
        }

        public bool CheckData(string tenKhuyenMai, string giaTri)
        {
            // Initialize Variables
            int count = 0;

            // Checked tenKhuyenMai
            if (dv.CheckString(tenKhuyenMai, 100))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Tên khuyến mãi không dài quá 100 kí tự và không để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked soDT
            if (dv.CheckNumber2(giaTri, giaTri.Length))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Giá trị phải nhập số, không dài quá 3 kí tự, giá trị từ 1 -> 100!",
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

        private void frmKhuyenMai_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void frmKhuyenMai_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvKM_Click(object sender, System.EventArgs e)
        {
            if (dgvKM.CurrentCell != null)
            {
                // Get row index selected
                int n = dgvKM.CurrentCell.RowIndex;

                // Other
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                //txtMaKhuyenMai.Text = dgvKM.Rows[n].Cells[1].Value.ToString();
                txtTenKhuyenMai.Text = dgvKM.Rows[n].Cells[2].Value.ToString();
                txtGiaTri.Text = dgvKM.Rows[n].Cells[3].Value.ToString();
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
                if (CheckData(txtTenKhuyenMai.Text, txtGiaTri.Text))
                {
                    bus_km.AddKM2(new DTO_KhuyenMai(txtTenKhuyenMai.Text, float.Parse(txtGiaTri.Text)));

                    int model_id = bus_km.GetMaxIdKM();
                    data_news = $"TenKhuyenMai: {txtTenKhuyenMai.Text} \nGiaTri: {txtGiaTri.Text}";

                    // Saved log
                    bus_log.AddLog3(new DTO_Log("KhuyenMai", model_id, "Add a new record KhuyenMai", data_olds, data_news));

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize Variables
                int currentId = int.Parse(dgvKM.CurrentRow.Cells[0].Value.ToString());
                data_olds = $"TenKhuyenMai: {dgvKM.CurrentRow.Cells[2].Value.ToString()} \nGiaTri: {dgvKM.CurrentRow.Cells[3].Value.ToString()}";
                data_news = $"TenKhuyenMai: {txtTenKhuyenMai.Text} \nGiaTri: {txtGiaTri.Text}";

                if (CheckData(txtTenKhuyenMai.Text, txtGiaTri.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn sửa thông tin: [{txtTenKhuyenMai.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_km.UpdateKM2(new DTO_KhuyenMai(currentId, txtTenKhuyenMai.Text, float.Parse(txtGiaTri.Text)));

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("KhuyenMai", currentId, "Update a record KhuyenMai", data_olds, data_news));

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize Variables
                int currentId = int.Parse(dgvKM.CurrentRow.Cells[0].Value.ToString());
                data_olds = "is_deleted = 0";
                data_news = "is_deleted = 1";

                if (CheckData(txtTenKhuyenMai.Text, txtGiaTri.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xoá: [{txtTenKhuyenMai.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_km.DelKM(currentId);

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("KhuyenMai", currentId, "Delete a record KhuyenMai", data_olds, data_news));

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
