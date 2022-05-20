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
        // dummy head node
        // compare heads of each list, smaller one gets pointed to for next
        // while loop while either head isn't null
        // if one list has already been merged (one head is null), merge rest of remaining list to end
        
        var dummy = new ListNode(0);
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
        
        curr.next = list1 == null ? list2 : list1;
        
        return dummy.next;
    }
}