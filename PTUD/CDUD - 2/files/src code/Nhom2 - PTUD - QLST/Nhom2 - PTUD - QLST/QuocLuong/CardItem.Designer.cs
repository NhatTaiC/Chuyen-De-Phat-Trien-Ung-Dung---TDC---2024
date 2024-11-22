namespace NguyenQuocLuong_21211tt4642
{ 
    partial class CardItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardItem));
            this.amountItem = new System.Windows.Forms.Label();
            this.priceItem = new System.Windows.Forms.Label();
            this.imgProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbnameSanPham = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountItem
            // 
            this.amountItem.AutoSize = true;
            this.amountItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.amountItem.Location = new System.Drawing.Point(4, 383);
            this.amountItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountItem.Name = "amountItem";
            this.amountItem.Size = new System.Drawing.Size(76, 20);
            this.amountItem.TabIndex = 4;
            this.amountItem.Text = "Sẵn có: 9";
            // 
            // priceItem
            // 
            this.priceItem.AutoSize = true;
            this.priceItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.priceItem.Location = new System.Drawing.Point(4, 298);
            this.priceItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceItem.Name = "priceItem";
            this.priceItem.Size = new System.Drawing.Size(511, 85);
            this.priceItem.TabIndex = 3;
            this.priceItem.Text = "Giá: 25,000 đ";
            this.priceItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgProduct
            // 
            this.imgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgProduct.Image = ((System.Drawing.Image)(resources.GetObject("imgProduct.Image")));
            this.imgProduct.ImageRotate = 0F;
            this.imgProduct.Location = new System.Drawing.Point(3, 3);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(513, 207);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduct.TabIndex = 5;
            this.imgProduct.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.imgProduct, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.priceItem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.amountItem, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbnameSanPham, 0, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 427);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lbnameSanPham
            // 
            this.lbnameSanPham.AutoSize = true;
            this.lbnameSanPham.BackColor = System.Drawing.Color.Transparent;
            this.lbnameSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbnameSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnameSanPham.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbnameSanPham.Location = new System.Drawing.Point(3, 213);
            this.lbnameSanPham.Name = "lbnameSanPham";
            this.lbnameSanPham.Size = new System.Drawing.Size(513, 85);
            this.lbnameSanPham.TabIndex = 6;
            this.lbnameSanPham.Text = "Cà chua";
            this.lbnameSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 216);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(62, 22);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Cá chua";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CardItem";
            this.Size = new System.Drawing.Size(519, 427);
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label amountItem;
        private System.Windows.Forms.Label priceItem;
        private Guna.UI2.WinForms.Guna2PictureBox imgProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbnameSanPham;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
