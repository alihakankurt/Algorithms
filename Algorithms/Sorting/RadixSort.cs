namespace Algorithms;

public partial class Sorting
{
    // Time Complexity
    // Best ~> n + k
    // Worst ~> n + k
    // Average ~> n + k
    public static void RadixSort(int[] values)
    {
        // Find the max value of the array
        int maxValue = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            maxValue = Math.Max(maxValue, values[i]);
        }

        // Apply counting sort to array by their each digit
        for (int k = 1; maxValue / k != 0; k *= 10)
        {
            int[] count = new int[10];
            for (int i = 0; i < values.Length; i++)
            {
                count[(values[i] / k) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            int[] clone = new int[values.Length];
            for (int i = values.Length - 1; i >= 0; i--)
            {
                int value = values[i];
                int digit = (value / k) % 10;
                count[digit]--;
                clone[count[digit]] = value;
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = clone[i];
            }
        }
    }
}
