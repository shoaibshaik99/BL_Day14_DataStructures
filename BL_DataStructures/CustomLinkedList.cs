﻿namespace BL_DataStructures
{
    internal class CustomLinkedList
    {
        public Node head;

        // Method to add a new node with data to the end of the list
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is addded into CustomLinkedList", data);
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
                Console.WriteLine("{0} is addded into CustomLinkedList", data);
            }
        }

        // Method to append a new node with data to the end of the list
        public void Append(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is appended into CustomLinkedList", data);
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
                Console.WriteLine("{0} is appended into CustomLinkedList", data);
            }
        }

        // Method to insert a new node with newData after a specified node with data
        public void InsertAfter(int data, int newData)
        {
            Node newNode = new Node(newData);
            Node currentNode = head;
            while (currentNode != null && currentNode.data != data)
            {
                currentNode = currentNode.next;
            }
            if (currentNode != null)
            {
                newNode.next = currentNode.next;
                currentNode.next = newNode;
                Console.WriteLine("{0} is inserted into CustomLinkedList after {1}", newData, data);
            }
            else
            {
                Console.WriteLine("No node with data {0} found in CustomLinkedList", data);
            }
        }

        public int Pop()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty, can't pop from a LinkedList ");
            }
            int data = head.data;
            head = head.next;
            Console.WriteLine("{0} is popped from CustomLinkedList", data);
            return data;
        }


        //Display the data in linkedlist
        public void Display()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + " -> ");
                currentNode = currentNode.next;
            }
            Console.WriteLine("null");
        }


        // Method to get the last node in the list
        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}