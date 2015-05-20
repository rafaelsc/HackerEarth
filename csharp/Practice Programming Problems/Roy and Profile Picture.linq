<Query Kind="Program">
  <Namespace>System</Namespace>
</Query>

public static class RoyProfilePictureProgram
{
    public static void Main(string[] args)
    {
        var maxLenght = int.Parse(Console.ReadLine().Trim());
        var numOfTests = int.Parse(Console.ReadLine().Trim());

        for (var i = 0; i < numOfTests; i++)
        {
            var sizes = Console.ReadLine().Trim().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            var w = int.Parse(sizes[0]);
            var h = int.Parse(sizes[1]);

            if (w < maxLenght || h < maxLenght)
            {
                Console.WriteLine("UPLOAD ANOTHER");
            }
            else if (w == h)
            {
                Console.WriteLine("ACCEPTED");
            }
            else
            {
                Console.WriteLine("CROP IT");
            }
        }
    }
}