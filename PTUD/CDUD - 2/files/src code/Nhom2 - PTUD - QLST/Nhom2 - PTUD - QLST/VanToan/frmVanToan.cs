using CrystalDecisions.Shared;
using Nhom2___PTUD___QLST.NhatTai;
using Nhom2___PTUD___QLST.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST.VanToan
{
    public partial class frmVanToan : Form
    {
        public frmVanToan()
        {
            InitializeComponent();
        }

        private void frmVanToan_Load(object sender, EventArgs e)
        {

            // Khởi tạo đối tượng rpt
            ThongKeSPTrongKho rpt = new ThongKeSPTrongKho();

            // Khởi tạo ParameterValues
            ParameterValues para = new ParameterValues();

            // Khởi tạo ParameterDiscreteValue
            ParameterDiscreteValue val = new ParameterDiscreteValue();

            // Gán giá trị cho ParameterDiscreteValue
            //val.Value = maHd;

            // Thêm val vào para
            //para.Add(val);

            // Định nghĩa biến tham gia cho rpt
            //rpt.DataDefinition.ParameterFields["@maHoaDon"].ApplyCurrentValues(para);

            // Gọi rpt
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
