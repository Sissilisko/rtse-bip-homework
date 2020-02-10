using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = 0;
      while (true)
      {
        string usrInput = Console.ReadLine();
        if (usrInput == "")
        {
          break;
        }
        string[] pieces = usrInput.Split(",");
        if (oldest < Convert.ToInt32(pieces[1]))
        {
          oldest = Convert.ToInt32(pieces[1]);
        }
      }
      Console.WriteLine("Age of the oldest: " + oldest);
    }
  }
}



