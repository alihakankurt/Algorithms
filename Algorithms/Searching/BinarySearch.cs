namespace Algorithms;

public partial class Searching
{
    // Time Complexity
    // Best ~> 1
    // Worst ~> log(n)
    // Average ~> log(n)
    public static int BinarySearch(int[] values, int value)
    {
        // Assign limits
        int left = 0;
        int right = values.Length - 1;

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
