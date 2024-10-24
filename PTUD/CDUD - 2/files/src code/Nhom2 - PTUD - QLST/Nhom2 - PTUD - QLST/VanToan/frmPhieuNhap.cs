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
		}

		// Initialize Variables
		BUS_PhieuNhap bus_pn = new BUS_PhieuNhap();
		int currentID = -1;
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
			txtMaPhieuNhap.Text = string.Empty;
			dtpNgayNhap.Value = DateTime.Now;
			txtThanhTien.Text = string.Empty;
			cbNhanVien.SelectedIndex = 0;
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
				if (txtMaPhieuNhap.Text.Length > 0)
				{
					if (CheckNumber(txtThanhTien.Text))
					{
						//thêm phieunhap
						bus_pn.ThemPhieuNhap(new DTO_PhieuNhap(txtMaPhieuNhap.Text, dtpNgayNhap.Value, float.Parse(txtThanhTien.Text), int.Parse(cbNhanVien.SelectedIndex.ToString())));
						MessageBox.Show("Thêm thành công!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						//làm mới
						LoadData();
					}
					else
					{
						MessageBox.Show("Thành tiền phải là số!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
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

		// btnXoa_Click
		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa phiếu nhập có mã là: +{txtMaPhieuNhap.Text}+ không?", "Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
				if (r == DialogResult.Yes)
				{
					if (currentID > 0)
					{
						bus_pn.XoaPhieuNhap(currentID);
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

		//btnSua_Click
		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtMaPhieuNhap.Text.Length > 0)
				{
					if (CheckNumber(txtThanhTien.Text))
					{
						//Sửa loại hàng
						bus_pn.SuaPN(new DTO_PhieuNhap(currentID, txtMaPhieuNhap.Text, dtpNgayNhap.Value, float.Parse(txtThanhTien.Text), int.Parse(cbNhanVien.SelectedIndex.ToString())));
						MessageBox.Show("Sửa thành công!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						//làm mới
						LoadData();
						
					}
					else
					{
						MessageBox.Show("Thành tiền phải là số!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					
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

		private void dgvPhieuNhap_Click(object sender, EventArgs e)
		{
			// Initialize Variable
			int n = dgvPhieuNhap.CurrentCell.RowIndex;

			if (n >= 0)
			{
				// txtMaPhieuNhap
				txtMaPhieuNhap.Text = dgvPhieuNhap.Rows[n].Cells["MaPhieuNhap"].Value.ToString();

				// dtpNgayNhap
				dtpNgayNhap.Text = dgvPhieuNhap.Rows[n].Cells["NgayNhap"].Value.ToString();

				// txtThanhTien
				txtThanhTien.Text = dgvPhieuNhap.Rows[n].Cells["ThanhTien"].Value.ToString();

				//cbNhanVien
				//cbNhanVien.Text = dgvPhieuNhap.Rows[n].Cells["MaNhanVien"].Value.ToString();
				cbNhanVien.SelectedIndex = int.Parse(dgvPhieuNhap.Rows[n].Cells["MaNhanVien"].Value.ToString());

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
