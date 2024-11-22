using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
            txtThanhTien.Text = "0";
            txtThanhTien.Enabled = false;
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
        }

        // Initialize Variables
        BUS_PhieuNhap bus_pn = new BUS_PhieuNhap();
        int currentID = -1;
        BUS_Log bus_log = new BUS_Log();
        string data_olds = string.Empty;
        string data_news = string.Empty;
        

        //Load Data
        private void LoadData()
        {
            dgvPhieuNhap.DataSource = bus_pn.LayDSPhieuNhap();

            //đổi tên cột
            dgvPhieuNhap.Columns["MaPhieuNhap"].HeaderText = "Mã phiếu nhập";
            dgvPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dgvPhieuNhap.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dgvPhieuNhap.Columns["MaNhanVien"].HeaderText = "Nhân viên";
            dgvPhieuNhap.Columns["id"].Visible = false;

            cbNhanVien.DataSource = bus_pn.DSNV();
            cbNhanVien.DisplayMember = "TenNhanVien";
            cbNhanVien.ValueMember = "id";
            //cb san pham

        }


        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Reset()
        {
            dtpNgayNhap.Value = DateTime.Now;
            txtThanhTien.Text = string.Empty;
            cbNhanVien.SelectedIndex = 0;
            txtThanhTien.Text = "0";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // function CheckNumber()
        public bool CheckNumber(string n)
        {
            if (n == string.Empty)
            {
                return false;
            }
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= '0' && n[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }

        //btnThem_click
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckNumber(txtThanhTien.Text))
                {
                    //thêm phieunhap
                    bus_pn.ThemPhieuNhap(new DTO_PhieuNhap(dtpNgayNhap.Value, float.Parse(txtThanhTien.Text), int.Parse(cbNhanVien.SelectedIndex.ToString())+1));
                    //làm mới
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thành tiền phải là số!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //thông báo khi có lỗi xảy ra
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // btnXoa_Click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize Variables
                int currentId = int.Parse(dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString());
                data_olds = "is_deleted = 0";
                data_news = "is_deleted = 1";

                if (txtThanhTien.Text.Length > 0)
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: [{dtpNgayNhap.Text}] không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_pn.DellPN(currentId);

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("PhieuNhap", currentId, "Delete a record PhieuNhap", data_olds, data_news));

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
            LoadData();
        }

        //btnSua_Click
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckNumber(txtThanhTien.Text))
                {
                    //Sửa loại hàng
                    bus_pn.SuaPN(new DTO_PhieuNhap(currentID, dtpNgayNhap.Value, float.Parse(txtThanhTien.Text), int.Parse(cbNhanVien.SelectedIndex.ToString())+1));
                    MessageBox.Show("Sửa thành công!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //làm mới
                    LoadData();

                }
                else
                {
                    MessageBox.Show("Thành tiền phải là số!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                //thông báo khi có lỗi xảy ra
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhieuNhap_Click(object sender, EventArgs e)
        {
            // Initialize Variable
            int n = dgvPhieuNhap.CurrentCell.RowIndex;

            if (n >= 0)
            {
                // dtpNgayNhap
                dtpNgayNhap.Text = dgvPhieuNhap.Rows[n].Cells["NgayNhap"].Value.ToString();

                // txtThanhTien
                txtThanhTien.Text = dgvPhieuNhap.Rows[n].Cells["ThanhTien"].Value.ToString();

                //cbNhanVien
                //cbNhanVien.Text = dgvPhieuNhap.Rows[n].Cells["MaNhanVien"].Value.ToString();
                cbNhanVien.SelectedIndex = int.Parse(dgvPhieuNhap.Rows[n].Cells["MaNhanVien"].Value.ToString())-1;

                //ID
                currentID = int.Parse(dgvPhieuNhap.Rows[n].Cells["id"].Value.ToString());

            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
