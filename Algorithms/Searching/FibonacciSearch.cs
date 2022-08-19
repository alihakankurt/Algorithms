namespace Algorithms;

public partial class Searching
{
    // Time Complexity
    // Best ~> 1
    // Worst ~> log(n)
    // Average ~> log(n)
    public static int FibonacciSearch(int[] values, int value)
    {
        // Assign fibonacci numbers
        int fibonacci1 = 0;
        int fibonacci2 = 1;
        int fibonacci3 = fibonacci1 + fibonacci2;

        // Loop while fibonacci3 is not smallest that greater or equal to n
        while (fibonacci1 < values.Length)
        {
            fibonacci1 = fibonacci2;
            fibonacci2 = fibonacci3;
            fibonacci3 = fibonacci1 + fibonacci2;
        }

        // The eliminated range from left
        int offset = -1;

        // Loop while we have a search area
        while (fibonacci3 > 1)
        {
            // Get the valid index
            int index = Math.Min(offset + fibonacci1, values.Length - 1);

            // If item in index is equals to value
            if (values[index] == value)
            {
                // Return index
                return index;
            }

            if (values[index] < value)
            {
                // Limit searching area by lowering fibonacci and setting offset to index if item in index is lesser than value
                fibonacci3 = fibonacci2;
                fibonacci2 = fibonacci1;
                fibonacci1 = fibonacci3 - fibonacci2;
                offset = index;
            }
            else
            {
                // Limit searching area by lowering fibonacci twice if item in index is greater than value
                fibonacci3 = fibonacci1;
                fibonacci2 -= fibonacci1;
                fibonacci1 = fibonacci3 - fibonacci2;
            }
        }

        // Check the last index
        if (fibonacci1 == 0 && values[values.Length - 1] == value)
        {
            return values.Length - 1;
        }

        return -1;
    }
}
