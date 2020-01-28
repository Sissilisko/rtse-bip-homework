using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      int usrInt = Convert.ToInt32(Console.ReadLine());
      int nmbr = 0;
      while (nmbr <= usrInt)
      {
        Console.WriteLine(nmbr);
        nmbr++;
      }

    }
  }
}
