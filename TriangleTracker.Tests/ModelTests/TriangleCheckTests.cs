using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleCheck;

namespace TriangleCheck.Tests
{
  public class TriangleCheckTests
  {
    [TestMethod]
    public void CheckType_IsItATriangle_String()
    {
      Triangle newTri = new Triangle(2,3,7);
      Assert.AreEqual("", newTri.CheckType());
    }
  }
}