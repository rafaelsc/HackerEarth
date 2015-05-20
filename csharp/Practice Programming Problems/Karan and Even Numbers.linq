<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Globalization</Namespace>
</Query>

public static class KaranEvenNumbersProgram
{
    public static void Main(string[] args)
    {
        while (true)
        {
            var n = int.Parse(Console.ReadLine().Trim());
            if (n == -1)
                return;

            if (n%2 == 0)
            {
                Console.WriteLine(n.ToString(CultureInfo.InvariantCulture));
            }
        }
    }
}