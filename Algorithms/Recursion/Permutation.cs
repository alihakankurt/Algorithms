namespace Algorithms;

public partial class Recursion
{
    public static int Permutation(int n, int k)
    {
        if (k < 0 || n < k)
        {
            return -1;
        }

        if (k == 0)
        {
            return 1;
        }

        return n * Permutation(n - 1, k - 1);
    }
}
