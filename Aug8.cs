//August 8, 2023
// Code Wars Practice Exercises Level 8kyu

//  8kyu Jenny's secret message:
//  Jenny has written a function that returns a greeting for a user. However, she's in love with Johnny, and would like to greet him slightly different. She added a special case to her function, but she made a mistake.
//  Can you help her?

//original:
// using System;

// public static class Kata
// {
//   public static string greet(string name)
//   {
//     return "Hello, " + name + "!";
//     if(name == "Johnny")
//       return "Hello, my love!";
//   }
// }

// My Attempt

using System;

public static class Kata
{
  public static string greet(string name)
  {
    //noticed her regular return was on the wrong line, she called it too early and it should have been the else case since she targeted Johnny in her logic
    if(name == "Johnny")
        return "Hello, my love!";
        return "Hello, " + name + "!";
  }
}

// Sample Tests
// using System;
// using NUnit.Framework;

// [TestFixture]
// public class JennysGreeting
// {
//   [Test]
//   public static void ShouldGreetJimNormally()
//   {
//     Assert.AreEqual("Hello, Jim!", Kata.greet("Jim"));
//   }
//   [Test]
//   public static void ShouldGreetJaneNormally()
//   {
//     Assert.AreEqual("Hello, Jane!", Kata.greet("Jane"));
//   }
//   [Test]
//   public static void ShouldGreetSimonNormally()
//   {
//     Assert.AreEqual("Hello, Simon!", Kata.greet("Simon"));
//   }
  
//   [Test]
//   public static void ShouldGreetJohnnySpecially()
//   {
//     Assert.AreEqual("Hello, my love!", Kata.greet("Johnny"));
//   }
// }

//  8kyu Short Long Short
//  Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string on the outside and the longer string on the inside. The strings will not be the same length, but they may be empty ( zero length ).