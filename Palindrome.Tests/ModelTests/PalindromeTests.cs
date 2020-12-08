using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

namespace Palindrome.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_CheckForPalindrome_True()
    {
      IsPalindrome testIsPalindrome = new IsPalindrome();
      Assert.AreEqual(true, testIsPalindrome.CheckForPalindrome("civic"));
    }

    [TestMethod]
    public void IsPalindrome_CheckForNotPalindrome_False()
    {
      IsPalindrome testNotPalindrom = new IsPalindrome();
      Assert.AreEqual(false, testNotPalindrom.CheckForPalindrome("car"));
    }
  }
}