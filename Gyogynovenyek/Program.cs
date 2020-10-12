using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyogynovenyek
{
    class Program
    {
        static List<Noveny> novenyek = new List<Noveny>();
        static Dictionary<string, int> reszek = new Dictionary<string, int>();

        static void Beolvas()
        {
            StreamReader file = new StreamReader("noveny.csv");
            while (!file.EndOfStream)
            {
                novenyek.Add(new Noveny(file.ReadLine()));
            }
            file.Close();
        }
        static void Elsofeladat()
        {
            Console.WriteLine($"1.Feladat: Növények Száma: {novenyek.Count}");
        }

        static void Masodikfeladat()
        {
            Console.WriteLine("2.Feladat: Gyűjthető részek:");
            foreach (var n in novenyek)
            {
                if (!reszek.ContainsKey(n.Resz))
                {
                    reszek.Add(n.Resz, 0);
                }
            }

            foreach (var n in novenyek)
            {
                reszek[n.Resz]++;
            }

            foreach (var r in reszek)
            {
                Console.WriteLine($"{r.Key}: {r.Value}");
            }
        }
        static void Harmadikfeladat()
        {
            int max = 0;
            string nev = "";
            foreach (var n in novenyek)
            {
                if (n.Idotartam > max)
                {
                    max = n.Idotartam;
                    nev = n.Nev;
                }
            }
            Console.WriteLine("A {0} nevű növényt szedték a legtovább, {1}-hónapig",nev, max);
        }
        static void Negyedikfeladat()
        {
            double szum = 0;
            double atlag = 0;
            foreach (var n in novenyek)
            {
                szum += n.Idotartam;
            }
            atlag = szum / novenyek.Count;
            Console.WriteLine("Átlagos gyűjthető időtartam {0}",atlag);
        }

        static void Main(string[] args)
        {
            Beolvas();
            Elsofeladat();
            Masodikfeladat();
            Harmadikfeladat();
            Negyedikfeladat();
            Console.ReadKey();
        }
    }
}
