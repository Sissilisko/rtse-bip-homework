using System;
using System.Collections.Generic;

namespace exercise_88
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
        string[] pieces = usrInput.Split(" ");
        Console.WriteLine(pieces[0]);
      }
    }
  }
}



