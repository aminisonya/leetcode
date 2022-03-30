/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // keep track of two heads
        // iterate thru both lists
        // as you iterate, update next pointer for each of the nodes, while being careful not to lose track of the node that was originally next
        // use a dummy head node
        
        var dummy = new ListNode(0);
        var curr = dummy;
        
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                curr.next = list1;
                list1 = list1.next;
            }
            else if (list1.val > list2.val)
            {
                curr.next = list2;
                list2 = list2.next;
            }
            
            curr = curr.next;
        }
        
        if (list1 != null) curr.next = list1;
        if (list2 != null) curr.next = list2;
        
        return dummy.next;
    }
}