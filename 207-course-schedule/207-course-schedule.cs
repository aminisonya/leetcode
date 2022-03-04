public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adjList = new Dictionary<int, List<int>>();
		var inDegree = new Dictionary<int, int>();
		var visited = 0;
		var queue = new Queue<int>();
		
		// Set up default adjList and inDegree
		for (var i = 0; i < numCourses; i++)
		{
			adjList.Add(i, new List<int>());
			inDegree.Add(i, 0);
		}
		
		// Build graph and inDegree
		foreach (var course in prerequisites)
		{
			var u = course[0];
			var v = course[1];
			// Add prereq to list of prereqs for that course
			adjList[u].Add(v);
			// Increment inDegree value for that node (the prereq)
			inDegree[v]++;
		}
		
		// Add all sources (nodes with 0 inDegree/prereq to queue)
		foreach (var entry in inDegree)
		{
			if (entry.Value == 0)
			{
				queue.Enqueue(entry.Key);
			}
		}
		
		// BFS
		while (queue.Count > 0)
		{
			// Starter node (no nodes pointing to it, we've already "crossed out" those nodes if any)
			var parent = queue.Dequeue();
			visited++;
			
			// Loop thru list of prereqs
			foreach (var child in adjList[parent])
			{
				// Decrement inDegree for each child
				inDegree[child]--;
				
				// If inDegree becomes zero add it to queue (it's now a "starter" node)
				if (inDegree[child] == 0)
				{
					queue.Enqueue(child);
				}
			}
		}
		
		// Did we visit every node? Then return true
		return visited == numCourses;
    }
}