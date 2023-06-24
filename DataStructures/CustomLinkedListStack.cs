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

        public void Display()
        {
            Console.WriteLine("Stack: ");
            stackList.Display();
        }
    }
}
