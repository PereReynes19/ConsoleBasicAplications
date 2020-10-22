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
            var today = DateTime.Now;
          
            Console.WriteLine( "Han pasado " + (today - dateUser).Days + " days");
            Console.WriteLine();

            TimeSpan hourUser;
            Console.WriteLine("Introduce the hour: (hh:mm)");
            hourUser = TimeSpan.Parse(Console.ReadLine());
            var resultH = (today - hourUser).Hour;
            var resultM = (today - hourUser).Minute;
            
            Console.WriteLine("It passed " + resultH + ":" + resultM + " hours");
            Console.ReadLine();

        }
    }
}
