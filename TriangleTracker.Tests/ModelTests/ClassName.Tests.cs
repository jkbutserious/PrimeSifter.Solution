using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleKindTests
  {
    [TestMethod]
    public void Triangle_SidesShouldBeEqual_True()
    {
      Triangle.TriangleKind practiceTri = new Triangle.TriangleKind(3, 3, 3);
      Assert.AreEqual(true, practiceTri.EquilateralChecker());
    }
    [TestMethod]
    public void Triangle_ShouldBeAnIsoscelesTriangle_True()
    {
      Triangle.TriangleKind practiceTri2 = new Triangle.TriangleKind(4, 4, 2);
      Assert.AreEqual(true, practiceTri2.IsoscelesChecker());
    }
    [TestMethod]
    public void Triangle_ShouldBeAScaleneTriangle_True()
    {
      Triangle.TriangleKind practiceTri3 = new Triangle.TriangleKind(2, 3, 4);
      Assert.AreEqual(true, practiceTri3.ScaleneChecker());
    }

    [TestMethod]
    public void Triangle_ShouldBeATriangle_True()
    {
      Triangle.TriangleKind practiceTri4 = new Triangle.TriangleKind(4, 5, 20);
      Assert.AreEqual(false, practiceTri4.ValidTriangle());
    }
    
    [TestMethod]
    public void Triangle_ShouldCheckFunctions_True()
    {
      Triangle.TriangleKind practiceTri5 = new Triangle.TriangleKind(5, 5, 5);
      Assert.AreEqual("Equilateral", practiceTri5.CheckAllFunctions());
    }
  }
}
  