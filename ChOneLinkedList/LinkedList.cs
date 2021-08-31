using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChOneLinkedList
{

    class Node
    {
        public int Value;
        public Node Next;
        public Node(int value, Node next = null)
        {
            Value = value;
            Next = next;
        }
    }

    class LinkedList
    {
        Node Head;

        public void InsertNodeAtEnd(int value)
        {
            if (Head is null)
            {
                Head = new Node(value);
            }
            else
            {
                Node actualNode = Head;
                while (actualNode.Next is not null)
                {
                    actualNode = actualNode.Next;
                }
                actualNode.Next = new Node(value);
            }
        }

        public void InsertNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                InsertNodeAtEnd(numbers[i]);
            }
        }

        public void InsertNode(int value, int position)
        {
            Node actualNode = Head;
            int actPos = 1;
            while (actPos < position - 1)
            {
                actPos++;
                actualNode = actualNode.Next;
            }
            Node toInsert = new Node(value, actualNode.Next);
            actualNode.Next = toInsert;

        }

        public void PrintList()
        {
            Node currentNode = Head;
            while (currentNode is not null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}