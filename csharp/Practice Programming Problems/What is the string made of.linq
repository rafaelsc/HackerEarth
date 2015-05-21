<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.Linq</Namespace>
</Query>

public static class WhatStringMadeProgram
{
   private static readonly IDictionary<char, int> DigitsToNumDashMap = new Dictionary<char, int>
   {
       {'0', 6},
       {'1', 2},
       {'2', 5},
       {'3', 5},
       {'4', 4},
       {'5', 5},
       {'6', 6},
       {'7', 3},
       {'8', 7},
       {'9', 6}
   };

   public static void Main(string[] args)
   {
       var digits = Console.ReadLine().Trim();
       Console.WriteLine(digits.Select(d => DigitsToNumDashMap[d]).Sum());
   }
}