namespace Algorithms;

public partial class Recursion
{
    public static int Factorial(int value)
    {
        if (value < 2)
        {
            return 1;
        }

        return value * Factorial(value - 1);
    }
}
