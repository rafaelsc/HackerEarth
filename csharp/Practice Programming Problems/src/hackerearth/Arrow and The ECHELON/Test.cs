using System;
using NUnit.Framework;

[TestFixture]
public class TestProgram
{

    [Test]
    public void InvalidInputs()
    {
        var result1 = ArrowTheEchelonProgram.FindBigestDecentNumber(-1);
        Assert.AreEqual("-1", result1);

        var result2 = ArrowTheEchelonProgram.FindBigestDecentNumber(0);
        Assert.AreEqual("-1", result2);

        var result3 = ArrowTheEchelonProgram.FindBigestDecentNumber(1);
        Assert.AreEqual("-1", result3);

        var result4 = ArrowTheEchelonProgram.FindBigestDecentNumber(2);
        Assert.AreEqual("-1", result4);
    }

    [Test]
    public void NoAwnserEntry4()
    {
        var result2 = ArrowTheEchelonProgram.FindBigestDecentNumber(4);
        Assert.AreEqual("-1", result2);
    }
    [Test]
    public void NoAwnserEntry7()
    {
        var result4 = ArrowTheEchelonProgram.FindBigestDecentNumber(7);
        Assert.AreEqual("-1", result4);
    }

    [Test]
    public void Sample03()
    {
        var result1 = ArrowTheEchelonProgram.FindBigestDecentNumber(3);
        Assert.AreEqual("555", result1);
    }
    [Test]
    public void Sample06()
    {
        var result1 = ArrowTheEchelonProgram.FindBigestDecentNumber(6);
        Assert.AreEqual("555555", result1);
    }
    [Test]
    public void Sample09()
    {
        var result1 = ArrowTheEchelonProgram.FindBigestDecentNumber(9);
        Assert.AreEqual("555555555", result1);
    }


    [Test]
    public void Sample05()
    {
        var result3 = ArrowTheEchelonProgram.FindBigestDecentNumber(5);
        Assert.AreEqual("33333", result3);
    }
    [Test]
    public void Sample10()
    {
        var result3 = ArrowTheEchelonProgram.FindBigestDecentNumber(10);
        Assert.AreEqual("3333333333", result3);
    }
    [Test]
    public void Sample15()
    {
        var result3 = ArrowTheEchelonProgram.FindBigestDecentNumber(15);
        Assert.AreEqual("555555555555555", result3);
    }


    [Test]
    public void Sample08()
    {
        var result3 = ArrowTheEchelonProgram.FindBigestDecentNumber(8);
        Assert.AreEqual("55533333", result3);
    }
    [Test]
    public void Sample11()
    {
        var result5 = ArrowTheEchelonProgram.FindBigestDecentNumber(11);
        Assert.AreEqual("55555533333", result5);
    }
    [Test]
    public void Sample14()
    {
        var result5 = ArrowTheEchelonProgram.FindBigestDecentNumber(14);
        Assert.AreEqual("55555555533333", result5);
    }

    [Test]
    public void Sample()
    {
        var result5 = ArrowTheEchelonProgram.FindBigestDecentNumber(1795);

        var strFor5 = (new string('5', 595 * 3));
        var strFor3 = (new string('3', 2 * 5));

        Assert.AreEqual(strFor5+ strFor3, result5);
    }

}