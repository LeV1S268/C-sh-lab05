/*using System.Collections;

MyList<int> list = new MyList<int> { 1, 2, 3, 4, 5, 6 };
list.Add(7);

Console.WriteLine(list[3]);

list[3] = 1;
Console.WriteLine(list[3]);


for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

foreach (int i in list)
{
    Console.WriteLine(i);
}

public class MyList<T> : IEnumerable<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[4];
        count = 0;
    }

    public int Count
    {
        get { return count; }
    }

    public T this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        items[count] = item;
        count++;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}*/