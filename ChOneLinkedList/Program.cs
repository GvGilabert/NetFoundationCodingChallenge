using System;

namespace ChOneLinkedList
{
    class Program
    {
        /*
            CHALLENGE #1
            * Insert Node into Linked List
            Write a function to insert a node in a singly-linked list at a given point in the linked list. The function
            should take in two inputs: the value of the node and the position where the node will be inserted.
            The position will be a 1-based index meaning that the position of the head node will be 1. The
            position will never be the beginning (the head) or the end (the tail) of the list.
            
            List: 1 -> 5 -> 10 -> 3 -> 6
            Input: insert(2,4)
            Output: 1 -> 5 -> 10 -> 2 -> 3 -> 6
            
            List: 1 -> 5 -> 10 -> 3 -> 6
            Input: insert(3,2)
            Output: 1 -> 3 -> 5 -> 10 -> 3 -> 6
            
            List: 1 -> 5 -> 10 -> 3 -> 6
            Input: insert(9,3)
            Output: 1 -> 5 -> 9 -> 10 -> 3 -> 6
        
         */
        static void Main(string[] args)
        {
            LinkedList lk = new LinkedList();
            lk.InsertNumbers(1, 5, 10, 3, 6);
            lk.PrintList();
            lk.InsertNode(2, 4);
            lk.PrintList();

            lk = new LinkedList();
            lk.InsertNumbers(1, 5, 10, 3, 6);
            lk.PrintList();
            lk.InsertNodeAtEnd(6);
            lk.InsertNode(3, 2);
            lk.PrintList();

            lk = new LinkedList();
            lk.InsertNumbers(1, 5, 10, 3, 6);
            lk.PrintList();
            lk.InsertNode(9, 3);
            lk.PrintList();
        }
    }
}
