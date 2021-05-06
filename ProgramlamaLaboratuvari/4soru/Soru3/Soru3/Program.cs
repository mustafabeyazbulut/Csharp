using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lutfen bir metin giriniz :");
            String a = Console.ReadLine();
            Dictionary<char, int> yeni = new Dictionary<char, int>();
            yeni = kontrol(a);
            foreach (KeyValuePair<char, int> x in yeni) Console.WriteLine("{0} harfi------{1} kere tekrar ediyor", x.Key, x.Value);

            Console.ReadLine();
        }

        static Dictionary<char, int> kontrol(String x)
        {
            Dictionary<char, int> sozluk = new Dictionary<char, int>();
            foreach (char i in x)
                if (sozluk.ContainsKey(i))sozluk[i]++;
                else sozluk.Add(i, 1);
          
            return sozluk;
        }
    }
}
