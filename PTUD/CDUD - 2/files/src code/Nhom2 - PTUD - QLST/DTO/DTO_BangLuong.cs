using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BangLuong
    {
        //properties
        private int id;
        private string maBangLuong;
        private DateTime thangNam;
        private float tongGioCong;
        private float _luong;
        //method
        public DTO_BangLuong(string maBangLuong, DateTime thangNam, float tongGioCong, float luong)
        {
            this.MaBangLuong = maBangLuong;
            this.ThangNam = thangNam;
            this.TongGioCong = tongGioCong;
            Luong = luong;
        }

        public DTO_BangLuong(int id, string maBangLuong, DateTime thangNam, float tongGioCong, float luong)
        {
            this.Id = id;
            this.MaBangLuong = maBangLuong;
            this.ThangNam = thangNam;
            this.TongGioCong = tongGioCong;
            Luong = luong;
        }

        public int Id { get => id; set => id = value; }
        public string MaBangLuong { get => maBangLuong; set => maBangLuong = value; }
        public DateTime ThangNam { get => thangNam; set => thangNam = value; }
        public float TongGioCong { get => tongGioCong; set => tongGioCong = value; }
        public float Luong { get => _luong; set => _luong = value; }
      
    }
}
