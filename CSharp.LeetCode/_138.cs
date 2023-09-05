namespace CSharp.LeetCode._138;

//138. Copy List with Random Pointer
//https://leetcode.com/problems/copy-list-with-random-pointer/description/
public class Solution
{
    private Dictionary<Node, Node> _hash = new Dictionary<Node, Node>();

    public Node CopyRandomList(Node head)
    {
        if (head == null) return null;

        var current = head;
        while (current != null)
        {
            _hash[current] = new Node(current.val);
            current = current.next;
        }

        current = head;
        while (current != null)
        {
            var hashed = _hash[current];
            hashed.next = current.next != null ? _hash[current.next] : null;
            hashed.random = current.random != null ? _hash[current.random] : null;
            current = current.next;
        }

        return _hash[head];
    }
}

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}