// C# Program to count the number
// of positions with same address
// in row major and column major order
using System;
class ornek
{

    // Returns count of
    // required positions
    static int getCount(int M, int N)
    {
        int count = 0;

        // horizontal 1D array
        if (M == 1)
            return N;

        // vertical 1D array
        if (N == 1)
            return M;

        if (N > M)
        {

            // iterating for all possible i
            for (int i = 1; i <= M; i++)
            {
                int numerator = N * i - N + M - i;
                int denominator = M - 1;

                // checking if j is integer
                if (numerator % denominator == 0)
                {
                    int j = numerator / denominator;

                    // checking if j lies b/w 1 to N
                    if (j >= 1 && j <= N)
                        count++;
                }
            }
        }
        else
        {

            // iterating for all possible j
            for (int j = 1; j <= N; j++)
            {
                int numerator = M * j - M + N - j;
                int denominator = N - 1;

                // checking if i is integer
                if (numerator % denominator == 0)
                {
                    int i = numerator / denominator;

                    // checking if i lies b/w 1 to M
                    if (i >= 1 && i <= M)
                        count++;
                }
            }
        }
        return count;
    }

    // Driver Code
    public static void Main()
    {
        int M = 25, N = 20;
        Console.WriteLine(getCount(M, N));
    }
}