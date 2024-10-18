/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 16/10/2024
 * DatabaseAccess.cs
 */
namespace DAL
{
    public class DatabaseAccess
    {
        // Fields
        private QLSTDataContext db = new QLSTDataContext();
        private string serverName = ".\\SQLEXPRESS";
        private string dbName = "QuanLySieuThi";

        // Constructors
        public DatabaseAccess(QLSTDataContext db, string serverName, string dbName)
        {
            this.db = db;
            this.serverName = serverName;
            this.dbName = dbName;
        }

        public DatabaseAccess()
        {
            Db = new QLSTDataContext(Properties.Settings.Default.QuanLySieuThiConnectionString);
        }

        // Properties
        public QLSTDataContext Db { get => db; set => db = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string DbName { get => dbName; set => dbName = value; }
    }
}
