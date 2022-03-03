public class Solution {
    public int GetSum(int a, int b) {
        // Get sum using bitwise operations
        // Initialize variable to handle any carry value there might be
        int carry;
		
        // Keep looping until there is no carry value left to add
        while (b != 0)
        {
            // Can find carry value with bitwise AND
            carry = (a & b);
            // Can find sum using bitwise XOR (but will not include any carry)
            a = a ^ b;
            // Carry value needs to be left shifted by one spot
            b = carry << 1;
        }
		
		return a;
    }
}