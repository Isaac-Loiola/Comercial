﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Google.Protobuf;

namespace ComercialTDSClass
{
    public class Nivel
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
            cmd.Connection.Close();
        }

        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from niveis where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nivel = new(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
            }
            dr.Close();
            cmd.Connection.Close();

            return nivel;
        }

        public static List<Nivel> ObterLista()
        {
            List<Nivel> niveis = new();

            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from niveis order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                niveis.Add
                    (
                        new
                         (
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2)
                         )
                    );
            }
            dr.Close();
            cmd.Connection.Close();
            return niveis;
        }

        /// <summary>
        /// Método não estático, precisamos considerar que as propriedades de Nivel já devem possuir valor.
        /// </summary>
        /// <returns>Booleano</returns>
        public bool Atualizar()
        {
            bool atualizado = false;
            if(Id < 1)
            {
                return false;
            }

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_niveis_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            if(cmd.ExecuteNonQuery() > 0)
            {
                atualizado = true;
            }

            cmd.Connection.Close();
            return atualizado;
        }
    }
}
