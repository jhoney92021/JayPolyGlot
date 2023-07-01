// namespace CSharpBasics.LinkedLists;

// public static class LinkedListBuilder
// {
//     public static LinkedList BuildLinkedList(int[] values)
//     {
//         var linkedList = new LinkedList();
//         var head = new Node(values[0]);
//         linkedList.Head = head;

//         for(int i = 1; i < values.Length; i++)
//         {
//             var nextLink = new Node(values[i]);
//             // nextLink.SetPrevious(head);
//             head.SetNext(nextLink);
//             head = nextLink;
//         }

//         return linkedList;
//     }
// }