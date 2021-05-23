using System;

namespace Fibonacci_Serach
{
	class Fibonacci
	{
		
		public static void Main()
		{
			int[] arr = { 10, 22, 35, 40, 45, 50, 80, 82, 85, 90, 100, 235 };
			int n = arr.Length;
			int x = 100;
			int ind = Algorithm_Fibonacci_Search(arr, n, x);
			if (ind >= 0)
				Console.Write("bulunan index= " + ind);
			else
				Console.Write(x + " key dizi icerisinde bulunmuyor");
		}
		public static int Algorithm_Fibonacci_Search(int [] A, int n, int key)
		{
			int indx;
			int low = 0;
			int high = n - 1;


			while (low <= high)
			{
				indx = Algorithm_Fibonacci(n);// get the fibonacci f[m-1] < n
				if (key == A[indx + low])							return indx+low;
				else if (key > A[indx + low])/*adjust the low*/		low = low + indx + 1;
				else /*adjust the high*/							high = low + indx - 1;

				n = high - low + 1;//adjust the n
			}
			return -1;

		} //end 
		static int Algorithm_Fibonacci(int n)
		{
			int fibk2 = 0;
			int fibk1 = 1;
			int fibk = 0;

			if (n == 0 || n == 1) return 0;

			while (fibk < n)
			{
				fibk = fibk1 + fibk2;

				fibk2 = fibk1;

				fibk1 = fibk;

			}
			return fibk2;
		}

	}
}
