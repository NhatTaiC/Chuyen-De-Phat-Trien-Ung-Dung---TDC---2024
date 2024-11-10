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

        public void LoadData()
        {
            // Others
            txtMaKhuyenMai.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // dgvKM
            dgvKM.DataSource = bus_km.GetListKM();
            dgvKM.Columns["id"].Visible = false;
            dgvKM.Columns["id"].HeaderText = "Id";
            dgvKM.Columns["MaKhuyenMai"].HeaderText = "Mã khuyến mãi";
            dgvKM.Columns["TenKhuyenMai"].HeaderText = "Tên khuyến mãi";
            dgvKM.Columns["GiaTri"].HeaderText = "Giá trị";
        }

        public void Reset()
        {
            // Other
            txtMaKhuyenMai.Clear();
            txtTenKhuyenMai.Clear();
            txtGiaTri.Clear();

            LoadData();
        }

        public bool CheckData(string maKhuyenMai, string tenKhuyenMai, string giaTri)
        {
            // Initialize Variables
            int count = 0;

            // Checked maKhuyenMai
            if (CheckString(maKhuyenMai, 30))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Mã khuyến mãi: [{maKhuyenMai}] không quá 30 kí tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked tenKhuyenMai
            if (CheckString(tenKhuyenMai, 100))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Tên khuyến mãi: [{tenKhuyenMai}] không quá 100 kí tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked soDT
            if (CheckNumber(giaTri))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Giá trị: [{giaTri}] phải nhập số!",
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

                txtMaKhuyenMai.Text = dgvKM.Rows[n].Cells[1].Value.ToString();
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
                if (CheckData(txtMaKhuyenMai.Text, txtTenKhuyenMai.Text, txtGiaTri.Text))
                {
                    bus_km.AddKM(new DTO_KhuyenMai(txtMaKhuyenMai.Text, txtTenKhuyenMai.Text, float.Parse(txtGiaTri.Text)));

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

                if (CheckData(txtMaKhuyenMai.Text, txtTenKhuyenMai.Text, txtGiaTri.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn sửa thông tin: [{txtTenKhuyenMai.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_km.UpdateKM(new DTO_KhuyenMai(currentId, txtMaKhuyenMai.Text, txtTenKhuyenMai.Text, float.Parse(txtGiaTri.Text)));

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

                if (CheckData(txtMaKhuyenMai.Text, txtTenKhuyenMai.Text, txtGiaTri.Text))
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
