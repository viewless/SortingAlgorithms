using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 64, 25, 12, 22, 11 };

            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
