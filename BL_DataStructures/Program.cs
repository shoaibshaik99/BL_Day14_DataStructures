namespace BL_DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Program to run");
            Console.WriteLine("1.In-built LinkedList\n2.Custom LinkedList");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    LinkedList<int> ll = new LinkedList<int>();
                    ll.AddLast(10);
                    ll.AddLast(20);
                    ll.AddLast(30);
                    //Console.WriteLine(ll.Last.Value);
                    foreach (int data in ll)
                    {
                        Console.WriteLine(data + " ");
                    }
                    break;
                case 2:
                    CustomLinkedList customLinkedList = new CustomLinkedList();
                    customLinkedList.Append(56);
                    customLinkedList.Append(30);
                    customLinkedList.Append(70);
                    break;
            }
        }
    }
}