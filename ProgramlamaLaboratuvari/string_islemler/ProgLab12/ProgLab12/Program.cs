// Greedy alg. kullanarak para değişimi
//200, 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01  TL (12 çeşit para)
using System;

namespace Greedy2
{
    class Program
    {
        static double[] para = { 200, 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
        static void Degistir(double orMiktar, double kalanMiktar, int[] paralar)
        {
            //foreach (double i in para)
            for (int i = 0; i < para.Length; i++)
            {
                if ((orMiktar % para[i]) < orMiktar)
                {
                    paralar[i] = (int)(orMiktar / para[i]);
                    orMiktar = orMiktar % para[i];
                }
            }
        }

        static void DegisimGoster(int[] arr)
        {
            for (int i = 0; i < para.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine($"{para[i]}' lerin sayısı =\t{arr[i]}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Değişmek istediğiniz para miktarını giriniz:");
            double orMiktar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");
            double toDegis = orMiktar;
            double kalanmiktar = 0.0;
            int[] paralar = new int[para.Length];
            Degistir(orMiktar, kalanmiktar, paralar);
            Console.WriteLine("Değişmin en iyi yolu " + toDegis + " tl = ");
            Console.WriteLine();
            DegisimGoster(paralar);
            Console.ReadKey();
        }
    }
}
