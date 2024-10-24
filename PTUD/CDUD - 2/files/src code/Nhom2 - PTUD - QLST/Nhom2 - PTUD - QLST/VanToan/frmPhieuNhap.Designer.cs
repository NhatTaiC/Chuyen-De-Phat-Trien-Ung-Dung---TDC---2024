namespace GUI
{
    partial class frmPhieuNhap
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
			this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.dgvPhieuNhap = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.cbNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.txtThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
			this.dtpNgayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.txtMaPhieuNhap = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.btnLamMoi = new System.Windows.Forms.ToolStripButton();
			this.btnThoat = new System.Windows.Forms.ToolStripButton();
			this.guna2GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
			this.guna2GroupBox4.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2GroupBox2
			// 
			this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.guna2GroupBox2.Controls.Add(this.dgvPhieuNhap);
			this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
			this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
			this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox2.Location = new System.Drawing.Point(0, 329);
			this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.guna2GroupBox2.Name = "guna2GroupBox2";
			this.guna2GroupBox2.Size = new System.Drawing.Size(1300, 294);
			this.guna2GroupBox2.TabIndex = 25;
			this.guna2GroupBox2.Text = "Danh sách phiếu nhập";
			this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dgvPhieuNhap
			// 
			this.dgvPhieuNhap.AllowUserToAddRows = false;
			this.dgvPhieuNhap.AllowUserToDeleteRows = false;
			this.dgvPhieuNhap.AllowUserToResizeColumns = false;
			this.dgvPhieuNhap.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvPhieuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPhieuNhap.ColumnHeadersHeight = 27;
			this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvPhieuNhap.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvPhieuNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 40);
			this.dgvPhieuNhap.Name = "dgvPhieuNhap";
			this.dgvPhieuNhap.RowHeadersVisible = false;
			this.dgvPhieuNhap.Size = new System.Drawing.Size(1300, 254);
			this.dgvPhieuNhap.TabIndex = 1;
			this.dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvPhieuNhap.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvPhieuNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPhieuNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvPhieuNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvPhieuNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvPhieuNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvPhieuNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvPhieuNhap.ThemeStyle.HeaderStyle.Height = 27;
			this.dgvPhieuNhap.ThemeStyle.ReadOnly = false;
			this.dgvPhieuNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPhieuNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvPhieuNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvPhieuNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
			this.dgvPhieuNhap.ThemeStyle.RowsStyle.Height = 22;
			this.dgvPhieuNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPhieuNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvPhieuNhap.Click += new System.EventHandler(this.dgvPhieuNhap_Click);
			// 
			// guna2GroupBox4
			// 
			this.guna2GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2GroupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.guna2GroupBox4.Controls.Add(this.guna2HtmlLabel1);
			this.guna2GroupBox4.Controls.Add(this.cbNhanVien);
			this.guna2GroupBox4.Controls.Add(this.guna2HtmlLabel3);
			this.guna2GroupBox4.Controls.Add(this.txtThanhTien);
			this.guna2GroupBox4.Controls.Add(this.dtpNgayNhap);
			this.guna2GroupBox4.Controls.Add(this.guna2HtmlLabel7);
			this.guna2GroupBox4.Controls.Add(this.txtMaPhieuNhap);
			this.guna2GroupBox4.Controls.Add(this.guna2HtmlLabel8);
			this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
			this.guna2GroupBox4.FillColor = System.Drawing.Color.Transparent;
			this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox4.Location = new System.Drawing.Point(2, 29);
			this.guna2GroupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.guna2GroupBox4.Name = "guna2GroupBox4";
			this.guna2GroupBox4.Size = new System.Drawing.Size(1298, 292);
			this.guna2GroupBox4.TabIndex = 26;
			this.guna2GroupBox4.Text = "Quản lí phiếu nhập";
			this.guna2GroupBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(689, 138);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 20);
			this.guna2HtmlLabel1.TabIndex = 15;
			this.guna2HtmlLabel1.Text = "Nhân viên:";
			// 
			// cbNhanVien
			// 
			this.cbNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbNhanVien.BackColor = System.Drawing.Color.Transparent;
			this.cbNhanVien.BorderColor = System.Drawing.Color.DeepSkyBlue;
			this.cbNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbNhanVien.ItemHeight = 30;
			this.cbNhanVien.Location = new System.Drawing.Point(829, 122);
			this.cbNhanVien.Name = "cbNhanVien";
			this.cbNhanVien.Size = new System.Drawing.Size(194, 36);
			this.cbNhanVien.TabIndex = 14;
			// 
			// guna2HtmlLabel3
			// 
			this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
			this.guna2HtmlLabel3.Location = new System.Drawing.Point(350, 127);
			this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
			this.guna2HtmlLabel3.Size = new System.Drawing.Size(78, 20);
			this.guna2HtmlLabel3.TabIndex = 19;
			this.guna2HtmlLabel3.Text = "Thành tiền:";
			// 
			// txtThanhTien
			// 
			this.txtThanhTien.BorderColor = System.Drawing.Color.DeepSkyBlue;
			this.txtThanhTien.BorderRadius = 2;
			this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtThanhTien.DefaultText = "";
			this.txtThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtThanhTien.Location = new System.Drawing.Point(490, 119);
			this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtThanhTien.Name = "txtThanhTien";
			this.txtThanhTien.PasswordChar = '\0';
			this.txtThanhTien.PlaceholderText = "";
			this.txtThanhTien.SelectedText = "";
			this.txtThanhTien.Size = new System.Drawing.Size(174, 28);
			this.txtThanhTien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtThanhTien.TabIndex = 17;
			// 
			// dtpNgayNhap
			// 
			this.dtpNgayNhap.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.dtpNgayNhap.BorderColor = System.Drawing.Color.DeepSkyBlue;
			this.dtpNgayNhap.BorderRadius = 3;
			this.dtpNgayNhap.Checked = true;
			this.dtpNgayNhap.FillColor = System.Drawing.Color.DeepSkyBlue;
			this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayNhap.Location = new System.Drawing.Point(829, 51);
			this.dtpNgayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpNgayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpNgayNhap.Name = "dtpNgayNhap";
			this.dtpNgayNhap.Size = new System.Drawing.Size(194, 36);
			this.dtpNgayNhap.TabIndex = 13;
			this.dtpNgayNhap.Value = new System.DateTime(2024, 10, 9, 9, 21, 6, 502);
			// 
			// guna2HtmlLabel7
			// 
			this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
			this.guna2HtmlLabel7.Location = new System.Drawing.Point(689, 67);
			this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
			this.guna2HtmlLabel7.Size = new System.Drawing.Size(81, 20);
			this.guna2HtmlLabel7.TabIndex = 11;
			this.guna2HtmlLabel7.Text = "Ngày nhập:";
			// 
			// txtMaPhieuNhap
			// 
			this.txtMaPhieuNhap.BorderColor = System.Drawing.Color.DeepSkyBlue;
			this.txtMaPhieuNhap.BorderRadius = 2;
			this.txtMaPhieuNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaPhieuNhap.DefaultText = "";
			this.txtMaPhieuNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaPhieuNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaPhieuNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaPhieuNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaPhieuNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtMaPhieuNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaPhieuNhap.Location = new System.Drawing.Point(490, 59);
			this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
			this.txtMaPhieuNhap.PasswordChar = '\0';
			this.txtMaPhieuNhap.PlaceholderText = "";
			this.txtMaPhieuNhap.SelectedText = "";
			this.txtMaPhieuNhap.Size = new System.Drawing.Size(174, 28);
			this.txtMaPhieuNhap.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtMaPhieuNhap.TabIndex = 10;
			// 
			// guna2HtmlLabel8
			// 
			this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
			this.guna2HtmlLabel8.Location = new System.Drawing.Point(350, 67);
			this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
			this.guna2HtmlLabel8.Size = new System.Drawing.Size(109, 20);
			this.guna2HtmlLabel8.TabIndex = 9;
			this.guna2HtmlLabel8.Text = "Mã phiếu nhập:";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLamMoi,
            this.btnThoat});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1300, 25);
			this.toolStrip1.TabIndex = 27;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Image = global::Nhom2___PTUD___QLST.Properties.Resources.plus;
			this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(57, 22);
			this.btnThem.Text = "Thêm";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::Nhom2___PTUD___QLST.Properties.Resources.bin;
			this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(47, 22);
			this.btnXoa.Text = "Xóa";
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Image = global::Nhom2___PTUD___QLST.Properties.Resources.loop;
			this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(46, 22);
			this.btnSua.Text = "Sửa";
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Image = global::Nhom2___PTUD___QLST.Properties.Resources.reset;
			this.btnLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(74, 22);
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Image = global::Nhom2___PTUD___QLST.Properties.Resources.logout;
			this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(57, 22);
			this.btnThoat.Text = "Thoát";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// frmPhieuNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1300, 623);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.guna2GroupBox4);
			this.Controls.Add(this.guna2GroupBox2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "frmPhieuNhap";
			this.Text = "Quản lí phiếu nhập";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
			this.guna2GroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
			this.guna2GroupBox4.ResumeLayout(false);
			this.guna2GroupBox4.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhieuNhap;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtThanhTien;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbNhanVien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhap;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhieuNhap;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnThem;
		private System.Windows.Forms.ToolStripButton btnXoa;
		private System.Windows.Forms.ToolStripButton btnSua;
		private System.Windows.Forms.ToolStripButton btnLamMoi;
		private System.Windows.Forms.ToolStripButton btnThoat;
	}
}