using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace balkezesek
{
    class Program
    {
        static List<Balkez> balkez = new List<Balkez>();
        static Dictionary<string, int> utoljara = new Dictionary<string, int>();
        static int evszam = 0;
        static void Beolvas()
        {
            StreamReader be = new StreamReader("balkezesek.csv");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                balkez.Add(new Balkez(be.ReadLine()));
            }
            be.Close();
            Console.WriteLine($"3.Feladat: {balkez.Count}");
        }

        static void Negyedik()
        {
            Console.WriteLine("4.Feladat:");
            foreach (var i in balkez)
            {
                if (i.Utolso.Contains("1999-10"))
                {
                    utoljara.Add(i.Nev, i.Magassag);
                }
            }

            foreach (var i in utoljara)
            {
                Console.WriteLine($"\t{i.Key}, {Math.Round(i.Value*2.54,1)}");
            }
        }

        static void Otodik()
        {
            while (true)
            {
                Console.WriteLine("5. Feladat: ");
                Console.Write("Kérek egy 1990 és 1999 közötti évszámot: ");
                evszam = int.Parse(Console.ReadLine());
                if (evszam >= 1900 && evszam <= 1999)
                {
                    break;
                }
                else
                {
                    Console.Write("Hibás adat! Kérek egy 1990 és 1999 közötti évszámot: ");

                }
            }
        }

        static void Hatodik()
        {
            foreach (var i in balkez)
            {
                if (evszam => i.Elso)
                {

                }
            }
        }
        static void Main(string[] args)
        {
            Beolvas();
            Negyedik();
            Otodik();
            Hatodik();
            Console.ReadKey();
        }
    }
}
