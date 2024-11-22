using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUS;
using DTO;
using System.Security.Cryptography;
namespace GUI
{
    public partial class frmLoaiHang : Form
    {
        //khai báo
        //bus loại hàng
        BUS_LoaiHang bus_lh = new BUS_LoaiHang();
        //id loại hàng hiện tại
        
        int currentID = -1;
        public frmLoaiHang()
        {
            InitializeComponent();
        }
        //Hàm load danh sách loại hàng
        public void LoadDSLoaiHang()
        {
            //load danh sách
            dgvLoaiHang.DataSource = bus_lh.LayDSLoaiHang();
            //đổi tên cột
            dgvLoaiHang.Columns["MaLoaiHang"].HeaderText = "Mã Loại Hàng";
            dgvLoaiHang.Columns["TenLoaiHang"].HeaderText = "Tên Loại Hàng";
            //ẩn cột id
            dgvLoaiHang.Columns["id"].Visible = false;
        }
        //sự kiện load form
        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            //gọi load danh sách
            LoadDSLoaiHang();
        }
        //sự kiện click nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoaiHang.Text.Length > 0 && txtTenLoaiHang.Text.Length > 0)
                {
                    //thêm loại hàng
                    bus_lh.ThemLoaiHang(new DTO_LoaiHang(txtMaLoaiHang.Text, txtTenLoaiHang.Text));  
                    MessageBox.Show("Thêm thành công!","Thoát", MessageBoxButtons.OK);
                    //làm mới
                    LamMoi();
                }
                else
                {
                    //thông báo khi chưa đầy đủ dữ liệu
                    MessageBox.Show("Chưa nhập dữ liệu!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                //thông báo khi có lỗi xảy ra
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //hàm làm mới
        private void LamMoi()
        {
            txtMaLoaiHang.Clear();
            txtTenLoaiHang.Clear();
            txtMaLoaiHang.Focus();
            //load lại data
            LoadDSLoaiHang();
        }
        //sự kiện click nút xóa

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //kiểm tra đã click vào dòng dữ liệu nào chưa
                    if (currentID > 0)
                    {
                        //xóa dữ liệu
                        bus_lh.XoaLoaiHang(currentID);
                        MessageBox.Show("Xóa thành công!", "Thoát", MessageBoxButtons.OK);
                        //làm mới
                        LamMoi();
                    }
                    else
                    {

                        //thông báo khi chưa chọn dữ liệu xóa
                        MessageBox.Show("Vui lòng chọn dữ liệu cần xóa!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                    
            }
            catch (Exception ex)
            {

                //thông báo khi có lỗi xảy ra
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        //sự kiện click datadrigview

        private void dgvLoaiHang_Click(object sender, EventArgs e)
        {
            //lấy dòng đang click
            int dong = dgvLoaiHang.CurrentRow.Index;
            //điền thông tin lên textbox
            txtMaLoaiHang.Text = dgvLoaiHang.Rows[dong].Cells["MaLoaiHang"].Value.ToString();
            txtTenLoaiHang.Text = dgvLoaiHang.Rows[dong].Cells["TenLoaiHang"].Value.ToString();
            //lấy id click
            currentID = int.Parse(dgvLoaiHang.Rows[dong].Cells["id"].Value.ToString());
            //MessageBox.Show(currentID.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLoaiHang.Text.Length > 0 && txtTenLoaiHang.Text.Length > 0)
                {
                    //Sửa loại hàng
                    bus_lh.SuaLoaHang(new DTO_LoaiHang(currentID,txtMaLoaiHang.Text, txtTenLoaiHang.Text));
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
