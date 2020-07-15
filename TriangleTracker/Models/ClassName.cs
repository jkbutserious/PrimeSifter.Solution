using System; 
using System.Collections.Generic;

namespace Triangle
{
  public class TriangleKind 
  {
    public int Side1;
    public int Side2;
    public int Side3;

    // public field: camelCase -- side1
    // private field: underscore camelCase -- _side1
    // property: PascalCase or UpperCamelCase -- Side1
    // auto-implemented property: PascalCase or UpperCamelCase -- Side1
    // Never use HungarianCase -- public int intSide1

    public TriangleKind(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public bool EquilateralChecker()
    {
      if (Side1 == Side2 && Side1 == Side3)
      {
        return true;
      }
      else
      {
        return false; 
      }
    }
    public bool IsoscelesChecker()
    {
      if ((Side1 == Side2 && Side1 != Side3) || (Side2 == Side3 && Side2 != Side1) || (Side3 == Side1 && Side2 != Side3 ))
    {
      return true; 
    }
    else
    {
      return false;
    }
    }

    public bool ScaleneChecker()
    {
      if(Side1 != Side2 && Side2 !=Side3 && Side1 != Side3)
      {
        return true;
      }
      else  
      {
        return false;
      }
    }

    public bool ValidTriangle()
    {
      if (Side1 + Side2 < Side3 || Side2 + Side3 < Side1 || Side1 + Side3 < Side2)
    {
      return false;
    }
    else
    {
      return true; 
    }
  }

  public string CheckAllFunctions()
  {
    if (ValidTriangle() == false)
    {
      throw new Exception("Invalid Triangle");
    } 
      else if(EquilateralChecker())
      {
        return "Equilateral";
      }
      else if(IsoscelesChecker())
        {
          return "Isosceles"; 
        }
        else if(ScaleneChecker())
          {
            return "Scalene"; 
          }    
      return "You have a crazy triangle";
    }
    
  } 

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the length of the first side of your triangle: ");
      string userInput1 = Console.ReadLine();
      int length1 = int.Parse(userInput1);

      Console.WriteLine("Enter the length of the second side of your triangle: ");
      string userInput2 = Console.ReadLine();
      int length2 = int.Parse(userInput2);

      Console.WriteLine("Enter the length of the third side of your triangle: ");
      string userInput3 = Console.ReadLine();
      int length3 = int.Parse(userInput3);

      TriangleKind thisTriangle = new TriangleKind(length1, length2, length3);
      string triangleType = thisTriangle.CheckAllFunctions();
      Console.WriteLine(triangleType);
    
    }
  }
}