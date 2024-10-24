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

namespace Nhom2___PTUD___QLST.VanToan
{
	public partial class frmChiTietPhieuNhap : Form
	{
		public frmChiTietPhieuNhap()
		{
			InitializeComponent();
		}

		// Initialize Variables
		BUS_ChiTietPhieuNhap bus_ctpn = new BUS_ChiTietPhieuNhap();
		BUS_PhieuNhap bus_pn = new BUS_PhieuNhap();
		int currentID = -1;

		private void LoadData()
		{
			dgvChiTietPhieuNhap.DataSource = bus_ctpn.LayDSCTPN();

			//đổi tên cột
			dgvChiTietPhieuNhap.Columns["SoLuong"].HeaderText = "Số lượng";
			dgvChiTietPhieuNhap.Columns["DonGia"].HeaderText = "Đơn giá";
			dgvChiTietPhieuNhap.Columns["idPhieuNhap"].HeaderText = "mã phiếu nhập";
			dgvChiTietPhieuNhap.Columns["idSanPham"].HeaderText = "Tên sản phẩm";
			dgvChiTietPhieuNhap.Columns["id"].Visible = false;

			cbMaPhieuNhap.DataSource = bus_pn.LayDSPhieuNhap();
			cbMaPhieuNhap.DisplayMember = "ID";
			cbMaPhieuNhap.ValueMember = "ID";

			//cbMaPhieuNhap.DataSource = bus_pn.LayDSPhieuNhap();
			//cbMaPhieuNhap.DisplayMember = "idSanPham";
			//cbMaPhieuNhap.ValueMember = "idSanPham";

			cbTenSanPham.DataSource = bus_ctpn.DSSP();
			cbTenSanPham.DisplayMember = "TenSanPham";
			cbTenSanPham.ValueMember = "id";
		}

		private void Reset()
		{
			txtSoLuong.Text = string.Empty;
			txtDonGia.Text = string.Empty;
			cbMaPhieuNhap.SelectedIndex = 0;
			cbTenSanPham.SelectedIndex = 0;
		}

		private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				if (int.Parse(txtSoLuong.Text) > 0 && float.Parse(txtDonGia.Text) > 0)
				{
					//thêm loại hàng
					bus_ctpn.ThemChiTietPhieuNhap(new DTO_ChiTietPhieuNhap(int.Parse(txtSoLuong.Text), float.Parse(txtDonGia.Text), int.Parse(cbMaPhieuNhap.Text), int.Parse(cbTenSanPham.SelectedValue.ToString())));
					//làm mới
					LoadData();
				}
				else
				{
					//thông báo khi chưa đầy đủ dữ liệu
					MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				//thông báo khi có lỗi xảy ra
				MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm có mã là: +{cbTenSanPham.Text}+ không?", "Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
				if (r == DialogResult.Yes)
				{
					if (currentID > 0)
					{
						bus_ctpn.XoaChiTietPhieuNhap(currentID);
						MessageBox.Show("Xóa thành công!", "Thoát", MessageBoxButtons.OK);
					}
					else
					{
						MessageBox.Show("Vui lòng chọn 1 dòng dữ liệu để xóa", "Thoát", MessageBoxButtons.OK);
					}
				}
			}
			catch (Exception ex)
			{
				//thông báo khi có lỗi xảy ra
				MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				if (int.Parse(txtSoLuong.Text) > 0)
				{
					//Sửa loại hàng
					bus_ctpn.SuaChiTietPhieuNhap(new DTO_ChiTietPhieuNhap(currentID, int.Parse(txtSoLuong.Text), float.Parse(txtDonGia.Text), int.Parse(cbMaPhieuNhap.Text), int.Parse(cbTenSanPham.SelectedValue.ToString())));
					//làm mới
					LoadData();
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

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgvChiTietPhieuNhap_Click(object sender, EventArgs e)
		{
			// Initialize Variable
			int n = dgvChiTietPhieuNhap.CurrentCell.RowIndex;

			if (n >= 0)
			{
				// txtMaDon
				txtSoLuong.Text = dgvChiTietPhieuNhap.Rows[n].Cells["SoLuong"].Value.ToString();

				// txtTenKhachHang
				txtDonGia.Text = dgvChiTietPhieuNhap.Rows[n].Cells["DonGia"].Value.ToString();

				// txtSDT
				cbMaPhieuNhap.Text = dgvChiTietPhieuNhap.Rows[n].Cells["idPhieuNhap"].Value.ToString();


				////txtDiemTichLuy

				//cbTenSanPham.DataSource = bus_ctpn.LayDSSP(int.Parse(dgvChiTietPhieuNhap.Rows[n].Cells["idSanPham"].Value.ToString()));
				//cbTenSanPham.DisplayMember = "TenSanPham";
				//cbTenSanPham.ValueMember = "id";
				//string s = cbTenSanPham.SelectedValue.ToString();

				//MessageBox.Show(s);
				//cbTenSanPham.DataSource = bus_ctpn.DSSP();
				//cbTenSanPham.DisplayMember = "TenSanPham";
				//cbTenSanPham.ValueMember = "id";

				//cbTenSanPham.SelectedIndex = cbTenSanPham.FindStringExact(s);
				//MessageBox.Show(cbTenSanPham.FindStringExact(s).ToString());

				cbTenSanPham.SelectedIndex = int.Parse(dgvChiTietPhieuNhap.Rows[n].Cells["idSanPham"].Value.ToString());

				//ID
				currentID = int.Parse(dgvChiTietPhieuNhap.Rows[n].Cells["id"].Value.ToString());

			}
			else
			{
				MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!",
					"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void guna2HtmlLabel1_Click(object sender, EventArgs e)
		{

		}
	}
}
