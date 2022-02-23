public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if (k == nums.Length)
		{
			return nums;
		}
		
		var count = new Dictionary<int, int>();
		for (var i = 0; i < nums.Length; i++)
		{
			if (count.ContainsKey(nums[i]))
			{
				count[nums[i]] = count[nums[i]] + 1;
			}
			else
			{
				count.Add(nums[i], 1);
			}
		}
		
		var heap = new PriorityQueue<int, int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
		foreach (var key in count.Keys)
		{
			heap.Enqueue(key, count[key]);
		}
		
		var result = new int[k];
		for (var i = 0; i < result.Length; i++)
		{
			result[i] = heap.Dequeue();
		}
		
		return result;
    }
}