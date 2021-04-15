using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class DictionaryKullanimi
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(134, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçimm");

            Dictionary<int, string>.KeyCollection AnahtarListesi = Ogrenci.Keys;
            foreach (int Anahtar in AnahtarListesi)
                Console.WriteLine(Anahtar);

            Dictionary<int, string>.ValueCollection DegerListesi = Ogrenci.Values;
            foreach (string Deger in DegerListesi)
                Console.WriteLine(Deger);
        }
       

    }
     
}
