public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        if (intervals.Length < 2)
		{
			return 1;
		}
		
        // Sort by meeting start times
		Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));
		
		// Iterate thru meeting time intervals
		// Keep track of all current meeting end times that aren't finished yet, occupying a meeting room
		// If next meeting start time is BEFORE the meeting with the earliest end time, will need to add another room
		// If not, that means a meeting room opened up and do NOT need to add new room (Update with new meetings end time)
		
		var i = 0;
		var j = i + 1;
		var rooms = 1;
		var pQueue = new PriorityQueue<int, int>();
		pQueue.Enqueue(intervals[0][1], intervals[0][1]);
		
		while (i < intervals.Length)
		{
			var prevEnd = pQueue.Peek();
			
			while (j < intervals.Length && prevEnd > intervals[j][0])
			{
				rooms++;
				pQueue.Enqueue(intervals[j][1], intervals[j][1]);
				prevEnd = pQueue.Peek();
				j++;
			}
			
			pQueue.Dequeue();
			if (j < intervals.Length) pQueue.Enqueue(intervals[j][1], intervals[j][1]);
			i = j;
			j = i + 1;
		}
		
		return rooms;
    }
}