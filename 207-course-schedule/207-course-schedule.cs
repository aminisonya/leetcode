public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        // Graph. Topological sort algo
        var prereqMap = new Dictionary<int, List<int>>(); // course : prereqs
        var inDegree = new Dictionary<int, int>(); // course : number of courses pointing to it
        var visited = 0; // keep track of how many courses we've visited
        var queue = new Queue<int>();
        
        // Build prereq map, add all courses first
        for (var i = 0; i < numCourses; i++)
        {
            prereqMap.Add(i, new List<int>());
            inDegree.Add(i, 0);
        }
        
        // Fill out prereq map by going thru prereqs array
        for (var j = 0; j < prerequisites.Length; j++)
        {
            var course = prerequisites[j][0];
            var prereq = prerequisites[j][1];
            prereqMap[course].Add(prereq);
            inDegree[prereq]++; // Add prereq bc it's pointing to a course
        }
        
        // Add all courses with 0 inDegree / no prereqs to the queue
        foreach (var course in inDegree)
        {
            // If that course has NO prereqs / courses pointing to it, add to queue
            if (course.Value == 0)
            {
                queue.Enqueue(course.Key);
            }
        }
        
        // While loop to go level by level in the queue, adding to it as we go
        while (queue.Count > 0)
        {
            var curr = queue.Dequeue(); // current course with no courses pointing to it. Not a prereq to another course.
            visited++;
            
            // Go thru list of prereqs for that course
            for (var i = 0; i < prereqMap[curr].Count; i++)
            {
                // decrement current prereq's indegree
                inDegree[prereqMap[curr][i]]--;
                
                // If indegree reached 0, add to queue
                // That means no courses are pointing to it anymore
                if (inDegree[prereqMap[curr][i]] == 0)
                {
                    queue.Enqueue(prereqMap[curr][i]);
                }
            }
        }
        
        // did we visit all the courses exactly once??
        return visited == numCourses;
    }
}