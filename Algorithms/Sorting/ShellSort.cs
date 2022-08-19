namespace Algorithms;

public partial class Sorting
{
    // Time Complexity
    // Best ~> n * log(n)
    // Worst ~> n^2
    // Average ~> n * log(n)
    public static void ShellSort(int[] values)
    {
        // Rearrange items using interval
        for (int interval = values.Length / 2; interval != 0; interval /= 2)
        {
            for (int i = interval; i < values.Length; i++)
            {
                // Store the value
                int value = values[i];

                // The index of arrangement
                int j = i;

                // Shift items while value is lesser than item that has index difference by interval
                while (j >= interval && values[j - interval] > value)
                {
                    values[j] = values[j - interval];
                    j -= interval;
                }

                // Place value to arranged index
                values[j] = value;
            }
        }
    }
}
