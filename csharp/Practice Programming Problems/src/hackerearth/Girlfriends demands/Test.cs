using System;
using NUnit.Framework;

[TestFixture]
public class TestProgram
{
    [Test]
    public void Sample01()
    {
        var result1 = GirlfriendsDemandsProgram.CheckGirlfriendsDemands("vgxgp", 2, 4);
        Assert.AreEqual("Yes", result1);
    }
    [Test]
    public void Sample02()
    {
        var result1 = GirlfriendsDemandsProgram.CheckGirlfriendsDemands("vgxgp", 2, 5);
        Assert.AreEqual("No", result1);
    }
    [Test]
    public void Sample03()
    {
        var result1 = GirlfriendsDemandsProgram.CheckGirlfriendsDemands("vgxgp", 7, 14);
        Assert.AreEqual("Yes", result1);
    }

    [Test]
    public void Input01()
    {
        var result1 = GirlfriendsDemandsProgram.CheckGirlfriendsDemands("vgxgp", 252509054433933447, 760713016476190629);
        Assert.AreEqual("Yes", result1);
    }
    [Test]
    public void Input02()
    {
        var result1 = GirlfriendsDemandsProgram.CheckGirlfriendsDemands("vgxgp", 145645985530478284, 403591478376763604);
        Assert.AreEqual("Yes", result1);
    }


}