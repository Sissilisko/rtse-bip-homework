using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    // Write your method here:
    public static int Smallest(int nmbr1, int nmbr2)
    {
      if (nmbr1 < nmbr2)
      {
        return nmbr1;
      }
      else
      {
        return nmbr2;
      }
    }
    
  }
}
