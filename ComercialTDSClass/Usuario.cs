using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ComercialTDSClass
{
    public class Usuario
    {
        // Propriedades 
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Nivel? Nivel { get; set; }
        public bool? Ativo { get; set; }
        
        // Métodos construtores.
        public Usuario()
        {
            Nivel = new();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        }
        // Receber todos os dados
        public Usuario(int? id, string? nome, string? email, string? senha, Nivel? nivelId, bool? ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivelId;
            Ativo = ativo;
        }

        public Usuario(string? nome, string? email, string? senha, Nivel? nivelId)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivelId;
        }

        // Insert
        public Usuario(string? nome, string? email, string? senha, Nivel? nivelId, bool? ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivelId;
            Ativo = ativo;
        }

        public Usuario(int? id, string? senha)
        {
            Id = id;
            Senha = senha;
        }

        public Usuario(int? id, string? nome, string? senha, Nivel? nivelId, bool? ativo)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Nivel = nivelId;
            Ativo = ativo;
        }


        /// <summary>
        /// Esse método adiciona um registro de usuario ao banco de dados.
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Id);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);

            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }

        /// <summary>
        /// Método Atualizar altera nome, senha e nivel da tabela usuarios.
        /// </summary>
        /// <returns>Boleano</returns>
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);

            return cmd.ExecuteNonQuery() > 0 ? true : false;
       
        }

        /// <summary>
        /// Método ObterPorid retorna registros de um usuario no banco de dados.
        /// </summary>
        /// <param name="id">Id do usuario</param>
        /// <returns>Objeto do tipo Usuario</returns>
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new
                    (
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        Nivel.ObterPorId(dr.GetInt32(4)),
                        dr.GetBoolean(5)
                    );
            }
            dr.Close();

            cmd.Connection.Close();
            return usuario;
        }

        /// <summary>
        /// Método Obter lista retorna registros de usuarios no banco de dados.
        /// </summary>
        /// <returns></returns>
        public static List<Usuario> ObterLista()
        {
            List<Usuario> usuarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from usuarios order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add
                (new
                    (
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        Nivel.ObterPorId(dr.GetInt32(4)),
                        dr.GetBoolean(5)
                    )
                );
            }
            dr.Close();

            cmd.Connection.Close();
            return usuarios;
        }

        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();

            return usuario;
        }

        public static bool AlterarSenha(string email, string senha)
        {
            

            return true;
        }

    }
}
