/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 09/11/2024
 * DTO_ThanhTien.cs
 */
namespace DTO
{
    public class DTO_ThanhTien
    {
        // Fields
        private int thanhTien;

        // Constructors
        public DTO_ThanhTien(int thanhTien)
        {
            this.thanhTien = thanhTien;
        }

        public DTO_ThanhTien()
        {
            this.thanhTien = 0;
        }

        // Properties
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
