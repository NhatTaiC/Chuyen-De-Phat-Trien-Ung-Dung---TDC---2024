﻿namespace Nhom2___PTUD___QLST.VanToan
{
    partial class frmVanToan
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ThongKeSPTrongKho1 = new Nhom2___PTUD___QLST.Report.ThongKeSPTrongKho();
            this.ThongKeSPTrongKho2 = new Nhom2___PTUD___QLST.Report.ThongKeSPTrongKho();
            this.ThongKeSPTrongKho3 = new Nhom2___PTUD___QLST.Report.ThongKeSPTrongKho();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1402, 707);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmVanToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 707);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmVanToan";
            this.Text = "frm_VanToan";
            this.Load += new System.EventHandler(this.frmVanToan_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Report.ThongKeSPTrongKho ThongKeSPTrongKho1;
        private Report.ThongKeSPTrongKho ThongKeSPTrongKho2;
        private Report.ThongKeSPTrongKho ThongKeSPTrongKho3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}