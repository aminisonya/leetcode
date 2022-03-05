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
        return Swap(head);
    }
    
    public ListNode Swap(ListNode curr)
    {
        if (curr == null || curr.next == null)
        {
            return curr;
        }
        
        var first = curr;
        var second = curr.next;
        
        first.next = Swap(second.next);
        second.next = first;
        
        return second;
    }
}