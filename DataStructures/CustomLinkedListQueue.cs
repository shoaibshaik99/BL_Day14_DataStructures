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

        public int Dequeue()
        {
            if (queueList.head == null)
            {
                Console.WriteLine("Cannot dequeue from an empty queue");
                return -1;
            }
            else
            {
                int data = queueList.head.data;
                queueList.Pop();
                return data;
            }
        }

        public void Display()
        {
            queueList.Display();
        }
    }
}
