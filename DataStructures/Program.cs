namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose a data structure:");
                Console.WriteLine("1. Custom Linked List\n2. Custom Stack\n3. Custom Queue\n4. Exit");
                int dataStructureOption = Convert.ToInt32(Console.ReadLine());
                switch (dataStructureOption)
                {
                    case 1:
                        CustomLinkedList customLinkedList = new CustomLinkedList();
                        bool exitLinkedList = false;
                        while (!exitLinkedList)
                        {
                            Console.WriteLine("\nChoose an option:");
                            Console.WriteLine("1. Add Last\n2. Append\n3. Insert After\n4. Pop\n5. Pop last\n6. Display\n7. Find\n" +
                                "8. Add in between\n9. Delete a node\n10. Display size\n11. SortedLinkedList\n12. Exit");
                            int option = Convert.ToInt32(Console.ReadLine());
                            int data, newData;
                            Node result;
                            switch (option)
                            {
                                case 1:
                                    Console.WriteLine("Enter data to add to the end of the list:");
                                    data = Convert.ToInt32(Console.ReadLine());
                                    customLinkedList.AddLast(data);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter data to append to the end of the list:");
                                    data = Convert.ToInt32(Console.ReadLine());
                                    customLinkedList.Append(data);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter data of the node to insert after:");
                                    data = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter data of the new node:");
                                    newData = Convert.ToInt32(Console.ReadLine());
                                    customLinkedList.InsertAfter(data, newData);
                                    break;
                                case 4:
                                    customLinkedList.Pop();
                                    break;
                                case 5:
                                    customLinkedList.PopLast();
                                    break;
                                case 6:
                                    customLinkedList.Display();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter data of the node to find:");
                                    data = Convert.ToInt32(Console.ReadLine());
                                    result = customLinkedList.Find(data);
                                    if (result != null)
                                        Console.WriteLine("Node with data {0} found in CustomLinkedList", result.data);
                                    else
                                        Console.WriteLine("No node with data {0} found in CustomLinkedList", data);
                                    break;
                                case 8:
                                    Console.WriteLine("Enter data of the first node:");
                                    int firstData = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter data of the second node:");
                                    int secondData = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter data of the new node:");
                                    newData = Convert.ToInt32(Console.ReadLine());
                                    customLinkedList.InsertBetween(firstData, secondData, newData);
                                    break;
                                case 9:
                                    Console.WriteLine("Enter the data of node to be deleted.");
                                    data = Convert.ToInt32(Console.ReadLine());
                                    customLinkedList.Delete(data);
                                    break;
                                case 10:
                                    int size = customLinkedList.Size();
                        Console.WriteLine("Size of the LinkedList is {0}",size);
                                    break;
                                case 11:
                                    SortedLinkedList sortedList = new SortedLinkedList();
                                    sortedList.Add(56);
                                    sortedList.Add(30);
                                    sortedList.Add(40);
                                    sortedList.Add(70);
                                    Console.WriteLine("Sorted linked list:");
                                    sortedList.Display();
                                    return;
                                case 12:
                                    exitLinkedList = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid option");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        CustomStack customStack = new CustomStack();
                        bool exitStack = false;
                        while (!exitStack)
                        {
                            Console.WriteLine("\nChoose an option:");
                            Console.WriteLine("1. Push\n2. Display\n3. Peek\n4. Pop\n5. Peek and Pop till Stack is empty \n6. Exit");
                            int stackOption = Convert.ToInt32(Console.ReadLine());
                            int stackData;
                            switch (stackOption)
                            {
                                case 1:
                                    Console.WriteLine("Enter data to push onto the stack:");
                                    stackData = Convert.ToInt32(Console.ReadLine());
                                    customStack.Push(stackData);
                                    break;
                                case 2:
                                    customStack.Display();
                                    break;
                                case 3:
                                    customStack.Peek();
                                    break;
                                case 4:
                                    customStack.Pop();
                                    break;
                                case 5:
                                    customStack.PeekAndPopTillEmpty();
                                    break;
                                case 6:
                                    exitStack = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid option");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        CustomQueue customQueue = new CustomQueue();
                        bool exitQueue = false;
                        while (!exitQueue)
                        {
                            Console.WriteLine("\nChoose an option:");
                            Console.WriteLine("1. Enqueue\n2. Display\n3. Exit");
                            int queueOption = Convert.ToInt32(Console.ReadLine());
                            int queueData;
                            switch (queueOption)
                            {
                                case 1:
                                    Console.WriteLine("Enter data to enqueue into the queue:");
                                    queueData = Convert.ToInt32(Console.ReadLine());
                                    customQueue.Enqueue(queueData);
                                    break;
                                case 2:
                                    customQueue.Display();
                                    break;
                                case 3:
                                    exitQueue = true;
                                    break;
                                default:
                                    Console.WriteLine("Invalid option");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}