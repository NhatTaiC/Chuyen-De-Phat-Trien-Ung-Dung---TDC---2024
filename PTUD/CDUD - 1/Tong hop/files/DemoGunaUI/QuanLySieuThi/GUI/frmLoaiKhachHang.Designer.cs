namespace GUI
{
    partial class frmLoaiKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenLoaiKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaLoaiKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvCaLam = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaLoaiKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLam)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GroupBox3.Controls.Add(this.btnThoat);
            this.guna2GroupBox3.Controls.Add(this.btnLamMoi);
            this.guna2GroupBox3.Controls.Add(this.btnSua);
            this.guna2GroupBox3.Controls.Add(this.btnXoa);
            this.guna2GroupBox3.Controls.Add(this.btnThem);
            this.guna2GroupBox3.Controls.Add(this.txtTenLoaiKhachHang);
            this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox3.Controls.Add(this.txtMaLoaiKhachHang);
            this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, -1);
            this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(649, 624);
            this.guna2GroupBox3.TabIndex = 16;
            this.guna2GroupBox3.Text = "Quản lí loại khách hàng";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThoat
            // 
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(498, 353);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 45);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(389, 353);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(103, 45);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // btnSua
            // 
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(280, 353);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 45);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(171, 353);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 45);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(62, 353);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 45);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            // 
            // txtTenLoaiKhachHang
            // 
            this.txtTenLoaiKhachHang.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTenLoaiKhachHang.BorderRadius = 2;
            this.txtTenLoaiKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoaiKhachHang.DefaultText = "";
            this.txtTenLoaiKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoaiKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoaiKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoaiKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoaiKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenLoaiKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoaiKhachHang.Location = new System.Drawing.Point(324, 119);
            this.txtTenLoaiKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLoaiKhachHang.Name = "txtTenLoaiKhachHang";
            this.txtTenLoaiKhachHang.PasswordChar = '\0';
            this.txtTenLoaiKhachHang.PlaceholderText = "";
            this.txtTenLoaiKhachHang.SelectedText = "";
            this.txtTenLoaiKhachHang.Size = new System.Drawing.Size(196, 28);
            this.txtTenLoaiKhachHang.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTenLoaiKhachHang.TabIndex = 1;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(124, 126);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(157, 21);
            this.guna2HtmlLabel6.TabIndex = 11;
            this.guna2HtmlLabel6.Text = "Tên loại khách hàng";
            // 
            // txtMaLoaiKhachHang
            // 
            this.txtMaLoaiKhachHang.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtMaLoaiKhachHang.BorderRadius = 2;
            this.txtMaLoaiKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoaiKhachHang.DefaultText = "";
            this.txtMaLoaiKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLoaiKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLoaiKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoaiKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLoaiKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaLoaiKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLoaiKhachHang.Location = new System.Drawing.Point(324, 58);
            this.txtMaLoaiKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaLoaiKhachHang.Name = "txtMaLoaiKhachHang";
            this.txtMaLoaiKhachHang.PasswordChar = '\0';
            this.txtMaLoaiKhachHang.PlaceholderText = "";
            this.txtMaLoaiKhachHang.SelectedText = "";
            this.txtMaLoaiKhachHang.Size = new System.Drawing.Size(196, 28);
            this.txtMaLoaiKhachHang.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMaLoaiKhachHang.TabIndex = 0;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(124, 65);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(150, 21);
            this.guna2HtmlLabel5.TabIndex = 9;
            this.guna2HtmlLabel5.Text = "Mã loại khách hàng";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GroupBox1.Controls.Add(this.dgvCaLam);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(658, -1);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(550, 624);
            this.guna2GroupBox1.TabIndex = 21;
            this.guna2GroupBox1.Text = "Danh sách loại khách hàng";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvCaLam
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCaLam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaLam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCaLam.ColumnHeadersHeight = 52;
            this.dgvCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCaLam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiKhachHang,
            this.TenLoaiKhachHang});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaLam.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCaLam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCaLam.Location = new System.Drawing.Point(0, 39);
            this.dgvCaLam.Name = "dgvCaLam";
            this.dgvCaLam.RowHeadersVisible = false;
            this.dgvCaLam.Size = new System.Drawing.Size(550, 585);
            this.dgvCaLam.TabIndex = 0;
            this.dgvCaLam.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCaLam.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCaLam.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCaLam.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCaLam.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCaLam.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCaLam.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCaLam.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCaLam.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCaLam.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCaLam.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCaLam.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCaLam.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvCaLam.ThemeStyle.ReadOnly = false;
            this.dgvCaLam.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCaLam.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCaLam.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCaLam.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCaLam.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCaLam.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCaLam.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaLoaiKhachHang
            // 
            this.MaLoaiKhachHang.HeaderText = "Mã loại khách hàng";
            this.MaLoaiKhachHang.Name = "MaLoaiKhachHang";
            // 
            // TenLoaiKhachHang
            // 
            this.TenLoaiKhachHang.HeaderText = "Tên loại khách hàng";
            this.TenLoaiKhachHang.Name = "TenLoaiKhachHang";
            // 
            // frmLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2GroupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLoaiKhachHang";
            this.Text = "Quản lí loại khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoaiKhachHang;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLoaiKhachHang;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCaLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKhachHang;
    }
}