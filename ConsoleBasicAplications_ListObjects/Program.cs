using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleBasicAplications_ListObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombres = new List<String>() {"Marti Ripoll", "Pere Boladeras", "Stoik Axondo"};

            foreach (String nombre in nombres)
            {
                Console.WriteLine(nombre);
                Thread.Sleep(1000);
            }
        }
    }
}
