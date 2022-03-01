public class Solution {
    public int[] CountBits(int n) {
        var result = new int[n + 1];

        // For each integer i, how many 1's are in the binary representation of i?
        for (var i = 0; i < n + 1; i++)
        {
          // If i is an even number, the number of 1's is equal to i / 2
          // If i is odd, the number of '1's is i / 2 + 1
          if (i % 2 == 0)
          {
            result[i] = result[i/2];
          }
          else
          {
            result[i] = result[i/2] + 1;
          }
        }

        return result;
    }
}