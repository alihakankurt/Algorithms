using System.Diagnostics;

namespace Algorithms;

internal class Program
{
    private static void Main(string[] args)
    {
        int b = 3;
        int e = 5;

        Console.Write(">>> In: ");
        Console.WriteLine($"{b}^{e}");

        Stopwatch stopwatch = Stopwatch.StartNew();

        int result = Recursion.BinaryExponentiation(b, e);

        stopwatch.Stop();

        Console.Write($">> Out: ");
        Console.WriteLine(result);

        Console.WriteLine($"> Time: {stopwatch.ElapsedMilliseconds} MS");
    }

    private static void WriteArray(int[] values)
    {
        Console.WriteLine($"{{ {string.Join(", ", values)} }}");
    }
}
