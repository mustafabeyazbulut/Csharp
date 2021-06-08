using System;

// 4x4 matris  Yeşil Alan= Y  , Kırmızı alan = K   Köşegenler = X
// X    Y   Y   X
// K    x   x   k
// K    X   X   K
// X    Y   Y   X

// 5x5 matris  Yeşil Alan= Y  , Kırmızı alan = K   Köşegenler = X
// X    Y   Y   Y   X
// K    X   Y   X   K
// K    K   X   K   K
// K    X   Y   X   K
// X    Y   Y   Y   X


namespace ProgLabDers
{
    class MatrisX
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
                        teksayi = r.Next(10, 100);
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


            Console.WriteLine("Y Toplam :" + YesilAlan(dizi));
            Console.WriteLine("K Toplam :" + KirmiziAlan(dizi));
            Console.WriteLine("X Toplam :" + xAlan(dizi));

        }

        public static int xAlan(int[,] dizi)
        {
            int xalantoplam = 0;

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(0); j++)
                {
                    if (i == j || j == (dizi.GetLength(0) - i - 1))
                    {
                        //Console.Write(dizi[i, j]);
                        xalantoplam = xalantoplam + dizi[i, j];
                    }
                    //else Console.Write(" ");
                }
                //Console.WriteLine();
            }


            return xalantoplam;

        }
        public static int KirmiziAlan(int[,] dizi)
        {

            int krimizitoplam = 0;
            for (int i = 0; i < dizi.GetLength(0); i++)
                for (int j = 0; j < dizi.GetLength(0); j++)
                    if (j < i && j < (dizi.GetLength(0) - i - 1) || j > i && j > (dizi.GetLength(0) - i - 1))
                        krimizitoplam += dizi[i, j];

            return krimizitoplam;
        }
        public static int YesilAlan(int[,] dizi)
        {
            int yesiltoplam = 0;
            for (int i = 0; i < dizi.GetLength(0); i++)
                for (int j = 0; j < dizi.GetLength(0); j++)
                    if (j > i && j < (dizi.GetLength(0) - i - 1) || j < i && j > (dizi.GetLength(0) - i - 1))
                        yesiltoplam += dizi[i, j];

            return yesiltoplam;
        }



    }
}
