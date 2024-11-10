/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 01/11/2024
 * DTO_Log.cs
 */
using System;

namespace DTO
{
    public class DTO_Log
    {
        // Fields
        private int id;
        private string log_name;
        private string model;
        private int model_id;
        private string action;
        private string data_olds;
        private string data_news;
        private int is_deleted;
        private int created_by;
        private DateTime created_at;
        private int updated_by;
        private DateTime updated_at;

        // Constructors
        public DTO_Log(int id, string log_name, string model, int model_id, string action, string data_olds, string data_news, int is_deleted, int created_by, DateTime created_at, int updated_by, DateTime updated_at)
        {
            this.id = id;
            this.log_name = log_name;
            this.model = model;
            this.model_id = model_id;
            this.action = action;
            this.data_olds = data_olds;
            this.data_news = data_news;
            this.is_deleted = is_deleted;
            this.created_by = created_by;
            this.created_at = created_at;
            this.updated_by = updated_by;
            this.updated_at = updated_at;
        }

        public DTO_Log(int id, string log_name, string model, int model_id, string action, string data_olds, string data_news)
        {
            this.id = id;
            this.log_name = log_name;
            this.model = model;
            this.model_id = model_id;
            this.action = action;
            this.data_olds = data_olds;
            this.data_news = data_news;
        }

        public DTO_Log(string log_name, string model, int model_id, string action, string data_olds, string data_news)
        {
            this.log_name = log_name;
            this.model = model;
            this.model_id = model_id;
            this.action = action;
            this.data_olds = data_olds;
            this.data_news = data_news;
        }

        public DTO_Log(int id, string model, int model_id, string action, string data_olds, string data_news)
        {
            this.id = id;
            this.model = model;
            this.model_id = model_id;
            this.action = action;
            this.data_olds = data_olds;
            this.data_news = data_news;
        }

        public DTO_Log(string model, int model_id, string action, string data_olds, string data_news)
        {
            this.model = model;
            this.model_id = model_id;
            this.action = action;
            this.data_olds = data_olds;
            this.data_news = data_news;
        }

        // Properties
        public int Id { get => id; set => id = value; }
        public string Log_name { get => log_name; set => log_name = value; }
        public string Model { get => model; set => model = value; }
        public int Model_id { get => model_id; set => model_id = value; }
        public string Action { get => action; set => action = value; }
        public string Data_olds { get => data_olds; set => data_olds = value; }
        public string Data_news { get => data_news; set => data_news = value; }
        public int Is_deleted { get => is_deleted; set => is_deleted = value; }
        public int Created_by { get => created_by; set => created_by = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public int Updated_by { get => updated_by; set => updated_by = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
