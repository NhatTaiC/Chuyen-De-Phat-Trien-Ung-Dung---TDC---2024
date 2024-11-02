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
        }
        public Image ItemImage
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
            get { return nameIteam.Text; }
            set { nameIteam.Text = value; }

        }
        public string SoLuong
        {
            get { return amountItem.Text; }
            set { amountItem.Text = value; }

        }
    }
}
