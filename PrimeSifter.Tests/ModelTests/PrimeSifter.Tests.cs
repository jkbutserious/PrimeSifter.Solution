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

    [TestMethod]
    public void PrimeChecker_NumberIsPrime_True()
    {
      //Arrange
      IsPrime testPrime = new IsPrime();
      int Factor = 5;

      //Act
      bool FTest = testPrime.PrimeChecker(Factor);

      //Assert
      Assert.AreEqual(true, FTest);
    }

    [TestMethod]
    public void PrimeLister_NumbersWillReturnChronologically_True()
    {
      //Arrange
      IsPrime testPrime = new IsPrime();
      int Factor = 7;

      //Act
      testPrime.PrimeLister(Factor);
      int NumberOfPrimes = _primes.Length();

      // int PTest[] = testPrime.PrimeLister(Factor);

      Assert.AreEqual(3, NumberOfPrimes);
    }
  }
}