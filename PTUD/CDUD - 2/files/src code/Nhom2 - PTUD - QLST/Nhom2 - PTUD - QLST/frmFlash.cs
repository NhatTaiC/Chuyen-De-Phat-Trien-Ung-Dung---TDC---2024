/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 05/05/2024
* frmFlashForm.cs
*/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
namespace Nhom2___PTUD___QLST
{
    public partial class frmFlash : Form
    {
        public frmFlash()
        {
            InitializeComponent();
        }

        // frmFlashForm_Load
        private void frmFlashForm_Load(object sender, EventArgs e)
        {
            backupdataBase();
            
        }
        private void backupdataBase()
        {
            string sqlConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=master;Integrated Security=True;";
            string databaseName = "QuanLySieuThi";
            string scriptFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "QLST_Scripts.sql");

            // Kiểm tra xem cơ sở dữ liệu đã tồn tại chưa
            using (SqlConnection conn = new SqlConnection(sqlConnectionString))
            {
                conn.Open();

                // Truy vấn để kiểm tra sự tồn tại của database
                string checkDatabaseQuery = "SELECT COUNT(1) FROM sys.databases WHERE name = @DatabaseName";
                using (SqlCommand cmd = new SqlCommand(checkDatabaseQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@DatabaseName", databaseName);

                    int databaseExists = (int)cmd.ExecuteScalar();
                    if (databaseExists > 0)
                    {
                        //MessageBox.Show("Đã có database");
                        // Nếu cơ sở dữ liệu đã tồn tại, không cần chạy lại script
                        return;
                    }
                }

                // Nếu database chưa tồn tại, đọc và xử lý script SQL
                string script = File.ReadAllText(scriptFilePath);

                // Tách các lệnh SQL theo "GO"
                string[] sqlBatches = script.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                // Thực thi từng batch
                foreach (string sqlBatch in sqlBatches)
                {
                    if (!string.IsNullOrWhiteSpace(sqlBatch))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlBatch, conn))
                        {
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Lỗi khi chạy lệnh SQL: {ex.Message}");
                            }
                        }
                    }
                }
                MessageBox.Show("Khởi tạo dữ liệu thành công!!");
            }
        }

        // timer1_Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            timer1.Enabled = false;
        }
    }
}
