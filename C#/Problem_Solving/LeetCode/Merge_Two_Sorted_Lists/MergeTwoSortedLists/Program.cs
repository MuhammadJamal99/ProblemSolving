public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
}
public class MergeTwoSortedListsClass
{
    static void Main(string [] args)
    {
        ListNode List1 = new ListNode(1);
        ListNode List2 = new ListNode(1);
        List1.next = new ListNode(2);
        List1.next.next = new ListNode(4);
        List2.next = new ListNode(3);
        List2.next.next = new ListNode(4);
        Console.WriteLine(MergeTwoLists(List1, List2));
    }
    static ListNode MergeTwoLists(ListNode List1, ListNode List2)
    {
        if (List1 == null)
            return List2;
        if (List2 == null)
            return List1;
        if (List1.val <= List2.val)
        {
            List1.next = MergeTwoLists(List1.next, List2);
            return List1;
        }
        else
        {
            List2.next = MergeTwoLists(List1, List2.next);
            return List2;
        }
    }
}
