namespace Algorithms.DataStructures;

/// <summary>
/// A representation of linked list structure.
/// </summary>
/// <typeparam name="T">The type of value that nodes will contain.</typeparam>
public sealed class LinkedList<T> : IEnumerable<LinkedListNode<T>>
{
    /// <summary>
    /// Gets the first node of the <see cref="LinkedList{T}"/>.
    /// </summary>
    public LinkedListNode<T>? First { get; internal set; }

    /// <summary>
    /// Gets the last node of the <see cref="LinkedList{T}"/>.
    /// </summary>
    public LinkedListNode<T>? Last { get; internal set; }

    /// <summary>
    /// Gets the node count of the <see cref="LinkedList{T}"/>.
    /// </summary>
    public int Count { get; internal set; }

    /// <summary>
    /// Adds a new <see cref="LinkedListNode{T}"/> to the <see cref="LinkedList{T}"/> from the first.
    /// </summary>
    /// <param name="value">The new value to be added.</param>
    public void AddFirst(T value)
    {
        var node = new LinkedListNode<T>
        {
            Value = value,
            Previous = null,
            Next = First,
        };

        if (Count != 0)
        {
            First!.Previous = node;
        }

        First = node;
        Last ??= node;
        Count++;
    }

    /// <summary>
    /// Adds a new <see cref="LinkedListNode{T}"/> to the <see cref="LinkedList{T}"/> from the last.
    /// </summary>
    /// <param name="value">The new value to be added.</param>
    public void AddLast(T value)
    {
        var node = new LinkedListNode<T>
        {
            Value = value,
            Previous = Last,
            Next = null,
        };

        if (Count != 0)
        {
            Last!.Next = node;
        }

        Last = node;
        First ??= node;
        Count++;
    }

    /// <summary>
    /// Deletes the first <see cref="LinkedListNode{T}"/> from the <see cref="LinkedList{T}"/>.
    /// </summary>
    /// <returns><see cref="LinkedListNode{T}"/></returns>
    public LinkedListNode<T>? DeleteFirst()
    {
        LinkedListNode<T>? node = null;

        if (Count != 0)
        {
            node = First!;
            First = First!.Next;

            node.Next = null;

            if (Count != 1)
            {
                First!.Previous = null;
            }

            Count--;
        }

        return node;
    }

    /// <summary>
    /// Deletes the last <see cref="LinkedListNode{T}"/> from the <see cref="LinkedList{T}"/>.
    /// </summary>
    /// <returns><see cref="LinkedListNode{T}"/></returns>
    public LinkedListNode<T>? DeleteLast()
    {
        LinkedListNode<T>? node = null;

        if (Count != 0)
        {
            node = Last;
            Last = Last!.Previous;

            node!.Previous = null;

            if (Count != 1)
            {
                Last!.Next = null;
            }

            Count--;
        }

        return node;
    }

    /// <summary>
    /// Finds the <see cref="LinkedListNode{T}"/> that <see cref="LinkedListNode{T}.Value"/> is <paramref name="value"/> by starting search from the <see cref="First"/>.
    /// </summary>
    /// <param name="value">The value of type <typeparamref name="T"/>.</param>
    /// <returns><see cref="LinkedListNode{T}"/></returns>
    public LinkedListNode<T>? FindFirst(T value)
    {
        LinkedListNode<T>? node = First;

        while (node != null && !node.Value!.Equals(value))
        {
            node = node.Next;
        }

        return node;
    }

    /// <summary>
    /// Finds the <see cref="LinkedListNode{T}"/> that <see cref="LinkedListNode{T}.Value"/> is <paramref name="value"/> by starting search from the <see cref="Last"/>.
    /// </summary>
    /// <param name="value">The value of type <typeparamref name="T"/>.</param>
    /// <returns><see cref="LinkedListNode{T}"/></returns>
    public LinkedListNode<T>? FindLast(T value)
    {
        LinkedListNode<T>? node = Last;

        while (node != null && !node.Value!.Equals(value))
        {
            node = node.Previous;
        }

        return node;
    }

    /// <summary>
    /// Determines whether the <paramref name="value"/> that exists in one of the nodes of the <see cref="LinkedList{T}"/>.
    /// </summary>
    /// <param name="value">The value to search.</param>
    /// <returns><see cref="bool"/></returns>
    public bool Contains(T value)
    {
        return FindFirst(value) != null;
    }

    /// <summary>
    /// Clears the <see cref="LinkedList{T}"/>.
    /// </summary>
    public void Clear()
    {
        while (Count != 0)
        {
            DeleteFirst();
        }
    }

    /// <summary>
    /// Sorts the <see cref="LinkedList{T}"/> by comparing values using <paramref name="comparer"/>.
    /// </summary>
    /// <param name="comparer">The comparer that using in comparing values.</param>
    public void Sort(IComparer<T>? comparer = null)
    {
        comparer ??= Comparer<T>.Default;

        if (comparer != null && Count != 0)
        {
            LinkedListNode<T>? node = First;
            LinkedListNode<T>? next = null;

            while (node != null)
            {
                next = node.Next;

                while (next != null)
                {
                    if (comparer.Compare(node.Value, next.Value) == 1)
                    {
                        (node.Value, next.Value) = (next.Value, node.Value);
                    }

                    next = next.Next;
                }

                node = next;
            }
        }
    }

    /// <inheritdoc/>
    public IEnumerator<LinkedListNode<T>> GetEnumerator()
    {
        LinkedListNode<T>? node = First;

        while (node != null)
        {
            yield return node;
            node = node.Next;
        }
    }

    /// <inheritdoc/>
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

/// <summary>
/// Node of the <see cref="LinkedList{T}"/>
/// </summary>
/// <typeparam name="T"></typeparam>
public sealed class LinkedListNode<T>
{
    /// <summary>
    /// The value of type <see cref="T"/>.
    /// </summary>
    public T? Value { get; set; }

    /// <summary>
    /// The previous node of the <see cref="LinkedListNode{T}"/>.
    /// </summary>
    public LinkedListNode<T>? Previous { get; internal set; }

    /// <summary>
    /// The next node of the <see cref="LinkedListNode{T}"/>.
    /// </summary>
    public LinkedListNode<T>? Next { get; internal set; }

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"LinkedListNode: {Value}";
    }
}
