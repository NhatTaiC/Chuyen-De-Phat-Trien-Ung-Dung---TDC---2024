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
    public partial class frmBaoCaoBangLuong : Form
    {
        private int idBangLuong;
        public frmBaoCaoBangLuong(int idBangLuong)
        { 
            InitializeComponent();
            this.idBangLuong = idBangLuong;
        }

        private void frmBaoCaoBangLuong_Load(object sender, EventArgs e)
        {
            rpt_BaoCaoBangLuongTheoMaBangLuong rpt = new rpt_BaoCaoBangLuongTheoMaBangLuong();
            //tạo tham số
            ParameterValues paraNam = new ParameterValues();

            ParameterDiscreteValue valNam = new ParameterDiscreteValue();

            valNam.Value = this.idBangLuong;

            paraNam.Add(valNam);

            rpt.DataDefinition.ParameterFields["@idBangLuong"].ApplyCurrentValues(paraNam);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
