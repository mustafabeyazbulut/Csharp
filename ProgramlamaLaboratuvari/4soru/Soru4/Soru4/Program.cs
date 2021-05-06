using System;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin Boyutunu Giriniz :");
            int n = int.Parse(Console.ReadLine());
            int[,] d = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < d.GetLength(0); i++)
                for (int j = 0; j < d.GetLength(1); j++) 
                    d[i, j] = r.Next(1, 11);

            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++) Console.Write(d[i, j] + "\t");
                Console.WriteLine();
            }


            Console.WriteLine();
            int toplam = new int();
            Console.WriteLine(toplam);

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i == j || j == (n + 1 - i))
                    {
                        Console.Write(d[i-1,j-1]);
                        toplam = toplam + d[i - 1, j - 1];
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Toplam :"+toplam);

            Console.ReadLine();


        }


    }
}
