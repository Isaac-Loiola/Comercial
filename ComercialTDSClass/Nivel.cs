using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Inserir, Atualizar
    }
}
