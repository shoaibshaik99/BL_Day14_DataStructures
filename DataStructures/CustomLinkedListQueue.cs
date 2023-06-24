namespace DataStructures
{
    public class CustomQueue
    {
        private CustomLinkedList queueList;

        public CustomQueue()
        {
            queueList = new CustomLinkedList();
        }

        public void Enqueue(int data)
        {
            queueList.Append(data);
        }

        
        public void Display()
        {
            queueList.Display();
        }
    }
}
