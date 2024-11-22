using CrystalDecisions.Shared;
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
    public partial class frmThongKeLoiNhuan : Form
    {
        public frmThongKeLoiNhuan()
        {
            InitializeComponent();
            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            string[] arr2 = { "2010", "2011","2012","2013","2014","2015","2016","2017","2018","2019","2020","2021","2022","2023","2024"};
            cbThang.DataSource = arr;
            cbNam.DataSource = arr2;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng rpt
            LoiNhuanTheoThang rpt = new LoiNhuanTheoThang();

            // Khởi tạo ParameterValues
            ParameterValues para = new ParameterValues();
            ParameterValues para2 = new ParameterValues();

            // Khởi tạo ParameterDiscreteValue
            ParameterDiscreteValue val = new ParameterDiscreteValue();
            ParameterDiscreteValue val2 = new ParameterDiscreteValue();

            // Gán giá trị cho ParameterDiscreteValue
            val.Value = cbThang.SelectedValue.ToString();
            val2.Value = cbNam.SelectedValue.ToString();

            // Thêm val vào para
            para.Add(val);
            para2.Add(val2);

            // Định nghĩa biến tham gia cho rpt
            rpt.DataDefinition.ParameterFields["@thang"].ApplyCurrentValues(para);
            rpt.DataDefinition.ParameterFields["@nam"].ApplyCurrentValues(para2);

            // Gọi rpt
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
