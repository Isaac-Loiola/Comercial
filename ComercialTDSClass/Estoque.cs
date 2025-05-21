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

        public Estoque( double quantidade, DateTime dataUltimoMovimento)
        {
            Quantidade = quantidade;
            DataUltimoMovimento = dataUltimoMovimento;
        }

        public bool Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update estoques set quantidade = {Quantidade} and data_ultimo_movimento = {DataUltimoMovimento}";
            int resultado = cmd.ExecuteNonQuery();
            if(resultado == 1)
            {
                return true;
            }

            return false;
        }
    }
}
