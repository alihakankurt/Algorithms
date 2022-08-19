namespace Algorithms;

public partial class Sorting
{
    // Time Complexity
    // Best ~> n + k
    // Worst ~> n + k
    // Average ~> n + k
    public static void CountingSort(int[] values)
    {
        // Find the max value of the array
        int maxValue = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            maxValue = Math.Max(maxValue, values[i]);
        }

        // Store count of items
        int[] count = new int[maxValue + 1];
        for (int i = 0; i < values.Length; i++)
        {
            count[values[i]]++;
        }

        for (int i = 1; i <= maxValue; i++)
        {
            count[i] += count[i - 1];
        }

        // Place items to clone array with their new index
        int[] clone = new int[values.Length];
        for (int i = 0; i < values.Length; i++)
        {
            int value = values[i];
            count[value]--;
            clone[count[value]] = value;
        }

        // Place sorted items from clone array to original array
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = clone[i];
        }
    }
}
