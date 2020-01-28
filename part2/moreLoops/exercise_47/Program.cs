using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Where to?");
      int usrGo = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int usrCome = Convert.ToInt32(Console.ReadLine());
      int count = usrCome;
      while (count <= usrGo)
      {
        Console.WriteLine(count);
        count++;
      }
      
    }
  }
}
