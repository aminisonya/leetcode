public class KthLargest {

    // Use a priority queue - min heap, dequeue until count equal to k
    // the first value returned from the min heap will now be the kth largest value
    
    public PriorityQueue<int, int> PQueue;
    public int K;
    
    public KthLargest(int k, int[] nums) {
        this.PQueue = new PriorityQueue<int, int>();
        this.K = k;
        
        foreach (var num in nums)
        {
            PQueue.Enqueue(num, num);
        }
        
        DequeueUntilK();
    }
    
    public int Add(int val) {
        PQueue.Enqueue(val, val);
        
        DequeueUntilK();
        
        return PQueue.Peek();
    }
    
    public void DequeueUntilK()
    {
        while (PQueue.Count > K)
        {
            PQueue.Dequeue();
        }
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */