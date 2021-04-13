using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                d[i] = r.Next(1, 2000);

            }
            diziBilgiYaz(d);
            Console.WriteLine();
            diziEkranaYaz(d);
            Console.WriteLine();
            BubbleSort(d);
            diziEkranaYaz(d);
            Console.WriteLine();



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
            for(int n = dizi.Length; 0 < n; n--) // n değişkenine dizinin uzunluğu atandı. Sıralama sonu en büyük eleman sona geleceği için tekrardan o elemanı kontrol etmesine gerek olmadığı için n-- olarak döngü sağlandı
                for (int i=0;i<n-1;i++) //n-1 e kadar olmasının sebebi son eleman için tekrardan kontrol yapmasını engellemek için
                    if (dizi[i] > dizi[i + 1])
                    {
                        int temp = dizi[i + 1];
                        dizi[i + 1] = dizi[i];
                        dizi[i] = temp;
                    }


        }

    }
}
