public class SparseVector {
    public List<int[]> Values;
    
    public SparseVector(int[] nums) {
        this.Values = new List<int[]>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                this.Values.Add(new int[] { i, nums[i] });
            }
        }
    }
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec) {
        var dotProduct = 0;
        var i = 0;
        var j = 0;
        
        while (i < this.Values.Count && j < vec.Values.Count)
        {
            if (this.Values[i][0] == vec.Values[j][0])
            {
                dotProduct += (this.Values[i][1] * vec.Values[j][1]);
                i++;
                j++;
            }
            else if (this.Values[i][0] < vec.Values[j][0])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        
        return dotProduct;
    }
}

// Your SparseVector object will be instantiated and called as such:
// SparseVector v1 = new SparseVector(nums1);
// SparseVector v2 = new SparseVector(nums2);
// int ans = v1.DotProduct(v2);