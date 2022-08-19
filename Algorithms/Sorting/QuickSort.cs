namespace Algorithms;

public partial class Sorting
{
    // Time Complexity
    // Best ~> n * log(n)
    // Worst ~> n^2
    // Average ~> n * log(n)
    public static void QuickSort(int[] values)
    {
        QuickSort(values, 0, values.Length - 1);
    }

    private static void QuickSort(int[] values, int left, int right)
    {
        if (left < right)
        {
            // Get the partition point
            int pivot = Partition(values, left, right);

            // Sort left of pivot
            QuickSort(values, left, pivot - 1);

            // Sort right of pivot
            QuickSort(values, pivot + 1, right);
        }
    }

    private static int Partition(int[] values, int left, int right)
    {
        // Select the rightmost item as pivot
        int pivot = values[right];

        // Points to the greater item in subarray
        int i = left;

        // Loop all items in subarray
        for (int j = left; j < right; j++)
        {
            // Swap current item with pivot if item is smaller
            if (values[j] <= pivot)
            {
                (values[i], values[j]) = (values[j], values[i]);
                i++;
            }
        }

        // Place the greater item to rightmost by swapping with pivot
        (values[i], values[right]) = (values[right], values[i]);

        // Return the partition point
        return i;
    }
}
