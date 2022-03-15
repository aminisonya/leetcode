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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // two pointers
        // update one with delay of n steps
        
        var dummy = new ListNode(0);
        dummy.next = head;
        var firstP = dummy;
        var secondP = dummy;
        
        // Iterate to get our first pointer ahead in the list by n nodes
        for (var i = 0; i <= n; i++)
        {
            firstP = firstP.next;
        }
        
        // Iterate until first pointer is at end of list
        // Meaning our second pointer is at node before node that needs to be removed
        while (firstP != null)
        {
            firstP = firstP.next;
            secondP = secondP.next;
        }
        
        // Once our first and second pointers have been updated, update next pointer to skip over node that is to be removed
        secondP.next = secondP.next.next;
        
        // Return sentinel nodes next pointer, which is pointing at head of list
        return dummy.next;
    }
}