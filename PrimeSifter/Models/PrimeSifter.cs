using System.Collections.Generic;
using System; 

namespace PrimeSifter.Models
{
  public class IsPrime
  {
    public int UserNumber { get; set; }

    public IsPrime(int userNumber)
    {
      UserNumber = userNumber;
    }
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
      if (N <= 1)
      {
        return false;
      }
      else if (N == 2 || N == 3 || N == 5 || N == 7)
      {
        return true;
      }
      else if (N % 2 != 0 || N % 3 != 0 || N % 5 != 0 || N % 7 != 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static List<IsPrime> PrimeLister(int N)
    {
      List<int> _primes = new  List<int> {};
      List<int> _notPrimes = new  List<int> {};
      for (int i = 2; i < N; i++)
      {
        if (IsPrime.UserNumber.PrimeChecker(N) == true)
        {
          _primes.Add(N);
          Console.WriteLine(_primes);
        }
        else
        {
          _notPrimes.Add(N);
        }
      }
    }
    
  }
}