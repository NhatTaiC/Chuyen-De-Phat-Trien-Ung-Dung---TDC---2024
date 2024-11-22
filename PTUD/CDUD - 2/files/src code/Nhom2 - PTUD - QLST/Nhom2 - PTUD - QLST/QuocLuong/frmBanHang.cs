﻿using BUS;
using DTO;
using Microsoft.VisualBasic;
using NguyenQuocLuong_21211tt4642;
using Nhom2___PTUD___QLST;
using Nhom2___PTUD___QLST.NhatTai;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBanHang : Form
    {
        //biến cờ;
        bool isClick = false;
        //bus loai hàng
        BUS_LoaiHang bus_loaihang = new BUS_LoaiHang();
        //bus nhà cung cấp
        BUS_NhaCungCap bus_nhacungcap = new BUS_NhaCungCap();
        //bus nhà sản phẩm
        BUS_SanPham bus_SanPham = new BUS_SanPham();
        //bus nhà kho hàng
        BUS_KhoHang bus_khohang = new BUS_KhoHang();
        //bus hóa đơn
        BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
        //bus chi tiết hóa đơn
        BUS_ChiTietHoaDon bus_chitiethoadon = new BUS_ChiTietHoaDon();
        //mảng sản phẩm
        List<DTO_SanPhamKhoHang> sanPhams;
        List<DTO_SanPhamKhoHang> TimKiemMasanPhams;
        //format tien
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        //currentGia
        double giaHientai = 0;
        //idHienTai
        int idHienTai = 0;
        //thanh tiền
        double thanhTien = 0;
        // bus khach hàng
        BUS_KhachHang bus_KhachHang = new BUS_KhachHang();
        //khach hàng
        DTO_KhachHang khachhang;
        //DTO Nhan vien
        DTO_NhanVien nhanvien;
        //bus Khuyen mai
        BUS_KhuyenMai bus_khuyenmai;

        public static bool CheckMaKhuyenMai { get; internal set; }
        public static int idKhuyenMai { get; internal set; }

        public frmBanHang()
        {
            InitializeComponent();
            sanPhams = bus_SanPham.ListSanPham();
            dgvThongTinHoaDon.Columns["MaSanPham"].Visible = false;
            dgvThongTinHoaDon.Columns["id"].Visible = false;
            lbThanhTien.Text = "0 VNĐ";
            txtTienDua.MaxLength = 8;
            nhanvien = frmMain.nhanVien;
            //khachhang = bus_KhachHang.LayKhachHang("0123456744");
            //TimKiemMasanPhams = ListTimKiemSanPhamBangMa("SP01");
        }


        private void frmBanHang_Load(object sender, EventArgs e)
        {
            
            try
            {
                //MessageBox.Show(khachhang.TenKhachHang);
                //gọi gàm load combobox
                LoadCbLoaiSanPham();
                //LoadNhaCungCap();
                //load sản phẩm
                LoadLayoutSanPham(sanPhams);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi: " + ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //load cb
        private void LoadCbLoaiSanPham()
        {
            //lấy danh sach loại hàng
            cbLoaiSanPham.DataSource = bus_loaihang.LayDSLoaiHang();
            cbLoaiSanPham.DisplayMember = "TenLoaiHang";
            cbLoaiSanPham.ValueMember = "id";

            //add
            //this.Controls.Add(labelInvisible);
            //labelInvisible.Visible = false;
        }
        //load cb
        //private void LoadNhaCungCap()
        //{
        //    // Gán DataSource cho ComboBox với dữ liệu đã kết hợp
        //    cbNhaCungCap.DataSource = bus_nhacungcap.LayDSNCC();  // Chuyển thành List khi gán vào ComboBox
        //    cbNhaCungCap.DisplayMember = "TenNCC";
        //    cbNhaCungCap.ValueMember = "id";
        //}
        private List<DTO_SanPhamKhoHang> timKiemSanPhamBangMa(string tukhoa)
        {
            var ketQua = sanPhams.Where(sp => sp.MaSanPham.ToLower().Contains(tukhoa.ToLower())).ToList();
            return ketQua;
        }
        private List<DTO_SanPhamKhoHang> timKiemSanPhamBangLoaiHang(int idLoaiHang)
        {
            var ketQua = sanPhams.Where(sp => sp.IdLoaiHang == idLoaiHang).ToList();
            return ketQua;
        }
        //load sản phẩm
        private void LoadLayoutSanPham(List<DTO_SanPhamKhoHang> listSanPham)
        {
            //làm sạch
            layoutSanPham.Controls.Clear();
            foreach (DTO_SanPhamKhoHang sanpham in listSanPham)
            {

                //tạo thẻ sản phẩm
                CardItem item = new CardItem();
                item.TenSanPham = sanpham.TenSanPham;
                item.Gia = "Giá: " + sanpham.GiaBan.ToString("#,###", cul.NumberFormat) + " VNĐ";
                item.SoLuong = "Sẵn có: " + sanpham.SoLuong.ToString();
                item.Size = new Size(100, 110);
                item.Name = sanpham.Id.ToString();
                var data = sanpham.AnhSanPham;
                // Kiểm tra kiểu dữ liệu của imageData
                if (data != null)
                {
                    if (data is System.Data.Linq.Binary binaryData)
                    {
                        byte[] byteArray = binaryData.ToArray(); // Chuyển đổi sang byte array
                                                                 //gán giá trị để kiểm tra
                                                                 //imageData = byteArray;
                        using (MemoryStream ms = new MemoryStream(byteArray))
                        {
                            Image image = Image.FromStream(ms);
                            item.AnhSanPham = image; // Gán hình ảnh vào PictureBox
                        }
                    }
                }
                else
                {
                    item.AnhSanPham = null;
                }
                // Gán sự kiện click cho toàn bộ item
                item.Click += new EventHandler(Item_Click);

                // Gán sự kiện cho các control bên trong và truyền CardItem làm sender
                item.pbSanPham.Click += (s, e) => Item_Click(item, e);
                item.lbGia.Click += (s, e) => Item_Click(item, e);
                item.lbTenSanPham.Click += (s, e) => Item_Click(item, e);
                item.lbSoLuong.Click += (s, e) => Item_Click(item, e);
                //wq
                layoutSanPham.Controls.Add(item);


            }
        }

        private void Item_Click(object sender, EventArgs e)
        {

            try
            {
                // Tạm thời hủy đăng ký sự kiện txtMaSanPham.TextChanged
                txtMaSanPham.TextChanged -= txtMaSanPham_TextChanged;
                CardItem cardItem = (CardItem)sender;
                DTO_SanPhamKhoHang sp = sanPhams.Find(p => p.Id == int.Parse(cardItem.Name.ToString()));
                txtTenSanPham.Text = sp.TenSanPham;
                txtGia.Text = sp.GiaBan.ToString("#,###", cul.NumberFormat);
                txtMaSanPham.Text = sp.MaSanPham;
                giaHientai = sp.GiaBan;
                idHienTai = sp.Id;
                txtSoLuong.Text = "1";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi: " + ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMaSanPham.TextChanged += txtMaSanPham_TextChanged;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSanPham.Text.Length > 0)
                {
                    DTO_SanPhamKhoHang sanPham = sanPhams.Find(sp => sp.MaSanPham == txtMaSanPham.Text);
                    if (sanPham != null)
                    {
                        if (txtSoLuong.Text.Trim().Length == 0)
                        {
                            throw new Exception("Vui lòng nhập số lượng!");
                        }
                        if (int.Parse(txtSoLuong.Text) <= 0)
                        {
                            throw new Exception("Số lượng không hợp lệ!");
                        }
                        if (sanPham.SoLuong >= int.Parse(txtSoLuong.Text))
                        {
                            if (KtMaSanPhamCoTrung(sanPham.MaSanPham))
                            {
                                XuLiThemTrungMa(sanPham.MaSanPham, int.Parse(txtSoLuong.Text));

                            }
                            else
                            {
                                DataGridViewRow newRow = new DataGridViewRow();
                                newRow.CreateCells(dgvThongTinHoaDon);
                                newRow.Cells[0].Value = txtTenSanPham.Text;
                                newRow.Cells[1].Value = txtGia.Text;
                                newRow.Cells[2].Value = txtSoLuong.Text;
                                newRow.Cells[3].Value = (giaHientai * float.Parse(txtSoLuong.Text)).ToString("#,###", cul.NumberFormat);
                                newRow.Cells[4].Value = sanPham.MaSanPham;
                                newRow.Cells[5].Value = (sanPham.Id);
                                dgvThongTinHoaDon.Rows.Add(newRow);
                            }
                            //Cập nhật số lượng trong list
                            sanPham.SoLuong -= int.Parse(txtSoLuong.Text);
                            //cập nhật list
                            //LoadLayoutSanPham(sanPhams);
                            //lb thanh tien
                            lbThanhTien.Text = tinhThanhTien();
                            //làm mới
                            LamMoi();

                        }
                        else
                        {
                            MessageBox.Show("Số lượng trong kho không đủ vui lòng kiểm tra lại!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã sản phẩm không hợp lệ!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //kiểm tra mã sản phẩm có trùng trong giỏ hàng không
        private bool KtMaSanPhamCoTrung(string maSanPham)
        {
            bool flag = false;
            for (int i = 0; i < dgvThongTinHoaDon.Rows.Count; i++)
            {
                if (dgvThongTinHoaDon.Rows[i].Cells["MaSanPham"].Value.ToString() == maSanPham)
                {
                    flag = true;
                }
            }
            return flag;
        }
        //xử lí khi thêm vào giỏ hàng trung mã
        private void XuLiThemTrungMa(string maSanPham, int soLuong)
        {
            for (int i = 0; i < dgvThongTinHoaDon.Rows.Count; i++)
            {
                if (dgvThongTinHoaDon.Rows[i].Cells["MaSanPham"].Value.ToString() == maSanPham)
                {
                    DTO_SanPhamKhoHang sp = sanPhams.Find(x => x.MaSanPham == maSanPham);
                    dgvThongTinHoaDon.Rows[i].Cells["SoLuong"].Value = soLuong + int.Parse(dgvThongTinHoaDon.Rows[i].Cells["SoLuong"].Value.ToString());
                    dgvThongTinHoaDon.Rows[i].Cells["TongTien"].Value = (int.Parse(dgvThongTinHoaDon.Rows[i].Cells["SoLuong"].Value.ToString()) * sp.GiaBan).ToString("#,###", cul.NumberFormat);

                    //thanhTien += float.Parse(dgvDSHangMua.Rows[i].Cells[4].Value.ToString());

                }
            }
        }
        private void LamMoi()
        {
            txtGia.Clear();
            txtMaSanPham.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
            txtTenSanPham.Clear();
            txtTienDua.Clear();
            txtTienThua.Clear();
            ////xem lại tiền đưa
            mauTienDua_TinhTienThua();
            //frmInHD f = new frmInHD("HD001");
            //f.ShowDialog();

        }

        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {
            LoadLayoutSanPham(timKiemSanPhamBangMa(txtMaSanPham.Text));
        }

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Back && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Phải nhập số!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                txtSoLuong.Focus();
            }
        }
        private string tinhThanhTien()
        {
            string stringThanhTien = "";
            double tinhTien = 0;
            for (int i = 0; i < dgvThongTinHoaDon.Rows.Count; i++)
            {

                DTO_SanPhamKhoHang sanpham = sanPhams.Find(x => x.MaSanPham == dgvThongTinHoaDon.Rows[i].Cells["MaSanPham"].Value.ToString());
                double tongdong = 0;
                tongdong = double.Parse(dgvThongTinHoaDon.Rows[i].Cells["SoLuong"].Value.ToString()) * sanpham.GiaBan;
                tinhTien += tongdong;
            }
            thanhTien = tinhTien;
            stringThanhTien = thanhTien.ToString("#,###", cul.NumberFormat) + " VNĐ";
            return stringThanhTien;
        }
        private void txtTienDua_TextLeave(object sender, EventArgs e)
        {
            // Lấy chuỗi hiện tại và loại bỏ các dấu phân cách cũ
            string text = txtTienDua.Text.Replace(".", "").Trim();
            if (decimal.TryParse(text, out decimal amount))
            {
                // Định dạng lại chuỗi với phân cách hàng nghìn
                txtTienDua.Text = string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:N0}", amount);
                // Đặt con trỏ vào cuối
                txtTienDua.SelectionStart = txtTienDua.Text.Length;
            }
        }
        private void txtTienDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Back && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Vui lòng nhập số!!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                txtSoLuong.Focus();
            }

        }

        private void txtTienDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Tạm thời hủy đăng ký sự kiện txtTienDua_TextChanged
                txtTienDua.TextChanged -= txtTienDua_TextChanged;

                if (dgvThongTinHoaDon.Rows.Count == 0)
                {
                    MessageBox.Show("Thông tin hóa đơn rỗng. Vui lòng kiểm tra lại!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTienDua.Clear();
                }
                mauTienDua_TinhTienThua();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK);
            }
            finally
            {
                txtTienDua.TextChanged += txtTienDua_TextChanged;
            }

            // Loại bỏ dấu chấm khỏi chuỗi
            //string textWithoutDots = txtTienDua.Text.Replace(".", "");
            //if (txtTienDua.Text.Length > 8)
            //{
            //    // Giữ lại 8 ký tự đầu tiên và format lại chuỗi
            //    textWithoutDots = textWithoutDots.Substring(0, 8);
            //    txtTienDua.Text = FormatWithThousandSeparator(textWithoutDots);

            //    // Đặt lại vị trí con trỏ
            //    txtTienDua.SelectionStart = txtTienDua.Text.Length;
            //}
        }
        private void mauTienDua_TinhTienThua()
        {
            //MessageBox.Show(thanhTien.ToString());
            if (txtTienDua.Text.Replace(".", "").Length < 9 && txtTienDua.Text.Replace(".", "").Length != 0)
            {
                if (double.Parse(txtTienDua.Text.Replace(".", "")) < thanhTien)
                {
                    txtTienDua.ForeColor = Color.Red;
                }
                else
                {
                    txtTienDua.ForeColor = Color.Green;
                }
                txtTienThua.Text = (double.Parse(txtTienDua.Text.Replace(".", "")) - thanhTien).ToString("#,###", cul.NumberFormat);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            //làm sạch dgv
            dgvThongTinHoaDon.Rows.Clear();
            //đặt lại thành tiền sau khi thanh toán thành công
            lbThanhTien.Text = "0 VNĐ";

        }

        //thêm chi tiết hóa đơn thanh toán
        public void ThemChiTietHoaDon()
        {
            int idhoadon = bus_HoaDon.GetMaxIdHD();
            for (int i = 0; i < dgvThongTinHoaDon.Rows.Count; i++)
            {
                int idSanPham = int.Parse(dgvThongTinHoaDon.Rows[i].Cells["id"].Value.ToString());
                int soLuong = int.Parse(dgvThongTinHoaDon.Rows[i].Cells["SoLuong"].Value.ToString());
                DTO_ChiTietHoaDon dong = new DTO_ChiTietHoaDon(soLuong, idhoadon, idSanPham);
                bus_chitiethoadon.AddCTHD2(dong);
                bus_khohang.CapNhatSoLuong(idSanPham, soLuong);
            }

            // Cap nhat so luong
            int totalCTHD = bus_chitiethoadon.GetTotalCashByIdHd(idhoadon);
            bus_HoaDon.UpdateTotalCash2(idhoadon, totalCTHD);

            // In hóa đơn
            string maHoaDonMoiNhat = bus_HoaDon.TimMaHoaDon(bus_HoaDon.GetMaxIdHD());
            frmInHD f = new frmInHD(maHoaDonMoiNhat);
            f.ShowDialog();

        }

        private void cbLoc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbLoc.Checked)
                {
                    LoadLayoutSanPham(timKiemSanPhamBangLoaiHang(int.Parse(cbLoaiSanPham.SelectedValue.ToString())));
                }
                else
                {
                    LoadLayoutSanPham(sanPhams);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbLoc.Checked)
                {
                    LoadLayoutSanPham(timKiemSanPhamBangLoaiHang(int.Parse(cbLoaiSanPham.SelectedValue.ToString())));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvThongTinHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Thông tin hóa đơn rỗng. Vui lòng kiểm tra lại!", "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DialogResult resuft = MessageBox.Show("Bạn có chắc không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resuft == DialogResult.Yes)
            {
                dgvThongTinHoaDon.Rows.Clear();
                thanhTien = 0;
                lbThanhTien.Text = "0 VNĐ";
                LamMoi();
                sanPhams = bus_SanPham.ListSanPham();
                LoadLayoutSanPham(sanPhams);
            }
        }

        private void HoaDon(string maHoaDon)
        {
            try
            {
                frmInHD f = new frmInHD(maHoaDon);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongTinHoaDon.Rows.Count == 0)
                {
                    throw new Exception("Thông tin hóa đơn rỗng. Vui lòng kiểm tra lại!");
                }
                if (txtTienDua.Text.Length == 0)
                {
                    throw new Exception("Hãy nhập số tiền khách trả!");
                }
                if (double.Parse(txtTienDua.Text.Replace(".", "")) < thanhTien)
                {
                    throw new Exception("Vui lòng nhập đủ số tiền!!!");
                }
                if (khachhang != null) {
                    MessageBox.Show("Bạn thanh toán có tích điểm");
                    DialogResult resuft = MessageBox.Show("Bạn có mã khuyến mãi không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resuft == DialogResult.Yes)
                    {

                        frmApDungMaKhuyenMai frmApDungMaKM = new frmApDungMaKhuyenMai();
                        frmApDungMaKM.ShowDialog();
                        ThanhToanCoKhuyenMaiCoKhachHang(idKhuyenMai, khachhang.Id);
                    }
                    else
                    {
                        ThanhToanKhongCoKhuyenMaiCoKhachHang(khachhang.Id);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn thanh toán không có tích điểm");
                    DialogResult resuft = MessageBox.Show("Bạn có mã khuyến mãi không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resuft == DialogResult.Yes)
                    {

                        frmApDungMaKhuyenMai frmApDungMaKM = new frmApDungMaKhuyenMai();
                        frmApDungMaKM.ShowDialog();
                        ThanhToanCoKhuyenMaiCoKhachHang(idKhuyenMai, 1);
                    }
                    else
                    {
                        ThanhToan();
                    }
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoDienThoai_MouseLeave(object sender, EventArgs e)
        {
            khachhang = bus_KhachHang.LayKhachHang(txtSoDienThoai.Text);
            //MessageBox.Show(khachhang.TenKhachHang);
            if (khachhang != null)
            {
                txtTenKhachHang.Text = khachhang.TenKhachHang;
            }
            else
            {
                txtTenKhachHang.Text = "";
            }
        }
        private void ThanhToanCoKhuyenMaiKhongCoKhachHang(int idKhuyenMai)
        {
            if (nhanvien != null)
            {
                bus_HoaDon.AddHD2(new DTO_HoaDon(1, idKhuyenMai, nhanvien.Id));
            }
            else
            {
                bus_HoaDon.AddHD2(new DTO_HoaDon(1, idKhuyenMai, 1));
            }
            MessageBox.Show("Thanh toán thành công!", "Thoát", MessageBoxButtons.OK);
            //string maHDCustom = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace(":","").Replace("/","").Replace(" ","");
            //thêm hóa đơn

            //thêm chi tiết hóa đơn
            ThemChiTietHoaDon();

            LamMoi();
            //làm sạch dgv
            dgvThongTinHoaDon.Rows.Clear();
            //đặt lại thành tiền sau khi thanh toán thành công
            lbThanhTien.Text = "0 VNĐ";
        }
        private void ThanhToanCoKhuyenMaiCoKhachHang(int idKhuyenMai,int idKhachHang)
        {
            if (nhanvien != null)
            {
                bus_HoaDon.AddHD2(new DTO_HoaDon(idKhachHang, idKhuyenMai, nhanvien.Id));
            }
            else
            {
                bus_HoaDon.AddHD2(new DTO_HoaDon(idKhachHang, idKhuyenMai, 1));
            }
            MessageBox.Show("Thanh toán thành công!", "Thoát", MessageBoxButtons.OK);
            //string maHDCustom = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace(":","").Replace("/","").Replace(" ","");
            //thêm hóa đơn

            //thêm chi tiết hóa đơn
            ThemChiTietHoaDon();

            LamMoi();
            //làm sạch dgv
            dgvThongTinHoaDon.Rows.Clear();
            //đặt lại thành tiền sau khi thanh toán thành công
            lbThanhTien.Text = "0 VNĐ";
        }
        private void ThanhToan()
        {
            if (nhanvien != null)
            {
                bus_HoaDon.AddHD2(new DTO_HoaDon(1, 1, nhanvien.Id));
            }
            else
            {
                bus_HoaDon.AddHD2(new DTO_HoaDon(1, 1, 1));
            }
            MessageBox.Show("Thanh toán thành công!", "Thoát", MessageBoxButtons.OK);
            //string maHDCustom = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace(":","").Replace("/","").Replace(" ","");
            //thêm hóa đơn

            //thêm chi tiết hóa đơn
            ThemChiTietHoaDon();

            LamMoi();
            //làm sạch dgv
            dgvThongTinHoaDon.Rows.Clear();
            //đặt lại thành tiền sau khi thanh toán thành công
            lbThanhTien.Text = "0 VNĐ";
        }
        private void ThanhToanKhongCoKhachHangCoKhuyenMai(int idKhuyenMai)
        {
            if (nhanvien != null)
            {
                bus_HoaDon.AddHD2(new DTO_HoaDon(1,idKhuyenMai, nhanvien.Id));
            }
            else
            {
                bus_HoaDon.AddHD2(new DTO_HoaDon(1, idKhuyenMai, 1));
            }
            MessageBox.Show("Thanh toán thành công!", "Thoát", MessageBoxButtons.OK);
            //string maHDCustom = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace(":","").Replace("/","").Replace(" ","");
            //thêm hóa đơn

            //thêm chi tiết hóa đơn
            ThemChiTietHoaDon();

            LamMoi();
            //làm sạch dgv
            dgvThongTinHoaDon.Rows.Clear();
            //đặt lại thành tiền sau khi thanh toán thành công
            lbThanhTien.Text = "0 VNĐ";
        }
        private void ThanhToanKhongCoKhuyenMaiCoKhachHang(int idKhachHang)
        {
            if (nhanvien != null)
            {
                bus_HoaDon.AddHD2(new DTO_HoaDon(idKhachHang,1 , nhanvien.Id));
            }
            else
            {
                bus_HoaDon.AddHD2(new DTO_HoaDon(idKhachHang,1 , 1));
            }
            MessageBox.Show("Thanh toán thành công!", "Thoát", MessageBoxButtons.OK);
            //string maHDCustom = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace(":","").Replace("/","").Replace(" ","");
            //thêm hóa đơn

            //thêm chi tiết hóa đơn
            ThemChiTietHoaDon();

            LamMoi();
            //làm sạch dgv
            dgvThongTinHoaDon.Rows.Clear();
            //đặt lại thành tiền sau khi thanh toán thành công
            lbThanhTien.Text = "0 VNĐ";
        }
    }
}
