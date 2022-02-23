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
    public ListNode MergeKLists(ListNode[] lists) {
        // Using a Priority Queue, add all head nodes from all lists
		// Create a new LinkedList from values in Priority Queue, as they are already sorted
		if (lists.Length <= 0 || lists == null)
		{
			return null;
		}
		
		var pQueue = new PriorityQueue<ListNode, int>();
		
		foreach (var list in lists)
		{
			if (list != null)
			{
				pQueue.Enqueue(list, list.val);
			}
		}
		
		var dummyHead = new ListNode();
		var curr = dummyHead;
		
		while (pQueue.Count > 0)
		{
			var topOfQueue = pQueue.Dequeue();
			curr.next = new ListNode(topOfQueue.val);
			curr = curr.next;
			
			// Make sure to add all nodes in LinkedList to priority queue
			if (topOfQueue.next != null)
			{
				pQueue.Enqueue(topOfQueue.next, topOfQueue.next.val);
			}
		}
		
		return dummyHead.next;
    }
}