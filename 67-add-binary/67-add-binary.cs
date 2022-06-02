public class Solution {
    public string AddBinary(string a, string b) 
    {
        BigInteger x = StringToBinaryBigInteger(a);
        BigInteger y = StringToBinaryBigInteger(b);
        BigInteger carry, answer;
        
        while (y != 0)
        {
            answer = x ^ y;
            carry = (x & y) << 1;
            
            x = answer;
            y = carry;
        }
        
        return ToBinaryString(x);
    }
    
    private BigInteger StringToBinaryBigInteger(string binary)
    {
        BigInteger result = 0;
        
        foreach (char c in binary)
        {
            result <<= 1;
            result += c == '1' ? 1 : 0;
        }
        
        return result;
    }
    
    private string ToBinaryString(BigInteger bigint)
    {
        var bytes = bigint.ToByteArray();
        var idx = bytes.Length - 1;

        var base2 = new StringBuilder();

        var binary = Convert.ToString(bytes[idx], 2);

        if (binary != "0" || bytes[0] == 0)
            base2.Append(binary);

        for (idx--; idx >= 0; idx--)
          base2.Append(Convert.ToString(bytes[idx], 2).PadLeft(8, '0'));

        return base2.ToString();
    }
}