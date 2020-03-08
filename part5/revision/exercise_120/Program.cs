using System;

namespace exercise_120
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your cube here.
      Cube gameCube = new Cube(6);
      gameCube.Volume();
      Console.WriteLine(gameCube);
    }
  }
}
