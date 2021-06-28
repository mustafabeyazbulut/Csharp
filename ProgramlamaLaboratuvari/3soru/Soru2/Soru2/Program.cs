using System;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Denklemi girin: ");
            string denklem = Console.ReadLine();
            string[] diziDenklem = denklem.Split(" = ");
            uint c = Convert.ToUInt32(diziDenklem[diziDenklem.Length - 1].Trim());
            string denklemSol = diziDenklem[0].Trim();
            string[] diziSol = denklemSol.Split(" + ");
            double S = 0;
            foreach (string eleman in diziSol)
            {
                string yeniEleman = eleman.Trim();
                uint a = Convert.ToUInt32(yeniEleman.Split("x")[0]);
                uint n = Convert.ToUInt32(yeniEleman.Split("^")[1]);
                S = S + Math.Pow((a + n), c);
            }
            Console.WriteLine("Sonuç : {0}", S);
        }
    }
}
