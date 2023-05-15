namespace CSharp.LeetCode._1721;

//1721. Swapping Nodes in a Linked List
//https://leetcode.com/problems/swapping-nodes-in-a-linked-list/description/
public class Solution
{
    public ListNode SwapNodes(ListNode head, int k)
    {
        var start = head;
        var end = head;

        for (var i = 0; i < k - 1; i++)
        {
            start = start.next;
        }

        var startFixed = start;

        while (start.next != null)
        {
            end = end.next;
            start = start.next;
        }

        (startFixed.val, end.val) = (end.val, startFixed.val);
        return head;
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
}