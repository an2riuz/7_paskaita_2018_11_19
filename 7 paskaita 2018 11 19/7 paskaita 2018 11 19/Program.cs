using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_paskaita_2018_11_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pakartojam masyvus
            /*
            int[] masyvas = new int[5] {0,1,2,3,4 };
            for (int i = 0; i < masyvas.Length; i++)
            {
                int elementas = masyvas[i];
                Console.WriteLine(elementas);
                
            }
            Console.ReadKey();
            
            // Sarasai (list)

            List<int> skaiciai = new List<int>();
            List<string> zodziai = new List<string>();
            List<double> realusSk = new List<double>();
            List<char> simboliai = new List<char>();

            //Papildymas duomenim

            List<string> words = new List<string>() { "vienas", "du", "trys" };
            words.Add("keturi");
            words.Insert(2, "kart du");
            string[] naujasMasyvas = {"tamsta", "proto", "neturi" };
            words.InsertRange(4, naujasMasyvas);
            for (var index = 0; index < words.Count ; index++)
            {
                Console.WriteLine(words[index]);
            }
            foreach (var elementas in words)
            {
                Console.WriteLine(elementas);
            }
            zodziai.ForEach(Console.WriteLine);

            //saraso svarbiausios funkcijos
            List<string> svarbiausi = new List<string>();
            svarbiausi.Add("vienas ");
            svarbiausi.Add(" du ");
            svarbiausi.Add(" trys ");
            svarbiausi.Insert(1, " plius ");

            svarbiausi.Remove("vienas ");
            svarbiausi.RemoveAt(1);
            //svarbiausi.Clear();
            Console.WriteLine(svarbiausi.Count);


            foreach (var elementas in svarbiausi)
            {
                Console.Write(elementas);
            }

            Console.ReadKey();
            */
            // uzduotys

            int[] skaiciuRinkinys = {0,1,2,3,4,5,6 };
            List<int> skaiciai = new List<int>();
            skaiciai.Add(7);
            skaiciai.Add(12);
            skaiciai.Add(18);
            skaiciai.AddRange(skaiciuRinkinys);
            skaiciai.Insert(3, 85);

            skaiciai.Remove(12);
            skaiciai.RemoveRange(1,3);
            skaiciai.RemoveAt(5);

            // ideti 100 atsitiktiniu skaiciu
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int randomas = rnd.Next(1, 150);
                skaiciai.Add(randomas);
            }
            // 4)Išveskite visą informaciją kurią tik sugalvojate apie šį skaičių sąrašą (suma, vidurkis, kiekis...).

            skaiciai.ForEach(Console.WriteLine);
            Console.WriteLine("skaiciu suma lygi: " + skaiciai.Sum());
            Console.WriteLine("skaiciu vidurkis lygus: " + skaiciai.Average());
            Console.WriteLine("skaiciu kiekis lygus: " + skaiciai.Count);
            Console.WriteLine("hash kodas: " + skaiciai.GetHashCode());
            Console.WriteLine("saraso tipas: " + skaiciai.GetType());

            // 5)Suraskite kiekį skaičių, kurie < 20.

            int elementuSkaicius = 0;
            foreach (var elementas in skaiciai)
            {
                if (elementas < 20 )
                {
                    elementuSkaicius++;
                }
            }

            Console.WriteLine("skaiciu mazesniu uz 20 kiekis lygus: " + elementuSkaicius);

            // 6)Pašalinkite skaičius, kurie > 80;

            for (int i = 0; i < skaiciai.Count; i++)
            {
                int elementas = skaiciai[i];
                if (elementas > 80)
                {
                    skaiciai.Remove(elementas);
                }
            }
            Console.WriteLine(skaiciai[25]);

            // 7)Atspausdinkite visus lyginius skaičius į vieną eilutę. (naudojant ForEach() funkciją).

            foreach (var elementas in skaiciai)
            {
                if (elementas % 2 == 0)
                {
                    Console.Write(elementas + " ");
                }
            }

            Console.ReadKey();
            
            

        }
    }
}
