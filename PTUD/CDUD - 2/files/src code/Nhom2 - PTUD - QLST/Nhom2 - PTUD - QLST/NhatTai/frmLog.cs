/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * frmLog.cs
 * 01/11/2024
 */
using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        // Initialize Variables
        BUS_Log bus_log = new BUS_Log();
        DataValidation dv = new DataValidation();

        public void LoadData()
        {
            // Others
            //txtModel.Focus();
            //btnThem.Enabled = true;
            //btnSua.Enabled = false;
            //btnXoa.Enabled = false;

            // Diasable
            txtModel.Enabled = false;
            txtModelId.Enabled = false;
            txtDataOlds.Enabled = false;
            txtDataNews.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // dgvKM
            dgvLog.DataSource = bus_log.GetListLog();
            dgvLog.Columns["id"].Visible = false;
            dgvLog.Columns["id"].HeaderText = "Id";
            dgvLog.Columns["log_name"].Visible = false;
            dgvLog.Columns["log_name"].HeaderText = "LogName";
            dgvLog.Columns["model"].HeaderText = "Model";
            dgvLog.Columns["model_id"].HeaderText = "ModelId";
            dgvLog.Columns["data_olds"].HeaderText = "DataOlds";
            dgvLog.Columns["data_news"].HeaderText = "DataNews";
        }

        public void Reset()
        {
            // Other
            txtModel.Clear();
            txtModelId.Clear();
            txtDataOlds.Clear();
            txtDataNews.Clear();

            LoadData();
        }

        public bool CheckData(string model, string model_id, string data_olds, string data_news)
        {
            // Initialize Variables
            int count = 0;

            // Checked model
            if (dv.CheckString(model, 100))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"model không quá 100 kí tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked model_id
            if (dv.CheckNumber3(model_id))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"model id phải nhập số!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked data_olds
            if (dv.CheckString(data_olds, 100))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"data_olds không quá 100 kí tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // Checked data_news
            if (dv.CheckString(data_news, 100))
            {
                count += 1;
            }
            else
            {
                MessageBox.Show($"data_news không quá 100 kí tự!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (count == 4)
            {
                return true;
            }
            return false;
        }

        private void frmKhuyenMai_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void frmKhuyenMai_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnLamMoi_Click(object sender, System.EventArgs e)
        {
            Reset();
        }

        private void dgvLog_Click(object sender, System.EventArgs e)
        {
            if (dgvLog.CurrentCell != null)
            {
                // Get row index selected
                int n = dgvLog.CurrentCell.RowIndex;

                // Other
                //btnThem.Enabled = false;
                //btnSua.Enabled = true;
                //btnXoa.Enabled = true;

                // Disable
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                txtModel.Text = dgvLog.Rows[n].Cells[2].Value.ToString();
                txtModelId.Text = dgvLog.Rows[n].Cells[3].Value.ToString();
                txtDataOlds.Text = dgvLog.Rows[n].Cells[4].Value.ToString();
                txtDataNews.Text = dgvLog.Rows[n].Cells[5].Value.ToString();
            }
            else
            {
                // Messaged
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa hoặc sửa thông tin!", "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (CheckData(txtModel.Text, txtModelId.Text, txtDataOlds.Text, txtDataNews.Text))
                {
                    bus_log.AddLog(new DTO_Log(
                        txtModel.Text,
                        int.Parse(txtModelId.Text),
                        txtDataOlds.Text,
                        txtDataNews.Text));

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
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize Variable
                int currentId = int.Parse(dgvLog.CurrentRow.Cells[0].Value.ToString());

                if (CheckData(txtModel.Text, txtModelId.Text, txtDataOlds.Text, txtDataNews.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn sửa thông tin: [{txtModel.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_log.UpdateLog(new DTO_Log(
                            currentId,
                            txtModel.Text,
                            int.Parse(txtModelId.Text),
                            txtDataOlds.Text,
                            txtDataNews.Text));

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
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize Variable
                int currentId = int.Parse(dgvLog.CurrentRow.Cells[0].Value.ToString());

                if (CheckData(txtModel.Text, txtModelId.Text, txtDataOlds.Text, txtDataNews.Text))
                {
                    DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa: [{txtModel.Text}] không?",
                       "Thông báo",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        bus_log.DelLog(currentId);

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
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
