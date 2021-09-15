using System;
using System.Collections;

namespace ConsoleApp1
{
    class Arraylistss
    {
        static void Main(string[] args)
        {
            ArrayList DinamikDizi = new ArrayList();

            DinamikDizi.Add(128);
            DinamikDizi.Add(18);
            DinamikDizi.Add(56);

            foreach (var i in DinamikDizi)
                Console.WriteLine(i);

            Console.WriteLine();
            DinamikDizi.Remove(18);

            for (int i = 0; i < DinamikDizi.Count; i++)
                Console.WriteLine(DinamikDizi[i]);


            Console.WriteLine();
            if (DinamikDizi.Contains(56))
                Console.WriteLine("Arraylistte var");
            else Console.WriteLine("Arraylistte yok");

            DinamikDizi.Sort();

            Console.WriteLine();
            Console.WriteLine(DinamikDizi.BinarySearch(56)); // 18'in hangi indekste olduğunu gösterir

        }



        static void diziornek()
        {
            string[] isimler = { "Ahmet CANSEVER", "Emirhan SOYLU", "Elif SÜTÇÜ", "Hakan ALTIN", "Sema ÇALIŞKAN" };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.WriteLine();

            foreach (string eleman in isimler)
            {
                Console.WriteLine(eleman);
            }

        }

    }
     
}
