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
  }
}