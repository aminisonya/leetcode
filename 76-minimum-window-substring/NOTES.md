// Sliding window
// Create dictionary to keep track of unique characters in t, and count of each character
// Initialize sliding window var
// Counter for t.Length, can decrement this anytime we find a match, when counter is 0 we know we've found a valid window
// left and right pointers for non-fixed size window
// min length var to keep track of min length overall of smallest window found
// while loop for this sliding window
// // If current char is found in t dict, decrement count
// Once we've found a window with all characters from our substring, can update min length, and store left and right pointers somewhere (int[2] array for example) to use later to build result string
// After we've found a minimum substring
// We adjust our left pointer to move on to find new possible min windows