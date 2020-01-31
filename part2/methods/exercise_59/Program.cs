using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    // Write your method here:
    public static int Greatest(int nmbr1, int nmbr2, int nmbr3)
    {
      int answer = 0;
      if (nmbr1 > nmbr2 & nmbr1 > nmbr3)
      {
        answer = nmbr1;
      }
      else if (nmbr2 > nmbr1 & nmbr2 > nmbr3)
      {
        answer = nmbr2;
      }
      else
      {
        answer = nmbr3;
      }
      return answer;
    }

  }
}
