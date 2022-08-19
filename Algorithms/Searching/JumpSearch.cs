namespace Algorithms;

public partial class Searching
{
    // Time Complexity
    // Best ~> 1
    // Worst ~> sqrt(n)
    // Average ~> sqrt(n)
    public static int JumpSearch(int[] values, int value)
    {
        // The square root of length of the values
        int sqrt = (int)Math.Sqrt(values.Length);

        // The previous step
        int previous = 0;

        // The current step of search
        int step = sqrt;

        // Find the block where value is exists
        while (values[Math.Min(step, values.Length) - 1] < value)
        {
            // Store previous step
            previous = step;

            // Jump to next step
            step += sqrt;

            // Return invalid index if we reach end of the array
            if (step >= values.Length)
            {
                return -1;
            }
        }

        // Linear searching the found block
        while (values[previous] < value)
        {
            // Return invalid index if we reach next block or end of the array
            if (++previous == Math.Min(step, values.Length))
            {
                return -1;
            }
        }

        // If current index is equals to value
        if (values[previous] == value)
        {
            // Return index
            return previous;
        }

        return -1;
    }
}
