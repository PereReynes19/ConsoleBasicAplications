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
          List<PersonModel> personaModels = PersonaModelNombre();

            foreach (PersonModel noms2 in personaModels)
            {
                Console.WriteLine("Hola " + noms2);
                Thread.Sleep(1000);
            }

        }

        private static List<string> PersonaModelNombre()
        {
            List<PersonModel> surt = new List<PersonModel>();

            surt.Add(new PersonModel {FirstName = "Jaime", LastName = "Ripoll" });
            surt.Add(new PersonModel { FirstName = "Oscar", LastName = "Garcia" });
            surt.Add(new PersonModel { FirstName = "Lorenzo", LastName = "Lopez" });
        }
    }
}
