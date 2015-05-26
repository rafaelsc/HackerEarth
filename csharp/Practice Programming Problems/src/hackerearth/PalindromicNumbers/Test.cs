using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class TestProgram
{
    [Test]
    public void Sample01()
    {
        var result1 = PalindromicNumbersProgram.CountPalidromeNumbers(10,13);
        Assert.AreEqual(1, result1);
    }
    [Test]
    public void Sample02()
    {
        var result1 = PalindromicNumbersProgram.CountPalidromeNumbers(20,30);
        Assert.AreEqual(1, result1);
    }
}