public class Solution {
    public int[][] Merge(int[][] intervals) {
        // sort intervals
        // merge overlaps when iterating
        
        Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));
        var result = new List<int[]>();
        
        for (var i = 0; i < intervals.Length; i++)
        {
            var currStart = intervals[i][0];
            
            if (result.Count <= 0 || result[result.Count - 1][1] < currStart)
            {
                result.Add(intervals[i]);
            }
            else if (result[result.Count - 1][1] >= currStart)
            {
                // merge these two intervals
                result[result.Count - 1][1] = Math.Max(result[result.Count - 1][1], intervals[i][1]);
            }
        }
        
        return result.ToArray();
    }
}