/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 01/11/2024
 * DAL_Log.cs
 */
using DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Log
    {
        // Fields
        private DatabaseAccess da = new DatabaseAccess();

        // Methods
        public IQueryable GetListLog()
        {
            IQueryable query = from log in da.Db.Logs
                               where log.is_deleted == 0
                               select new
                               {
                                   log.id,
                                   log.log_name,
                                   log.model,
                                   log.model_id,
                                   log.action,
                                   log.data_olds,
                                   log.data_news
                               };
            return query;
        }

        public void AddLog(DTO_Log log)
        {
            try
            {
                // Checked log != null
                if (log != null)
                {
                    da.Db.Logs.InsertOnSubmit(new Log
                    {
                        log_name = log.Log_name,
                        model = log.Model,
                        model_id = log.Model_id,
                        action = log.Action,
                        data_olds = log.Data_olds,
                        data_news = log.Data_news,
                        is_deleted = 0,
                        created_by = 0,
                        created_at = DateTime.Now,
                        updated_by = 0,
                        updated_at = DateTime.Now
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm log mới thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Log mới đã có trong dữ liệu.",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        public void UpdateLog(DTO_Log log)
        {
            try
            {
                // Initialize Variable
                string nameLog = string.Empty;

                // Checked log saved in db log
                var query = from l in da.Db.Logs
                            where l.id == log.Id
                            select l;

                if (query.FirstOrDefault() != null)
                {
                    Log log_update = da.Db.Logs.SingleOrDefault(lo => lo.id == log.Id);
                    log_update.log_name = log.Log_name;
                    log_update.model = log.Model;
                    log_update.model_id = log.Model_id;
                    log_update.action = log.Action;
                    log_update.data_olds = log.Data_olds;
                    log_update.data_news = log.Data_news;
                    log_update.is_deleted = 0;
                    log_update.created_by = 0;
                    log_update.created_at = DateTime.Now;
                    log_update.updated_by = 0;
                    log_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameLog = log_update.log_name;

                    // Messaged
                    MessageBox.Show($"Sửa thông tin log [{nameLog}] thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Sửa thông tin log [{nameLog}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        public void DelLog(int id)
        {
            try
            {
                // Initialize Variable
                string nameLog = string.Empty;

                // Checked log saved in db log
                var query = from l in da.Db.Logs
                            where l.id == id
                            select l;

                if (query.Count() == 1)
                {
                    Log log_update = da.Db.Logs.SingleOrDefault(lo => lo.id == id);
                    log_update.is_deleted = 1;
                    log_update.created_by = 0;
                    log_update.created_at = DateTime.Now;
                    log_update.updated_by = 0;
                    log_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameLog = log_update.log_name;

                    // Messaged
                    MessageBox.Show($"Xóa log [{nameLog}] thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Xóa log [{nameLog}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // AddLog2 not have log_name
        public void AddLog2(DTO_Log log)
        {
            try
            {
                // Checked log != null
                if (log != null)
                {
                    // Get max(id) from table log
                    var query2 = da.Db.Logs.OrderByDescending(l => l.id).FirstOrDefault();

                    da.Db.Logs.InsertOnSubmit(new Log
                    {
                        log_name = query2.id < 10 ? "LOG_NAME_0" + (query2.id + 1) : "LOG_NAME_" + (query2.id + 1),
                        model = log.Model,
                        model_id = log.Model_id,
                        action = log.Action,
                        data_olds = log.Data_olds,
                        data_news = log.Data_news,
                        is_deleted = 0,
                        created_by = 0,
                        created_at = DateTime.Now,
                        updated_by = 0,
                        updated_at = DateTime.Now
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    MessageBox.Show("Thêm log mới thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Thêm không thành công! Log mới đã có trong dữ liệu.",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // UpdateLog2 not have log_name
        public void UpdateLog2(DTO_Log log)
        {
            try
            {
                // Initialize Variable
                string nameLog = string.Empty;

                // Checked log saved in db log
                var query = from l in da.Db.Logs
                            where l.id == log.Id
                            select l;

                if (query.FirstOrDefault() != null)
                {
                    Log log_update = da.Db.Logs.SingleOrDefault(lo => lo.id == log.Id);
                    log_update.model = log.Model;
                    log_update.model_id = log.Model_id;
                    log_update.action = log.Action;
                    log_update.data_olds = log.Data_olds;
                    log_update.data_news = log.Data_news;
                    log_update.is_deleted = 0;
                    log_update.created_by = 0;
                    log_update.created_at = DateTime.Now;
                    log_update.updated_by = 0;
                    log_update.updated_at = DateTime.Now;

                    // Saved db
                    da.Db.SubmitChanges();
                    nameLog = log_update.log_name;

                    // Messaged
                    MessageBox.Show($"Sửa thông tin log [{nameLog}] thành công!",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    MessageBox.Show("Sửa thông tin log [{nameLog}] không thành công! Vui lòng kiểm tra các thông tin đã nhập chính xác hay không?",
                       "Thông báo",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // AddLog3 using saving Log CRUD
        public void AddLog3(DTO_Log log)
        {
            try
            {
                // Checked log != null
                if (log != null)
                {
                    // Get max(id) from table log
                    var query2 = da.Db.Logs.OrderByDescending(l => l.id).FirstOrDefault();

                    da.Db.Logs.InsertOnSubmit(new Log
                    {
                        log_name = query2.id < 10 ? "LOG_NAME_0" + (query2.id + 1) : "LOG_NAME_" + (query2.id + 1),
                        model = log.Model,
                        model_id = log.Model_id,
                        action = log.Action,
                        data_olds = log.Data_olds,
                        data_news = log.Data_news,
                        is_deleted = 0,
                        created_by = 0,
                        created_at = DateTime.Now,
                        updated_by = 0,
                        updated_at = DateTime.Now
                    });

                    // Saved db
                    da.Db.SubmitChanges();

                    // Messaged
                    //MessageBox.Show("Thêm log mới thành công!",
                    //   "Thông báo",
                    //   MessageBoxButtons.OK,
                    //   MessageBoxIcon.Information);
                }
                else
                {
                    // Messaged
                    //MessageBox.Show("Thêm không thành công! Log mới đã có trong dữ liệu.",
                    //   "Thông báo",
                    //   MessageBoxButtons.OK,
                    //   MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
