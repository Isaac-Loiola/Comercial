using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public static class Banco
    {
        public static string StrConn { get; set; }

        public static MySqlCommand Abrir(string strconn="")
        {
            MySqlCommand cmd = new();

            StrConn = strconn;
            if (StrConn == string.Empty)
            {
                //StrConn = $@"server=10.91.47.220;database=comercialtdsdb01;user=root;password=123"; // Work
                StrConn = $@"server=127.0.0.1;database=comercialtdsdb01;user=root;password="; // home
                MySqlConnection cn = new(StrConn);

                try
                {
                    cn.Open(); // Passando por aqui terá uma conexão aberta.
                    cmd.Connection = cn;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return cmd;

        }
    }
}
