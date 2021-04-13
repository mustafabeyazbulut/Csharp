using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] dizi = new int[5];
             Math.Floor(4.6);//her zaman aşağı yuvarlar
             Math.Ceiling(4.6);//her zaman yukarı yuvarlar
             Math.Round(4.5);
            Array.Sort(dizi);// küçükten büyüğe
            Array.Rever
            se(dizi); //büyükten küçüğe
            Console.WriteLine("Hello World!");*/

            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {        
                int rastgele = r.Next(1,20);
                Console.WriteLine("Rastgele Sayı :" + rastgele);
            }
            Console.ReadKey();
           
        }
    }
}
