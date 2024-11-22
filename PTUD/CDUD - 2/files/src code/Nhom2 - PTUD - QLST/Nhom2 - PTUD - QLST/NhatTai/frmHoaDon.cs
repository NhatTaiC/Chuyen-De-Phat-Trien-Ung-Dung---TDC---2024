/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 07/11/2024
 * frmHoaDon.cs
 */
using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST.NhatTai
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_HoaDon bus_hd = new BUS_HoaDon();
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_KhuyenMai bus_km = new BUS_KhuyenMai();
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        DataValidation dv = new DataValidation();
        BUS_Log bus_log = new BUS_Log();
        string data_olds = string.Empty;
        string data_news = string.Empty;

        public void LoadData()
        {
            // dgvHD getList
            dgvHD.DataSource = bus_hd.GetListHD2();

            // dgvHD display for
            dgvHD.Columns[0].HeaderText = "Id";
            dgvHD.Columns[1].HeaderText = "Mã hóa đơn";
            dgvHD.Columns[2].HeaderText = "Ngày lập hóa đơn";
            dgvHD.Columns[3].HeaderText = "Giờ lập hóa đơn";
            dgvHD.Columns[4].HeaderText = "Tổng tiền";
            dgvHD.Columns[5].HeaderText = "Thành tiền";
            dgvHD.Columns[6].HeaderText = "Mã khách hàng";
            dgvHD.Columns[7].HeaderText = "Mã khuyến mãi";
            dgvHD.Columns[8].HeaderText = "Mã nhân viên";
            dgvHD.Columns[9].HeaderText = "Tên khách hàng";
            dgvHD.Columns[10].HeaderText = "Tên khuyến mãi";
            dgvHD.Columns[11].HeaderText = "Tên nhân viên";
            //dgvHD.Columns[4].DefaultCellStyle.Format = "#,###";
            //dgvHD.Columns[5].DefaultCellStyle.Format = "#,###";

            // dgvHD visible
            dgvHD.Columns[0].Visible = false;
            dgvHD.Columns[1].Visible = true;
            dgvHD.Columns[2].Visible = false;
            dgvHD.Columns[3].Visible = false;
            dgvHD.Columns[4].Visible = true;
            dgvHD.Columns[5].Visible = true;
            dgvHD.Columns[6].Visible = false;
            dgvHD.Columns[7].Visible = false;
            dgvHD.Columns[8].Visible = false;

            // cboMaKH
            cboMaKH.DataSource = bus_kh.LayDSKH();
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "id";
            cboMaKH.SelectedIndex = 0;

            // cboMaKM
            cboMaKM.DataSource = bus_km.GetListKM();
            cboMaKM.DisplayMember = "TenKhuyenMai";
            cboMaKM.ValueMember = "id";
            cboMaKM.SelectedIndex = 0;

            // cboMaNV
            cboMaNV.DataSource = bus_nv.GetListNV();
            cboMaNV.DisplayMember = "TenNhanVien";
            cboMaNV.ValueMember = "id";
            cboMaNV.SelectedIndex = 0;

            // Other
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            data_olds = string.Empty;
            data_news = string.Empty;
        }

        public void Reset()
        {
            LoadData();
        }

        private void frmHoaDon_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvHD_Click(object sender, System.EventArgs e)
        {
            if (dgvHD.CurrentCell != null)
            {
                // Get row index selected
                int n = dgvHD.CurrentCell.RowIndex;

                // Other
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                // cboMaKH
                cboMaKH.DataSource = bus_kh.LayDSKH();
                cboMaKH.DisplayMember = "TenKH";
                cboMaKH.ValueMember = "id";
                cboMaKH.SelectedIndex = int.Parse(dgvHD.Rows[n].Cells[6].Value.ToString()) - 1;

                // cboMaKM
                cboMaKM.DataSource = bus_km.GetListKM();
                cboMaKM.DisplayMember = "TenKhuyenMai";
                cboMaKM.ValueMember = "id";
                cboMaKM.SelectedIndex = int.Parse(dgvHD.Rows[n].Cells[7].Value.ToString()) - 1;

                // cboMaNV
                cboMaNV.DataSource = bus_nv.GetListNV();
                cboMaNV.DisplayMember = "TenNhanVien";
                cboMaNV.ValueMember = "id";
                cboMaNV.SelectedIndex = int.Parse(dgvHD.Rows[n].Cells[8].Value.ToString()) - 1;
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
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn tạo hóa đơn mới không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    bus_hd.AddHD(new DTO_HoaDon(int.Parse(cboMaKH.SelectedValue.ToString()), int.Parse(cboMaKM.SelectedValue.ToString()), int.Parse(cboMaNV.SelectedValue.ToString())));

                    int model_id = bus_hd.GetMaxIdHD();

                    data_news = $"MaKH: {cboMaKH.SelectedValue.ToString()} \n" +
                        $"MaKM: {cboMaKM.SelectedValue.ToString()} \n" +
                        $"MaNV: {cboMaNV.SelectedValue.ToString()}";

                    // Saved log
                    bus_log.AddLog3(new DTO_Log("HoaDon", model_id, "Add a new record HoaDon", data_olds, data_news));

                    Reset();
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
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa thông tin hóa đơn không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    int currentId = int.Parse(dgvHD.CurrentRow.Cells[0].Value.ToString());
                    data_olds = $"MaKH: {dgvHD.CurrentRow.Cells[6].Value.ToString()} \n" +
                       $"MaKM: {dgvHD.CurrentRow.Cells[7].Value.ToString()} \n" +
                       $"MaNV: {dgvHD.CurrentRow.Cells[8].Value.ToString()}";
                    data_news = $"MaKH: {cboMaKH.SelectedValue.ToString()} \n" +
                        $"MaKM: {cboMaKM.SelectedValue.ToString()} \n" +
                        $"MaNV: {cboMaNV.SelectedValue.ToString()}";

                    bus_hd.UpdateHD(new DTO_HoaDon(currentId, int.Parse(cboMaKH.SelectedValue.ToString()), int.Parse(cboMaKM.SelectedValue.ToString()), int.Parse(cboMaNV.SelectedValue.ToString())));

                    // Saved log
                    bus_log.AddLog3(new DTO_Log("HoaDon", currentId, "Update a record HoaDon", data_olds, data_news));

                    Reset();
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
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    int currentId = int.Parse(dgvHD.CurrentRow.Cells[0].Value.ToString());
                    data_olds = "is_deleted = 0";
                    data_news = "is_deleted = 1";

                    bus_hd.DeleteHD(currentId);

                    // Saved log
                    bus_log.AddLog3(new DTO_Log("HoaDon", currentId, "Delete a record HoaDon", data_olds, data_news));

                    Reset();
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
