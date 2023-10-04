namespace CSharp.LeetCode._703;

//703. Kth Largest Element in a Stream
//https://leetcode.com/problems/kth-largest-element-in-a-stream/description/
public class KthLargest
{
    private readonly List<int> _list;
    private readonly int _k;

    public KthLargest(int k, int[] nums)
    {
        Array.Sort(nums);
        _list = new List<int>(nums);
        _k = k;
    }

    public int Add(int val)
    {
        var index = _list.BinarySearch(val);
        index = index >= 0 ? index : ~index;
        _list.Insert(index, val);
        return _list[^_k];
    }
}