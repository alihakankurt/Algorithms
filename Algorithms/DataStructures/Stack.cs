namespace Algorithms.DataStructures;

public sealed class Stack<T>
{
    private Node<T>? _top;

    public int Count { get; private set; }

    public void Push(T value)
    {
        _top = new(value, _top);
        Count++;
    }

    public T? Peek()
    {
        return (_top is not null) ? _top.Value : default;
    }

    public T? Pop()
    {
        T? value = default;
        if (_top is not null)
        {
            value = _top.Value;
            _top = _top.Next;
            Count--;
        }

        return value;
    }

    public void Clear()
    {
        while (_top is not null)
        {
            Node<T> node = _top;
            _top = _top.Next;
            node.Next = null;
        }

        Count = 0;
    }
}
