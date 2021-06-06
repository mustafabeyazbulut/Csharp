//Başlangıç ve bitiş saatleriyle birlikte -n- etkinlik verilir.
//Bir kişinin aynı anda yalnızca tek bir etkinlik üzerinde çalışabileceğini varsayarak,
//tek bir kişi tarafından gerçekleştirilebilecek maksimum etkinlik sayısını ve etkinlikleri
//ekrana yazan program.

using System;
using System.Collections.Generic;

//Bu örnekteki bitiş zamanlarını sıralı şekildedir.
//Aksi takdirde önce bitiş zamanlarıan göre sıralanmalıdır

namespace Greedy1
{
    class Program
    {
        // n --> Etkinliklerin toplam sayısı
        // s[] --> Tüm etkinliklerin başlama zamanlarını içeren dizi
        // f[] --> Tüm etkinliklerin bitiş zamanlarını içeren dizi
        public static List<int> maxEtkinlik(int[] s, int[] f)
        {
            int i, j;
            int n = s.Length;
            List<int> liste = new List<int>();
            

            //Console.Write("Seçilen etkinlikler: ");

            // İlk etkinlik her zaman ilk başta seçiliyor
            i = 0;
            // Console.Write(i + " ");
            liste.Add(i);
            //int etkinlikSayi = 1;
            // Geri kalan etkinlikler gözönüne alınıyor
            for (j = 1; j < n; j++)
            {
                // Bu aktivitenin başlangıç zamanı önceden seçilen aktivitenin bitiş zamanından büyük
                // veya ona eşitse, o zaman bu etkinliği seçelim
                if (s[j] >= f[i])
                {
                    //Console.Write(j + " ");
                    liste.Add(j);
                    i = j;
                    //etkinlikSayi++;
                }
            }
            //Console.WriteLine("\nToplam etkinlik sayısı: {0}",etkinlikSayi);
            return liste;
        }
        static void Main(string[] args)
        {
            int[] s = { 1, 3, 0, 5, 8, 5 };
            int[] f = { 2, 4, 6, 7, 9, 9 };
            
            List<int> liste = maxEtkinlik(s, f);
            Console.WriteLine("Toplam etkinlik sayısı: {0}",liste.Count);
            Console.Write("Etkinliklerin indis numaraları: ");
            Console.WriteLine(String.Join("; ", liste));
            foreach (int i in liste)
            {
                Console.WriteLine("Etkinlik başlangıç zamanı: {0}, bitiş zamanı: {1}",s[i],f[i]);
            }
            //liste.ForEach(Console.WriteLine);
        }
    }
}