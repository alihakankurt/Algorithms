namespace Algorithms;

public partial class Recursion
{
    public static int Combination(int n, int k)
    {
        if (k < 0 || n < k)
        {
            return -1;
        }

        if (k == 0 || k == n)
        {
            return 1;
        }

        return Combination(n - 1, k) + Combination(n - 1, k - 1);
    }
}
