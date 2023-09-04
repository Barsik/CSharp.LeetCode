namespace CSharp.LeetCode._141;

//141. Linked List Cycle
//https://leetcode.com/problems/linked-list-cycle/description/
public class Solution
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return false;
        }

        var slow = head;
        var fast = head.next.next;

        while (slow != null && fast is { next: not null })
        {
            if (slow == fast)
            {
                return true;
            }

            slow = slow.next;
            fast = fast.next.next;
        }

        return false;
    }
}