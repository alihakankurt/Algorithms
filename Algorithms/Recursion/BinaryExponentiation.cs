namespace Algorithms;

public partial class Recursion
{
    public static int BinaryExponentiation(int b, int e)
    {
        if (e == 0)
        {
            return 1;
        }

        int evaluation = BinaryExponentiation(b, e / 2);
        evaluation *= evaluation;

        if ((e & 1) == 1)
        {
            evaluation *= b;
        }

        return evaluation;
    }
}
