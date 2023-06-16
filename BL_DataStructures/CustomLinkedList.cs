using System.Xml.Linq;

namespace BL_DataStructures
{
    internal class CustomLinkedList
    {
        public Node head;

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