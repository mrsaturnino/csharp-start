using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06_polimorfismo
{
    class Program
    { 
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Matutino", "Andre", "mrsaturnino@hotmail.com", "532123");
            
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(a);



            Console.ReadLine();
        }
    }
}
