using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuocLuong_21211tt4642
{
    public partial class CardItem : UserControl
    {

        public CardItem()
        {
            InitializeComponent();
            //this.pbSanPham.Click += (s, e) => this.OnClick(e);
            //this.lbnameSanPham.Click += (s, e) => this.OnClick(e);
            //this.lbGia.Click += (s, e) => this.OnClick(e);
            //this.lbSoLuong.Click += (s, e) => this.OnClick(e);
            //foreach (Control control in this.Controls)
            //{
            //    control.Click += (s, e) => this.OnClick(e); // Chuyển click từ các thành phần con đến CardItem
            //}
        }
        //protected override void OnClick(EventArgs e)
        //{
        //    base.OnClick(e);
        //    this.InvokeOnClick(this, e);
        //}
        public Image AnhSanPham
        {
            get
            {
                return imgProduct.Image;
            }
            set
            {
                imgProduct.Image = value;
            }
        }
        public string TenSanPham
        {
            get { return lbTenSanPham.Text; }
            set { lbTenSanPham.Text = value; }

        }
        public string SoLuong
        {
            get { return amountItem.Text; }
            set { amountItem.Text = value; }

        }
        public string Gia
        {
            get { return priceItem.Text; }
            set { priceItem.Text = value; }
        }
        public Guna2PictureBox pbSanPham
        {
            get { return imgProduct; }
            set { imgProduct = value; }
        }
        public Label lbTenSanPham
        {
            get { return lbnameSanPham; }
            set { lbnameSanPham = value; }
        }
        public Label lbGia
        {
            get { return priceItem; }
            set { priceItem = value; }
        }
        public Label lbSoLuong
        {
            get { return amountItem; }
            set { amountItem = value; }
        }
       
        

    }
}
