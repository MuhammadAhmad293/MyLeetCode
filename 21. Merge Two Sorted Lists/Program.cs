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

public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }

        // If one of the lists is not empty, append the remaining nodes.
        if (l1 != null)
            current.next = l1;
        else
            current.next = l2;

        return dummy.next;
    }
}

class Program
{
    static void Main()
    {
        // Example 1
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        Solution solution = new Solution();
        ListNode mergedList = solution.MergeTwoLists(list1, list2);
        PrintList(mergedList);

        // Example 2
        ListNode list3 = null;
        ListNode list4 = null;
        ListNode mergedList2 = solution.MergeTwoLists(list3, list4);
        PrintList(mergedList2);

        // Example 3
        ListNode list5 = null;
        ListNode list6 = new ListNode(0);
        ListNode mergedList3 = solution.MergeTwoLists(list5, list6);
        PrintList(mergedList3);
    }

    static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();
    }
}
