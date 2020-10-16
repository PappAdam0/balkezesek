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
                    Console.WriteLine($"\t{i.Nev}, {Math.Round(i.Magassag * 2.54, 1):N1} cm");
                }
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
                    Console.Write("Hibás adat! Kérek egy 1990 és 1999 közötti évszámot!: ");

                }
            }
        }

        static void Hatodik()
        {
            double suly = 0;
            double db = 0;
            double atlag = 0;
            foreach (var i in balkez)
            {
                if (evszam >= int.Parse(i.Elso.Substring(0,4)) && evszam <= int.Parse(i.Utolso.Substring(0, 4)))
                {
                    suly = suly + i.Suly;
                    db++;
                }
            }
            atlag = suly / db;
            
            Console.WriteLine($"6. Feladat: {atlag:N2} font");
        }

        static void pluszegy()
        {
            var nevek = from b in balkez
                        select b.Nev;

            var nevlista = nevek.ToList();

            var kezdobetu = from n in nevlista 
                            orderby n
                            group n by n[0] into tempNevek
                            select tempNevek;

            foreach (var cs in kezdobetu)
            {
                Console.WriteLine($"Kezdőbetű: {cs.Key}");
                foreach (var cst in cs)
                {
                    Console.WriteLine($"\t{cst}");
                }
            }
        }
        static void Main(string[] args)
        {
            Beolvas();
            Negyedik();
            Otodik();
            Hatodik();
            pluszegy();
            Console.ReadKey();
        }
    }
}
