using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Task_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = new int[] { -4, 2, 2, -5, 2, 3, 2, 3, 1, 5, 2, 6, 6 };
            int[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(x => Math.Abs(int.Parse(x))).ToArray();
            int n = int.Parse(Console.ReadLine());



            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (var item in input)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic[item] = 1;
                }
            }

            foreach (KeyValuePair<int, int> entry in dic)
            {
                if (entry.Value == n)
                {
                    Console.WriteLine(entry.Key);
                }
            }

        }
    }
}
