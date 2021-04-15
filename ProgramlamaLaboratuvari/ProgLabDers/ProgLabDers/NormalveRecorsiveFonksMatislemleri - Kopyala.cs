using System;

namespace ConsoleApp1
{
    class NormalveRecorsiveFonksMatislemleri
    {
        static void Main(string[] args)
        {
            //fib,fak,pow,norep rand
    
            us_giris();

        }
        static void us_giris()
        {
            Console.Write("Hangi Sayının üssü alınacak: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayının üssü kaç olacak: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + " üssü " +n+" normal :" + us_iterasyon(x,n));
            Console.WriteLine(x + " üssü " + n + " recorsive :" + us_recorsve(x,n));

        }
        static int us_iterasyon(int x, int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * x;

            }
            return f;
        }
        static int us_recorsve(int x,int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;
            if (n % 2 == 0) return us_recorsve(x * x, n / 2);
            else return x*us_recorsve(x*x,n/2);
        }
        static void fak_giris()
        {
            Console.Write("Hangi Sayının Faktoriyeli hesaplansın : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + " Faktöriyel normal : " + fak_iterasyon(n));
            Console.WriteLine(n + " Faktoriyel recorsive: " + fak_recorsve(n));

        }
        static int fak_iterasyon(int n)
        {
            int f = 1;
            for(int i = 1; i <= n; i++)
            {
                f=f*i;
            }
            return f;
        }
        static int fak_recorsve(int n)
        {
            if (n == 1) return 1;
            return n * fak_recorsve(n - 1);

        }
        static void fib_giris()
        {
            Console.Write("Hesaplanmasını istediğiniz fib indisi: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + ". fib değeri normal : " + fib_iterasyon(n));
            Console.WriteLine(n + ". fib değeri recorsive: " + fib_recorsve(n));

        }
        static int fib_iterasyon(int n)
        {
            if (n == 1) return 0;
            else if (n == 2) return 1;
            else
            {
                int a = 0, b = 1, temp = 0;

                for (int i = 1; i <= n - 2; i++)
                {
                    temp = a;
                    a = b;
                    b = b + temp;

                }
                return b;
            }
        }
        static int fib_recorsve(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;

            return fib_recorsve(n - 1) + fib_recorsve(n - 2);

        }

    }
     
}
