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
	public partial class frmCaLam : Form
	{
		public frmCaLam()
		{
			InitializeComponent();
		}

		// Initialize Variables
		BUS_CaLam bus_cl = new BUS_CaLam();
		int currentID = -1;
		private void LoadData()
		{
			dgvCaLam.DataSource = bus_cl.LayDSCaLam();

			//đổi tên cột
			dgvCaLam.Columns["MaCaLam"].HeaderText = "Mã ca làm";
			dgvCaLam.Columns["TenCaLam"].HeaderText = "Tên ca làm";
			dgvCaLam.Columns["GioBatDau"].HeaderText = "Giờ bắt đầu";
			dgvCaLam.Columns["GioKetThuc"].HeaderText = "Giờ kết thúc";
			dgvCaLam.Columns["id"].Visible = false;
		}

		private void Reset()
		{
			txtTenCaLam.Text = string.Empty;
			txtGioBatDau.Text = string.Empty;
			txtGioKetThuc.Text = string.Empty;
		}

		private void frmCaLam_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				if(txtTenCaLam.Text != "Ca sáng" && txtTenCaLam.Text != "Ca tối" && txtTenCaLam.Text != "Ca chiều")
				{
                    if (txtTenCaLam.Text.Length > 0 && txtGioBatDau.Text.Length > 0 && txtGioKetThuc.Text.Length > 0)
                    {
                        //thêm ca làm
                        bus_cl.ThemCaLam(new DTO_CaLam(txtTenCaLam.Text, txtGioBatDau.Text, txtGioKetThuc.Text));
                        //làm mới
                        LoadData();
                    }
                    else
                    {
                        //thông báo khi chưa đầy đủ dữ liệu
                        MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
				else
				{
                    MessageBox.Show("Ca làm đã tồn tại!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
				//Xóa ca lam
				DialogResult r = MessageBox.Show($"Bạn có chắc muốn xóa ca làm: {txtTenCaLam.Text} không?", "Thông báo",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
				if (r == DialogResult.Yes)
				{
					if (currentID > 0)
					{
                            bus_cl.XoaCaLam(currentID);
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
				if (txtTenCaLam.Text.Length > 0 && txtGioBatDau.Text.Length > 0 && txtGioKetThuc.Text.Length > 0)
				{
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn sửa: [{txtTenCaLam.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        //Sửa ca lam
                        bus_cl.SuaCaLam(new DTO_CaLam(currentID, txtTenCaLam.Text, txtGioBatDau.Text, txtGioKetThuc.Text));
                        //làm mới
                        LoadData();
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

		private void dgvCaLam_Click(object sender, EventArgs e)
		{
			// Initialize Variable
			int n = dgvCaLam.CurrentCell.RowIndex;

			if (n >= 0)
			{

				// txtTenCaLam
				txtTenCaLam.Text = dgvCaLam.Rows[n].Cells["TenCaLam"].Value.ToString();

				// txtGioBatDau
				txtGioBatDau.Text = dgvCaLam.Rows[n].Cells["GioBatDau"].Value.ToString();

				//txtGioKetThuc
				txtGioKetThuc.Text = dgvCaLam.Rows[n].Cells["GioKetThuc"].Value.ToString();

				//ID
				currentID = int.Parse(dgvCaLam.Rows[n].Cells["id"].Value.ToString());

			}
			else
			{
				MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!",
					"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		//btnThoat_Click
		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
