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
        BUS_Log bus_log = new BUS_Log();
        string data_olds = string.Empty;
        string data_news = string.Empty;

        private void LoadData()
		{
			dgvChiTietPhieuNhap.DataSource = bus_ctpn.LayDSCTPN();

			//đổi tên cột
			dgvChiTietPhieuNhap.Columns["SoLuong"].HeaderText = "Số lượng";
			dgvChiTietPhieuNhap.Columns["DonGia"].HeaderText = "Đơn giá";
			dgvChiTietPhieuNhap.Columns["idPhieuNhap"].HeaderText = "mã phiếu nhập";
			dgvChiTietPhieuNhap.Columns["idSanPham"].HeaderText = "Tên sản phẩm";
			dgvChiTietPhieuNhap.Columns["id"].Visible = false;
			dgvChiTietPhieuNhap.Columns["idpn"].Visible = false;
			dgvChiTietPhieuNhap.Columns["idsp"].Visible = false;

            cbMaPhieuNhap.DataSource = bus_pn.LayDSPhieuNhap();
            cbMaPhieuNhap.DisplayMember = "MaPhieuNhap";
            cbMaPhieuNhap.ValueMember = "ID";
            cbMaPhieuNhap.SelectedIndex = 0;

            //cbMaPhieuNhap.DataSource = bus_pn.LayDSPhieuNhap();
            //cbMaPhieuNhap.DisplayMember = "idSanPham";
            //cbMaPhieuNhap.ValueMember = "idSanPham";

            cbTenSanPham.DataSource = bus_ctpn.DSSP();
			cbTenSanPham.DisplayMember = "TenSanPham";
			cbTenSanPham.ValueMember = "id";
			cbTenSanPham.SelectedIndex = 0;
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
                    int idPhieuNhap = cbMaPhieuNhap.SelectedIndex + 1;
                    int idSanPham = cbTenSanPham.SelectedIndex + 1;
                    int soLuong = int.Parse(txtSoLuong.Text);
                    float donGia = float.Parse(txtDonGia.Text);

                    if (!bus_ctpn.CheckCTHDByIdpnIdSp(idPhieuNhap, idSanPham))
                    {
                        // Tính tổng tiền cho sản phẩm mới
                        float thanhTienMoi = soLuong * donGia;

                        // Thêm sản phẩm vào ChiTietPhieuNhap
                        bus_ctpn.ThemChiTietPhieuNhap(new DTO_ChiTietPhieuNhap(soLuong, donGia, idPhieuNhap, idSanPham));

                        // Cập nhật tổng tiền trong Phiếu Nhập
                        bus_ctpn.UpdateThanhTien(idPhieuNhap, thanhTienMoi);

                        // Cập nhật số lượng trong Kho Hàng
                        //bus_khohang.UpdateSoLuong(idSanPham, soLuong);

                        // Làm mới dữ liệu
                        LoadData();

                        MessageBox.Show("Thêm sản phẩm vào phiếu nhập và cập nhật kho hàng thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Sản phẩm đã có trong chi tiết phiếu nhập hiện tại!\n" +
                            $"Chỉ cập nhật lại số lượng", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        // Cập nhật số lượng trong ChiTietPhieuNhap
                        bus_ctpn.UpdateSoLuongSpInCTPN(soLuong, idPhieuNhap, idSanPham);

                        // Cập nhật tổng tiền trong Phiếu Nhập
                        bus_ctpn.UpdateThanhTien(idPhieuNhap, soLuong * donGia);

                        // Cập nhật số lượng trong Kho Hàng
                        //bus_ctpn.UpdateSoLuong(idSanPham, soLuong);

                        // Làm mới dữ liệu
                        LoadData();
                    }
                }
                else
                {
                    // Thông báo khi dữ liệu không hợp lệ
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Thông báo khi có lỗi xảy ra
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void btnXoa_Click(object sender, EventArgs e)
		{
            try
            {
                // Initialize Variables
                int currentId = int.Parse(dgvChiTietPhieuNhap.CurrentRow.Cells[0].Value.ToString());
                data_olds = "is_deleted = 0";
                data_news = "is_deleted = 1";

                if (txtDonGia.Text.Length > 0 && txtSoLuong.Text.Length > 0)
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: [{cbTenSanPham.Text}] không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_ctpn.DellPN(currentId);

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("ChiTietPhieuNhap", currentId, "Delete a record ChiTietPhieuNhap", data_olds, data_news));

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
            try
            {
                // Kiểm tra dữ liệu nhập
                if (int.TryParse(txtSoLuong.Text, out int soLuong) && soLuong > 0 &&
                    float.TryParse(txtDonGia.Text, out float donGia) && donGia > 0)
                {
                    // Lấy thông tin từ DataGridView
                    int idChiTiet = int.Parse(dgvChiTietPhieuNhap.CurrentRow.Cells[0].Value.ToString());
                    int idPhieuNhapHienTai = int.Parse(dgvChiTietPhieuNhap.CurrentRow.Cells[1].Value.ToString()); // ID Phiếu nhập
                    int idSanPhamHienTai = int.Parse(dgvChiTietPhieuNhap.CurrentRow.Cells[2].Value.ToString());  // ID Sản phẩm

                    // Lấy thông tin từ ComboBox
                    int idPhieuNhapMoi = cbMaPhieuNhap.SelectedIndex + 1;
                    int idSanPhamMoi = cbTenSanPham.SelectedIndex + 1;

                    // Kiểm tra nếu mã phiếu nhập hoặc sản phẩm bị thay đổi
                    if (idPhieuNhapHienTai != idPhieuNhapMoi || idSanPhamHienTai != idSanPhamMoi)
                    {
                        MessageBox.Show("Không thể thay đổi thông tin mã phiếu nhập hoặc sản phẩm vì liên quan đến khóa phụ!",
                            "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tạo đối tượng DTO mới để cập nhật
                    DTO_ChiTietPhieuNhap chiTietMoi = new DTO_ChiTietPhieuNhap(idChiTiet, soLuong, donGia, idPhieuNhapHienTai, idSanPhamHienTai);

                    // Gọi hàm cập nhật
                    bus_ctpn.SuaChiTietPhieuNhap(chiTietMoi);

                    // Tính lại tổng tiền và cập nhật
                    float thanhTienMoi = soLuong * donGia;
                    bus_ctpn.UpdateThanhTien(idPhieuNhapHienTai, thanhTienMoi);

                    // Làm mới dữ liệu
                    LoadData();

                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

				txtSoLuong.Text = dgvChiTietPhieuNhap.Rows[n].Cells["SoLuong"].Value.ToString();

				txtDonGia.Text = dgvChiTietPhieuNhap.Rows[n].Cells["DonGia"].Value.ToString();

				cbMaPhieuNhap.SelectedIndex = int.Parse(dgvChiTietPhieuNhap.Rows[n].Cells["idpn"].Value.ToString()) - 1;

				cbTenSanPham.SelectedIndex = int.Parse(dgvChiTietPhieuNhap.Rows[n].Cells["idsp"].Value.ToString()) - 1;

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
