namespace Algorithms;

public partial class Sorting
{
    // Time Complexity
    // Best ~> n * log(n)
    // Worst ~> n * log(n)
    // Average ~> n * log(n)
    public static void HeapSort(int[] values)
    {
        // Build max-heap
        for (int i = values.Length / 2 - 1; i >= 0; i--)
        {
            Heapify(values, i, values.Length);
        }

        // Sort
        for (int i = values.Length - 1; i > 0; i--)
        {
            (values[0], values[i]) = (values[i], values[0]);
            Heapify(values, 0, i);
        }
    }

    private static void Heapify(int[] values, int root, int size)
    {
        // Greatest value among the root and childs
        int index = root;

        // The left child
        int left = 2 * root + 1;

        // The right child
        int right = 2 * root + 2;

        if (left < size && values[index] < values[left])
        {
            index = left;
        }

        if (right < size && values[index] < values[right])
        {
            index = right;
        }

        // Swap and continue heapify if root is not the greatest
        if (root != index)
        {
            (values[root], values[index]) = (values[index], values[root]);
            Heapify(values, index, size);
        }
    }
}
