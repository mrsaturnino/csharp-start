using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*e-commerce celulares
            Produto produto = new Produto();
            produto.modelo = "Samsung Galaxy A32";
            produto.preco = 1.334f;
            produto.descricao = "Descrição: Samsung Galaxy A32 - Tela infinita de 6,4'', 4G, 128GB";
            produto.estoque = 54;
            produto.Smartphone();
            */

            //loja virtual games
            LojaGame game = new LojaGame();
            game.name = "Fifa 2022";
            game.plataforma = "PC, PS4 e XBOX One";
            game.preco = 150.00f;
            game.descricao = "Jogo de futebol";
            game.Games();
        }
    }
}
