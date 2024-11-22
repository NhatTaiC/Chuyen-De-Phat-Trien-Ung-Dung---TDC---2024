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
			string[] arr = { "Tên khách hàng", "Số điện thoại" };
			cbTimTheo.DataSource = arr;
		}

		// Initialize Variables
		BUS_KhachHang bus_kh = new BUS_KhachHang();
		BUS_Log bus_log = new BUS_Log();
        string data_olds = string.Empty;
        string data_news = string.Empty;

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
						if (txtTenKhachHang.Text.Length > 0)
						{
							DTO_KhachHang kh = new DTO_KhachHang(txtTenKhachHang.Text,
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
                // Initialize Variables
                int currentId = int.Parse(dgvKhachHang.CurrentRow.Cells[0].Value.ToString());
                data_olds = "is_deleted = 0";
                data_news = "is_deleted = 1";

                if (CheckNumberPhone(txtSDT.Text) && CheckNumber(txtDiemTichLuy.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: [{txtTenKhachHang.Text}] không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_kh.DellKH(currentId);

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("KhachHang", currentId, "Delete a record KhachHang", data_olds, data_news));

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

		//btnSua_click
		private void btnSua_Click(object sender, EventArgs e)
		{
			if (CheckNumber(txtDiemTichLuy.Text))
			{
				if (CheckNumberPhone(txtSDT.Text))
				{
					
						if (txtTenKhachHang.Text.Length > 0)
						{
							DTO_KhachHang kh = new DTO_KhachHang(currentID,txtTenKhachHang.Text,
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
			if(cbTimTheo.SelectedValue.ToString() == "Tên khách hàng")
			{
                string n = txtTimKiem.Text.Trim();
                if (string.IsNullOrEmpty(n))
                {
                    LoadData();
                }
                else
                {
                    dgvKhachHang.DataSource = bus_kh.timkiemTheoTen(n);
                }
            }
			else
			{
                string n = txtTimKiem.Text.Trim();
                if (string.IsNullOrEmpty(n))
                {
                    LoadData();
                }
                else
                {
                    dgvKhachHang.DataSource = bus_kh.timkiemTheoSDT(n);
                }
            }

			
        }
    }
}
