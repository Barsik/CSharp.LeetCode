namespace CSharp.LeetCode._203;

//203. Remove Linked List Elements
//https://leetcode.com/problems/remove-linked-list-elements/description/
public class Solution
{
    public ListNode RemoveElements1(ListNode head, int val)
    {
        if (head == null) return null;
        head.next = RemoveElements1(head.next, val);
        return head.val == val ? head.next : head;
    }

    public ListNode RemoveElements2(ListNode head, int val)
    {
        var fakeNode = new ListNode(0, head);

        var current = fakeNode.next;
        var prev = fakeNode;
        while (current != null)
        {
            if (current.val == val)
            {
                prev.next = current.next;
            }
            else
            {
                prev = current;
            }

            current = current.next;
        }

        return fakeNode.next;
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