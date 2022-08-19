namespace Algorithms;

public partial class Recursion
{
    public static int GreatCommonDivisor(int value1, int value2)
    {
        if (value2 == 0)
        {
            return value1;
        }

        return GreatCommonDivisor(value2, value1 % value2);
    }
}
