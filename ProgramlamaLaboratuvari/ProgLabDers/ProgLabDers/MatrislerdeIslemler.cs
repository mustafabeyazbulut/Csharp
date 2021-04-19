using System;

namespace MatrislerdeIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 5];
            int[,] b = new int[5, 5];


            matrisRastgeleDegerAta(a);
            matrisRastgeleDegerAta(b);


            Console.WriteLine("-----A Matrisi-----");
            matrisListele(a);
            Console.WriteLine("\n-----B Matrisi-----");
            matrisListele(b);

            Console.WriteLine("\n-----Matris Toplamı-----");
            int[,] c = matrisToplam(a, b);
            matrisListele(c);

            matrisScalerCarpim(a, 5);
            Console.WriteLine("\n-----Matris Scaler Çarpım-----");
            matrisListele(a);



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
    }
}
