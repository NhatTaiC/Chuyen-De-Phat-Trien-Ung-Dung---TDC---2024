/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 09/11/2024
 * frm_ChiTietHoaDon.cs
 */
using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST.NhatTai
{
    public partial class frmHoaDonChiTiet : Form
    {
        public frmHoaDonChiTiet()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_ChiTietHoaDon bus_cthd = new BUS_ChiTietHoaDon();
        BUS_HoaDon bus_hd = new BUS_HoaDon();
        BUS_SanPham bus_sp = new BUS_SanPham();
        BUS_KhoHang bus_kh = new BUS_KhoHang();
        BUS_KhachHang bus_khachhang = new BUS_KhachHang();
        BUS_KhuyenMai bus_km = new BUS_KhuyenMai();
        BUS_NhanVien bus_nv = new BUS_NhanVien();
        BUS_Log bus_log = new BUS_Log();
        string data_olds = string.Empty;
        string data_news = string.Empty;
        DataValidation dv = new DataValidation();
        int soLuongInput = 0;
        int tongTien = 0;

        public void LoadFirst()
        {
            // Active
            btnThemHD.Enabled = true;
            btnCTHD.Enabled = true;
            cboMaKH.Enabled = true;
            cboMaKM.Enabled = true;
            cboMaNV.Enabled = true;

            // cboMaKH
            cboMaKH.DataSource = bus_khachhang.LayDSKH();
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "id";
            cboMaKH.SelectedIndex = 0;

            // cboMaKM
            cboMaKM.DataSource = bus_km.GetListKM();
            cboMaKM.DisplayMember = "TenKhuyenMai";
            cboMaKM.ValueMember = "id";
            cboMaKM.SelectedIndex = 0;

            // cboMaNV
            cboMaNV.DataSource = bus_nv.GetListNV();
            cboMaNV.DisplayMember = "TenNhanVien";
            cboMaNV.ValueMember = "id";
            cboMaNV.SelectedIndex = 0;

            // DeactiveControlsCTHD
            DeactiveControlsCTHD();

            // Dgvs
            dgvCTHD.Enabled = false;
            dgvSP.Enabled = false;

            // Other
            btnTimHd.Visible = false;
        }

        public void DeactiveControlsCTHD()
        {
            // Buttons
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimHd.Enabled = false;
            btnTimSp.Enabled = false;
            btnTinhTongTien.Enabled = false;
            btnLuuCTHD.Enabled = false;
            btnLamMoiCTHD.Enabled = false;
            btnIn.Enabled = false;

            // Cbos
            cboMaHD.Enabled = false;
            cboMaSP.Enabled = false;
            cboTimKiemSp.Enabled = false;

            // Txts
            txtSoLuong.Enabled = false;
            txtSoLuong.Text = "0";
            txtTongTien.Enabled = false;
            txtTongTien.Text = "0";
            txtTimKiemMaHd.Enabled = false;
            txtTimKiemMaHd.Text = "";
            txtTimKiemMaHd.Enabled = false;
            txtTimKiemSp.Text = "";
            txtTimKiemSp.Enabled = false;
            txtTimKiemMaHd.Visible = false;
            guna2HtmlLabel6.Visible = false;

            // Dgvs
            dgvSP.Enabled = false;
            dgvCTHD.Enabled = false;
            dgvSP.DataSource = false;
            dgvCTHD.DataSource = false;
        }

        public void ResetFirst()
        {
            LoadFirst();
        }

        public void DeactiveControlsHD()
        {
            // Btns
            btnThemHD.Enabled = false;
            btnLamMoi.Enabled = false;

            // Cbos
            cboMaKH.Enabled = false;
            cboMaKM.Enabled = false;
            cboMaNV.Enabled = false;
        }

        public void LoadData()
        {
            // Others
            txtSoLuong.Focus();
            txtSoLuong.Enabled = true;
            txtSoLuong.Text = "0";
            txtTongTien.Enabled = false;
            txtTongTien.Text = "0";
            soLuongInput = 0;
            data_olds = string.Empty;
            data_news = string.Empty;
            tongTien = 0;
            txtTimKiemMaHd.Enabled = true;
            txtTimKiemMaHd.Text = "";
            txtTimKiemSp.Enabled = true;
            txtTimKiemSp.Text = "";

            // Btns
            btnTimHd.Enabled = true;
            btnTimSp.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTinhTongTien.Enabled = true;
            btnLuuCTHD.Enabled = true;
            btnLamMoiCTHD.Enabled = true;
            btnLamMoi.Enabled = true;
            btnCTHD.Enabled = false;
            btnIn.Enabled = true;

            // Cbos
            cboMaHD.Enabled = true;
            cboMaSP.Enabled = true;
            cboTimKiemSp.Enabled = true;

            // Dgvs
            dgvSP.Enabled = true;
            dgvCTHD.Enabled = true;

            // cboMaHD
            cboMaHD.DataSource = bus_hd.GetListHD4();
            cboMaHD.DisplayMember = "MaHoaDon";
            cboMaHD.ValueMember = "id";
            cboMaHD.SelectedIndex = 0;

            // cboMaSP
            cboMaSP.DataSource = bus_sp.GetListSP();
            cboMaSP.DisplayMember = "TenSanPham";
            cboMaSP.ValueMember = "id";
            cboMaSP.SelectedIndex = 0;

            // cboSanPham
            cboTimKiemSp.SelectedIndex = 0;

            // dgvSP
            dgvSP.DataSource = bus_sp.GetListSP();
            dgvSP.Columns[0].HeaderText = "Id";
            dgvSP.Columns[1].HeaderText = "Mã sản phẩm";
            dgvSP.Columns[2].HeaderText = "Tên sản phẩm";
            dgvSP.Columns[3].HeaderText = "Đơn vị tính";
            dgvSP.Columns[4].HeaderText = "Đơn giá";
            dgvSP.Columns[5].HeaderText = "Số lượng";
            dgvSP.Columns[0].Visible = false;
            dgvSP.Columns[1].Visible = false;
            //dgvSP.Columns[4].DefaultCellStyle.Format = "#,###";

        }

        public void LoadDataByMaHd(int idMaHd)
        {
            // Others
            txtSoLuong.Focus();
            txtSoLuong.Enabled = true;
            txtSoLuong.Text = "0";
            txtTongTien.Enabled = false;
            txtTongTien.Text = "0";
            soLuongInput = 0;
            data_olds = string.Empty;
            data_news = string.Empty;
            tongTien = 0;
            txtTimKiemMaHd.Enabled = true;
            txtTimKiemMaHd.Text = "";
            txtTimKiemMaHd.Enabled = true;
            txtTimKiemSp.Text = "";
            btnTimSp.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTinhTongTien.Enabled = true;
            btnLuuCTHD.Enabled = true;
            cboMaHD.Enabled = true;
            cboMaSP.Enabled = true;
            dgvSP.Enabled = true;
            dgvCTHD.Enabled = true;

            // cboMaHD
            cboMaHD.DataSource = bus_hd.GetListHD();
            cboMaHD.DisplayMember = "MaHoaDon";
            cboMaHD.ValueMember = "id";
            cboMaHD.SelectedIndex = idMaHd;

            // cboMaSP
            cboMaSP.DataSource = bus_sp.GetListSP();
            cboMaSP.DisplayMember = "TenSanPham";
            cboMaSP.ValueMember = "id";
            cboMaSP.SelectedIndex = 0;

            // cboSanPham
            cboTimKiemSp.SelectedIndex = 0;

            // dgvSP
            dgvSP.DataSource = bus_sp.GetListSP();
            dgvSP.Columns[0].HeaderText = "Id";
            dgvSP.Columns[1].HeaderText = "Mã sản phẩm";
            dgvSP.Columns[2].HeaderText = "Tên sản phẩm";
            dgvSP.Columns[3].HeaderText = "Đơn vị tính";
            dgvSP.Columns[4].HeaderText = "Đơn giá";
            dgvSP.Columns[5].HeaderText = "Số lượng";
            dgvSP.Columns[0].Visible = false;
            dgvSP.Columns[1].Visible = false;
            //dgvSP.Columns[4].DefaultCellStyle.Format = "#,###";

        }

        public void Reset()
        {
            LoadData();
        }

        public bool CheckData(int idSanPham, string soLuong)
        {
            // Initialize Variables
            int count = 0;
            int soLuongSpTrongKho = bus_sp.GetSoLuongSpTrongKho(idSanPham);

            // Checked soLuong
            if (dv.CheckSoLuongSp(idSanPham, soLuong))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"Giá trị phải nhập số, giá trị từ 1 -> {soLuongSpTrongKho}!",
                   "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }

            if (count == 1)
            {
                return true;
            }
            return false;
        }

        private void frmChiTietHoaDon_Load(object sender, System.EventArgs e)
        {
            //LoadData();
            LoadFirst();
        }

        private void btnLamMoi_Click(object sender, System.EventArgs e)
        {
            //Reset();
            ResetFirst();
        }

        private void frmChiTietHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form không?", "Thông báo",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Warning);

            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void dgvSP_Click(object sender, System.EventArgs e)
        {
            if (dgvSP.CurrentCell != null)
            {
                // Get row index selected
                int n = dgvSP.CurrentCell.RowIndex;

                // cboMaSP
                cboMaSP.SelectedIndex = int.Parse(dgvSP.Rows[n].Cells[0].Value.ToString()) - 1;

                // Others
                txtTimKiemMaHd.Text = string.Empty;
                txtTimKiemSp.Text = string.Empty;
            }
            else
            {
                // Messaged
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void dgvCTHD_Click(object sender, System.EventArgs e)
        {
            if (dgvCTHD.CurrentCell != null)
            {
                // Get row index selected
                int n = dgvCTHD.CurrentCell.RowIndex;

                // cboMaHD
                cboMaHD.SelectedIndex = int.Parse(dgvCTHD.Rows[n].Cells[6].Value.ToString()) - 1;
                cboMaSP.SelectedIndex = int.Parse(dgvCTHD.Rows[n].Cells[7].Value.ToString()) - 1;
                txtSoLuong.Text = dgvCTHD.Rows[n].Cells[3].Value.ToString();

                // Others
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                cboMaHD.Enabled = false;
                cboMaSP.Enabled = false;
                dgvSP.Enabled = false;
                txtTimKiemMaHd.Text = string.Empty;
                txtTimKiemSp.Text = string.Empty;
            }
            else
            {
                // Messaged
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void cboMaHD_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // dgvCTHD
            dgvCTHD.DataSource = bus_cthd.GetListCTHDTheoMaHD(bus_hd.GetHdByMaHD(cboMaHD.Text));
            dgvCTHD.Columns[0].HeaderText = "Id CTHD";
            dgvCTHD.Columns[1].HeaderText = "Mã hóa đơn";
            dgvCTHD.Columns[2].HeaderText = "Tên sản phẩm";
            dgvCTHD.Columns[3].HeaderText = "Số lượng";
            dgvCTHD.Columns[4].HeaderText = "Đơn giá";
            dgvCTHD.Columns[5].HeaderText = "Thành tiền";
            dgvCTHD.Columns[6].HeaderText = "Id hóa đơn";
            dgvCTHD.Columns[7].HeaderText = "Id sản phẩm";
            dgvCTHD.Columns[0].Visible = false;
            dgvCTHD.Columns[6].Visible = false;
            dgvCTHD.Columns[7].Visible = false;
            //dgvCTHD.Columns[4].DefaultCellStyle.Format = "#,###";
            //dgvCTHD.Columns[5].DefaultCellStyle.Format = "#,###";

            // Others
            txtTongTien.Text = "0";
            tongTien = 0;
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (CheckData(cboMaSP.SelectedIndex + 1, txtSoLuong.Text))
                {
                    // Checked idSp, idHd saved in CTHD
                    if (!bus_cthd.CheckCTHDByIdHdIdSp(cboMaHD.SelectedIndex + 1, cboMaSP.SelectedIndex + 1))
                    {
                        // Added new record ChiTietHoaDon
                        bus_cthd.AddCTHD(new DTO_ChiTietHoaDon(int.Parse(txtSoLuong.Text),
                            cboMaHD.SelectedIndex + 1,
                            cboMaSP.SelectedIndex + 1));

                        // Get soLuongInput
                        soLuongInput = int.Parse(txtSoLuong.Text);

                        // Updated SoLuongSp in table KhoHang
                        bus_kh.UpdateSoLuongSP(cboMaSP.SelectedIndex + 1, soLuongInput);

                        // Added new record Log
                        int model_id = bus_cthd.GetMaxIdCTHD();
                        data_news = $"SoLuong: {txtSoLuong.Text}\n" +
                            $"idMaHD: {(cboMaHD.SelectedIndex + 1).ToString()}\n" +
                            $"idMaSP: {(cboMaSP.SelectedIndex + 1).ToString()}";

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("CTHD", model_id, "Add a new record ChiTietHoaDon", data_olds, data_news));

                        // LoadDataByMaHd
                        LoadDataByMaHd(cboMaHD.SelectedIndex);

                    }
                    else
                    {
                        // Messaged
                        MessageBox.Show($"Sản phẩm đã có trong chi tiết hóa đơn hiện tại!\n" +
                            $"Chỉ cập nhật lại số lượng", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        // Get SoLuongOld in CTHD
                        int soLuongOld = bus_cthd.GetSoLuongSpInCTHD(cboMaHD.SelectedIndex + 1,
                            cboMaSP.SelectedIndex + 1);

                        // Updated SoLuongSp in table CTHD
                        bus_cthd.UpdateSoLuongSpInCTHD(int.Parse(txtSoLuong.Text),
                            cboMaHD.SelectedIndex + 1,
                            cboMaSP.SelectedIndex + 1);

                        // Get SoLuongSpInput
                        soLuongInput = int.Parse(txtSoLuong.Text);

                        // Updated SoLuongSp in table KhoHang
                        bus_kh.UpdateSoLuongSP(cboMaSP.SelectedIndex + 1, soLuongInput);

                        // Added new record Log
                        int model_id = bus_cthd.GetMaxIdCTHD();
                        data_news = $"SoLuong: {soLuongOld}\n" +
                            $"idMaHD: {(cboMaHD.SelectedIndex + 1).ToString()}\n" +
                            $"idMaSP: {(cboMaSP.SelectedIndex + 1).ToString()}";
                        data_news = $"SoLuong: {soLuongInput}\n" +
                            $"idMaHD: {(cboMaHD.SelectedIndex + 1).ToString()}\n" +
                            $"idMaSP: {(cboMaSP.SelectedIndex + 1).ToString()}";

                        // Saved log
                        bus_log.AddLog3(new DTO_Log("CTHD", model_id, "Update SoLuong a record ChiTietHoaDon", data_olds, data_news));

                        // LoadDataByMaHd
                        LoadDataByMaHd(cboMaHD.SelectedIndex);
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckData(cboMaSP.SelectedIndex + 1, txtSoLuong.Text))
                {
                    // Checked idSp, idHd saved in CTHD
                    if (bus_cthd.CheckCTHDByIdHdIdSp(cboMaHD.SelectedIndex + 1, cboMaSP.SelectedIndex + 1))
                    {
                        int currentId = int.Parse(dgvCTHD.CurrentRow.Cells[0].Value.ToString());

                        DialogResult dr = MessageBox.Show($"Bạn có chắc muốn cập nhật số lượng của sản phẩm {dgvCTHD.CurrentRow.Cells[2].Value.ToString()} không?",
                            "Thông báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            // GetSoLuongCurrent in CTHD
                            int soLuongCurrent = bus_cthd.GetSoLuongSpInCTHD(cboMaHD.SelectedIndex + 1,
                                cboMaSP.SelectedIndex + 1);

                            // Updated SoLuongSp in table CTHD
                            bus_cthd.UpdateCTHD(new DTO_ChiTietHoaDon(currentId, int.Parse(txtSoLuong.Text),
                                cboMaHD.SelectedIndex + 1,
                                cboMaSP.SelectedIndex + 1));

                            // GetSoLuongCurrent in CTHD
                            int soLuongUpdate = bus_cthd.GetSoLuongSpInCTHD(cboMaHD.SelectedIndex + 1,
                                cboMaSP.SelectedIndex + 1);

                            // Get soLuongNew
                            int soLuongNew = soLuongUpdate - soLuongCurrent;

                            // Updated SoLuongSp in table KhoHang
                            bus_kh.UpdateSoLuongSP(cboMaSP.SelectedIndex + 1, soLuongNew);

                            // Added new record Log
                            int model_id = bus_cthd.GetMaxIdCTHD();
                            data_olds = $"SoLuong: {soLuongCurrent}\n" +
                                $"idMaHD: {(cboMaHD.SelectedIndex + 1).ToString()}\n" +
                                $"idMaSP: {(cboMaSP.SelectedIndex + 1).ToString()}";
                            data_news = $"SoLuong: {soLuongUpdate}\n" +
                                $"idMaHD: {(cboMaHD.SelectedIndex + 1).ToString()}\n" +
                                $"idMaSP: {(cboMaSP.SelectedIndex + 1).ToString()}";

                            // Saved log
                            bus_log.AddLog3(new DTO_Log("CTHD", model_id, "Update a record ChiTietHoaDon", data_olds, data_news));

                            // LoadDataByMaHd
                            LoadDataByMaHd(cboMaHD.SelectedIndex);
                        }
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckData(cboMaSP.SelectedIndex + 1, txtSoLuong.Text))
                {
                    // Checked idSp, idHd saved in CTHD
                    if (bus_cthd.CheckCTHDByIdHdIdSp(cboMaHD.SelectedIndex + 1, cboMaSP.SelectedIndex + 1))
                    {
                        int currentId = int.Parse(dgvCTHD.CurrentRow.Cells[0].Value.ToString());

                        DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {dgvCTHD.CurrentRow.Cells[2].Value.ToString()} không?",
                            "Thông báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            // GetSoLuongCurrent in CTHD
                            int soLuongCurrent = bus_cthd.GetSoLuongSpInCTHD(cboMaHD.SelectedIndex + 1,
                                cboMaSP.SelectedIndex + 1);

                            //// Updated SoLuongSp in table CTHD
                            //bus_cthd.DeleteCTHD(currentId);

                            //// GetSoLuongCurrent in CTHD
                            //int soLuongUpdate = bus_cthd.GetSoLuongSpInCTHD2(cboMaHD.SelectedIndex + 1,
                            //    cboMaSP.SelectedIndex + 1);

                            // Updated SoLuongSp in table CTHD
                            bus_cthd.DeleteCTHD2(currentId);

                            // GetSoLuongCurrent in CTHD
                            int soLuongUpdate = 0;

                            // Get soLuongNew
                            int soLuongNew = soLuongUpdate - soLuongCurrent;

                            // Updated SoLuongSp in table KhoHang
                            bus_kh.UpdateSoLuongSP(cboMaSP.SelectedIndex + 1, soLuongNew);

                            // Added new record Log
                            int model_id = bus_cthd.GetMaxIdCTHD();
                            data_olds = $"SoLuong: {soLuongCurrent}\n" +
                                $"idMaHD: {(cboMaHD.SelectedIndex + 1).ToString()}\n" +
                                $"idMaSP: {(cboMaSP.SelectedIndex + 1).ToString()}";
                            data_news = $"SoLuong: {soLuongUpdate}\n" +
                                $"idMaHD: {(cboMaHD.SelectedIndex + 1).ToString()}\n" +
                                $"idMaSP: {(cboMaSP.SelectedIndex + 1).ToString()}";

                            // Saved log
                            bus_log.AddLog3(new DTO_Log("CTHD", model_id, "Delete a record ChiTietHoaDon", data_olds, data_news));

                            Reset();
                        }
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
        }

        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text == "0")
            {
                txtTongTien.Text = bus_cthd.GetTotalCashByIdHd(cboMaHD.SelectedIndex + 1).ToString();
            }
            else
            {
                MessageBox.Show($"Đã tính tổng tiền của chi tiết hóa đơn!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnLuuCTHD_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text != "0")
            {
                DialogResult dr = MessageBox.Show($"Bạn có chắc muốn cập nhật tổng tiền cho hóa đơn {dgvCTHD.CurrentRow.Cells[1].Value.ToString()} không?",
                                    "Thông báo",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    bus_hd.UpdateTotalCash(cboMaHD.SelectedIndex + 1, int.Parse(txtTongTien.Text));

                    Reset();
                }
            }
            else
            {
                MessageBox.Show($"Chưa tính tổng tiền của chi tiết hóa đơn!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnTimHd_Click(object sender, EventArgs e)
        {
            if (dv.IsValidString2(txtTimKiemMaHd.Text))
            {
                // dgvCTHD
                dgvCTHD.DataSource = bus_cthd.SearchListCTHDByMaHD(txtTimKiemMaHd.Text);
                dgvCTHD.Columns[0].HeaderText = "Id CTHD";
                dgvCTHD.Columns[1].HeaderText = "Mã hóa đơn";
                dgvCTHD.Columns[2].HeaderText = "Tên sản phẩm";
                dgvCTHD.Columns[3].HeaderText = "Số lượng";
                dgvCTHD.Columns[4].HeaderText = "Đơn giá";
                dgvCTHD.Columns[5].HeaderText = "Thành tiền";
                dgvCTHD.Columns[6].HeaderText = "Id hóa đơn";
                dgvCTHD.Columns[7].HeaderText = "Id sản phẩm";
                dgvCTHD.Columns[0].Visible = false;
                dgvCTHD.Columns[6].Visible = false;
                dgvCTHD.Columns[7].Visible = false;
            }
            else
            {
                MessageBox.Show($"Nội dung tìm kiếm không để trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnTimSp_Click(object sender, EventArgs e)
        {
            if (txtTimKiemSp.Text.Trim() != string.Empty)
            {
                if (cboTimKiemSp.SelectedIndex == 0)
                {
                    // dgvSp
                    dgvSP.DataSource = bus_sp.SearchSpByTenSP(txtTimKiemSp.Text);
                    dgvSP.Columns[0].HeaderText = "Id";
                    dgvSP.Columns[1].HeaderText = "Mã sản phẩm";
                    dgvSP.Columns[2].HeaderText = "Tên sản phẩm";
                    dgvSP.Columns[3].HeaderText = "Đơn vị tính";
                    dgvSP.Columns[4].HeaderText = "Đơn giá";
                    dgvSP.Columns[5].HeaderText = "Số lượng";
                    dgvSP.Columns[0].Visible = false;
                    dgvSP.Columns[1].Visible = false;
                }
                else
                {
                    // dgvSp
                    dgvSP.DataSource = bus_sp.SearchSpByDVT(txtTimKiemSp.Text);
                    dgvSP.Columns[0].HeaderText = "Id";
                    dgvSP.Columns[1].HeaderText = "Mã sản phẩm";
                    dgvSP.Columns[2].HeaderText = "Tên sản phẩm";
                    dgvSP.Columns[3].HeaderText = "Đơn vị tính";
                    dgvSP.Columns[4].HeaderText = "Đơn giá";
                    dgvSP.Columns[5].HeaderText = "Số lượng";
                    dgvSP.Columns[0].Visible = false;
                    dgvSP.Columns[1].Visible = false;
                }
            }
            else
            {
                MessageBox.Show($"Nội dung tìm kiếm không để trống, chỉ nhập chữ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn tạo hóa đơn mới không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    bus_hd.AddHD(new DTO_HoaDon(int.Parse(cboMaKH.SelectedValue.ToString()), int.Parse(cboMaKM.SelectedValue.ToString()), int.Parse(cboMaNV.SelectedValue.ToString())));

                    int model_id = bus_hd.GetMaxIdHD();

                    data_news = $"MaKH: {cboMaKH.SelectedValue.ToString()} \n" +
                        $"MaKM: {cboMaKM.SelectedValue.ToString()} \n" +
                        $"MaNV: {cboMaNV.SelectedValue.ToString()}";

                    // Saved log
                    bus_log.AddLog3(new DTO_Log("HoaDon", model_id, "Add a new record HoaDon", data_olds, data_news));

                    // DeactiveControlsHD
                    DeactiveControlsHD();

                    // Load ControlsCTHD
                    Reset();

                    // cboMaHD
                    cboMaHD.SelectedValue = model_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            // DeactiveControlsHD
            DeactiveControlsHD();

            // Load Controls CTHD
            LoadData();
        }

        private void btnLamMoiCTHD_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // SearchHDById
            string maHD = bus_hd.SearchHDById(cboMaHD.SelectedIndex + 1);

            if (maHD != string.Empty)
            {
                frmInHD f = new frmInHD(maHD);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Mã hóa đơn không có trong dữ liệu, không thể in hóa đơn!",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }
        }
    }
}
