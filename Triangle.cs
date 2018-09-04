using System;
using System.Linq;

namespace TriangleJudge
{
  public class Triangle
  {
    public int sideA;
    public int sideB;
    public int sideC;



    // public Triangle(int inputA, int inputB, int inputC)
    // {
    //   sideA = inputA;
    //   sideB = inputB;
    //   sideC = inputC;
    // }
  }

  public class Program
  {
    public static void Main()
    {
      Console.Write("sideA?");
      var newA = Convert.ToInt32(Console.ReadLine());
      Console.Write("sideB?");
      var newB = Convert.ToInt32(Console.ReadLine());
      Console.Write("sideC?");
      var newC = Convert.ToInt32(Console.ReadLine());

      // var newTriangle = new Triangle(newA, newB, newC);
      // Console.WriteLine("{0} {1} {2}",newTriangle.sideA,newTriangle.sideB,newTriangle.sideC);

      if (newA >= newB + newC || newB >= newA + newC || newC >= newA + newB )
      {
        Console.WriteLine("not triangle");
      }
      else if (newA == newB && newB == newC)
      {
        Console.WriteLine("equil");
      }
      else if (newA == newB || newB == newC || newC==newA)
      {
        Console.WriteLine("iso");
      }
      else
      {
        Console.WriteLine("scal");
      }
    }

  }
}
