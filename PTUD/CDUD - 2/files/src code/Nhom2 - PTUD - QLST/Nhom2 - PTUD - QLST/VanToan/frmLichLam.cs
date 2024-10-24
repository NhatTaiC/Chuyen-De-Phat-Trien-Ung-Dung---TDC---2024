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
	public partial class frmLichLam : Form
	{
		public frmLichLam()
		{
			InitializeComponent();
		}

		BUS_LichLam bus_ll = new BUS_LichLam();
		BUS_CaLam bus_cl = new BUS_CaLam();
		int currentID = -1;
		private void LoadData()
		{
			//Load dữ liệu
			dgvLichLam.DataSource = bus_ll.LayDSLichLam();

			//đổi tên cột
			dgvLichLam.Columns["MaLichLam"].HeaderText = "Mã lịch làm";
			dgvLichLam.Columns["NgayLam"].HeaderText = "Ngày làm";
			dgvLichLam.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
			dgvLichLam.Columns["TenCaLam"].HeaderText = "Tên ca làm";
			dgvLichLam.Columns["id"].Visible = false;

			cbMaCaLam.DataSource = bus_cl.LayDSCaLam();
			cbMaCaLam.DisplayMember = "TenCaLam";
			cbMaCaLam.ValueMember = "id";

			cbNhanVien.DataSource = bus_ll.LayDSNV();
			cbNhanVien.DisplayMember = "TenNhanVien";
			cbNhanVien.ValueMember = "id";
		}

		private void Reset()
		{
			txtMaLichLam.Text = string.Empty;
			dtpNgay.Value = DateTime.Now;
			cbNhanVien.SelectedIndex = 0;
			cbMaCaLam.SelectedIndex = 0;
		}

		private void frmLichLam_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (txtMaLichLam.Text.Length > 0)
			{
				DTO_LichLam ll = new DTO_LichLam(txtMaLichLam.Text, dtpNgay.Value,
			int.Parse(cbNhanVien.SelectedValue.ToString()), int.Parse(cbMaCaLam.SelectedValue.ToString()));
				bus_ll.ThemLichLam(ll);
				//Reset();
				LoadData();
			}
			else
			{
				MessageBox.Show("Vui lòng nhập mã lịch làm!",
					"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa lịch làm có mã là: +{txtMaLichLam.Text}+ không?", "Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
				if (r == DialogResult.Yes)
				{
					if (currentID > 0)
					{
						bus_ll.XoaLichLam(currentID);
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
			DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin lịch làm có mã là: +{txtMaLichLam.Text}+ không?",
"Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (r == DialogResult.Yes)
			{
					DTO_LichLam ll = new DTO_LichLam(currentID, txtMaLichLam.Text, dtpNgay.Value,
			int.Parse(cbNhanVien.SelectedValue.ToString()), int.Parse(cbMaCaLam.SelectedValue.ToString()));
					bus_ll.SuaLichLam(ll);
					Reset();
			}
			LoadData();
		}

		private void dgvLichLam_Click(object sender, EventArgs e)
		{

			// Initialize Variable
			int n = dgvLichLam.CurrentCell.RowIndex;

			if (n >= 0)
			{
				// txtMaLichLam
				txtMaLichLam.Text = dgvLichLam.Rows[n].Cells["MaLichLam"].Value.ToString();

				// dtpNgay
				dtpNgay.Text = dgvLichLam.Rows[n].Cells["NgayLam"].Value.ToString();

				// cbNhanVien
				//cbNhanVien.Text = dgvLichLam.Rows[n].Cells["TenNhanVien"].Value.ToString();
				cbNhanVien.SelectedIndex = int.Parse(dgvLichLam.Rows[n].Cells["TenNhanVien"].Value.ToString());

				//txtMaCaLam
				//cbMaCaLam.Text = dgvLichLam.Rows[n].Cells["TenCaLam"].Value.ToString();
				cbMaCaLam.SelectedIndex = int.Parse(dgvLichLam.Rows[n].Cells["TenCaLam"].Value.ToString());

				//ID
				currentID = int.Parse(dgvLichLam.Rows[n].Cells["id"].Value.ToString());

			}
			else
			{
				MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!",
					"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
