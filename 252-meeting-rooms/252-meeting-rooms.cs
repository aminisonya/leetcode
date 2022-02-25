public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        // Sort
		// Iterate and check for any overlaps
		if (intervals.Length < 2)
		{
			return true;
		}
		
		Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));
		var i = 0;
		var j = i + 1;
		
		while (i < intervals.Length)
		{
			while (j < intervals.Length && intervals[i][1] > intervals[j][0])
			{
				return false;
			}
			
			i = j;
			j = i + 1;
		}
		
		return true;
    }
}