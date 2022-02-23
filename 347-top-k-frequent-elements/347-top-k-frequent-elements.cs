public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Using heap approach, there are 3 main steps
		if (nums.Length == k)
		{
			return nums;
		}
		
		// 1. Build dictionary with int + int's frequency
		var dict = new Dictionary<int, int>();
		for (var i = 0; i < nums.Length; i++)
		{
			if (dict.ContainsKey(nums[i]))
			{
				dict[nums[i]] = dict[nums[i]] + 1;
			}
			else
			{
				dict.Add(nums[i], 1);
			}
		}
		
		// 2. Create a priority queue, based on highest frequency to lowest
		var pQueue = new PriorityQueue<int, int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
		foreach (var key in dict.Keys)
		{
			pQueue.Enqueue(key, dict[key]);
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