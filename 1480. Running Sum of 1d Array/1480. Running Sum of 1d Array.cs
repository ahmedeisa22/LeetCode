public class Solution {
    public int[] RunningSum(int[] nums) {
         int[] sum = new int[nums.Length];
 sum[0] = nums[0];
 for (int i = 0; i < nums.Length -1 ; i++)
 {
     sum[i+1] = nums[i+1] + sum[i];
 }
 return sum;
    }
}
