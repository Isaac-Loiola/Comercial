using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ComercialTDSClass
{
    class Nivel
    {

        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string Sigla { get; set; }

        public Nivel()
        {

        }
        public Nivel(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public Nivel( string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        // Inserir, Atualizar - id, Listar, ObterPorId - id
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_nivel_insert";
            //cmd.Parameters.Add("spnome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
    }
}
