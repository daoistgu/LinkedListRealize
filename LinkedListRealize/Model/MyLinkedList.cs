using System.Collections;

namespace LinkedListRealize.Model;
/// <summary>
/// Односвязный список
/// </summary>
public class MyLinkedList<T> : IEnumerable
{
    /// <summary>
    /// Первый элемент списка
    /// </summary>
    public Item<T> Head { get; private set; }
    /// <summary>
    /// Последний элемент списка
    /// </summary>
    public Item<T> Tail { get; private set; }
    /// <summary>
    /// Количество элементов в списке
    /// </summary>
    public int Count { get; private set; }
    /// <summary>
    /// Создать пустой список
    /// </summary>
    public MyLinkedList()
    {
        Clear();
    }
    /// <summary>
    /// создать список с начальным элементом
    /// </summary>
    /// <param name="data"></param>
    public MyLinkedList(T data)
    {
        SetHeadAndTail(data);
    }

    /// <summary>
    /// Добавить данные в конец списка
    /// </summary>
    /// <param name="data"></param>

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
    /// <summary>
    /// Добавть данные в начало списка
    /// </summary>
    /// <param name="data"></param>
    public void AppendHead(T data)
    {
        var item = new Item<T>(data);
        item.Next = Head;
        Head = item;
        Count++;
    }
    /// <summary>
    /// Удалить первое вхождение данных в список
    /// </summary>
    /// <param name="data"></param>

    public void Delete(T data)
    {
        if (Head != null)
        {
            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                Count--;
                return;
            }
            var current = Head.Next;
            var previous = Head;


            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    previous.Next = current.Next;

                    Count--;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }
        else
        {
            SetHeadAndTail(data);
        }
    }
    /// <summary>
    /// Очистить список от всех элементов
    /// </summary>
    public void Clear()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }
    /// <summary>
    /// Добавить элемент в список, после определенного элемента 
    /// </summary>
    public void InsertAfter(T target, T data)
    {
        if (Head != null)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(target))
                {
                    var item = new Item<T>(data); 
                    item.Next = current.Next;
                    current.Next = item;
                    Count++;
                    return;
                }
                else
                {
                    current = current.Next;
                }
            }
        }
        else
        {
            Add(data);
        }
    }


    private void SetHeadAndTail(T data)
    {
        var item = new Item<T>(data);
        Head = item;
        Tail = item;
        Count = 1;
    }

    /// <summary>
    /// получить перечисление всех элементов списка
    /// </summary>
    /// <returns></returns>
    public IEnumerator GetEnumerator()
    {
        var current = Head;
        while (current != null)
        {
            yield return current;
            current = current.Next;
        }
    }
    public override string ToString()
    {
        return "Linked List " + Count + " Элементов";
    }
}
