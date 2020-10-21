using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleBasicAplications_StringsList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombres = new List<String>() {"Juan Rodriguez", "Pere Reynes", "Maria Garcia"};

            foreach (string nombre in nombres)
            {
                Console.WriteLine("Hola " + nombre);
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
}
