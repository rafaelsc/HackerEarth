<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System</Namespace>
  <Namespace>System.Globalization</Namespace>
  <Namespace>System.Numerics</Namespace>
</Query>

public static class SmallFactorialsProgram
{
    public static void Main(string[] args)
    {
        var numOfTests = int.Parse(Console.ReadLine().Trim());

        for (var i = 0; i < numOfTests; i++)
        {
            var n = int.Parse(Console.ReadLine().Trim());
            var factorial = Factorial(n);
            Console.WriteLine(factorial.ToString(CultureInfo.InvariantCulture));
        }
    }

    private static BigInteger Factorial(int ofNumber)
    {
        BigInteger result = BigInteger.One;
        for (var i = 2; i <= ofNumber; i++)
        {
            result *= i;
        }
        return result;
    }
}
