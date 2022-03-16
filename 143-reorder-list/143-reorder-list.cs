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
    public void ReorderList(ListNode head) {
        // Reverse second half of list
        // This creates a "second" list thats in descending order
        // Merge two sorted lists together
        
        // Set up fast and slow pointers to find middle of list
        var fast = head;
        var slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        
        // Now that you've found the middle of the list, reverse the second half
        ListNode prev = null;
        var curr = slow;
        while (curr != null)
        {
            var tempNext = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tempNext;
        }
        
        // Merge the two halves together
        var first = head;
        var second = prev;
        while (second.next != null)
        {
            var firstNext = first.next;
            var secNext = second.next;
            first.next = second;
            second.next = firstNext;
            first = firstNext;
            second = secNext;
        }
    }
}