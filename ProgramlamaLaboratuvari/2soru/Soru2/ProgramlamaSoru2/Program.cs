using System;
namespace ProgramlamaSoru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2x^2+3x^2+3x^2=3
            Console.Write("Denklemi girin: ");
            string denklem = Console.ReadLine();
            string[] diziDenk = denklem.Split('=');
            uint c = Convert.ToUInt32(diziDenk[diziDenk.Length - 1]);
            string denkSol = diziDenk[0];
            string[] diziSol = denkSol.Split('+');
            double S = 0;
            foreach (string eleman in diziSol)
            {
                string yeni = eleman;
                uint a = Convert.ToUInt32(yeni.Split('x')[0]);
                uint n = Convert.ToUInt32(yeni.Split('^')[1]);
                int i, faktoriyelA = 1;
                int faktoriyelN = 1;
                for (i = 1; i <= a; i++)
                {
                    faktoriyelA = faktoriyelA * i;
                }
                for (int j = 1; j <= n; j++)
                {
                    faktoriyelN = faktoriyelN * j;
                }
                S = S + Math.Pow((faktoriyelA + faktoriyelN), c);
            }
            Console.WriteLine("Sonuç : {0}", S);
            Console.ReadKey();
        }
    }
}
