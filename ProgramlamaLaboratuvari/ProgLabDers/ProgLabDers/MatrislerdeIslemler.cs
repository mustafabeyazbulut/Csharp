using System;

namespace MatrislerdeIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 2];
            int[,] b = new int[2, 3];

            Console.Write("Dizinin Boyutunu Giriniz :");
            int n = int.Parse(Console.ReadLine());
            int[,] c = new int[n, n];

            matrisRastgeleDegerAta(a);
            matrisRastgeleDegerAta(b);
            matrisRastgeleDegerAta(c);

            Console.WriteLine("-----A Matrisi-----");
            matrisListele(a);
            Console.WriteLine("\n-----B Matrisi-----");
            matrisListele(b);
            Console.WriteLine("\n-----c Matrisi-----");
            matrisListele(c);


            //Console.WriteLine("\n-----Matris Çarpımı-----");
            //int[,] d= ikiMatrisCarpim(a, b);
            //matrisListele(d);

            matriscapraztoplam(c);

        }
        static void matriscapraztoplam(int[,] dizi)
        {
            int toplam = new int();
            Console.WriteLine();

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(0); j++)
                {
                    if (i == j || j == (dizi.GetLength(0) - i - 1))
                    {
                        Console.Write(dizi[i, j]);
                        toplam = toplam + dizi[i, j];
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Toplam :" + toplam);
        }
        static void matrisRastgeleDegerAta(int[,] matris)
        {
            Random r = new Random();
            for (int i = 0; i < matris.GetLength(0); i++)
                for (int j = 0; j < matris.GetLength(1); j++)
                    matris[i, j] = r.Next(0, 10);
        }
        static void matrisListele(int[,] matris)
        {
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                    Console.Write(matris[i, j] + "\t");
                Console.WriteLine();
            }
        }
        static int[,] matrisToplam(int[,] a, int[,] b)
        {

            if (a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1))
            {
                int[,] c = new int[a.GetLength(0), b.GetLength(1)];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < b.GetLength(1); j++)
                        c[i, j] = a[i, j] + b[i, j];
                return c;
            }
            else
            {
                Console.WriteLine("Boyut Hatası Toplanamaz");
                return new int[0, 0];
            }

        }
        static void matrisScalerCarpim(int[,] matris, int b)
        {
            for (int i = 0; i < matris.GetLength(0); i++)
                for (int j = 0; j < matris.GetLength(1); j++)
                    matris[i, j] = b * matris[i, j];
        }
        static int [,] ikiMatrisCarpim(int[,] a, int[,] b)
        {
            if (a.GetLength(1) == b.GetLength(0))
            {
                int[,] c = new int[a.GetLength(0), b.GetLength(1)]; //2 3 matris ile 3-5 matris yeni boyut 2-5 olur.
                for (int i = 0; i < c.GetLength(0); i++) 
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k< a.GetLength(1); k++)
                            c[i, j] += a[i, k] * b[k,j];
                    }
                }
                return c;
            }
            else
            {
                Console.WriteLine("Boyut Hatası Çarpılamaz");
                return new int[0, 0];
            }

           
        }

    }
}
