namespace Algorithms;

public partial class Sorting
{
    // Time Complexity
    // Best ~> n^2
    // Worst ~> n^2
    // Average ~> n^2
    public static void SelectionSort(int[] values)
    {
        // Loop the items
        for (int i = 0; i < values.Length; i++)
        {
            // Holds minimum index
            int index = i;

            // Find the minimum index of the subarray
            for (int j = i + 1; j < values.Length; j++)
            {
                if (values[j] < values[index])
                {
                    index = j;
                }
            }

            // Place the minimum to current index
            (values[i], values[index]) = (values[index], values[i]);
        }
    }
}
