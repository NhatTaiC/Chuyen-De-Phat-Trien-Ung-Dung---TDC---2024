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

        public void LoadData()
        {
            // Others
            txtTenKhuyenMai.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // dgvKM
            dgvKM.DataSource = bus_km.GetListKM();
            dgvKM.Columns["id"].Visible = false;
            dgvKM.Columns["id"].HeaderText = "Id";
            dgvKM.Columns["MaKhuyenMai"].Visible = false;
            dgvKM.Columns["MaKhuyenMai"].HeaderText = "Mã khuyến mãi";
            dgvKM.Columns["TenKhuyenMai"].HeaderText = "Tên khuyến mãi";
            dgvKM.Columns["GiaTri"].HeaderText = "Giá trị";
        }

        public void Reset()
        {
            // Other
            txtTenKhuyenMai.Clear();
            txtGiaTri.Clear();

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
                MessageBox.Show($"Tên khuyến mãi không dài quá 100 kí tự!",
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
                    bus_km.AddKM(new DTO_KhuyenMai(txtTenKhuyenMai.Text, float.Parse(txtGiaTri.Text)));

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

                if (CheckData(txtTenKhuyenMai.Text, txtGiaTri.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn sửa thông tin: [{txtTenKhuyenMai.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_km.UpdateKM(new DTO_KhuyenMai(currentId, txtTenKhuyenMai.Text, float.Parse(txtGiaTri.Text)));

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

                if (CheckData(txtTenKhuyenMai.Text, txtGiaTri.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xoá: [{txtTenKhuyenMai.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_km.DelKM(currentId);

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
