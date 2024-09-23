namespace CDUD1
{
    partial class KhoHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvKhoHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMaKho = new System.Windows.Forms.TextBox();
            this.btnMaSanPham = new System.Windows.Forms.TextBox();
            this.btnSoLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(736, 432);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 62);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(505, 432);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 62);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(279, 432);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 62);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvKhoHang
            // 
            this.dgvKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoHang.Location = new System.Drawing.Point(0, 518);
            this.dgvKhoHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKhoHang.Name = "dgvKhoHang";
            this.dgvKhoHang.RowHeadersWidth = 51;
            this.dgvKhoHang.RowTemplate.Height = 24;
            this.dgvKhoHang.Size = new System.Drawing.Size(1217, 298);
            this.dgvKhoHang.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "QUẢN LÍ KHO HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã kho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số lượng";
            // 
            // btnMaKho
            // 
            this.btnMaKho.Location = new System.Drawing.Point(452, 142);
            this.btnMaKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaKho.Name = "btnMaKho";
            this.btnMaKho.Size = new System.Drawing.Size(376, 26);
            this.btnMaKho.TabIndex = 15;
            // 
            // btnMaSanPham
            // 
            this.btnMaSanPham.Location = new System.Drawing.Point(452, 191);
            this.btnMaSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaSanPham.Name = "btnMaSanPham";
            this.btnMaSanPham.Size = new System.Drawing.Size(376, 26);
            this.btnMaSanPham.TabIndex = 15;
            // 
            // btnSoLuong
            // 
            this.btnSoLuong.Location = new System.Drawing.Point(452, 238);
            this.btnSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSoLuong.Name = "btnSoLuong";
            this.btnSoLuong.Size = new System.Drawing.Size(376, 26);
            this.btnSoLuong.TabIndex = 15;
            // 
            // KhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 816);
            this.Controls.Add(this.btnSoLuong);
            this.Controls.Add(this.btnMaSanPham);
            this.Controls.Add(this.btnMaKho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvKhoHang);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KhoHang";
            this.Text = "KhoHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvKhoHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox btnMaKho;
        private System.Windows.Forms.TextBox btnMaSanPham;
        private System.Windows.Forms.TextBox btnSoLuong;
    }
}