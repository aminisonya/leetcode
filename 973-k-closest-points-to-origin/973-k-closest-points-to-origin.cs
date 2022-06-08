public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        // O(n) where we want to iterate thru all of the points and calculate their distances from origin (0,0)
        // Min Heap (priority queue in c#) to store the distances. Can build the result from the Heap until k points.
        
        var pQueue = new PriorityQueue<int[], int>(); // current point : distance
        var result = new List<int[]>();
        
        for (var i = 0; i < points.Length; i++)
        {
            var curr = points[i];
            var distance = (curr[0] * curr[0]) + (curr[1] * curr[1]);
            
            pQueue.Enqueue(curr, distance);
        }
        
        var j = 0;
        while (j < points.Length && j < k)
        {
            var curr = pQueue.Dequeue();
            result.Add(curr);
            j++;
        }
        
        return result.ToArray();
    }
}