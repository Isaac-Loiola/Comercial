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
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set;}
        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }

        public Endereco(int? id, int? clienteId, string cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            Id = id;
            ClienteId = clienteId;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }

        public Endereco(int? clienteId, string cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipoEndereco)
        {
            ClienteId = clienteId;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }

        public static List<Endereco> ObterListaPorClienteId(int idCliente)
        {
            List<Endereco> enderecos = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where id = {idCliente}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add
                    (
                        new
                            (
                                dr.GetInt32(1),
                                dr.GetString(2),
                                dr.GetString(3),
                                dr.GetString(4),
                                dr.GetString(5),
                                dr.GetString(6),
                                dr.GetString(7),
                                dr.GetString(8),
                                dr.GetString(9)
                            )
                    );
            }
            dr.Close();
            cmd.Connection.Close();
            return enderecos;
        } 
    }
}
