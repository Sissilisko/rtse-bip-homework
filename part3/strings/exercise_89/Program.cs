using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        string usrInput = Console.ReadLine();
        if (usrInput == "")
        {
          break;
        }
        string[] pieces = usrInput.Split();
        Console.WriteLine(pieces[pieces.Length -1]);
      }
    }
  }
}



