using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifter.Models;
using System;

namespace PrimeSifter.Tests
{
  [TestClass]
  public class IsPrimeTests
  {
    [TestMethod]
    public void GreaterThanOne_NumberIsGreaterThanOne_True()
    {
      //Arrange
      IsPrime testPrime = new IsPrime();
      int Factor = 2;
      
      //Act
      bool NTest = testPrime.GreaterThanOne(Factor);

      //Assert
      Assert.AreEqual(true, NTest);
    }
  }
}