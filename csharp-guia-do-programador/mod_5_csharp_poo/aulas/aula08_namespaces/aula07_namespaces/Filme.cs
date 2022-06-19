using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_namespaces //Namespace principal do programa

{
    //Não podemos ter classes com nomes iguais no mesmo namespace. Por isso criamos outro namespace para utilizar uma classe que tenha o mesmo nome de uma outra que vem do nosso namespace principal. 
    class Filme
    {
        public string nome;
        public string desc;
        public int ano;
        public string estudio;

    }
}
