/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 01/11/2024
 * BUS_Log.cs
 */
using DAL;
using DTO;
using System.Linq;

namespace BUS
{
    public class BUS_Log
    {
        // Fields
        private DAL_Log dal_log = new DAL_Log();

        // Methods
        public IQueryable GetListLog()
        {
            return dal_log.GetListLog();
        }

        public void AddLog(DTO_Log log)
        {
            dal_log.AddLog(log);
        }

        public void UpdateLog(DTO_Log log)
        {
            dal_log.UpdateLog(log);
        }

        public void DelLog(int id)
        {
            dal_log.DelLog(id);
        }

        public void AddLog2(DTO_Log log)
        {
            dal_log.AddLog2(log);
        }

        public void UpdateLog2(DTO_Log log)
        {
            dal_log.UpdateLog2(log);
        }

        public void AddLog3(DTO_Log log)
        {
            dal_log.AddLog3(log);
        }
    }
}
