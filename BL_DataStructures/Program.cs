using Microsoft.VisualBasic.FileIO;

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
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("01. Add Last\n02. Append\n03. Insert After\n04. Pop\n05. Pop last\n06. Display\n07. Find\n" +
                    "08. Add in between\n09. Delete a node\n10. Display size\n11. Exit");
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
                        if (customLinkedList.head == null)
                            Console.WriteLine("Cannot pop from an empty list");
                        else
                            customLinkedList.Pop();
                        break;
                    case 5:
                        if (customLinkedList.head == null)
                            Console.WriteLine("Cannot pop from an empty list");
                        else
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
                        {
                            Console.WriteLine("Node with data {0} found in CustomLinkedList", result.data);
                        }
                        else
                        {
                            Console.WriteLine("No node with data {0} found in CustomLinkedList", data);
                        }
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
