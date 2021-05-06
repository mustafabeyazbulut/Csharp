using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.sayıyı giriniz:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("2.sayıyı giriniz:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(us_recorsive(a, b));
            Console.ReadKey();
        }
        static int us_recorsive(int x, int n)
        {
            if (n == 0) return 1;
            else if (n == 1) return x;
            else if (n % 2 == 0) return us_recorsive(x * x, n / 2);
            else return x * us_recorsive(x * x, n / 2);
        }
    }
}
