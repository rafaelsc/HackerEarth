<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.Linq</Namespace>
  <Namespace>System.Net.Sockets</Namespace>
</Query>

public static class ArrowTheEchelonProgram
{
    public static void Main(string[] args)
    {
        var numOfTests = int.Parse(Console.ReadLine().Trim());

        for (var i = 0; i < numOfTests; i++)
        {
            var numOfDigits =  int.Parse(Console.ReadLine().Trim());

            var result = FindBigestDecentNumber(numOfDigits);
            Console.WriteLine(result);
        }
    }

    public static string FindBigestDecentNumber(int numOfDigits)
    {
        if (numOfDigits <= 2) 
            return "-1";

        /*
        if (numOfDigits % 3 == 0)
        {
            return (new string('5', numOfDigits));
        }
        if (numOfDigits % 5 == 0)
        {
            return (new string('3', numOfDigits));
        }
        */

        var eq = new LinearDiophantineEquation(3, 5, numOfDigits);
        var bigXSolutionForLinearSystem = eq.FindPositiveSolution().FirstOrDefault();

        if (bigXSolutionForLinearSystem != null)
        {
            var strFor5 = (new string('5', (int) bigXSolutionForLinearSystem.Item1 * 3));
            var strFor3 = (new string('3', (int) bigXSolutionForLinearSystem.Item2 * 5));
            return strFor5 + strFor3;
        }

        return "-1";
    }
}

// a*x + b*y = c
public class LinearDiophantineEquation
{
    //Equações diofantinas lineares
    //http://pt.wikipedia.org/wiki/Equa%C3%A7%C3%A3o_diofantina

    private readonly int _a;
    private readonly int _b;
    private readonly int _c;
    private readonly EuclidExtended.EuclidExtendedSolution _euclidExtendedSolution;

    public long GCD {
        get { return _euclidExtendedSolution.GCD; }
    }

    public LinearDiophantineEquation(int a, int b, int c)
    {
        this._a = a;
        this._b = b;
        this._c = c;
        this._euclidExtendedSolution = EuclidExtended.Calculate(a, b);
    }

    public bool HasSolution
    {
        get { return (_c%GCD == 0); }
    }

    public IEnumerable<Tuple<long, long>> FindPositiveSolution()
    {
        if(!HasSolution)
            yield break;

        var ees = _euclidExtendedSolution;
        var minKValue = ((ees.Y * _c - 2) / (_a / ees.GCD));

        do
        {
            var lastFind = FindSystemSolution(minKValue);
            var isStillPossitive = (lastFind.Item1 >= 0 && lastFind.Item2 >= 0);
            if (!isStillPossitive)
                yield break;

            yield return lastFind;
            minKValue--;
        } while (true);
    }

    // http://en.wikipedia.org/wiki/B%C3%A9zout%27s_identity
    // https://br.answers.yahoo.com/question/index?qid=20091022132637AARLoTP
    public Tuple<long, long> FindSystemSolution(long k)
    {
        if (!HasSolution)
            return null;

        // a*x + b*y = c
        // sample 7x + 2y = 20 
        // S = { x + [b/mdc(a,b)].k , y - [a/mdc(a,b)].k } 
        //S = { 20 + [2 / 1].k , -60 - [7 / 1].k }
        //S = { 20 + 2.k , -60 - 7.k }

        var ees = _euclidExtendedSolution;

        var x = (ees.X*_c + (_b / ees.GCD) * k);
        var y = (ees.Y*_c - (_a / ees.GCD) * k);

        return Tuple.Create(x, y);
    }

}

public static class EuclidExtended
{
    //http://pt.wikipedia.org/wiki/Algoritmo_de_Euclides_estendido

    /// <summary>
    /// a*x + b*y = mdc(a,b)
    /// </summary>
    /// <param name="a">a</param>
    /// <param name="b">b</param>
    /// <returns>x, y and gcd(a,b)</returns>
    public static EuclidExtendedSolution Calculate(long a, long b)
    {
        long x0 = 1, xn = 1;
        long y0 = 0, yn = 0;
        long x1 = 0;
        long y1 = 1;
        long q;
        long r = a % b;

        while (r > 0)
        {
            q = a / b;
            xn = x0 - q * x1;
            yn = y0 - q * y1;

            x0 = x1;
            y0 = y1;
            x1 = xn;
            y1 = yn;
            a = b;
            b = r;
            r = a % b;
        }

        return new EuclidExtendedSolution(xn, yn, b);
    }

    public sealed class EuclidExtendedSolution
    {
        public long GCD { private set; get; }
        public long X { private set; get; }
        public long Y { private set; get; }

        public EuclidExtendedSolution(long x, long y, long gcd)
        {
            this.X = x;
            this.Y = y;
            this.GCD = gcd;
        }
    }
}
