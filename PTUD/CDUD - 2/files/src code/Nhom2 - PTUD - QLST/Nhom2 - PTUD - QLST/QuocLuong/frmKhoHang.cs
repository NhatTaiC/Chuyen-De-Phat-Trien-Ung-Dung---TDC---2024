using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class frmKhoHang : Form
    {
        //bus san pham
        BUS_SanPham bus_sp = new BUS_SanPham();
        //bus kho hàng
        BUS_KhoHang bus_khohang = new BUS_KhoHang();
        //id hiện tại
        int currentID = 0;
        int idSanPham = 0;
        public frmKhoHang()
        {
            InitializeComponent();
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            //load combobox sản phẩm
            LoadCBSanPham();
            //load kho hàng
            LoadKhoHang();
            //vô hiệu button
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void LoadCBSanPham()
        {
           
            //đỗ dữ liệu cho cb san pham
            cbSanPham.DataSource = bus_sp.LoadDSSanPham();
            cbSanPham.ValueMember = "id";
            cbSanPham.DisplayMember = "TenSanPham";
        }
        //Load danh sách kho hàng
        private void LoadKhoHang()
        {
            //goi bus kho hàng
            dgvKhoHang.DataSource = bus_khohang.LoadKhoHang();
            //đổi tên header
            dgvKhoHang.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvKhoHang.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            //ẩn côt
            dgvKhoHang.Columns["id"].Visible = false;
            dgvKhoHang.Columns["idSanPham"].Visible = false;
        }

        private void dgvKhoHang_Click(object sender, EventArgs e)
        {
            //lấy dòng đang click
            int dong = dgvKhoHang.CurrentRow.Index;
            //điền thông tin lên textbox
            txtSoLuong.Text = dgvKhoHang.Rows[dong].Cells["SoLuong"].Value.ToString();
            cbSanPham.SelectedValue = int.Parse(dgvKhoHang.Rows[dong].Cells["idSanPham"].Value.ToString());
            //gán id
            currentID = int.Parse(dgvKhoHang.Rows[dong].Cells["id"].Value.ToString());
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Back && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                txtSoLuong.Focus();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentID > 0 && txtSoLuong.Text.Length > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    bus_khohang.SuaKhoHang(new DTO_KhoHang(currentID, int.Parse(cbSanPham.SelectedValue.ToString()),int.Parse(txtSoLuong.Text)));
                    //load lại data
                    LamMoi();
                }
                else
                {
                    MessageBox.Show("Chưa chọn dữ liệu!", "Thoát", MessageBoxButtons.OK);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: "+ex.Message,"Thoát",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //hàm làm mới
        private void LamMoi()
        {
            cbSanPham.SelectedIndex = 0;
            txtSoLuong.Clear();
            LoadKhoHang();
        }

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult rs = MessageBox.Show("Bạn chắc thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (rs == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LamMoi();
		}
	}
}
