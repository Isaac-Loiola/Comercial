using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    class Banco
    {
        public MySqlCommand Abrir()
        {
            MySqlCommand cmd = new();
            string strconn = @"server=127.0.0.1;database=comercialtds;user=root;password=";

            MySqlConnection cn = new(strconn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cmd;
        }
    }
}
