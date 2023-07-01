namespace CSharpBasics.LinkedLists;

public class LinkedList<T>
{
    public Node<T> First { get; private set; }
    public Node<T> Last { get; private set; }
    public int Count { get; private set; }

    public bool AddFirst(Node<T> newNode)
    {
        if (First == null)
        {
            First = newNode;
            Last = newNode;
            Count++;
            return true;
        }

        newNode.Next = First;
        // First.Previous = newNode;
        First = newNode;
        Count++;
        return true;
    }

    public bool AddLast(Node<T> newNode)
    {
        if (Last == null)
        {
            First = newNode;
            Last = newNode;
            Count++;
            return true;
        }

        // newNode.Previous = Last;
        Last.Next = newNode;
        Last = newNode;
        Count++;
        return true;
    }

    public bool AddAfter(Node<T> newNode, Node<T> existingNode)
    {
        if (existingNode == null)
        {
            return false;
        }

        if (existingNode == Last)
        {
            AddLast(newNode);
            return true;
        }

        newNode.Next = existingNode.Next;
        existingNode.Next = newNode;
        Count++;
        return true;
    }

    public Node<T> FindNode(T value)
    {
        var foundNode = First;

        while (foundNode != null && !foundNode.Value.Equals(value))
        {
            foundNode = foundNode.Next;
        }
        Console.WriteLine($"Found node: {foundNode.Value}");
        return foundNode;
    }

    public bool RemoveFirst()
    {
        if (First == null || Count == 0)
        {
            return false;
        }

        if (First == Last)
        {
            First = null;
            Last = null;
            Count--;
            return true;
        }

        First = First.Next;
        // First.Previous = null;
        Count--;
        return true;
    }

    public bool RemoveLast()
    {
        if (Last == null || Count == 0)
        {
            return false;
        }

        if (First == Last)
        {
            First = null;
            Last = null;
            Count--;
            return true;
        }

        var current = First;
        while (current.Next != Last)
        {
            current = current.Next;
        }

        Last = current;
        Last.Next = null;
        Count--;
        return true;
    }

    public bool RemoveThisNode(Node<T> toRemove)
    {
        if (toRemove == null)
        {
            return false;
        }

        if (toRemove == First)
        {
            RemoveFirst();
            return true;
        }

        if (toRemove == Last)
        {
            RemoveLast();
            return true;
        }

        var previous = First;
        var current = previous.Next;
        while (current != null && current != toRemove)
        {
            previous = current;
            current = previous.Next;
        }

        if (current == null)
        {
            return false;
        }

        previous.Next = current.Next;
        Count--;
        Console.WriteLine("Removed: "+current.Value);
        return true;
    }

    public bool Traverse()
    {
        Console.WriteLine("First: "+First.Value);
        Console.WriteLine("Last: "+Last.Value);

        if (First == null)
        {
            return false;
        }

        var current = First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }

        return true;
    }
}