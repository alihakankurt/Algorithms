namespace Algorithms;

public partial class Sorting
{
    // Time Complexity
    // Best ~> n
    // Worst ~> n^2
    // Average ~> n^2
    public static void BubbleSort(int[] values)
    {
        // Loop the steps
        for (int i = 0; i < values.Length; i++)
        {
            // Tracks the swap state
            bool swapped = false;

            // Loop the items
            for (int j = 0; j < values.Length - i - 1; j++)
            {
                // Compare the items 
                if (values[j] > values[j + 1])
                {
                    // Swaps the items
                    (values[j], values[j + 1]) = (values[j + 1], values[j]);
                    swapped = true;
                }
            }

            // If values are sorted, break the loop
            if (!swapped)
            {
                break;
            }
        }
    }
}
