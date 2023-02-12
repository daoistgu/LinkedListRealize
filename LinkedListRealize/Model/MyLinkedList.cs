using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListRealize.Model;
public class MyLinkedList<T>
{
    public Item<T> Head { get; private set; }
    public Item<T> Tail { get; private set; }
    public int Count { get; private set; }

    public MyLinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }
    public MyLinkedList(T data)
    {
        var item = new Item<T>(data);
       SetHeadAndTail(data);
    }

    public void Add(T data)
    {
        if (Tail != null)
        {
            var item = new Item<T>(data);
            Tail.Next = item;
            Tail = item;
            Count++;
        }
        else
        {
            SetHeadAndTail(data);
        }
    }

    private void SetHeadAndTail(T data)
    {
        var item = new Item<T>(data);
        Head = item;
        Tail = item;
        Count = 1;
    }
}
