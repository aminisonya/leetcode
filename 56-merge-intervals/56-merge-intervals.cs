public class Solution {
    public int[][] Merge(int[][] intervals) {
        // Start by sorting all of the intervals based on the first value
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
		
		var result = new List<int[]>();
		
		// Iterate through subsequent intervals, starting at beginning with first two intervals
		var i = 0;
		var j = 1;
		
		// Remember to make sure we don't go out of bounds
		while (i < intervals.Length)
		{
			// Grab the first and second values in the FIRST interval
			var firstVal = intervals[i][0];
			var secVal = intervals[i][1];
			
			// Compare first interval's second value to second interval's first value
			while (j  < intervals.Length && intervals[j][0] <= secVal)
			{
				// Is there overlap? Then replace the first interval's second value
				secVal = Math.Max(secVal, intervals[j][1]);
				j++;
			}
			
			// Add the newly adjusted-for-overlap interval to the result list
			result.Add(new [] { firstVal, secVal });
			
			i = j;
			j = i + 1;
		}
		
		return result.ToArray();
    }
}