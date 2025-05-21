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

    }
}
