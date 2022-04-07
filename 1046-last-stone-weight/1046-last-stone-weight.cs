public class Solution {
    public int LastStoneWeight(int[] stones) {
        // Use Priority Queue - max heap
        // Enqueue all items from array
        // Dequeue, take max item and subtract next dequeue'd item
        // Enqueue that difference, and repeat
        // Return last stone, if no stone left return 0
        
        var pQueue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        
        for (var i = 0; i < stones.Length; i++)
        {
            pQueue.Enqueue(stones[i], stones[i]);
        }
        
        while (pQueue.Count > 1)
        {
            var max = pQueue.Dequeue();
            var second = pQueue.Dequeue();
            
            if (max != second)
            {
                max = max - second;
                pQueue.Enqueue(max, max);
            }
        }
        
        return pQueue.Count > 0 ? pQueue.Dequeue() : 0;
    }
}