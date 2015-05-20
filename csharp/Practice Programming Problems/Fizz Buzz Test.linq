<Query Kind="Program" />

public static class FizzBuzzProgram
{
   public static void Main(string[] args)
   {
       var num = int.Parse(Console.ReadLine().Trim());
       FizzBuzz(num);
   }

   private static void FizzBuzz(int toNumber)
   {
       for (var i = 1; i <= toNumber; i++)
       {
           var text = "";

           if (i % 3 == 0)
           {
               text += "Fizz";
           }
           if (i % 5 == 0)
           {
               text += "Buzz";
           }
           if (String.IsNullOrEmpty(text))
           {
               text = i.ToString(CultureInfo.InvariantCulture);
           }

           Console.WriteLine(text);
       }
   }
}