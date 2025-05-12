using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ComercialTDSClass
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set;}
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Ativo { get; set; }  
        public List<Endereco> Endereco { get; set; }

        public Cliente()
        {

        }
        public Cliente(int id, string nome, string cpf, string telefone, string email, DateTime dataNascimento, DateTime dataCadastro, int ativo, List<Endereco> endereco)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
            Ativo = ativo;
            Endereco = endereco;
        }

        public Cliente(string nome, string cpf, string telefone, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
        }


        /// <summary>
        /// Método Inserir adiciona um registro de um cliente no banco de dados. 
        /// Propriedades necessárias: Nome, Cpf, Telefone, Email, DataNascimento.
        /// </summary>
        public void Inserir()
        {
            // Referenciando valores nas procedures.
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", DataNascimento);

            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }
        
        /// <summary>
        /// Método Atualizar altera dados de um registro de um cliente. 
        /// Propriedades necessárias: Id, Nome, Telefone, DataNascimento.
        /// </summary>
        /// <returns>boleano</returns>
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", DataNascimento);
            return cmd.ExecuteNonQuery() > 0? true: false;
        }
    }
}
