using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Produto
    {
        public int? Id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public double ValorUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public Categoria? Categoria { get; set; }
        public double EstoqueMinimo { get; set; }
        public  double Desconto { get; set; }
        public byte[]? Imagem { get; set; }
        public DateTime DataCad { get; set; }
        public int? Descontinuado { get; set; }

    }
}
