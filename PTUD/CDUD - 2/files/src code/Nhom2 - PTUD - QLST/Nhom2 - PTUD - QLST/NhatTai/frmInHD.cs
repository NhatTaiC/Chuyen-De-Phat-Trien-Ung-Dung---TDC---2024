using CrystalDecisions.Shared;
using Nhom2___PTUD___QLST.Report;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST.NhatTai
{
    public partial class frmInHD : Form
    {
        public frmInHD()
        {
            InitializeComponent();
        }

        // Initialize Variables
        string maHd = string.Empty;

        public frmInHD(string id)
        {
            maHd = id;
            InitializeComponent();
        }

        private void frmInHD_Load(object sender, System.EventArgs e)
        {
            if (maHd != "")
            {
                // Khởi tạo đối tượng rpt
                GetHdByMaHd rpt = new GetHdByMaHd();

                // Khởi tạo ParameterValues
                ParameterValues para = new ParameterValues();

                // Khởi tạo ParameterDiscreteValue
                ParameterDiscreteValue val = new ParameterDiscreteValue();

                // Gán giá trị cho ParameterDiscreteValue
                val.Value = maHd;

                // Thêm val vào para
                para.Add(val);

                // Định nghĩa biến tham gia cho rpt
                rpt.DataDefinition.ParameterFields["@maHoaDon"].ApplyCurrentValues(para);

                // Gọi rpt
                crvInHd.ReportSource = rpt;
            }
        }

        private void frmInHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát form không?", "Thông báo",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning);

            if (dr == DialogResult.Cancel)
            {
                maHd = string.Empty;
                e.Cancel = true;
            }
        }
    }
}
