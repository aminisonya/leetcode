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
    public ListNode ReverseList(ListNode head) {
        //base case: we've reached last node, so head.next = null
        if (head == null || head.next == null)
        {
            return head;
        }
        
        var node = ReverseList(head.next);
        
        var p = head.next;
        p.next = head;
        head.next = null;
        
        return node;
    }
}