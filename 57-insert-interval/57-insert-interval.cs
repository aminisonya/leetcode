public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        // Solution in 3 steps
        // Add all intervals ending before newinterval first
        // Add all intervals starting after newinterval last
        // Middle step is to merge any potential overlapping intervals, then add newinterval
        
        var result = new List<int[]>();
        var i = 0;
        
        // Add all intervals that END BEFORE the new interval starts
        while (i < intervals.Length && intervals[i][1] < newInterval[0])
        {
            result.Add(intervals[i]);
            i++;
        }
        
        // Merge new interval in, merging all overlaps
        while (i < intervals.Length && intervals[i][0] <= newInterval[1])
        {
            // Want the earliest (smallest) start time
            // And the largest (max) end time
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        result.Add(newInterval);
        
        // Add all intervals that START AFTER the new interval ends
        while (i < intervals.Length && intervals[i][0] > newInterval[1])
        {
            result.Add(intervals[i]);
            i++;
        }
        
        return result.ToArray();
    }
}