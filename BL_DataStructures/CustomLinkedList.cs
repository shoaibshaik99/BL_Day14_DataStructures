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

        // Method to remove the head node from the list and return its data, returns null if list is empty.
        public int? Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Cannot pop from an empty list");
                return null;
            }
            int data = head.data;
            head = head.next;
            Console.WriteLine("{0} is popped from CustomLinkedList", data);
            return data;
        }

        // Method to remove the last node from the list and return its data, returns null if list is empty.
        public int? PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Cannot pop from an empty list");
                return null;
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

        //Method to insert a node between the two specified nodes
        public void InsertBetween(int firstData, int secondData, int newData)
        {
            Node newNode = new Node(newData);
            Node currentNode = head;
            while (currentNode != null && currentNode.next != null && (currentNode.data != firstData || currentNode.next.data != secondData))
            {
                currentNode = currentNode.next;
            }
            if (currentNode != null && currentNode.next != null)
            {
                newNode.next = currentNode.next;
                currentNode.next = newNode;
                Console.WriteLine("{0} is inserted into CustomLinkedList between {1} and {2}", newData, firstData, secondData);
            }
            else
            {
                Console.WriteLine("No consecutive nodes with data {0} and {1} found in CustomLinkedList", firstData, secondData);
            }
        }

        //Method to delete a node display the size of list after deleting
        public void Delete(int data)
        {
            if (head == null)
            {
                Console.WriteLine("Cannot delete from an empty list");
                return;
            }
            if (head.data == data)
            {
                head = head.next;
                Console.WriteLine("{0} is deleted from CustomLinkedList", data);
                Console.WriteLine("The size of the list is now {0}", Size());
                return;
            }
            Node previousNode = FindPreviousNode(data);
            if (previousNode != null && previousNode.next != null)
            {
                previousNode.next = previousNode.next.next;
                Console.WriteLine("{0} is deleted from CustomLinkedList", data);
                Console.WriteLine("The size of the list is now {0}", Size());
            }
            else
            {
                Console.WriteLine("No node with data {0} found in CustomLinkedList", data);
            }
        }

        //Method to search for a previous of a node with specified data and return it
        private Node FindPreviousNode(int data)
            {
                Node currentNode = head;
                while (currentNode != null)
                {
                    if (currentNode.next != null && currentNode.next.data == data)
                    {
                        return currentNode;
                    }
                    else
                    {
                        currentNode = currentNode.next;
                    }
                }
                return null;
            }

        //Method to return the size if the list
        public int Size()
            {
                int size = 0;
                Node currentNode = head;
                while (currentNode != null)
                {
                    size++;
                    currentNode = currentNode.next;
                }
                return size;
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