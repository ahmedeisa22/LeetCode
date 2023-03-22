public class Solution {
  public  int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums?.Length; i++)
                    dict[nums[i]] = i;
            
            for (int i = 0; i < nums?.Length; i++)
            {
                int complement = target - nums[i];

                if (dict.ContainsKey(complement) && dict[complement] != i)
                {
                   return new int[] { i, dict[complement] };
                }
            }
            return null;
        } 
}
