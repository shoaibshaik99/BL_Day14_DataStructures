namespace BL_DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. AddLast\n2. Append\n3. InsertAfter\n4. Pop\n5. PopLast\n6. Display\n7. Find\n8. Exit");
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
                        try
                        {
                            data = customLinkedList.Pop();
                            Console.WriteLine("{0} was removed from the head of the list", data);
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        try
                        {
                            data = customLinkedList.PopLast();
                            Console.WriteLine("{0} was removed from the end of the list", data);
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 6:
                        customLinkedList.Display();
                        break;
                    case 7:
                        Console.WriteLine("Enter data of the node to find:");
                        data = Convert.ToInt32(Console.ReadLine());
                        result = customLinkedList.Find(data);
                        if (result != null)
                        {
                            Console.WriteLine("Node with data {0} found in CustomLinkedList", result.data);
                        }
                        else
                        {
                            Console.WriteLine("No node with data {0} found in CustomLinkedList", data);
                        }
                        break;
                    case 8:
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
