public class Solution {
    public int HammingWeight(uint n) {
        // Want to return the number of '1' bits
        var count = 0;

        // Iterate through bits in n while n is not 0
        while (n != 0)
        {
          // Check if last bit is a 1
          // If both bits are 1 (n & 1), result bit is 1
          if ((n & 1) == 1)
          {
            count++;
          }

          // Right shift n by one space
          n = n >> 1;
        }

        return count;
    }
}