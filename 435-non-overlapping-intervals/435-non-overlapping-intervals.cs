public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        // Sort
		// Iterate and keep count of how many merges would be needed
		// Return count of merges
		
		if (intervals.Length < 2)
		{
			return 0;
		}
		
		Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));
		var merges = 0;
		var prevEnd = intervals[0][1];
		
		for (var i = 1; i < intervals.Length; i++)
		{
			if (intervals[i][0] >= prevEnd)
			{
				// If there's no overlap, simply update the prevEnd value, no merge was necessary
				prevEnd = intervals[i][1];
			}
			else
			{
				// If there is overlap, decide which interval should be kept based on second/greater values
				// Want to keep the interval with the smaller end value to reduce chance of further merges being needed
				prevEnd = Math.Min(prevEnd, intervals[i][1]);
				merges++;
			}
		}
		
		
		return merges;
    }
}