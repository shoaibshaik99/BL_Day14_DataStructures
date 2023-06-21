namespace DataStructures
{
    public class SortedLinkedList
    {
        public Node head;

        // Method to add a new node with data to the list in sorted order
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null || head.data >= data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.next != null && currentNode.next.data < data)
                {
                    currentNode = currentNode.next;
                }
                newNode.next = currentNode.next;
                currentNode.next = newNode;
            }
            Console.WriteLine("{0} is added into SortedLinkedList", data);
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