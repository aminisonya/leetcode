public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        // Broken into 3 steps
		// 1. Add all intervals before the new interval starts
		var result = new List<int[]>();
		var i = 0;
		
		while (i < intervals.Length && intervals[i][1] < newInterval[0])
		{
			result.Add(intervals[i]);
			i++;
		}
		
		// 2. Add new interval, after merging any overlaps
		while (i < intervals.Length && intervals[i][0] <= newInterval[1])
		{
			// Update values of interval to be added, that merges all potential overlaps
			newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
			newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
			i++;
		}
		// Add new interval outside of while loop, so it's only added once
		result.Add(newInterval);
		
		// 3. Add any remaining intervals
		while (i < intervals.Length)
		{
			result.Add(intervals[i]);
			i++;
		}
		
		return result.ToArray();
    }
}