using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicAplications_DateHourAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateUser;
            Console.WriteLine("Introduce the date: (dd/MM/yyyy)");
            dateUser = DateTime.Parse(Console.ReadLine());
            var today = DateTime.Today;
          
            Console.WriteLine( "Han pasado " + (today - dateUser).Days + " dias");
            Console.ReadLine();
        }
    }
}
