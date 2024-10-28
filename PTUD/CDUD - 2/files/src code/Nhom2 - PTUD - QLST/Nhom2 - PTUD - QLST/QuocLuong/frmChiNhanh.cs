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
    public partial class frmChiNhanh : Form
    {
        //bus chi nhanh
        BUS_ChiNhanh bus_chinhanh = new BUS_ChiNhanh();
        //id đang chọn
        int currentID = 0;
        public frmChiNhanh()
        {
            InitializeComponent();
        }

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            //load danh sách chi nhánh
            LoadDSChiNhanh();
        }
        private void LoadDSChiNhanh()
        {
            dgvChiNhanh.DataSource = bus_chinhanh.LoadDSChiNhanh();
            //dổi tên cột
            dgvChiNhanh.Columns["MaChiNhanh"].HeaderText = "Mã chi nhánh";
            dgvChiNhanh.Columns["TenChiNhanh"].HeaderText = "Tên chi nhánh";
            dgvChiNhanh.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvChiNhanh.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            //ẩn cột
            dgvChiNhanh.Columns["id"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaChiNhanh.Text.Length > 0 
                    && txtTenChiNhanh.Text.Length > 0
                    && txtSoDienThoai.Text.Length > 0
                    && txtDiaChi.Text.Length > 0)
                {
                    //thêm loại hàng
                    bus_chinhanh.ThemChiNhanh(new DTO_ChiNhanh(txtMaChiNhanh.Text,txtTenChiNhanh.Text,txtDiaChi.Text,txtSoDienThoai.Text));
                    MessageBox.Show("Thêm thành công!", "Thoát", MessageBoxButtons.OK);
                    //làm mới
                    LamMoi();
                }
                else
                {
                    //thông báo khi chưa đầy đủ dữ liệu
                    MessageBox.Show("Chưa nhập dữ liệu!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //thông báo khi có lỗi xảy ra
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LamMoi()
        {
            //làm mới txt
            txtMaChiNhanh.Focus();
            txtMaChiNhanh.Clear();
            txtTenChiNhanh.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            //load lai chi nhanh
            LoadDSChiNhanh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(currentID > 0)
            {
                //Hỏi
                DialogResult resuflt = MessageBox.Show("Có chắc xóa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resuflt == DialogResult.Yes)
                {
                    //gọi hàm xóa chi nhánh
                    bus_chinhanh.XoaChiNhanh(currentID);
                    //Thông báo
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    //làm mới
                    LamMoi();
                } 
               
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu!", "Thoát", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgvChiNhanh_Click(object sender, EventArgs e)
        {
            //lấy dòng đang click
            int dong = dgvChiNhanh.CurrentRow.Index;
            //điền thông tin lên textbox
            txtMaChiNhanh.Text = dgvChiNhanh.Rows[dong].Cells["MaChiNhanh"].Value.ToString();
            txtTenChiNhanh.Text = dgvChiNhanh.Rows[dong].Cells["TenChiNhanh"].Value.ToString();
            txtDiaChi.Text = dgvChiNhanh.Rows[dong].Cells["DiaChi"].Value.ToString();
            txtSoDienThoai.Text = dgvChiNhanh.Rows[dong].Cells["SoDienThoai"].Value.ToString();
            //gán id cho currnentID
            currentID = int.Parse(dgvChiNhanh.Rows[dong].Cells["id"].Value.ToString());
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaChiNhanh.Text.Length > 0
                    && txtTenChiNhanh.Text.Length > 0
                    && txtSoDienThoai.Text.Length > 0
                    && txtDiaChi.Text.Length > 0)
                {
                    //thêm loại hàng
                    bus_chinhanh.SuaChinhNhanh(new DTO_ChiNhanh(currentID, txtMaChiNhanh.Text, txtTenChiNhanh.Text, txtDiaChi.Text, txtSoDienThoai.Text));
                    MessageBox.Show("Sửa thành công!", "Thoát", MessageBoxButtons.OK);
                    //làm mới
                    LamMoi();
                }
                else
                {
                    //thông báo khi chưa đầy đủ dữ liệu
                    MessageBox.Show("Chưa nhập dữ liệu!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //thông báo khi có lỗi xảy ra
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Back && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                txtSoDienThoai.Focus();
            }
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
