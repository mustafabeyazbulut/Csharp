using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("1. Sayiyi giriniz: ");
            string s1 = Console.ReadLine();
            Console.Write("2. Sayiyi giriniz: ");
            string s2 = Console.ReadLine();
            Console.Write("3. Sayiyi giriniz: ");
            string s3 = Console.ReadLine();
            Console.Write("String Toplami: ");
            Console.WriteLine(s1 + s2 + s3);

            a = Convert.ToInt32(s1);
            b = Convert.ToInt32(s2);
            c = int.Parse(s3);
            Console.Write("Int Toplami: ");
            Console.WriteLine(a+b+c);
        }
    }
}
