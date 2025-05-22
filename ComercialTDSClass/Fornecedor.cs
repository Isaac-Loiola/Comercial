using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Fornecedor
    {

        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public string Cnpj { get; set; }
        public string Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Fornecedor(int id, string razaoSocial, string fantasia, string cnpj, string contato, string telefone, string email)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public Fornecedor( string razaoSocial, string fantasia, string cnpj, string contato, string telefone, string email)
        {
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            Cnpj = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public Fornecedor(string razaoSocial, string fantasia, string contato, string telefone, string email)
        {
            RazaoSocial = razaoSocial;
            Fantasia = fantasia;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_forncedor_insert";
            cmd.Parameters.AddWithValue("sprazao_social", RazaoSocial);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
    }
}
