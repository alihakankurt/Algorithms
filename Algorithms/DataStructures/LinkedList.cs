namespace Algorithms.DataStructures;

public sealed class LinkedList<T>
{
    private Node<T>? _first;

    public int Count { get; private set; }

    public void Add(T value)
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
        Count++;
    }

    public void Delete(T value)
    {
        if (_first is null)
        {
            return;
        }

        Node<T> node = _first;
        while (node.Next is not null)
        {
            if (node.Next.Value?.Equals(value) ?? false)
            {
                Node<T> deleted = node.Next;
                node.Next = node.Next.Next;
                deleted.Next = null;
                Count--;
                break;
            }

            node = node.Next;
        }
    }

    public Node<T>? Find(T value)
    {
        Node<T>? node = _first;
        while (node is not null && (!node.Value?.Equals(value) ?? false))
        {
            node = node.Next;
        }

        return node;
    }

    public void Clear()
    {
        while (_first is not null)
        {
            Node<T>? node = _first.Next;
            _first.Next = null;
            _first = node;
        }

        Count = 0;
    }
}
