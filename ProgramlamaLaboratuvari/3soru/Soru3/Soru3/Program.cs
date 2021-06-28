using System;
using System.Collections.Generic;

namespace soru3
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Action<object> write = Console.Write;

            const int N = 5;
            const int maxWeight = 8;
            var items = new List<Item>();

            for (var i = 0; i < N; i++)
            {
                items.AddRange(new List<Item>
              {
                     new Item {w = 1, v = 1},
                     new Item {w = 2, v = 3},
                     new Item {w = 3, v = 4},
                     new Item {w = 4, v = 5},
                     new Item {w = 5, v = 6},
          });
                Knapsack.Init(items, maxWeight);
                Knapsack.Run();
                Knapsack.Print(write);
                Console.ReadKey();
            }
        }
        static class Knapsack
        {
            static int[][] M { get; set; }
            static int[][] P { get; set; }
            static Item[] I { get; set; }
            public static int MaxValue { get; private set; }
            static int W { get; set; }

            public static void Init(List<Item> items, int maxWeight)
            {
                I = items.ToArray();
                W = maxWeight;

                var n = I.Length;
                M = new int[n][];
                P = new int[n][];
                for (var i = 0; i < M.Length; i++) { M[i] = new int[W + 1]; }
                for (var i = 0; i < P.Length; i++) { P[i] = new int[W + 1]; }
            }

            public static void Run()
            {
                MaxValue = Recursive(I.Length - 1, W, 1);
            }

            static int Recursive(int i, int w, int depth)
            {
                var take = 0;
                if (M[i][w] != 0) { return M[i][w]; }

                if (i == 0)
                {
                    if (I[i].w <= w)
                    {
                        P[i][w] = 1;
                        M[i][w] = I[0].v;
                        return I[i].v;
                    }

                    P[i][w] = -1;
                    M[i][w] = 0;
                    return 0;
                }

                if (I[i].w <= w)
                {
                    take = I[i].v + Recursive(i - 1, w - I[i].w, depth + 1);
                }

                var dontTake = Recursive(i - 1, w, depth + 1);

                M[i][w] = Max(take, dontTake);

                if (take > dontTake) { P[i][w] = 1; }
                else { P[i][w] = -1; }

                return M[i][w];
            }

            public static void Print(Action<object> write)
            {
                var list = new List<Item>();
                list.AddRange(I);
                var w = W;
                var i = list.Count - 1;
                write(string.Format("Maksimum değer = {0}\n", MaxValue));
                write("\nSeçilen Ürünler:\n");

                var valueSum = 0;
                var weightSum = 0;
                while (i >= 0 && w >= 0)
                {
                    if (P[i][w] == 1)
                    {
                        valueSum += list[i].v;
                        weightSum += list[i].w;
                        if (true) { write(string.Format("{0}\n", list[i])); }
                        w -= list[i].w;
                    }

                    i--;
                }
            }

            static int Max(int a, int b)
            {
                return a > b ? a : b;
            }
        }

        class Item
        {
            private static int count;
            public int Id { get; private set; }
            public int v { get; set; }
            public int w { get; set; }
            public Item()
            {
                Id = ++count;
            }

            public override string ToString()
            {
                return string.Format("Ürün: {0}  Fiyat: {1}  Ağırlık: {2}",
                                     Id, v, w);
            }
        }
    }
}