using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryClass<int, string> genus = new MyDictionaryClass<int, string>();
            genus.Add(1, "Scottish");
            genus.Add(2, "British");
            genus.Add(3, "Sfenks");
            genus.Add(4, "Himalaya");
            genus.Add(5, "İran");


            //Console.WriteLine(dictionary1.keysLength);

            for (int i = 0; i < genus.keysLength; i++)
            {
                Console.WriteLine("Cins türü : " + genus.Values[i] + "                  cins kodu : " + genus.Keys[i]);
            }
        }
    }
}