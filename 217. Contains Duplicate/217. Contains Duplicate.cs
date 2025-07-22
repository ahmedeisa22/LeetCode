public class Solution {
    public bool ContainsDuplicate(int[] nums) {
          int n = nums.Length;
   HashSet<int> result = new HashSet<int>();
   for (int i = 0; i < n; i++)
   {
       result.Add(nums[i]);

   }


   return (result.Count != n);
    }
}
