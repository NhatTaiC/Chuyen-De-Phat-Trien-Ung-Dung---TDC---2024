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
            this.nameIteam = new System.Windows.Forms.Label();
            this.priceItem = new System.Windows.Forms.Label();
            this.amountItem = new System.Windows.Forms.Label();
            this.imgProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // nameIteam
            // 
            this.nameIteam.AutoSize = true;
            this.nameIteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameIteam.Location = new System.Drawing.Point(113, 240);
            this.nameIteam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameIteam.Name = "nameIteam";
            this.nameIteam.Size = new System.Drawing.Size(201, 29);
            this.nameIteam.TabIndex = 1;
            this.nameIteam.Text = "Nước ép trái cây";
            // 
            // priceItem
            // 
            this.priceItem.AutoSize = true;
            this.priceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.priceItem.Location = new System.Drawing.Point(123, 278);
            this.priceItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceItem.Name = "priceItem";
            this.priceItem.Size = new System.Drawing.Size(176, 33);
            this.priceItem.TabIndex = 3;
            this.priceItem.Text = "Giá: 25,000";
            // 
            // amountItem
            // 
            this.amountItem.AutoSize = true;
            this.amountItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountItem.Location = new System.Drawing.Point(321, 320);
            this.amountItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountItem.Name = "amountItem";
            this.amountItem.Size = new System.Drawing.Size(80, 20);
            this.amountItem.TabIndex = 4;
            this.amountItem.Text = "Sẵn có: 9";
            // 
            // imgProduct
            // 
            this.imgProduct.Image = ((System.Drawing.Image)(resources.GetObject("imgProduct.Image")));
            this.imgProduct.ImageRotate = 0F;
            this.imgProduct.Location = new System.Drawing.Point(68, 16);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(300, 221);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProduct.TabIndex = 5;
            this.imgProduct.TabStop = false;
            // 
            // CardItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.imgProduct);
            this.Controls.Add(this.amountItem);
            this.Controls.Add(this.priceItem);
            this.Controls.Add(this.nameIteam);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CardItem";
            this.Size = new System.Drawing.Size(425, 361);
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameIteam;
        private System.Windows.Forms.Label priceItem;
        private System.Windows.Forms.Label amountItem;
        private Guna.UI2.WinForms.Guna2PictureBox imgProduct;
    }
}
