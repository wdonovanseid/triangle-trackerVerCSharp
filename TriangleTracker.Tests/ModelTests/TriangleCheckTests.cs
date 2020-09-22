using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleCheck;

namespace TriangleCheck.Tests
{
  [TestClass]
  public class TriangleCheckTests
  {
    [TestMethod]
    public void CheckType_IsItATriangle_NoString()
    {
      Triangle newTri = new Triangle(2,3,99);
      Assert.AreEqual("not a triangle", newTri.CheckType());
    }

    [TestMethod]
    public void CheckType_IsItATriangle_YesString()
    {
      Triangle newTri = new Triangle(2,3,4);
      Assert.AreEqual("this is a triangle", newTri.CheckType());
    }

    [TestMethod]
    public void CheckType_IsEqualTri_String()
    {
      Triangle newTri = new Triangle(3,3,3);
      Assert.AreEqual("equalateral triangle", newTri.CheckType());
    }

    [TestMethod]
    public void CheckType_IsIsoscelesTri_String()
    {
      Triangle newTri = new Triangle(3,3,5);
      Assert.AreEqual("isosceles triangle", newTri.CheckType());
    }
  }
}