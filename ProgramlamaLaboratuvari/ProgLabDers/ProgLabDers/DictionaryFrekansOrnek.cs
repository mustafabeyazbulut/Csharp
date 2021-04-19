using System;
using System.Collections.Generic;
using System.Collections;

namespace DictionaryFrekansOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 2, 2, 3,3, 4, 5, 5, 66, 66,3, 66, 75, 75, 75, 75, 75, 4, 6, 7, 8, 3, 7, 0 };
            ArrayList alist = new ArrayList() { 2, 2, 3, 4, 5, 5, 66, 66, 66, 75, 75, 75, 75, 75, 4, 6, 7, 8, 3, 7, 0 };
            List<int> llist= new List<int>() { 2, 2, 3, 4, 5, 5, 66, 66, 66, 75, 75, 75, 75, 75, 4, 6, 7, 8, 3, 7, 0 };

            Dictionary<int, int> frekansListesi = frekans(dizi);

            foreach (KeyValuePair<int, int> x in frekansListesi)
                Console.WriteLine("Sayi: {0}    ---  Frekans :  {1} ", x.Key, x.Value);


        }

        static Dictionary<int,int> frekans(int[] d)
        {
            Dictionary<int, int> free = new Dictionary<int, int>();

            foreach(int i in d)
                if (free.ContainsKey(i))
                    free[i]++; // dictionary nin i numaralı keyini 1 arttırır.
                else
                    free.Add(i, 1);// dictionary nin i numaralı keyine 1 değerini ekler.
            return free;
        }
        
    }
}
