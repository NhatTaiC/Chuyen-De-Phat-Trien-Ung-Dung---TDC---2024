﻿/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * frmTaiKhoan.cs
 * 21/10/2024
 */
using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
        int quyen = -1;

        public void LoadData()
        {
            // Others
            txtMaTK.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // cboQuyen
            cboQuyen.SelectedIndex = 0;

            // dgvTaiKhoan
            dgvTaiKhoan.DataSource = bus_tk.GetListTK();
            dgvTaiKhoan.Columns["id"].Visible = false;
            dgvTaiKhoan.Columns[0].HeaderText = "Id";
            dgvTaiKhoan.Columns[1].HeaderText = "Mã tài khoản";
            dgvTaiKhoan.Columns[2].HeaderText = "Tên tài khoản";
            dgvTaiKhoan.Columns[3].HeaderText = "Mật khẩu";
            dgvTaiKhoan.Columns[4].HeaderText = "Quyền";

        }

        public void Reset()
        {
            // Text
            txtMaTK.Clear();
            txtTenTaiKhoan.Text = string.Empty;
            txtMatKhau.Clear();

            // cboQuyen
            cboQuyen.SelectedIndex = 0;

            // LoadData()
            LoadData();
        }

        public bool CheckData(string maTK, string tenTK, string matKhau)
        {
            // Initialize Variables
            int count = 0;

            // Checked maTK
            if (CheckString(maTK, 30))
            {
                count++;
            }
            else
            {
                MessageBox.Show($"Mã tài khoản: [{maTK}] không quá 30 kí tự!",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
            }

            // Checked tenTK
            if (CheckString(tenTK, 100))
            {
                count++;
            }
            else
            {
                MessageBox.Show($"Mã tài khoản: [{tenTK}] không quá 100 kí tự!",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
            }

            // Checked tenTK
            if (CheckString(matKhau, 100))
            {
                count++;
            }
            else
            {
                MessageBox.Show($"Mật khẩu: [{matKhau}] không quá 100 kí tự!",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning);
            }

            if (count == 3)
            {
                return true;
            }
            return false;
        }

        public bool CheckString(string name, int strlength)
        {
            if (name != string.Empty && name.Length <= strlength)
            {
                return true;
            }
            return false;
        }

        private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form không?", "Thông báo",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning);

            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmTaiKhoan_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            // cboQuyen
            if (cboQuyen.SelectedIndex == 0)
            {
                quyen = 0;
            }
            else
            {
                quyen = 1;
            }

            // Added new taikhoan
            try
            {
                if (CheckData(txtMaTK.Text, txtTenTaiKhoan.Text, txtMatKhau.Text))
                {
                    bus_tk.AddTK(new DTO_TaiKhoan(txtMaTK.Text, txtTenTaiKhoan.Text, txtMatKhau.Text, quyen));

                    Reset();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Initialize Variables
            int currentId = int.Parse(dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString());

            // Deleted a current taikhoan
            try
            {
                if (CheckData(txtMaTK.Text, txtTenTaiKhoan.Text, txtMatKhau.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: [{txtTenTaiKhoan.Text}] không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_tk.DelTK(currentId);

                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!", "Thông báo",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // cboQuyen
            if (cboQuyen.SelectedIndex == 0)
            {
                quyen = 0;
            }
            else
            {
                quyen = 1;
            }

            // Initialize Variables
            int currentId = int.Parse(dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString());

            // Added new taikhoan
            try
            {
                if (CheckData(txtMaTK.Text, txtTenTaiKhoan.Text, txtMatKhau.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn sửa thông tin: [{txtTenTaiKhoan.Text}] không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_tk.UpdateTK(new DTO_TaiKhoan(currentId, txtMaTK.Text, txtTenTaiKhoan.Text, txtMatKhau.Text, quyen));

                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentCell != null)
            {
                // Get index row selected
                int n = dgvTaiKhoan.CurrentCell.RowIndex;
                //int n = dgvTaiKhoan.CurrentRow.Index;

                // Other
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                txtMaTK.Text = dgvTaiKhoan.Rows[n].Cells[1].Value.ToString();
                txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[n].Cells[2].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[n].Cells[3].Value.ToString();

                // cboQuyen
                if (dgvTaiKhoan.Rows[n].Cells[4].Value.ToString() == "0")
                {
                    quyen = 0;
                    cboQuyen.SelectedIndex = 0;
                }
                else
                {
                    quyen = 1;
                    cboQuyen.SelectedIndex = 1;
                }
            }
            else
            {
                // Messaged
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}