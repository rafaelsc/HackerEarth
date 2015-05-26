<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.Linq</Namespace>
  <Namespace>System.Numerics</Namespace>
</Query>

public static class PalindromicNumbersProgram
{
    public static void Main(string[] args)
    {
        var numOfTests = int.Parse(Console.ReadLine().Trim());

        for (var i = 0; i < numOfTests; i++)
        {
            var numbers = (Console.ReadLine().Trim()).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var n1 = int.Parse(numbers[0]);
            var n2 = int.Parse(numbers[1]);

            var result = CountPalidromeNumbers(n1, n2);
            Console.WriteLine(result);
        }
    }

    public static int CountPalidromeNumbers(int n1, int n2)
    {
        var palindromeEntrys =  from n in n1.EnumerateTo(n2)
                                where n.ToString().IsPalidrome()
                                select n;

        var numberOfPalidromes = palindromeEntrys.Count();
        return numberOfPalidromes;
    }
}

public static class IntegerEx
{
    public static IEnumerable<int> EnumerateTo(this int from, int to, bool includeLastNumber = true)
    {
        for (var i = from; i < to; i++)
        {
            yield return i;
        }
        if (includeLastNumber)
        {
            yield return to;
        }
    }
}

public static class StringUtil
{
    public static bool IsPalidrome(this string str1)
    {
        return IsPalidromeOf(str1, str1);
    }
    public static bool IsPalidromeOf(this string str1, string stringToCompare)
    {
        return str1 == new string(stringToCompare.Reverse().ToArray());
    }
}