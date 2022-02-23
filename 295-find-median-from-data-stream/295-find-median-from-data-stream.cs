public class MedianFinder {

	public PriorityQueue<int, int> _maxHeap; // will store the LOWER half
	public PriorityQueue<int, int> _minHeap; // will store the HIGHER half
	
    public MedianFinder() {
        _maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
		_minHeap = new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num) {
		// as we add to our two priority queues, want to keep them balanced
		// allow minHeap to hold + 1 over maxHeap
        _minHeap.Enqueue(num, num);
		var topOfMinHeap = _minHeap.Dequeue();
		_maxHeap.Enqueue(topOfMinHeap, topOfMinHeap);
		
		// if out of balance, restore balance
		if (_minHeap.Count < _maxHeap.Count)
		{
			var topOfMaxHeap = _maxHeap.Dequeue();
			_minHeap.Enqueue(topOfMaxHeap, topOfMaxHeap);
		}
    }
    
    public double FindMedian() {
		// if minHeap holds an additional value, that value is the median
		// else calculate median using both heaps
		// note: make sure to use Peek() and NOT Dequeue()
        if (_minHeap.Count > _maxHeap.Count)
		{
			return _minHeap.Peek();
		}
		else
		{
			return ((double) _maxHeap.Peek() + _minHeap.Peek()) / 2.0;
		}
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */