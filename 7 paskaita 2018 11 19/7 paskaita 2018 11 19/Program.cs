using System;
using System.Collections.Generic;

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
            */
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
        }
    }
}
