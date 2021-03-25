using System;

namespace _01_Task_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length > 20)
            {
                return;
            }
            else if (input.Length < 20)
            {
                //while (input.Length <= 20)
                //{
                //    input += "*";
                //}
                input = input.PadRight(20, '*');
            }

            Console.WriteLine(input);
        }
    }
}
