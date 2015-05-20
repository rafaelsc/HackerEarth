<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Linq</Namespace>
</Query>

public static class CompleteStringProgram
{
    public static void Main(string[] args)
    {
        var numOfTests = int.Parse(Console.ReadLine().Trim());

        for (var i = 0; i < numOfTests; i++)
        {
            var text = Console.ReadLine().Trim();
            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ".All(c => text.ToUpperInvariant().Contains(c)) ? "YES" : "NO");
        }
    }
}