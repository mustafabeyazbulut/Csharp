using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[3, 4];
            m[0, 2] = 23;

            int[][] z= new int[3][];
            z[0] = new int[4];
            z[1] = new int[2];
            z[2] = new int[3];
            z[2][1] = 12;
        }
    }
}
