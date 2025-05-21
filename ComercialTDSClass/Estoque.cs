using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Estoque
    {
        public int ProdutoId { get; set;}
        public double Quantidade { get; set; }
        public DateTime DataUltimoMovimento { get; set; }

        public Estoque()
        {

        }

        public Estoque(int produtoId, double quantidade, DateTime dataUltimoMovimento)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }

        public Estoque(int produtoId, double quantidade)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
        }

        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_estoque_insert";
            cmd.Parameters.AddWithValue("spproduto_id", ProdutoId);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);

            int resultado = cmd.ExecuteNonQuery();
            if(resultado == 1)
            {
                return true;
            }

            return false;
        }

        public static List<Estoque> ObterLista()
        {
            List<Estoque> estoques = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from estoques";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoques.Add
                    (
                        new
                        (
                            dr.GetInt32(0),
                            dr.GetDouble(1),
                            dr.GetDateTime(2)
                        )
                    );
            }
            dr.Close();
            cmd.Connection.Close();

            return estoques;
        }
    }
}
