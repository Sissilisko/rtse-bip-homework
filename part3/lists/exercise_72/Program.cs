using System;
using System.Collections.Generic;

namespace exercise_72
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 9999)
                {
                    break;
                }
                list.Add(input);
            }
            int small = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (small > list[i])
                {
                    small = list[i];
                }
            }
            Console.WriteLine("Smallest number: " + small);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == small)
                    Console.WriteLine("Found at index: " + i);
            }
        }
    }
}
