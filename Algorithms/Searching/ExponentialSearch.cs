namespace Algorithms;

public partial class Searching
{
    // Time Complexity
    // Best ~> 1
    // Worst ~> log(n)
    // Average ~> log(n)
    public static int ExponentialSearch(int[] values, int value)
    {
        // If value is in first place
        if (values[0] == value)
        {
            // Return 0
            return 0;
        }

        // Evaluate bound to use in binary search
        int bound = 1;
        while (bound < values.Length && values[bound] < value)
        {
            bound *= 2;
        }

        // Assign limits using bound
        int left = bound / 2;
        int right = Math.Min(bound, values.Length - 1);

        // Loop while we have a searchable area
        while (left <= right)
        {
            // Get middle index between left and right
            int middle = (left + right) / 2;

            // If middle item is equals to value
            if (values[middle] == value)
            {
                // Return the index
                return middle;
            }

            if (values[middle] < value)
            {
                // Limit searching area as rightside if middle item is lesser than value
                left = middle + 1;
            }
            else
            {
                // Limit searching area as leftside if middle item is greater than value
                right = middle - 1;
            }
        }

        return -1;
    }
}
