using Ispit.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ucenici = new List<Ucenik>();
            for (int i = 0; i < 3; i++) 
            {
                Console.Write("Unesite ime ucenika: ");
                var ime = Console.ReadLine();
                Console.Write("Unesite prezime ucenika: ");
                var prezime = Console.ReadLine();
                Console.Write("Unesite datum rodenja: ");
                var datumrodjenja = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy.", CultureInfo.InvariantCulture);
                Console.Write("Unesite prosjek: ");
                var prosjek = Console.ReadLine();

                ucenici.Add(new Ucenik
                {
                    Datumrodjenja = datumrodjenja,
                    Ime = ime,
                    Prezime = prezime,
                    Prosjek = double.Parse(prosjek)
                });

            }

            Console.WriteLine();

            foreach (var ucenik in ucenici)
            {
                Console.WriteLine(ucenik.ToString());
            }

        }
    }
}
