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
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GUI
{
	public partial class frmKhachHang : Form
	{
		public frmKhachHang()
		{
			InitializeComponent();
		}

		// Initialize Variables
		BUS_KhachHang bus_kh = new BUS_KhachHang();

		int currentID = -1;

		private void LoadData()
		{
			//load data
			dgvKhachHang.DataSource = bus_kh.LayDSKH();
			//đổi tên cột
			dgvKhachHang.Columns["MaKH"].HeaderText = "Mã khách hàng";
			dgvKhachHang.Columns["TenKH"].HeaderText = "Tên khách hàng";
			dgvKhachHang.Columns["SDT"].HeaderText = "Số điện thoại";
			dgvKhachHang.Columns["Diem"].HeaderText = "Điểm";
			dgvKhachHang.Columns["id"].Visible = false;
		}

		//Load dữ liệu
		private void frmKhachHang_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		//Reset
		private void Reset()
		{
			txtMaKhachHang.Text = string.Empty;
			txtTenKhachHang.Text = string.Empty;
			txtSDT.Text = string.Empty;
			txtDiemTichLuy.Text = string.Empty;
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

		// btnThem_Click
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (CheckNumber(txtDiemTichLuy.Text))
			{
				if (CheckNumberPhone(txtSDT.Text))
				{
					if (txtMaKhachHang.Text.Length > 0)
					{
						if (txtTenKhachHang.Text.Length > 0)
						{
							DTO_KhachHang kh = new DTO_KhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text,
				txtSDT.Text, int.Parse(txtDiemTichLuy.Text));

							bus_kh.ThemKH(kh);

							Reset();
						}
						else
						{
							MessageBox.Show("Vui lòng nhập tên khách hàng", "Thồn báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("vui lòng nhập mã khách hàng", "Thồn báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Số điện thoại phải là số và có độ dài là 10 kí tự", "Thồn báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Điểm phải là số!",
					"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}

		// btnXoa_click
		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa khách hàng có mã là: +{txtMaKhachHang.Text}+ không?", "Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
				if (r == DialogResult.Yes)
				{
					if (currentID > 0)
					{
						bus_kh.XoaKH(currentID);
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

		//btnSua_click
		private void btnSua_Click(object sender, EventArgs e)
		{
			if (CheckNumber(txtDiemTichLuy.Text))
			{
				if (CheckNumberPhone(txtSDT.Text))
				{
					if (txtMaKhachHang.Text.Length > 0)
					{
						if (txtTenKhachHang.Text.Length > 0)
						{
							DTO_KhachHang kh = new DTO_KhachHang(currentID, txtMaKhachHang.Text, txtTenKhachHang.Text,
				txtSDT.Text, int.Parse(txtDiemTichLuy.Text));

							bus_kh.SuaKH(kh);

							Reset();
						}
						else
						{
							MessageBox.Show("Vui lòng nhập tên khách hàng", "Thồn báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("vui lòng nhập mã khách hàng", "Thồn báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Số điện thoại phải là số và có độ dài là 10 kí tự", "Thồn báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Điểm phải là số!",
					"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			LoadData();
		}
		
		private void dgvKhachHang_Click(object sender, EventArgs e)
		{
			// Initialize Variable
			int n = dgvKhachHang.CurrentCell.RowIndex;

			if (n >= 0)
			{
				// txtMaKhachHang
				txtMaKhachHang.Text = dgvKhachHang.Rows[n].Cells["MaKH"].Value.ToString();

				// txtTenKhachHang
				txtTenKhachHang.Text = dgvKhachHang.Rows[n].Cells["TenKH"].Value.ToString();

				// txtSDT
				txtSDT.Text = dgvKhachHang.Rows[n].Cells["SDT"].Value.ToString();

				//txtDiemTichLuy
				txtDiemTichLuy.Text = dgvKhachHang.Rows[n].Cells["Diem"].Value.ToString();

				//ID
				currentID = int.Parse(dgvKhachHang.Rows[n].Cells["id"].Value.ToString());

			}
			else
			{
				MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!",
					"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			Reset();
			LoadData();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
