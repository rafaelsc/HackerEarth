<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Linq</Namespace>
</Query>

public static class BestInternetBrowserProgram
{
   public static void Main(string[] args)
   {
       var numOfTests = int.Parse(Console.ReadLine().Trim());

       for (var i = 0; i < numOfTests; i++)
       {
           var url = Console.ReadLine().Trim();
           var normalTypeQnt = url.Count();
           var newayTypeQnt = normalTypeQnt - 4 - url.Count(c => c.IsVowel()) + 1;

           Console.WriteLine("{0}/{1}", newayTypeQnt, normalTypeQnt);
       }
   }
}

public static class CharExtentions
{
   public static bool IsVowel(this char character)
   {
       return "aeiouAEIOU".IndexOf(character) >= 0;
   }
}