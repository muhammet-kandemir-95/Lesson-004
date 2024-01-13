using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Test Data: ");
      int number = Convert.ToInt32(Console.ReadLine());
      ;
      Console.WriteLine("Input the " + number + " numbers : ");
      for (int i = 1; i <= number; i++)
      {
        int cube = i*i*i;
        Console.WriteLine("Number is : " + i + " and the cube of the "+ i+ " is :"+ cube);
        
        
       

        // Console.Write(i + " ");
        // sum = sum + i;

      }
      
    }
  }
}