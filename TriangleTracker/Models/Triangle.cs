using System;

namespace TriangleCheck
{
  public class Triangle
  {
    // private int SideA;
    // private int SideB;
    // private int SideC;
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }

    public Triangle(int sideAInput, int sideBInput,int sideCInput)
    {
      SideA = sideAInput;
      SideB = sideBInput;
      SideC = sideCInput;
    }
    public string CheckType()
    {
      if ((SideA > (SideB + SideC)) || (SideB > (SideA + SideC)) || (SideC > (SideA + SideB)))
      {
        return "not a triangle";
      } else if ((SideA != SideB) && ((SideA != SideC)) && ((SideB != SideC)))
      {
        return "this is a triangle";
      } else if ((SideA == SideB) && (SideA == SideC))
      {
        return "equalateral triangle";
      } else 
      {
        return "isosceles triangle";
      }
    }
  }
}





