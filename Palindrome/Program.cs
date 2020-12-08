using System;
using Palindrome.Models;

namespace Palindrome
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Give me a word and I'll check if it's a palindrome!");
      string inputString = Console.ReadLine();

      if(IsPalindrome.CheckForPalindrome(inputString) == true)
      {
        Console.WriteLine($"{inputString} is a palindrome!");
      }
      else
      {
        Console.WriteLine($"{inputString} is not a palindrome!");
      }
    }
  }
}