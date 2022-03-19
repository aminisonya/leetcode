/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        // Binary search
        // Looking for first bad version, and last good version (to verify)
        var lastGood = 1;
        var firstBad = n;
        
        while (lastGood < firstBad)
        {
            var midpoint = lastGood + (firstBad - lastGood) / 2;
            var isBad = IsBadVersion(midpoint);
            
            if (isBad)
            {
                // If midpoint is bad version, want to keep searching the left half
                firstBad = midpoint;
            }
            else if (!isBad)
            {
                // If midpoint is NOT bad version, want to search the right half
                lastGood = midpoint + 1;
            }
        }
        
        return firstBad;
    }
}