namespace Algorithms;

public partial class Sorting
{
    // Time Complexity
    // Best ~> n * log(n)
    // Worst ~> n * log(n)
    // Average ~> n * log(n)
    public static void MergeSort(int[] values)
    {
        MergeSort(values, 0, values.Length - 1);
    }

    private static void MergeSort(int[] values, int left, int right)
    {
        if (left < right)
        {
            // The middle index of the subarrays
            int middle = (left + right) / 2;

            // Sort the left subarray
            MergeSort(values, left, middle);

            // Sort the right subarray
            MergeSort(values, middle + 1, right);

            // Merge sorted arrays
            Merge(values, left, middle, right);
        }
    }

    private static void Merge(int[] values, int left, int middle, int right)
    {
        // Instantiate new subarrays
        int[] leftSubarray = new int[middle - left + 1];
        int[] rightSubarray = new int[right - middle];

        // Copy items to left subarray
        for (int i = 0; i < leftSubarray.Length; i++)
        {
            leftSubarray[i] = values[left + i];
        }

        // Copy items to right subarray
        for (int i = 0; i < rightSubarray.Length; i++)
        {
            rightSubarray[i] = values[middle + i + 1];
        }


        int l = 0;
        int r = 0;
        int k = left;

        // Until we reach either end of left or right subarray sort the arrays
        while (l < leftSubarray.Length && r < rightSubarray.Length)
        {
            values[k++] = (leftSubarray[l] < rightSubarray[r]) ? leftSubarray[l++] : rightSubarray[r++];
        }

        // Place remaining items to the left subarray
        while (l < leftSubarray.Length)
        {
            values[k++] = leftSubarray[l++];
        }

        // Place remaining items to the right subarray
        while (r < rightSubarray.Length)
        {
            values[k++] = rightSubarray[r++];
        }
    }
}
