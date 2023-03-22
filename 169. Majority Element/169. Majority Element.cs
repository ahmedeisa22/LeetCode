public class Solution {
    public int MajorityElement(int[] nums) {
          int majority = nums.Length / 2;

            var dict = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]]++;
                else
                    dict[nums[i]] = 1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict[nums[i]] > majority)
                    return nums[i];
            }

            return -1; // this is not exists
    }
}
