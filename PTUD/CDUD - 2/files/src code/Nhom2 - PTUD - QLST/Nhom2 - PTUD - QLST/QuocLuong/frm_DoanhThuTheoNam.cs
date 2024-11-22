using CrystalDecisions.Shared;
using Nhom2___PTUD___QLST.Report;
using System;
using System.Windows.Forms;
namespace Nhom2___PTUD___QLST.QuocLuong
{
    public partial class frm_DoanhThuTheoNam : Form
    {
        public frm_DoanhThuTheoNam()
        {
            InitializeComponent();
            cbNam.SelectedIndex = 0;
        }

        private void frm_DoanhThuTheoNam_Load(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            rpt_DoanhThuTheoNam rpt = new rpt_DoanhThuTheoNam();
            //tạo tham số
            ParameterValues paraNam = new ParameterValues();

            ParameterDiscreteValue valNam = new ParameterDiscreteValue();

            valNam.Value = int.Parse(cbNam.Text);

            paraNam.Add(valNam);

            rpt.DataDefinition.ParameterFields["@nam"].ApplyCurrentValues(paraNam);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
