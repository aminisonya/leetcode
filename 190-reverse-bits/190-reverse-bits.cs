public class Solution {
    public uint reverseBits(uint n) {
        uint res = 0;

        // Loop enough times to reverse a 32 bit
        for (var i = 0; i < 32; i++)
        {
          // Left shift result bits by 1
          res = res << 1;
          
          // Check if bit is a 1 or 0
          uint bit = n % 2;
          res = res + bit;

          // Right shift original bits by 1
          n = n >> 1;
        }

        return res;
    }
}