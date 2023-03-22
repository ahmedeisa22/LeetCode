public class Solution {
  public  int PivotIndex(int[] nums)
        {
            int total = nums.Sum();
            int left = 0;
            int right = 0;
            int index = -1;
         

            for ( int i = 0; i < nums.Length; i++)
            {
                right = total - nums[i] - left;
                if (left == right || ( i == 0 && right == 0))
                {
                    index = i;
                    break;
                }
                left += nums[i];
            }

            return index;
        }
}
