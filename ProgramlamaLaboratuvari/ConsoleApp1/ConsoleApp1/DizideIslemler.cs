using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = new int[10];
            d = diziOlustur(1, 10);

            BubbleSort(d);
            diziEkranaYaz(d);
            Console.WriteLine();
            BinarySearch(d);

        }
        static int[] diziOlustur(int a,int b )
        {
            int[] d = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                d[i] = r.Next(a, b);

            }
            return d;
        }
        static void diziBilgiYaz(Array arr)
        {
            Console.WriteLine("Dizinin uzunluğu :" + arr.Length);
            Console.WriteLine("Dizinin rank= " + arr.Rank);
        }
        static void diziEkranaYaz(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("Dizinin " + (i + 1) + ".nci elemanı :" + arr[i]);
        }
        static void BubbleSort(int[] dizi)
        {
            //Kucukten Buyuge Bubble Sort sıralama
            for (int n = dizi.Length; 0 < n; n--) // n değişkenine dizinin uzunluğu atandı. Sıralama sonu en büyük eleman sona geleceği için tekrardan o elemanı kontrol etmesine gerek olmadığı için n-- olarak döngü sağlandı
                for (int i = 0; i < n - 1; i++) //n-1 e kadar olmasının sebebi son eleman için tekrardan kontrol yapmasını engellemek için
                    if (dizi[i] > dizi[i + 1])
                    {
                        int temp = dizi[i + 1];
                        dizi[i + 1] = dizi[i];
                        dizi[i] = temp;
                    }


        }

        static void SelectionSort(int[] dizi)
        {
            //Kucukten Buyuge Selection Sort sıralama
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < dizi.Length; j++)
                    if (dizi[minIndex] > dizi[j])
                        minIndex = j;
                int temp = dizi[i];
                dizi[i] = dizi[minIndex];
                dizi[minIndex] = temp;
            }



        }
        static void InsertionSort(int[] dizi)
        {
            for (int n = dizi.Length, i = 1; i <= n - 1; i++)
            {
                int deger = dizi[i];
                int j = i;
                while (j > 0 && (deger < dizi[j - 1]))
                {
                    dizi[j] = dizi[j - 1];
                    j--;
                }
                dizi[j] = deger;

            }

        }

        static void lineerSearch(int []dizi)
        {
            Console.Write("Aramak istediğiniz veri :");
            int sonuc = -1;
            int aranan = Convert.ToInt32(Console.ReadLine());

            for (int n = dizi.Length, i = 0; i <= n - 1; i++)
                if (aranan == dizi[i])
                {
                    sonuc = i; break;
                }

            if (sonuc == -1) Console.WriteLine("Aradığınız veri Yok.");
            else Console.WriteLine("Aradiğiniz bilgi " + sonuc+". indistedir.");

        }
        static void BinarySearch(int[] dizi)
        {
            Console.Write("Aramak istediğiniz veri :");
            int sonuc = -1;
            int aranan = Convert.ToInt32(Console.ReadLine());
            int alt = 0, ust = dizi.Length - 1;

            while (alt < ust)
            {
               int orta = (ust + alt) / 2;
                if (aranan == dizi[orta]) { sonuc = orta; break; }
                else
                {
                    if (aranan < dizi[orta]) ust = orta - 1;
                    else alt = orta + 1;
                }
            }
            if (sonuc == -1) Console.WriteLine("Aradığınız veri Yok.");
            else Console.WriteLine("Aradiğiniz bilgi " + sonuc + ". indistedir.");

        }

    }
}
