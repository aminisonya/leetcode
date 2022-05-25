/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        // binary search
        // if false, search to the right. if true, search to the left.
        
        var left = 1;
        var right = n;
        var firstBadVersion = 0;
        
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            
            if (IsBadVersion(mid) == true)
            {
                firstBadVersion = mid + 1;
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        
        return left;
    }
}