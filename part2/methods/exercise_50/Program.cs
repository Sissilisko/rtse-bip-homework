﻿using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times?");
      int times = Convert.ToInt32(Console.ReadLine());
      int count = 0;
      while (count < times)
      {
        PrintPhrase();
        count++;
      }
    }

    // Write your method here:
    public static void PrintPhrase() 
    {
      Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
