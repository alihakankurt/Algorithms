namespace Algorithms;

public partial class Searching
{
    // Time Complexity
    // Best ~> 1
    // Worst ~> n
    // Average ~> n
    public static int LinearSearch(int[] values, int value)
    {
        // Loop all items
        for (int i = 0; i < values.Length; i++)
        {
            // If item is equals to value
            if (values[i] == value)
            {
                // Return current index
                return i;
            }
        }

        // Return invalid index if value could not be found
        return -1;
    }
}
