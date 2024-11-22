namespace Nhom2___PTUD___QLST.NhatTai
{
    partial class frmInHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInHD));
            this.crvInHd = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.GetHdByMaHd1 = new Nhom2___PTUD___QLST.Report.GetHdByMaHd();
            this.SuspendLayout();
            // 
            // crvInHd
            // 
            this.crvInHd.ActiveViewIndex = -1;
            this.crvInHd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInHd.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInHd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInHd.Location = new System.Drawing.Point(0, 0);
            this.crvInHd.Name = "crvInHd";
            this.crvInHd.ReportSource = this.GetHdByMaHd1;
            this.crvInHd.Size = new System.Drawing.Size(1333, 623);
            this.crvInHd.TabIndex = 0;
            // 
            // frmInHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.crvInHd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInHD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInHD_FormClosing);
            this.Load += new System.EventHandler(this.frmInHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInHd;
        private Report.GetHdByMaHd GetHdByMaHd1;
    }
}