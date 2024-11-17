/*
 * PTUD 2 - Nhom 2
 * Chau Nhat Tai
 * Nguyen Quoc Luong
 * Le Van Toan
 * program.cs
 * 21/10/2024
 */
using System;
using System.Windows.Forms;

namespace Nhom2___PTUD___QLST
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Open frmFlash
            frmFlash f = new frmFlash();
            f.ShowDialog();

            // frmFlash == OK
            if (f.DialogResult == DialogResult.OK)
            {
                // Open frmDangNhap
                frmDangNhap fDN = new frmDangNhap();
                fDN.ShowDialog();
            }

            //Application.Run(new frmMain());
        }
    }
}
