using BUS;
using DTO;
using Guna.UI2.WinForms;
using NguyenQuocLuong_21211tt4642;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //mảng sản phẩm
        List<DTO_SanPhamKhoHang> sanPhams;
        public frmBanHang()
        {
            InitializeComponent();
            sanPhams = bus_SanPham.ListSanPham();
        }


        private void frmBanHang_Load(object sender, EventArgs e)
        {
            try
            {
                //gọi gàm load combobox
                LoadCbLoaiSanPham();
                LoadNhaCungCap();
                //load sản phẩm
                LoadLayoutSanPham();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi: "+ex.Message,"Thoát",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
        private void LoadNhaCungCap()
        {
            cbNhaCungCap.DataSource = bus_nhacungcap.LayDSNCC();
            cbNhaCungCap.DisplayMember = "TenNCC";
            cbNhaCungCap.ValueMember = "id";
        }
        //load sản phẩm
        private void LoadLayoutSanPham()
        {
            //làm sạch
            layoutSanPham.Controls.Clear();
            foreach (DTO_SanPhamKhoHang sanpham in sanPhams)
            {

                //tạo thẻ sản phẩm
                CardItem item = new CardItem();
                item.TenSanPham = sanpham.TenSanPham;
                item.Gia = "Giá: " + sanpham.GiaBan.ToString() + " VNĐ";
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
                CardItem cardItem = (CardItem)sender;
                DTO_SanPhamKhoHang sp = sanPhams.Find(p => p.Id == int.Parse(cardItem.Name.ToString()));
                txtTenSanPham.Text = sp.TenSanPham;
                txtGia.Text = sp.GiaBan.ToString();
                txtMaSanPham.Text = sp.MaSanPham;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Xảy ra lỗi: " + ex.Message, "Thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
