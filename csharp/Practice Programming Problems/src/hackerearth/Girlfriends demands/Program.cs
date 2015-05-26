using System;
using System.Numerics;

public static class GirlfriendsDemandsProgram
{
    public static void Main(string[] args)
    {
        var demand = Console.ReadLine().Trim();
        var numOfTests = long.Parse(Console.ReadLine().Trim());

        for (var i = 0; i < numOfTests; i++)
        {
            var rndChoidsValues = (Console.ReadLine().Trim()).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var n1 = long.Parse(rndChoidsValues[0]);
            var n2 = long.Parse(rndChoidsValues[1]);

            var result = CheckGirlfriendsDemands(demand, n1, n2);
            Console.WriteLine(result);
        }
    }

    public static string CheckGirlfriendsDemands(string demand, long n1, long n2)
    {
        var size = (long) demand.Length;
        n1--; n2--;
        var idx1 = (int) (n1 % size);
        var idx2 = (int) (n2 % size);
        var itIsAYes = (demand[idx1]) == (demand[idx2]);
        return itIsAYes ? "Yes" : "No";
    }
}
