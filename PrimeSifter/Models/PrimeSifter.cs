using System.Collections.Generic;
using System; 

namespace PrimeSifter.Models
{
  public class IsPrime
  {
    // public int UserNumber { get; set; }
    // private static List<PrimeNumbers> _primes = new IsPrime;
    public bool GreaterThanOne(int N)
    {
      if (N > 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool PrimeChecker(int N)
    {
      if (N < 2)
      {
        return false;
      }
      else if (N == 2)
      {
        return false;
      }
      else if (N % 2 != 0 || N % 3 != 0 || N % 5 != 0 || N % 7 != 0)
      {
        return false;
      }
      else
      {
        return false;
      }
    }
    
  }
}