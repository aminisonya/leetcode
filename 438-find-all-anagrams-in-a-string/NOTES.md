Sliding Window
* Very similar to Permutation in String problem
* Two arrays of int[26] for each letter of alphabet (assuming all are lowercase or uppercase)
* Fill out array for smaller string first
* Start sliding window, for loop, only need pointer for right side of window, not left.
* Left will always be right - p.Length (smaller strings length)
* Add each char value to array of larger string values one at a time
* When we've reached out window length, start updating left side of window, remove left char from array
* At each iteration we check if two arrays are equal (contain same values, can use separate function for this). If equal, add starting point (left side) to result array.
* Return result