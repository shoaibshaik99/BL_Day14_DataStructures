namespace DataStructures
{
    public class CustomStack
    {
        private CustomLinkedList stackList;

        public CustomStack()
        {
            stackList = new CustomLinkedList();
        }

        public void Push(int data)
        {
            stackList.AddFirst(data);
        }

        public int? Pop()
        {
            if (stackList.head == null)
            {
                Console.WriteLine("Cannot pop from an empty stack");
                return null;
            }
            else
            {
                int data = stackList.head.data;
                stackList.Pop();
                return data;
            }
        }

        public int? Peek()
        {
            if (stackList.head == null)
            {
                Console.WriteLine("Cannot peek from an empty stack");
                return null;
            }
            else
            {
                int data = stackList.head.data;
                Console.WriteLine("{0} is at the top of the stack", data);
                return data;
            }
        }

        public void PeekAndPopTillEmpty()
        {
            while (stackList.head != null)
            {
                Peek();
                Pop();
            }
        }

        public void Display()
        {
            Console.WriteLine("Stack: ");
            stackList.Display();
        }
    }
}
