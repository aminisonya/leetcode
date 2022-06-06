public class Solution {
    public int HammingWeight(uint n) {
        // Count the number on '1' bits in n
        // Take (n & 1) which will compare current last bit and 1 to see if it's a 1 or not. If BOTH are 1s, then last bit is a 1, and can increase count of 1's
        // Then bit shift n to the right to cut off that last bit
        
        var count = 0;
        
        while (n != 0)
        {
            if ((n & 1) == 1)
            {
                count++;
            }
            
            n = n >> 1;
        }
        
        return count;
    }
}