using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    class Usuario
    {
        // Propriedades 
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Nivel? NivelId { get; set; }
        public bool? Ativo { get; set; }
        
        // Métodos construtores.
        public Usuario()
        {
             
        }
        // Receber todos os dados
        public Usuario(int? id, string? nome, string? email, string? senha, Nivel? nivelId, bool? ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            NivelId = nivelId;
            Ativo = ativo;
        }

        public Usuario(string? nome, string? email, string? senha, Nivel? nivelId)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            NivelId = nivelId;
        }

        // Insert
        public Usuario(string? nome, string? email, string? senha, Nivel? nivelId, bool? ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            NivelId = nivelId;
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
            NivelId = nivelId;
            Ativo = ativo;
        }

        public void Inserir()
        {

        }

        public bool Atualizar()
        {
            return true;
        }

        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();

            return usuario;
        }

        public static List<Usuario> ObterLista()
        {
            List<Usuario> usuarios = new();
            
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
