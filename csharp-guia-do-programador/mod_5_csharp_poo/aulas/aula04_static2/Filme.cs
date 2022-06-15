using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_static2
{
    internal class Filme
    {
        public string nome;
        public string desc;
        public int ano;
        public string estudio;

        public Filme(string nome, string desc, int ano, string estudio)
        {
            this.nome = nome;
            this.desc = desc;
            this.ano = ano;
            this.estudio = estudio;
        }
    }
}
