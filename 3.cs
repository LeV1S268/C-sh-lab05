/*using System.Collections;

MyDictionary<int, string> dic = new MyDictionary<int, string>();

dic.Add(1, "one");
dic.Add(2, "two");
dic.Add(3, "three");

Console.WriteLine(dic[2]);

dic[2] = "Five";

Console.WriteLine(dic[2]);

foreach (var pair in dic)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
{
    private TKey[] keys;
    private TValue[] values;
    private int count;

    public MyDictionary()
    {
        keys = new TKey[4];
        values = new TValue[4];
        count = 0;
    }

    public int Count
    {
        get { return count; }
    }

    public TValue this[TKey key]
    {
        get { return values[count]; }
        set { values[count] = value; }
    }

    public void Add(TKey key, TValue value)
    {
        if (count == keys.Length)
        {
            Array.Resize(ref keys, keys.Length * 2);
        }
        keys[count] = key;
        values[count] = value;
        count++;
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}*/