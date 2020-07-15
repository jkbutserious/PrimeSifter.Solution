using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifter.Models;
using System;

namespace PrimeSifter.Tests
{
  [TestClass]
  public class IsPrime
  {
    [TestMethod]
    public void GreaterThanOne_NumberIsGreaterThanOne_True()
    {
      //Arrange
      // IsPrime testPrime = new IsPrime();
      int N = 2;
      
      //Act
      bool NTest = GreaterThanOne(N);

      //Assert
      Assert.AreEqual(true, NTest);
    }
  }
}