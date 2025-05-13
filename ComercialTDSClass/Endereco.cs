  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace ComercialTDSClass
{
    public class Endereco
    {
        public int? Id { get; set;}
        public int? ClienteId { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set;}
        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }

        public static List<Endereco> ObterListaPorClienteId(int idCliente)
        {
            List<Endereco> enderecos = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where id = {idCliente}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

            }

            return enderecos;
        } 
    }
}
