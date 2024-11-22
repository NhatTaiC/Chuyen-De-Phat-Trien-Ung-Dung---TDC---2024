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
			string[] arr = { "Theo tên", "Theo ngày" };
			cbTimKiem.DataSource = arr;
            dtpNgay.CustomFormat = "dd/MM/yyyy";
			dtpNgayLam.CustomFormat = "dd/MM/yyyy";
			
        }

		BUS_LichLam bus_ll = new BUS_LichLam();
		BUS_CaLam bus_cl = new BUS_CaLam();
		int currentID = -1;
        BUS_Log bus_log = new BUS_Log();
        string data_olds = string.Empty;
        string data_news = string.Empty;


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
            dgvLichLam.Columns["ten"].Visible = false;

            cbMaCaLam.DataSource = bus_cl.LayDSCaLam();
			cbMaCaLam.DisplayMember = "TenCaLam";
			cbMaCaLam.ValueMember = "id";

			cbNhanVien.DataSource = bus_ll.LayDSNV();
			cbNhanVien.DisplayMember = "TenNhanVien";
			cbNhanVien.ValueMember = "id";

            dgvLichLam.Columns["NgayLam"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

		private void Reset()
		{
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
			LoadData();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{		
				DTO_LichLam ll = new DTO_LichLam(dtpNgay.Value,
			int.Parse(cbNhanVien.SelectedValue.ToString()), int.Parse(cbMaCaLam.SelectedValue.ToString()));
				bus_ll.ThemLichLam(ll);
				//Reset();
				LoadData();		
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
            try
            {
                // Initialize Variables
                int currentId = int.Parse(dgvLichLam.CurrentRow.Cells[0].Value.ToString());
                data_olds = "is_deleted = 0";
                data_news = "is_deleted = 1";

                if (cbNhanVien.Text.Length > 0)
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa lịch làm của nhân viên: [{cbNhanVien.Text}] không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_ll.DellLL(currentId);

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("LichLam", currentId, "Delete a record LichLam", data_olds, data_news));

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

		private void btnSua_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show($"Bạn có chắc muốn sửa thông tin lịch làm của nhân viên: +{cbNhanVien.Text}+ không?",
"Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (r == DialogResult.Yes)
			{
					DTO_LichLam ll = new DTO_LichLam(currentID, dtpNgay.Value,
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
				// dtpNgay
				dtpNgay.Text = dgvLichLam.Rows[n].Cells["NgayLam"].Value.ToString();

				// cbNhanVien
				//cbNhanVien.Text = dgvLichLam.Rows[n].Cells["TenNhanVien"].Value.ToString();
				cbNhanVien.Text = dgvLichLam.Rows[n].Cells["TenNhanVien"].Value.ToString();

				//txtMaCaLam
				//cbMaCaLam.Text = dgvLichLam.Rows[n].Cells["TenCaLam"].Value.ToString();
				cbMaCaLam.SelectedIndex = int.Parse(dgvLichLam.Rows[n].Cells["Ten"].Value.ToString())-1;

				//ID
				currentID = int.Parse(dgvLichLam.Rows[n].Cells["id"].Value.ToString());

			}
			else
			{
				MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!",
					"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
			if(cbTimKiem.SelectedValue.ToString() == "Theo tên")
			{
                string n = txtTimKiem.Text.Trim();
                if (string.IsNullOrEmpty(n))
                {
                    LoadData();
                }
                else
                {
                    dgvLichLam.DataSource = bus_ll.TimKiemTheoTen(n);
                }
            }
			else
			{
				//DateTime n;
    //            if (dtpNgayLam.Text.Length == 10)
    //            {
				//	MessageBox.Show(txtTimKiem.Text);
				//	n = DateTime.Parse(txtTimKiem.Text.Trim());
    //                dgvLichLam.DataSource = bus_ll.TimKiemTheoNgay(n);
    //                LoadData();
    //            }
    //            else
    //            {
    //                LoadData();
    //            }
			}
		}

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
			if(cbTimKiem.SelectedIndex == 0)
			{
				dtpNgayLam.Visible = false;
				txtTimKiem.Visible = true;
			}
			else
			{
                dtpNgayLam.Visible = true;
                txtTimKiem.Visible = false;
            }
        }

        private void dtpNgayLam_ValueChanged(object sender, EventArgs e)
        {
            DateTime n = dtpNgayLam.Value;
            dgvLichLam.DataSource = bus_ll.TimKiemTheoNgay(n);
        }
    }
}
