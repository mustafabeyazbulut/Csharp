using System;




namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin Boyutunu Giriniz :");
            int n = int.Parse(Console.ReadLine());
            int[,] dizi = new int[n, n];
            int teksayi = 0;

            Random r = new Random();
            for (int i = 0; i < dizi.GetLength(0); i++) //random sayi ekleme
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    while (true) // tek sayi gelene kadar döner
                    {
                        teksayi = r.Next(10, 10000);
                        if (teksayi % 2 != 0)
                        {
                            dizi[i, j] = teksayi;
                            break;
                        }
                    }
                }


            for (int i = 0; i < dizi.GetLength(0); i++) // matris listeleme
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                    Console.Write(dizi[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Y Toplam :" + AlanToplam(dizi));

        }


        public static int AlanToplam(int[,] dizi)
        {
            int alantoplam = 0;

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(0); j++)
                {
                    if ( i == j || j == (dizi.GetLength(0) - 1 - i ))
                    {
                        //Console.Write(dizi[i, j]);
                        alantoplam = alantoplam + dizi[i, j];
                    }

                    //else Console.Write(" ");
                }
                
                for (int j = i + 2; j < dizi.GetLength(0) - 1 - i ; j += 2)//üst kısım
                    alantoplam += dizi[i, j];

                for (int j = dizi.GetLength(0) + 1 - i ; j < i; j += 2)
                    alantoplam += dizi[i, j];
                //Console.WriteLine();
            }


            return alantoplam;

        }

       


    }




}
