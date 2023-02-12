using LinkedListRealize.Model;

var list = new MyLinkedList<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.AppendHead(7);

Console.WriteLine();
list.InsertAfter(3, 33);
foreach (var item in list)
{
    Console.Write(item + " ");
}

Console.ReadLine();