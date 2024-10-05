using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDUD1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Form formOld = null;
        public void openForm(Form formnew)
        {
            if (formOld != null)
            {
                formnew.MdiParent = this;
                formnew.ControlBox = false;
                formnew.Show();
                formOld = formnew;
                formOld.Close();
            }
            else
            {
                formnew.MdiParent = this;
                formnew.ControlBox = false;
                formnew.Show();
                formOld = formnew;
            }
        }
        private void đanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inẤnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
