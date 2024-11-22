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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_NhaCungCap bus_ncc = new BUS_NhaCungCap();
        int currentID = -1;
        BUS_Log bus_log = new BUS_Log();
        string data_olds = string.Empty;
        string data_news = string.Empty;

        private void LoadData()
        {
            //load dữ liệu
            dgvNCC.DataSource = bus_ncc.LayDSNCC();

            //đổi tên cột
            dgvNCC.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
            dgvNCC.Columns["TenNCC"].HeaderText = "Tên tên nhà cung cấp";
            dgvNCC.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvNCC.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvNCC.Columns["id"].Visible = false;
        }


        private void dgvNCC_Click(object sender, EventArgs e)
        {
            // Initialize Variable
            int n = dgvNCC.CurrentCell.RowIndex;

            if (n >= 0)
            {
                // txtTenNCC
                txtTenNCC.Text = dgvNCC.Rows[n].Cells["TenNCC"].Value.ToString();

                // txtSDT
                txtSDT.Text = dgvNCC.Rows[n].Cells["SDT"].Value.ToString();

                //txtDiaChi
                txtDiaChi.Text = dgvNCC.Rows[n].Cells["DiaChi"].Value.ToString();

                //ID
                currentID = int.Parse(dgvNCC.Rows[n].Cells["id"].Value.ToString());

            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //LoadData
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //Func Reset
        private void Reset()
        {
            txtTenNCC.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }

        // checknumberphone
        public bool CheckNumberPhone(string n)
        {
            if (n == string.Empty)
            {
                return false;
            }
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= '0' && n[i] <= '9' && n.Length == 10)
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
                if (txtTenNCC.Text.Length > 0)
                {
                    if (CheckNumberPhone(txtSDT.Text))
                    {
                        if (txtDiaChi.Text.Length > 0)
                        {
                            //thêm NhaCungCap
                            bus_ncc.ThemNCC(new DTO_NhaCungCap(txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text));
                            //làm mới
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập địa chỉ!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại phải là số và có 10 kí tự!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên nhà cung cấp!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //thông báo khi có lỗi xảy ra
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //btnXoa_click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize Variables
                int currentId = int.Parse(dgvNCC.CurrentRow.Cells[0].Value.ToString());
                data_olds = "is_deleted = 0";
                data_news = "is_deleted = 1";

                if (txtTenNCC.Text.Length > 0)
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: [{txtTenNCC.Text}] không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_ncc.DellNCC(currentId);

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("NhaCungCap", currentId, "Delete a record NhaCungCap", data_olds, data_news));

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
                if (txtTenNCC.Text.Length > 0)
                {
                    if (CheckNumberPhone(txtSDT.Text))
                    {
                        if (txtDiaChi.Text.Length > 0)
                        {
                            //Sửa loại hàng
                            bus_ncc.SuaNCC(new DTO_NhaCungCap(currentID, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text));
                            //làm mới
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập địa chỉ!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại phải là số và có 10 kí tự!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên nhà cung cấp!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //thông báo khi có lỗi xảy ra
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //btn_LamMoi_Click
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //btn_Thoat_Click
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

