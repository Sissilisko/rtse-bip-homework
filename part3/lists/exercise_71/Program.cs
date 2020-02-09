﻿using System;
using System.Collections.Generic;

namespace exercise_71
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("Search for?");
      int srchFor = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < list.Count; i++)
      {
        if (list[i] == srchFor)
        {
          Console.WriteLine (srchFor + " is at index " +i);
        }
      }
    }
  }
}
