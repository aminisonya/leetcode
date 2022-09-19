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
        // use a dummy node for temp head of final list
        // while loop thru both lists, comparing values and adjusting pointers to point to smallest value next
        // update lists and all pointers
        
        if (list1 == null && list2 == null)
        {
            return list1;
        }
        
        var dummy = new ListNode();
        var curr = dummy;
        
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                curr.next = list1;
                list1 = list1.next;
            }
            else
            {
                curr.next = list2;
                list2 = list2.next;
            }
            
            curr = curr.next;
        }
        
        curr.next = (list1 == null) ? list2 : list1; 
        
        return dummy.next;
    }
}