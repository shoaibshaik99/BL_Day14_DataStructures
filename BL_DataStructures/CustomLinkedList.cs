namespace BL_DataStructures
{
    public class CustomLinkedList
    {
        public Node head;

        // Method to add a new node with data to the end of the list
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is added into CustomLinkedList", data);
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
                Console.WriteLine("{0} is added into CustomLinkedList", data);
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

        // Method to remove the head node from the list and return its data
        public int Pop()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Cannot pop from an empty list");
            }
            int data = head.data;
            head = head.next;
            Console.WriteLine("{0} is popped from CustomLinkedList", data);
            return data;
        }

        // Method to remove the last node from the list and return its data
        public int PopLast()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Cannot pop from an empty list");
            }
            Node currentNode = head;
            Node previousNode = null;
            while (currentNode.next != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
            int data = currentNode.data;
            if (previousNode != null)
            {
                previousNode.next = null;
            }
            else
            {
                head = null;
            }
            Console.WriteLine("{0} is popped from CustomLinkedList", data);
            return data;
        }

        // Method to search for a node with the specified data and return it
        public Node Find(int data)
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    return currentNode;
                }
                currentNode = currentNode.next;
            }
            return null;
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

        // Method to display the linked list
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
    }
}