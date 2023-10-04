namespace CSharp.LeetCode._1_100._21;

//21. Merge Two Sorted Lists
//https://leetcode.com/problems/merge-two-sorted-lists/
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var cur1 = list1;
        var cur2 = list2;

        var fake = new ListNode();
        var cur = fake;

        while (cur1 != null && cur2 != null)
        {
            if (cur1.val < cur2.val)
            {
                cur.next = cur1;
                cur1 = cur1.next;
            }
            else
            {
                cur.next = cur2;
                cur2 = cur2.next;
            }

            cur = cur.next;
        }

        if (cur1 != null) cur.next = cur1;
        if (cur2 != null) cur.next = cur2;
        return fake.next;
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