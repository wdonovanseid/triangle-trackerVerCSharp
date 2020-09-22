using System;
// using TriangleCheck.Backend;

namespace TriangleCheck
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter side A");
      string sideAStr = Console.ReadLine();
      int sideAInt = int.Parse(sideAStr);
      Console.WriteLine("Enter side B");
      string sideBStr = Console.ReadLine();
      int sideBInt = int.Parse(sideBStr);
      Console.WriteLine("Enter side C");
      string sideCStr = Console.ReadLine();
      int sideCInt = int.Parse(sideCStr);
      Triangle newTri = new Triangle(sideAInt,sideBInt,sideCInt);

    }
  }
}