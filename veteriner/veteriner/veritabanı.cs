using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace veteriner
{
    internal class veritabanı
    {
        public SqlConnection baglanti()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SBN71LL\SQLEXPRESS;Initial Catalog=veterinerdb;Integrated Security=True;MultipleActiveResultSets=True");

            con.Open();
            return con;
                
        }

        public static string MD5Sifrele(string şifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(şifrelenecekMetin);
            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();
            foreach(byte item in dizi)
            {
                sb.Append(item.ToString("x2").ToLower());

            }

            return sb.ToString();

        }
    }
}
