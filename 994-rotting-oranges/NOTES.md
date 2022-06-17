// Traverse the whole grid, add rotten oranges to queue and keep count of fresh oranges
// Go thru queue of rotten oranges, for each rotten orange traverse in all 4 directions
// If see fresh orange, change to rotten orange, and add to queue, and decrement count of fresh oranges
// Return number of times queue was traversed until empty (number of mins for all oranges to go rotten)
​
// Queue of Tuples with row and col indexes for each rotten orange
​
// Traverse grid, enqueue all rotten oranges and keep count of fresh oranges
​
// If there were no fresh oranges, simply return 0
​
// Keep track of "minutes"/each traversal to new row/col
// For every item currently in queue... (For every item in this level of BFS)
// Get next row/col vals
// Make sure we're not out of bounds
// Also, continue if not a fresh orange (do nothing if empty or rotten orange)
// Change to rotten orange value, add new rotten orange to queue
// Decrement count of fresh oranges
​
// Subtract from mins, as last loop will add 1 unnecessarily