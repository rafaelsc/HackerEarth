using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class TestProgram
{
    [Test]
    public void Sample01()
    {
        var result1 = PasswordProgram.PasswordSolution(new List<string> {"abc","def","feg","cba"});
        Assert.AreEqual("3 b", result1);
    }
}