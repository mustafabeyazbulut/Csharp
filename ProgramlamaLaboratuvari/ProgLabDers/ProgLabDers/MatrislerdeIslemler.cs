using System;

namespace MatrislerdeIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[,] a = new int[4, 2];
             int[,] b = new int[2, 3];

             matrisRastgeleDegerAta(a);
             matrisRastgeleDegerAta(b);

             Console.WriteLine("-----A Matrisi-----");
             matrisListele(a);
             Console.WriteLine("\n-----B Matrisi-----");
             matrisListele(b);

             Console.WriteLine("\n-----Matris Çarpımı-----");
             int[,] d= ikiMatrisCarpim(a, b);
             matrisListele(d);*/


            // matriscapraztoplam();

            //matrisTranspoz();

            int n;
            Console.Write("Matris Kapasitesi: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[n, n];
            matrisElemanGir(matris);
            Console.WriteLine("\n-----Matris-----");
            matrisListele(matris);
            Console.WriteLine("Determinat = {0} ", DET(matris));
    

        }
        static void matrisTranspoz()
        {
            int n = 5;
            int m = 3;
            int[,] dizi = new int[n, m];

            matrisRastgeleDegerAta(dizi);
            Console.WriteLine("\n-----Matris-----");
            matrisListele(dizi);

            int[,] T = new int[m, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    T[j, i] = dizi[i, j];

            Console.WriteLine("\n-----Matris Transpozu-----");
            matrisListele(T);


        }
        static int DET(int[,] matris)
        {
            int d = 0;
            int n = matris.GetLength(0);
            int[,] altMatris = new int[n-1, n-1];
            int alt_i = 0,alt_j=0;


            if (n == 2)
                return (matris[0, 0] * matris[1, 1] - matris[1, 0] * matris[0, 1]);
            else
            {
                for (int k = 0; k < n; k++)
                {
                    alt_i = 0;
                    for (int i = 1; i < n; i++)
                    {
                        alt_j = 0;
                        for (int j = 0; j < n; j++)
                        {

                            if (j == k) continue;

                            altMatris[alt_i, alt_j] = matris[i, j];
                            
                            alt_j++;

                        }
                        
                        alt_i++;
                    }

                    d = d + Convert.ToInt32(Math.Pow(-1, k)) * matris[0, k] * DET(altMatris);
                }

            }

            return d;
        }
        static void matriscapraztoplam()
        {
            Console.WriteLine();
            Console.Write("Dizinin Boyutunu Giriniz :");
            int n = int.Parse(Console.ReadLine());
            int[,] dizi = new int[n, n];

            matrisRastgeleDegerAta(dizi);
            Console.WriteLine("\n-----Matris<-----");
            matrisListele(dizi);

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


           /* int top = 0;
            for (int j = 1; j <= (n / 2); j++)
                for (int i = j; i <= n - (j + 1); i++)
                    top += dizi[i, j - 1] + dizi[i, n - j];Hocanın çözüm */

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
            Console.WriteLine();
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
        static void matrisElemanGir(int[,] matris)
        {
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write("M[ {0}, {1} ] :",i,j);
                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

        }

    }
}
