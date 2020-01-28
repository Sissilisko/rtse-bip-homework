using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      int usrInt = Convert.ToInt32(Console.ReadLine());
      while (usrInt <= 100)
      {
        Console.WriteLine(usrInt);
        usrInt++;
      }

    }
  }
}
