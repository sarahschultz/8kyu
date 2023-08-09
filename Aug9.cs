// Code Wars 
// Continuation of the Multiply drill https://www.codewars.com/kata/50654ddff44f800200000004/train/csharp from yesterday:

// EXPECTED TESTS
using NUnit.Framework;
using System;
[TestFixture]
public class CustomMathTest
{
  [Test]
  public void ShouldMultiple()
  {
    Assert.AreEqual(2, CustomMath.multiply(2, 1));
    Assert.AreEqual(8, CustomMath.multiply(2, 4));
  }
}

public class CustomMath {
    public static int multiply(int a, int b) {
        return a * b;
    }
}

// HECK YEAH! Just had to add the asterisk - I literally thought C# was going to mess with me by having a different operator symbol or something. Thankfully C# seems to respect the math I'm used to lol