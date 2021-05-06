using System;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin Boyutunu Giriniz :");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] d = new int[boyut];
            Random r = new Random();
            for (int i = 0; i < d.Length; i++) //Diziye rastgele 10-100 arası sayı ekler
                d[i] = r.Next(10,100);

            SelectionSort(d); // BinarySearch araması için sıralama gereklidir
            diziEkranaYaz(d); // diziyi listeler

            Console.Write("Aramak istediğiniz veri(10-100 arası) :");
            int a = Convert.ToInt32(Console.ReadLine());

            int sonuc=binarysearch(d, a); // fonksiyona gönderilen bilgileri alıp istenilen sonucu sonuc degiskenine tanımlar
            
            if (sonuc == -1) Console.WriteLine("Aradığınız veri Yok.");
            else Console.WriteLine("Aradiğiniz bilgi " + sonuc + ". indistedir.");

            Console.ReadLine();

        }
        static void diziEkranaYaz(int[] d)
        {
            for (int i = 0; i < d.Length; i++)
                Console.WriteLine("Dizinin " + (i ) + ".nci indisi elemanı :" + d[i]);
        }

        static void SelectionSort(int[] d)
        {
            //Kucukten Buyuge Selection Sort sıralama
            for (int i = 0; i < d.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < d.Length; j++)
                    if (d[minIndex] > d[j])
                        minIndex = j;
                int temp = d[i];
                d[i] = d[minIndex];
                d[minIndex] = temp;
            }
        }

        private static int binarysearch(int[] d, int a)
        {
            int enkucukindex = 0;
            int enbuyukindex = d.Length - 1;
            while (enkucukindex <= enbuyukindex)
            {
                int ortaindex = (enbuyukindex + enkucukindex) / 2;

                if (a < d[ortaindex])
                    enbuyukindex = ortaindex - 1;
                else if (a > d[ortaindex])
                    enkucukindex = ortaindex + 1;
                else if (a == d[ortaindex])
                    return ortaindex;

            }
            return -1;
        }

    }
}
