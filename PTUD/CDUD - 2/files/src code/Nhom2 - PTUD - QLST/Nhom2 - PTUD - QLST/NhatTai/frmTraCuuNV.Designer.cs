﻿namespace Nhom2___PTUD___QLST.NhatTai
{
    partial class frmTraCuuNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuNV));
            this.menuToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnLamMoi = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.tableContainer = new System.Windows.Forms.TableLayoutPanel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvTim = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tableFields = new System.Windows.Forms.TableLayoutPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTim = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboTim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.menuToolStrip.SuspendLayout();
            this.tableContainer.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.tableFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLamMoi,
            this.btnThoat});
            this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(1333, 39);
            this.menuToolStrip.TabIndex = 0;
            this.menuToolStrip.Text = "menuToolStrip";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = global::Nhom2___PTUD___QLST.Properties.Resources.reset;
            this.btnLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(112, 36);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::Nhom2___PTUD___QLST.Properties.Resources.logout;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 36);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tableContainer
            // 
            this.tableContainer.ColumnCount = 1;
            this.tableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableContainer.Controls.Add(this.guna2GroupBox2, 0, 1);
            this.tableContainer.Controls.Add(this.guna2GroupBox1, 0, 0);
            this.tableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableContainer.Location = new System.Drawing.Point(0, 39);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.RowCount = 2;
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableContainer.Size = new System.Drawing.Size(1333, 584);
            this.tableContainer.TabIndex = 2;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.dgvTim);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(3, 119);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1327, 462);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Kết quả";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvTim
            // 
            this.dgvTim.AllowUserToAddRows = false;
            this.dgvTim.AllowUserToDeleteRows = false;
            this.dgvTim.AllowUserToResizeColumns = false;
            this.dgvTim.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTim.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTim.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTim.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTim.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTim.Location = new System.Drawing.Point(0, 40);
            this.dgvTim.MultiSelect = false;
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTim.RowHeadersVisible = false;
            this.dgvTim.RowTemplate.Height = 50;
            this.dgvTim.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTim.Size = new System.Drawing.Size(1327, 422);
            this.dgvTim.TabIndex = 0;
            this.dgvTim.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTim.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTim.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTim.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTim.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTim.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTim.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTim.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTim.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTim.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTim.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTim.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTim.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvTim.ThemeStyle.ReadOnly = false;
            this.dgvTim.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTim.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTim.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTim.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTim.ThemeStyle.RowsStyle.Height = 50;
            this.dgvTim.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTim.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.tableFields);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1327, 110);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Nhập thông tin";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableFields
            // 
            this.tableFields.ColumnCount = 3;
            this.tableFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableFields.Controls.Add(this.guna2HtmlLabel1, 0, 0);
            this.tableFields.Controls.Add(this.txtTim, 1, 0);
            this.tableFields.Controls.Add(this.cboTim, 2, 0);
            this.tableFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFields.Location = new System.Drawing.Point(0, 40);
            this.tableFields.Name = "tableFields";
            this.tableFields.RowCount = 1;
            this.tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableFields.Size = new System.Drawing.Size(1327, 70);
            this.tableFields.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(436, 64);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Nội dung tra cứu";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTim
            // 
            this.txtTim.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim.DefaultText = "";
            this.txtTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.ForeColor = System.Drawing.Color.Black;
            this.txtTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Location = new System.Drawing.Point(448, 6);
            this.txtTim.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTim.Name = "txtTim";
            this.txtTim.PasswordChar = '\0';
            this.txtTim.PlaceholderText = "";
            this.txtTim.SelectedText = "";
            this.txtTim.Size = new System.Drawing.Size(430, 58);
            this.txtTim.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTim.TabIndex = 0;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // cboTim
            // 
            this.cboTim.BackColor = System.Drawing.Color.Transparent;
            this.cboTim.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.cboTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTim.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTim.ForeColor = System.Drawing.Color.Black;
            this.cboTim.ItemHeight = 30;
            this.cboTim.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên"});
            this.cboTim.Location = new System.Drawing.Point(887, 3);
            this.cboTim.Name = "cboTim";
            this.cboTim.Size = new System.Drawing.Size(437, 36);
            this.cboTim.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cboTim.TabIndex = 1;
            // 
            // frmTraCuuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.tableContainer);
            this.Controls.Add(this.menuToolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTraCuuNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTraCuuNV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTraCuuNV_FormClosing);
            this.Load += new System.EventHandler(this.frmTraCuuNV_Load);
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            this.tableContainer.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.tableFields.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuToolStrip;
        private System.Windows.Forms.ToolStripButton btnLamMoi;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.TableLayoutPanel tableContainer;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TableLayoutPanel tableFields;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTim;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTim;
        private Guna.UI2.WinForms.Guna2ComboBox cboTim;
    }
}