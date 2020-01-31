using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      PrintSpaces(0);
      PrintStars(0);
      PrintRightTriangle(0);
      ChristmasTree(10);
    }

    public static void PrintStars(int stars)
    {
      for (int i = 0; i < stars; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    public static void PrintSpaces(int space)
    {
      for (int i = 0; i < space; i++)
      {
        Console.Write(" ");
      }
    }

    public static void PrintRightTriangle(int size)
    {
      int left = size -1;
      for (int i = 1; i <= size; i++)
      {
        PrintSpaces(left);
        PrintStars(i);
        left--;
      }
    }

    public static void ChristmasTree(int height)
    {
      int left = height -1;
      int starsRow = 1;
      for (int i = 1; i <= height; i++)
      {
        PrintSpaces(left);
        PrintStars(starsRow);
        starsRow += 2;
        left--;
      }
      int treeFoot = height - 2;
      for (int x = 0; x < 2; x++)
      {
        PrintSpaces(treeFoot);
        PrintStars(3);
      }
    }
  }
}
