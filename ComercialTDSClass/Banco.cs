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
            string strconn = @"server=10.91.47.220;database=comercialtdsdb01;user=root;password=123"; // Work

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
