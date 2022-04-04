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
    public ListNode SwapNodes(ListNode head, int k) {
        // Two pointer approach, two passes
        // First pass: find kth node from the end
        // Second pass: find kth node from start, swap these two nodes VALUES (not actual nodes)
        
        if (head == null || head.next == null)
        {
            return head;
        }
        
        var slow = head;
        var fast = head;
        var count = 1;        
        while (count < k)
        {
            fast = fast.next;
            count++;
        }
        
        while (fast != null && fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }
        
        // Slow pointer is now at kth node from the end
        // Do a second pass to get kth node from start
        var first = head;
        count = 1;
        while (count < k)
        {
            first = first.next;
            count++;
        }
        
        // Want to "swap" first and slow nodes VALUES
        var temp = first.val;
        first.val = slow.val;
        slow.val = temp;
        
        return head;
    }
}