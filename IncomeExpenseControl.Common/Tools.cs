using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseControl.Common
{
    public class Tools
    {
        public void DataGridViewResize(DataGridView grid, int sayi)
        {
            try
            {
                for (int i = 0; i < sayi; i++)
                {
                    grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public string MD5Encryption(string name)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(name));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public string CreateCode()
        {
            Random Rnd = new Random();
            StringBuilder StrBuild = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                int ASCII = Rnd.Next(65, 91);
                char Karakter = Convert.ToChar(ASCII);
                StrBuild.Append(Karakter);
            }
            return StrBuild.ToString();
        }
    }
}
