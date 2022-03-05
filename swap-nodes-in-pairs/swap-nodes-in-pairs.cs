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
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null)
        {
            return head;
        }
        
        var first = head;
        var second = head.next;
        
        first.next = SwapPairs(second.next);
        second.next = first;
        
        return second;
    }
}