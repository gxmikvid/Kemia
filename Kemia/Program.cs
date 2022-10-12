using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Kemia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Anyag> anyagok = new List<Anyag>();
            string[] nyersAdat = File.ReadAllLines(Environment.CurrentDirectory + "/../../felfedezesek.csv");

            int okorCount = 0;
            int prevEv = 0;
            int prevDelta = 0;
            int felfedDelta = 0;
            int largest = 0;
            for (int i = 1; i < nyersAdat.Length; i++)
            {
                string[] split = nyersAdat[i].Split(';');
                int evNulla = 0;
                anyagok.Add(new Anyag(evNulla, split[1], split[2], Convert.ToInt32(split[3]), split[4]));
            }

            Console.WriteLine($"3. feladat: Elemek száma: {anyagok.Count}");
            Console.WriteLine($"4. feladat: Felfedezések száma az ókorban: {okorCount}");

            Console.Write("5. feladat: Kérek egy vegyjelet:");
            string Bekert = Console.ReadLine();
            while (!Regex.IsMatch(Bekert, @"^[a-zA-Z]{1,2}$"))
            {
                Console.Write("5. feladat: Kérek egy vegyjelet:");
                Bekert = Console.ReadLine();
            }

            Console.WriteLine("6. feladat: Keresés");
            Anyag kertAnyag = anyagok.Find(x => x.Vegyjel.ToLower() == Bekert.ToLower());
            if (!(kertAnyag is null))
            {
                Console.Write($"\tAz elem vegyjele: {kertAnyag.Vegyjel}");
                Console.Write($"\n\tAz elem neve: {kertAnyag.Nev}");
                Console.Write($"\n\tRendszáma: {kertAnyag.Rendszam}");
                Console.Write($"\n\tFelfedezés éve: {kertAnyag.Ev}");
                Console.Write($"\n\tFelfedező: {kertAnyag.Felfedezo}");
            }

            Console.ReadKey();
        }
    }
}
