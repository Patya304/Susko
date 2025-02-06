using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20241106
{
    class Program
    {
        static string[] kozmondasok;
        static void Main(string[] args)
        {
            string[] kozmondasok = File.ReadAllLines("kozmondasok.txt", Encoding.Default);

            List<string> km = new List<string>();
            FileStream fs = new FileStream("kozmondasok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            while (sr.EndOfStream)
            {
                km.Add(sr.ReadLine());
            }

            km.Add(sr.ReadLine());
            sr.Close();
            fs.Close();

            f2(km);
            f3();
            f4();
            f5(km);

            Console.Write("Enter");
            Console.ReadKey();
        }


        static void f2(List<string> lista)
        {
            Console.WriteLine($"\n2. Feladat a (listából): A fájl {lista.Count} közmondást tartalmaz.");
            Console.WriteLine($"\n2. Feladat a (tombből): A fájl {kozmondasok.Length} közmondást tartalmaz.");

        }

        static void f3()
        {
            foreach (var item in kozmondasok)
            {
                if (item.ToLower().Contains("malacz"))
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void f4()
        {
            int db = 0;
            foreach (var item in kozmondasok)
            {
                if (item.ToLower().Contains("ló"))
                {
                    db++;
                }
                Console.WriteLine($"\n4. Feladat: A 'ló' szót {db} közmondásokat tartalmaz.");
            }

        }

        static void f5(List<string> lista)
        {
            string asd = lista[0];
            int asdas = lista[0].Length;
            foreach (var item in lista)
            {
                if (item.Length > max)
                {
                    asdas = item.Length;
                    asd = item;
                }
            }
            Console.WriteLine($"5. Feladat:  a leghosszabb kozmondas {asdas}");
            Console.WriteLine(asd);
        }

        static void f6()
        {
            Console.WriteLine("Kéz kezet mos.")
        }

    }
}
