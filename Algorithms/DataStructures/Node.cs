﻿namespace Algorithms.DataStructures;

public sealed class Node<T>
{
    public T Value { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T value, Node<T>? next)
    {
        Value = value;
        Next = next;
    }
}
