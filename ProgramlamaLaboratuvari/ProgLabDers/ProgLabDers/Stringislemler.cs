using System;
using System.Collections.Generic;

namespace Bos
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "Merhaba Dünya.";
            //string b = "Dünya";
            //long x = 50000000000000000;
            //a = x.ToString("N");// basamaklara nokta ve ondalık ayıraç
            // Console.Write("Bir ifade giriniz= ");
            // a = Console.ReadLine();
            // Console.WriteLine("Değer= .{0}.",a);
            //Console.WriteLine();
            //Console.WriteLine("Yeni= .{0}.",a.Trim());    //hem baştaki hem sondaki boşlukları atar
            //Console.WriteLine("Yeni= .{0}.", a.TrimStart());    //baştaki boşlukları atar
            //Console.WriteLine("Yeni= .{0}.", a.TrimEnd());    //sondaki boşlukları atar
            //Console.WriteLine("Karşılaştırma = {0}", String.Compare(a, b)); //Aynı ise 0 değeri, a b'den önce geliyorsa -1 gelir, b a'dan önce 1 gelir.
            //Console.WriteLine("Birleştirme = {0}", String.Concat(a, b)); //a nın sonua b yi ekler geriye döndürür
            //Console.WriteLine("Arama = {0}", a.IndexOf("ha")); // a stringinin başından sonuna belirtilen ifadeyi arar, bulamazsa -1, indis döndürür
            //Console.WriteLine("Arama = {0}", a.IndexOf("ba",4)); // a stringinin belirtilen indisten sonuna kadar belirtilen ifadeyi arar, bulamazsa -1, indis döndürür
            //Console.WriteLine("Arama = {0}", a.IndexOf("ün", 4,5)); // a stringinin belirtilen indisten itibaren belirtlen uzunluk kadarlık yerde belirtilen ifadeyi arar, bulamazsa -1, indis döndürür
            //Console.WriteLine("Arama = {0}", a.LastIndexOf("a")); // a stringinin sondan başa belirtilen ifadeyi arar, bulamazsa -1, indis döndürür
            //Console.WriteLine("Arama = {0}", a.LastIndexOf("a",4)); // a stringinin belirtilen indisten sola doğru, başa doğru belirtilen ifadeyi arar, bulamazsa -1, indis döndürür
            //Console.WriteLine("Arama = {0}", a.LastIndexOf("a", 4,2)); // a stringinin belirtilen indisten itibaren sol tarafa doğru belirtlen uzunluk kadarlık yerde sondan başa belirtilen ifadeyi arar, bulamazsa -1, indis döndürür
            //string[] y = a.Split('a');
            //foreach (string i in y)
            /*for(int i =0;i<y.Length;i++)
            {
                Console.WriteLine("PArçalı dizinin {0} elemanı = {1}",i,y[i]);
            }*/
            //string[] y = a.Split('.');
            //Console.WriteLine("Cümle sayısı= {0}",y.Length-1);

            /*b = a.Substring(4);// belirtilen indisten itibaren sonuna kadar alır geri döndürür.
            Console.WriteLine("Alt ifade = "+b);*/

            /* b = a.Substring(4,5);// belirtilen indisten itibaren belirtilen uzunluk kadarını alır geri döndürür.
             Console.WriteLine("Alt ifade = " + b);*/

            //uygulama10();
            uygulama11();

        }
        
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
        static void uygulama11()
        {
            // n --> Etkinliklerin toplam sayısı
            // s[] --> Tüm etkinliklerin başlama zamanlarını içeren dizi
            // f[] --> Tüm etkinliklerin bitiş zamanlarını içeren dizi

            int[] s = { 1, 3, 0, 5, 8, 5,10 };
            int[] f = { 2, 4, 6, 7, 9, 9,11 };

            List<int> liste = maxEtkinlik(s, f);
            Console.WriteLine("Toplam etkinlik sayısı: {0}", liste.Count);
            Console.Write("Etkinliklerin indis numaraları: ");
            Console.WriteLine(String.Join("; ", liste));
            foreach (int i in liste)
            {
                Console.WriteLine("Etkinlik başlangıç zamanı: {0}, bitiş zamanı: {1}", s[i], f[i]);
            }
            //liste.ForEach(Console.WriteLine);
        }
        static void uygulama10()
        {
            /* int indis = -1;
            int sayac = 0;
            string a= "xx xx xxx. yy yyyy. yyy yyy yy. zzzz. zzz zzzzz.";*/

            //cümle sayısı - indexof ile yöntem 1
            /*
            while (1==1)
            {
                try
                {
                    indis = a.IndexOf(".", (indis + 1));
                    if (indis != -1)
                    {
                        sayac++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("HATA");
                }
            }
            Console.WriteLine("Cümle sayısı= {0}",sayac);
            */

            //cümle sayısı - split ile yöntem 2
            /*string[] cevap = a.Split('.');
            sayac = cevap.Length - 1;
            Console.WriteLine("Cümle sayısı= {0}", sayac);*/


            //kelime sayısı - split
            /* string[] cevap = a.Split(' ');
             sayac = cevap.Length;
             Console.WriteLine("Kelime sayısı= {0}", sayac); */

            //ekrandan girilen ax^2 + bx + c = 0    biçimindenki denklemin köklerini bulma
            int a = 0, b = 0, c = 0;
            Console.Write("Denklemi giriniz= ");
            string ax = Console.ReadLine();
            string[] s = ax.Split('x');
            string[] t = s[1].Split(' ');
            string[] v = s[2].Split(' ');

            a = Convert.ToInt32(s[0]);
            b = Convert.ToInt32(t[2]);
            c = Convert.ToInt32(v[2]);

            Console.WriteLine("a= {0}, b= {1}, c={2}", a, b, c);

            int delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double kok1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double kok2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Kök1 = {0}, Kök2= {1}", kok1, kok2);
            }
            else if (delta == 0)
            {
                double kok1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("İki kök birbirine eşit, Kök1 = {0}", kok1);
            }
            else
            {
                Console.WriteLine("Reek kökü yoktur.");
            }

        }
    }
}
