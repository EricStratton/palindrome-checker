using System;
using System.Linq;

namespace Palindrome.Models
{
  public class IsPalindrome
  {
    public bool CheckForPalindrome(string inputString)
    {
      string reverseInputString = new string(inputString.Reverse().ToArray());

      if(inputString == reverseInputString)
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