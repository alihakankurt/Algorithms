namespace Algorithms;

public partial class Recursion
{
    public static int Fibonacci(int value)
    {
        if (value < 1)
        {
            return 0;
        }

        if (value < 3)
        {
            return 1;
        }

        return Fibonacci(value - 1) + Fibonacci(value - 2);
    }
}
