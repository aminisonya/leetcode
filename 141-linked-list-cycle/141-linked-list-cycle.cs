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
        // tortoise and hare : slow and fast pointer to detect cycle in linked list
        
        if (head == null)
        {
            return false;
        }
        
        var slow = head;
        var fast = head.next;
        
        while (slow != null && fast != null)
        {
            if (fast.next == null)
            {
                return false;
            }
            
            if (slow == fast)
            {
                return true;
            }
            
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return false;
    }
}