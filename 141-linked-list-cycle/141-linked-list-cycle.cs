/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        // Tortoise and Hare approach
        // two pointers, one going twice as fast
        // if they meet, there's a cycle
        
        if (head == null)
        {
            return false;
        }
        
        var slow = head;
        var fast = head.next;
        
        while (slow != fast)
        {
            if (fast == null || fast.next == null)
            {
                return false;
            }
            
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return true;
    }
}