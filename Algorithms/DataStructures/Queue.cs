namespace Algorithms.DataStructures;

public sealed class Queue<T>
{
    private Node<T>? _first;

    public int Count { get; private set; }

    public void Enqueue(T value)
    {
        Count++;
        if (_first is null)
        {
            _first = new(value, null);
            return;
        }

        Node<T> node = _first;
        while (node.Next is not null)
        {
            node = node.Next;
        }

        node.Next = new(value, null);
    }

    public T? Peek()
    {
        return (_first is not null) ? _first.Value : default;
    }

    public T? Dequeue()
    {
        T? value = default;
        if (_first is not null)
        {
            Node<T> node = _first;
            _first = node.Next;
            node.Next = null;
            value = node.Value;
            Count--;
        }

        return value;
    }

    public void Clear()
    {
        while (_first is not null)
        {
            Node<T> node = _first;
            _first = _first.Next;
            node.Next = null;
        }

        Count = 0;
    }
}
