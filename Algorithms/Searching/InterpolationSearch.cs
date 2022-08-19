namespace Algorithms;

public partial class Searching
{
    // Time Complexity
    // Best ~> 1
    // Worst ~> n
    // Average ~> log(log(n))
    public static int InterpolationSearch(int[] values, int value)
    {
        // Assign limits
        int left = 0;
        int right = values.Length - 1;

        // Loop while we have a searching area
        while (left <= right && values[left] != values[right])
        {
            // Evaluate middle
            int middle = left + ((value - values[left]) * (right - left) / (values[right] - values[left]));

            // If middle item is equals to value
            if (values[middle] == value)
            {
                // Return index
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

        // If item in left limit is equals to value
        if (values[left] == value)
        {
            // Return left
            return left;
        }

        return -1;
    }
}
