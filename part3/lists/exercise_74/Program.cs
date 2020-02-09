using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("Search for?");
      string usrInput = Console.ReadLine();
      int find = 0;
      for (int i = 0; i < list.Count; i++)
      {
       if (usrInput == list[i])
       {
         find += 1;
       }
      }
      if (find > 0)
      {
        Console.WriteLine(usrInput + " was found!");
      }
      else
      {
        Console.WriteLine(usrInput + " was not found!");
      }
    }
  }
}

