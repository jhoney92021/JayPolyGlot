using CSharpBasics.Helpers;

namespace CSharpBasics.LinkedLists;

#nullable enable

public class Node <T>
{
    public int Index { get; set; }
    public T Value { get; set; }
    public Node<T>? Next { get; internal set; }
    // public Node<T>? Previous { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = null;
        // Previous = null;
    }

}


// public static class LinkExntensions
// {
//     public static void SetNext(this Node thisLink, Node nextLink)
//     {
//         thisLink.NextLink = nextLink;
//     }
//     // public static void SetPrevious(this Node thisLink, Node previousLink)
//     // {
//     //     thisLink.PreviousLink = previousLink;
//     // }
// }