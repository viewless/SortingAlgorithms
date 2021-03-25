using System;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //64, 25, 12, 22, 11

            int[] arr = new int[] { 64, 25, 12, 22, 11 };

            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;

                for (int j = i; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
