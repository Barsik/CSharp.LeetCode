namespace CSharp.LeetCode._705;

//705. Design HashSet
//https://leetcode.com/problems/design-hashset/description/
public class MyHashSet
{
    private static readonly int _size = 200;
    private readonly List<int>?[] _bucket = new List<int>?[_size];

    public MyHashSet()
    {
    }

    public void Add(int key)
    {
        var hash = key % _size;
        ref var list = ref _bucket[hash];
        if (list == null)
        {
            list = new List<int> { key };
        }
        else if (!list.Contains(key))
        {
            list.Add(key);
        }
    }

    public void Remove(int key)
    {
        var hash = key % _size;
        var list = _bucket[hash];
        list?.Remove(key);
    }

    public bool Contains(int key)
    {
        var hash = key % _size;
        var list = _bucket[hash];
        return list != null && list.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */