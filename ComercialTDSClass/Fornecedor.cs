using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
           
        /// <summary>
        /// Método para Inserir um fornecedor ao banco de dados!
        /// Propriedades necessárias: RazaoSocial, Fantasia, Cpnj, Contato, Telefone, Email.
        /// </summary>
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
        
        /// <summary>
        /// Método para atualizar registro de um fornecedor!
        /// Propriedades necessárias: Id, Fantasia, Contato, Telefone, Email.
        /// </summary>
        /// <returns>Booleano</returns>
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            bool retorno = cmd.ExecuteNonQuery() > 0 ? true : false;

            cmd.Connection.Close();
            return retorno;
        }

        /// <summary>
        /// Método para listar todos fornecedores do banco de dados!
        /// </summary>
        /// <returns>Lista de fornecedores</returns>
        public static List<Fornecedor> ObterLista()
        {
            List<Fornecedor> fornecedores = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from fornecedores";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedores.Add
                    (
                        new
                            (
                                dr.GetInt32(0),
                                dr.GetString(1),
                                dr.GetString(2),
                                dr.GetString(3),
                                dr.GetString(4),
                                dr.GetString(5),
                                dr.GetString(6)
                            )

                    );
            }
            dr.Close();
            cmd.Connection.Close();
            return fornecedores;
        }
    }
}
