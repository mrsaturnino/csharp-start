using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Netflix.com.br; //também podemos "importar" outros namespaces do programa, facilitando a criação de objetos e visualização das classes.

namespace aula07_namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrimeVideo.com.br.Filme filmePrimeVideo = new PrimeVideo.com.br.Filme(); //objeto da classe "Filme" do namespace: "PrimeVideo.com.br"

            Filme filmePrincipal = new Filme(); //objeto da classe "Filme" do namespace: "aula07_namespaces"

            Serie serie = new Serie(); //Puxando uma classe/tipo do namespace importado "Netflix.com.br";

        }
    }
}
