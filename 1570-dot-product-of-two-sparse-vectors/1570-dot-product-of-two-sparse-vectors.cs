public class SparseVector {
    public int[] Vector;
    public Dictionary<int, int> NonZeroes;
    
    public SparseVector(int[] nums) {
        this.Vector = nums;
        this.NonZeroes = new Dictionary<int, int>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                NonZeroes.Add(i, nums[i]);
            }
        }
    }
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec) {
        var dotProduct = 0;
        
        for (var i = 0; i < vec.Vector.Length; i++)
        {
            if (NonZeroes.ContainsKey(i))
            {
                dotProduct = dotProduct + (vec.Vector[i] * NonZeroes[i]);
            }
        }
        
        return dotProduct;
    }
}

// Your SparseVector object will be instantiated and called as such:
// SparseVector v1 = new SparseVector(nums1);
// SparseVector v2 = new SparseVector(nums2);
// int ans = v1.DotProduct(v2);