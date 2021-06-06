using System;

namespace ProgLab10
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int indis = -1;
            int sayac = 0;
            string a= "xx xx xxx. yy yyyy. yyy yyy yy. zzzz. zzz zzzzz.";*/

            //cümle sayısı - indexof ile yöntem 1
            /*
            while (1==1)
            {
                try
                {
                    indis = a.IndexOf(".", (indis + 1));
                    if (indis != -1)
                    {
                        sayac++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("HATA");
                }
            }
            Console.WriteLine("Cümle sayısı= {0}",sayac);
            */

            //cümle sayısı - split ile yöntem 2
            /*string[] cevap = a.Split('.');
            sayac = cevap.Length - 1;
            Console.WriteLine("Cümle sayısı= {0}", sayac);*/


            //kelime sayısı - split
            /* string[] cevap = a.Split(' ');
             sayac = cevap.Length;
             Console.WriteLine("Kelime sayısı= {0}", sayac); */

            //ekrandan girilen ax^2 + bx + c = 0    biçimindenki denklemin köklerini bulma
            int a = 0, b = 0, c = 0;
            Console.Write("Denklemi giriniz= ");
            string ax = Console.ReadLine();
            string[] s = ax.Split('x');
            string[] t = s[1].Split(' ');
            string[] v = s[2].Split(' ');

            a = Convert.ToInt32(s[0]);
            b = Convert.ToInt32(t[2]);
            c = Convert.ToInt32(v[2]);

            Console.WriteLine("a= {0}, b= {1}, c={2}",a,b,c);

            int delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double kok1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double kok2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Kök1 = {0}, Kök2= {1}", kok1, kok2);
            }
            else if (delta == 0)
            {
                double kok1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("İki kök birbirine eşit, Kök1 = {0}", kok1);
            }
            else
            {
                Console.WriteLine("Reek kökü yoktur.");
            }




            Console.ReadKey();
        }
    }
}
