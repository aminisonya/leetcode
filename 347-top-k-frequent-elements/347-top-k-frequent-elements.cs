public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Using heap approach, there are 3 main steps
		if (nums.Length == k)
        {
            return nums;
        }
		
		// 1. Build dictionary with int + int's frequency
		var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict.Add(num, 1);
            }
            else
            {
                dict[num]++;
            }
        }
		
		// 2. Create a priority queue, based on highest frequency to lowest
        var pQueue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach (var item in dict)
        {
            pQueue.Enqueue(item.Key, item.Value);
        }
		
		
		// 3. Return an array with top k elements from priority queue
        var result = new int[k];
		for (var i = 0; i < k; i++)
        {
            result[i] = pQueue.Dequeue();
        }
        
        return result;
    }
}