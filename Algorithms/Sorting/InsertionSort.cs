namespace Algorithms;

public partial class Sorting
{
    // Time Complexity
    // Best ~> n
    // Worst ~> n^2
    // Average ~> n^2
    public static void InsertionSort(int[] values)
    {
        // Loop the items starting from 1
        for (int i = 1; i < values.Length; i++)
        {
            // The value in current index
            int value = values[i];

            // The new index of the value
            int j = i - 1;

            // Shift all items that greater than value
            while (j >= 0 && values[j] > value)
            {
                values[j + 1] = values[j];
                j--;
            }

            // Set the new index to value
            values[j + 1] = value;
        }
    }
}
