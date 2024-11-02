/*
 * Chau Nhat Tai
 * Nhom2 - PTUD2 - QLST
 * 01/11/2024
 * DataValidation.cs
 */
namespace BUS
{
    public class DataValidation
    {
        // Fields
        private string str_name;
        private int str_length;

        // Constructors
        public DataValidation(string str_name, int str_length)
        {
            this.str_name = str_name;
            this.str_length = str_length;
        }

        public DataValidation()
        {
            this.str_name = string.Empty;
            this.str_length = 0;
        }

        // Properties
        public string Str_name { get => str_name; set => str_name = value; }
        public int Str_length { get => str_length; set => str_length = value; }

        // Methods
        public bool CheckString(string name, int strlength)
        {
            this.str_name = name;
            this.str_length = strlength;
            if (str_name != string.Empty && name.Length <= strlength)
            {
                return true;
            }
            return false;
        }

        public bool CheckNumber(string name, int strlength)
        {
            this.str_name = name;
            this.str_length = strlength;

            if (str_name == null)
            {
                return false;
            }

            if (str_name.Length > str_length)
            {
                return false;
            }

            for (int i = 0; i < str_name.Length; i++)
            {
                if (str_name[i] >= 'a' && str_name[i] <= 'z' || str_name[i] >= 'A' && str_name[i] <= 'Z')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
