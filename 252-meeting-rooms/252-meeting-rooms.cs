public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        // Looking for any overlap in any of the meetings
        // Keep track of start and end times as loop thru intervals
        // Sort intervals so only have to iterate thru once
        
        if (intervals.Length < 2)
        {
            return true;
        }
        
        // Will need to memorize how to sort 2d array
        Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));
        
        for (var i = 0; i < intervals.Length - 1; i++)
        {
            // Compare ending time of first meeting to starting time of next meeting
            if (intervals[i][1] > intervals[i + 1][0])
            {
                return false;
            }
        }
        
        return true;
    }
}