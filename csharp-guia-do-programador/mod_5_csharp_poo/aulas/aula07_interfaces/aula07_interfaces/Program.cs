using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula07_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable forma = new SetaDireita();

            forma.Draw();

            Console.ReadLine();
        }
    }
    //As interfaces basicamente nos ajudam a organizar melhor o código. Como vemos acima, podemos facilmente criar uma instância de uma classe que segue o contrato da "interface".

    //Usando como exemplo a parte de desenhar formas geométricas do Paint.
    interface IDrawable
    {
        void Draw(); //função de desenhar a forma geométrica.
        float Area(); //função para determinar a Área da forma geométrica.
    }
    class SetaDireita : IDrawable
    {
        //linha
        public float Area()
        {
            return 20.5f; //tamanho/área de forma geométrica de exemplo.
        }

        public void Draw()
        {
            Console.WriteLine("→");
        }
    }

    class SetaBaixo : IDrawable
    {
        //retangulo
        public float Area()
        {
            return 180.5f;
        }

        public void Draw()
        {
            Console.WriteLine("↓");
        }
    }

    class SetaEsquerda : IDrawable
    {
        //quadrado
        public float Area()
        {
            return 85.5f;
        }

        public void Draw()
        {
            Console.WriteLine("←");
        }
    }
}
