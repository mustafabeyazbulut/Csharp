using System;

namespace ConsoleApp1
{
    class RastgeleSayi

    {
        static void Main(string[] args)
        {
            //int[] dizi = new int[5];
             //Math.Floor(4.6);//her zaman aşağı yuvarlar
             //Math.Ceiling(4.6);//her zaman yukarı yuvarlar
             //Math.Round(4.5);
            //Array.Sort(dizi);// küçükten büyüğe
            //Array.Reverse(dizi); //büyükten küçüğe
            //Console.WriteLine("Hello World!");

            
            Console.Write("Rastgele sayı sınırı tavan değerini giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kaç sayı çekilecek giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b) Console.WriteLine("Aralık Hatası ");
            else
            {
                int[] sayi = new int[a];
                for (int i = 0; i < a; i++)
                    sayi[i] = i;

                Random r = new Random();

                int boyut = sayi.Length;
                for(int i = 0; i < b; i++)
                {
                    int n = r.Next(boyut);
                    Console.WriteLine("Rastgele Sayı =" + sayi[n]);
                    for (int j = n; j < boyut - 1; j++)
                        sayi[j] = sayi[j + 1];

                    boyut--;
                }


            }

            


           
        }
    }
}
