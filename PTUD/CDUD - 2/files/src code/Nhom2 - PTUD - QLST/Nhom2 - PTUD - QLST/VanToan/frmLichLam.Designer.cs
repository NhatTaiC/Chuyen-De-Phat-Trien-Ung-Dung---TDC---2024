namespace GUI
{
    partial class frmLichLam
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
			this.dtpNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.cbNhanVien = new System.Windows.Forms.ComboBox();
			this.cbMaCaLam = new System.Windows.Forms.ComboBox();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.txtMaLichLam = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.btnLamMoi = new System.Windows.Forms.ToolStripButton();
			this.btnThoat = new System.Windows.Forms.ToolStripButton();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.dgvLichLam = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2GroupBox3.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.guna2GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLichLam)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2GroupBox3
			// 
			this.guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.guna2GroupBox3.Controls.Add(this.dtpNgay);
			this.guna2GroupBox3.Controls.Add(this.cbNhanVien);
			this.guna2GroupBox3.Controls.Add(this.cbMaCaLam);
			this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel1);
			this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel11);
			this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel6);
			this.guna2GroupBox3.Controls.Add(this.txtMaLichLam);
			this.guna2GroupBox3.Controls.Add(this.guna2HtmlLabel5);
			this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
			this.guna2GroupBox3.FillColor = System.Drawing.Color.Transparent;
			this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox3.Location = new System.Drawing.Point(0, 28);
			this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.guna2GroupBox3.Name = "guna2GroupBox3";
			this.guna2GroupBox3.Size = new System.Drawing.Size(1201, 277);
			this.guna2GroupBox3.TabIndex = 14;
			this.guna2GroupBox3.Text = "Quản lí lịch làm";
			this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtpNgay
			// 
			this.dtpNgay.Checked = true;
			this.dtpNgay.FillColor = System.Drawing.Color.DeepSkyBlue;
			this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtpNgay.Location = new System.Drawing.Point(597, 93);
			this.dtpNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpNgay.Name = "dtpNgay";
			this.dtpNgay.Size = new System.Drawing.Size(200, 36);
			this.dtpNgay.TabIndex = 3;
			this.dtpNgay.Value = new System.DateTime(2024, 10, 8, 13, 28, 23, 695);
			// 
			// cbNhanVien
			// 
			this.cbNhanVien.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cbNhanVien.FormattingEnabled = true;
			this.cbNhanVien.Location = new System.Drawing.Point(599, 154);
			this.cbNhanVien.Name = "cbNhanVien";
			this.cbNhanVien.Size = new System.Drawing.Size(196, 33);
			this.cbNhanVien.TabIndex = 2;
			// 
			// cbMaCaLam
			// 
			this.cbMaCaLam.FormattingEnabled = true;
			this.cbMaCaLam.Location = new System.Drawing.Point(599, 214);
			this.cbMaCaLam.Name = "cbMaCaLam";
			this.cbMaCaLam.Size = new System.Drawing.Size(196, 33);
			this.cbMaCaLam.TabIndex = 2;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.White;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(446, 108);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(43, 21);
			this.guna2HtmlLabel1.TabIndex = 13;
			this.guna2HtmlLabel1.Text = "Ngày";
			// 
			// guna2HtmlLabel11
			// 
			this.guna2HtmlLabel11.BackColor = System.Drawing.Color.White;
			this.guna2HtmlLabel11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.Black;
			this.guna2HtmlLabel11.Location = new System.Drawing.Point(448, 226);
			this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
			this.guna2HtmlLabel11.Size = new System.Drawing.Size(78, 21);
			this.guna2HtmlLabel11.TabIndex = 13;
			this.guna2HtmlLabel11.Text = "Mã ca làm";
			// 
			// guna2HtmlLabel6
			// 
			this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
			this.guna2HtmlLabel6.Location = new System.Drawing.Point(446, 166);
			this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
			this.guna2HtmlLabel6.Size = new System.Drawing.Size(80, 21);
			this.guna2HtmlLabel6.TabIndex = 11;
			this.guna2HtmlLabel6.Text = "Nhân viên";
			// 
			// txtMaLichLam
			// 
			this.txtMaLichLam.BorderColor = System.Drawing.Color.DeepSkyBlue;
			this.txtMaLichLam.BorderRadius = 2;
			this.txtMaLichLam.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMaLichLam.DefaultText = "";
			this.txtMaLichLam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMaLichLam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMaLichLam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaLichLam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMaLichLam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaLichLam.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtMaLichLam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMaLichLam.Location = new System.Drawing.Point(599, 50);
			this.txtMaLichLam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaLichLam.Name = "txtMaLichLam";
			this.txtMaLichLam.PasswordChar = '\0';
			this.txtMaLichLam.PlaceholderText = "";
			this.txtMaLichLam.SelectedText = "";
			this.txtMaLichLam.Size = new System.Drawing.Size(196, 28);
			this.txtMaLichLam.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.txtMaLichLam.TabIndex = 0;
			// 
			// guna2HtmlLabel5
			// 
			this.guna2HtmlLabel5.BackColor = System.Drawing.Color.White;
			this.guna2HtmlLabel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
			this.guna2HtmlLabel5.Location = new System.Drawing.Point(446, 57);
			this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
			this.guna2HtmlLabel5.Size = new System.Drawing.Size(87, 21);
			this.guna2HtmlLabel5.TabIndex = 9;
			this.guna2HtmlLabel5.Text = "Mã lịch làm";
			// 
			// toolStrip1
			// 
			this.toolStrip1.AllowMerge = false;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLamMoi,
            this.btnThoat});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1200, 25);
			this.toolStrip1.TabIndex = 20;
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
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.guna2GroupBox1.Controls.Add(this.dgvLichLam);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
			this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox1.Location = new System.Drawing.Point(0, 313);
			this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(1201, 310);
			this.guna2GroupBox1.TabIndex = 15;
			this.guna2GroupBox1.Text = "Danh sách lịch làm";
			this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dgvLichLam
			// 
			this.dgvLichLam.AllowUserToAddRows = false;
			this.dgvLichLam.AllowUserToDeleteRows = false;
			this.dgvLichLam.AllowUserToResizeColumns = false;
			this.dgvLichLam.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvLichLam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLichLam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvLichLam.ColumnHeadersHeight = 52;
			this.dgvLichLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvLichLam.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvLichLam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvLichLam.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvLichLam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvLichLam.Location = new System.Drawing.Point(0, 40);
			this.dgvLichLam.Name = "dgvLichLam";
			this.dgvLichLam.RowHeadersVisible = false;
			this.dgvLichLam.Size = new System.Drawing.Size(1201, 270);
			this.dgvLichLam.TabIndex = 0;
			this.dgvLichLam.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvLichLam.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvLichLam.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvLichLam.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvLichLam.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvLichLam.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvLichLam.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvLichLam.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvLichLam.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvLichLam.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvLichLam.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvLichLam.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvLichLam.ThemeStyle.HeaderStyle.Height = 52;
			this.dgvLichLam.ThemeStyle.ReadOnly = false;
			this.dgvLichLam.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvLichLam.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvLichLam.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvLichLam.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
			this.dgvLichLam.ThemeStyle.RowsStyle.Height = 22;
			this.dgvLichLam.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvLichLam.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvLichLam.Click += new System.EventHandler(this.dgvLichLam_Click);
			// 
			// frmLichLam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 623);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.guna2GroupBox3);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmLichLam";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmLichLam_Load);
			this.guna2GroupBox3.ResumeLayout(false);
			this.guna2GroupBox3.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.guna2GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLichLam)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox txtMaLichLam;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgay;
        private System.Windows.Forms.ComboBox cbMaCaLam;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLamMoi;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLichLam;
		private System.Windows.Forms.ComboBox cbNhanVien;
	}
}