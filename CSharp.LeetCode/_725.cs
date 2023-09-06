namespace CSharp.LeetCode._725;

//725. Split Linked List in Parts
//https://leetcode.com/problems/split-linked-list-in-parts/description/
public class Solution
{
    public ListNode[] SplitListToParts(ListNode head, int k)
    {
        var result = new ListNode[k];
        var count = 0;
        var index = 0;
        if (head == null) return result;

        var current = head;

        while (current != null)
        {
            count++;
            current = current.next;
        }

        var remainder = count % k;
        var blockSize = count / k;

        current = head;
        for (var i = 0; i < k; i++)
        {
            var block = new ListNode(0);
            var blockCurrent = block;

            for (var j = 0; j < blockSize + (i < remainder ? 1 : 0); j++)
            {
                blockCurrent.next = new ListNode(current.val);
                blockCurrent = blockCurrent.next;
                current = current.next;
            }

            result[i] = block.next;
        }

        return result;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}