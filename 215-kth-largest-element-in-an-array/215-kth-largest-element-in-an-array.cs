public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // Use priority queue - min heap
        // Only want largest values, dequeue all smaller values until count is k
        
        var pQueue = new PriorityQueue<int, int>();
        
        foreach (var num in nums)
        {
            pQueue.Enqueue(num, num);
            
            while (pQueue.Count > k)
            {
                pQueue.Dequeue();
            }
        }
        
        return pQueue.Peek();
    }
}