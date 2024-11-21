using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Nhom2___PTUD___QLST.Report;

namespace Nhom2___PTUD___QLST.QuocLuong
{
    public partial class frmBaoCaoDoanhthuTheoThang : Form
    {
        public frmBaoCaoDoanhthuTheoThang()
        {
            InitializeComponent();
            cbThang.SelectedIndex = 0;
            cbNam.SelectedIndex = 0;
        }

        private void frmBaoCaoDoanhthuTheoThang_Load(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
             rpt_DoanhThuTheoThang rpt = new rpt_DoanhThuTheoThang();
            // Tạo các giá trị tham số
            ParameterValues paraNam = new ParameterValues();
            ParameterValues paraThang = new ParameterValues();

            ParameterDiscreteValue valNam = new ParameterDiscreteValue();
            ParameterDiscreteValue valThang = new ParameterDiscreteValue();

            //ép kiểu sang int;
            valNam.Value = Convert.ToInt32(cbNam.Text);
            valThang.Value = Convert.ToInt32(cbThang.Text);

            // Thêm giá trị tham số vào danh sách tham số tương ứng
            paraNam.Add(valNam);
            paraThang.Add(valThang);

            // Truyền giá trị tham số vào báo cáo
            rpt.DataDefinition.ParameterFields["@nam"].ApplyCurrentValues(paraNam);
            rpt.DataDefinition.ParameterFields["@thang"].ApplyCurrentValues(paraThang);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
