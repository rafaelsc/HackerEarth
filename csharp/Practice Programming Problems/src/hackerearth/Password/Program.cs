using System;
using System.Collections.Generic;
using System.Linq;

public static class PasswordProgram
{
    public static void Main(string[] args)
    {
        var numOfPasswd = int.Parse(Console.ReadLine().Trim());
        var listOfValues = new List<string>(numOfPasswd);
        for (var i = 0; i < numOfPasswd; i++)
        {
            var text = Console.ReadLine().Trim();
            listOfValues.Add(text);
        }

        var result = PasswordSolution(listOfValues);
        Console.WriteLine(result);
    }

    public static string PasswordSolution(IList<string> values)
    {
        var palindromeEntrys =  from v1 in values
                                from v2 in values
                                where v1.IsPalidromeOf(v2)
                                select v1;

        var hiddenPalidrome = palindromeEntrys.FirstOrDefault() ?? "";
        return string.Format("{0} {1}", hiddenPalidrome.Length, hiddenPalidrome[hiddenPalidrome.Length/2]);
    }
}

public static class StringUtil
{
    public static bool IsPalidromeOf(this string str1, string stringToCompare)
    {
        return str1 == new string(stringToCompare.Reverse().ToArray());
    }
}