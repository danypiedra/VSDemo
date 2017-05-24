using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HElloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);
            Console.ReadKey();
        }
    }
}
