public class Solution {
 public int LongestConsecutive(int[] nums)
        {
            int counter = 0;
            int maxCounter = int.MinValue;
            Array.Sort(nums);

            if (nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return 1;
          else if(nums.Length == 2&& nums[0] == nums[1])
                return 1;

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i + 1] == nums[i])
                    continue;
                if (Math.Abs(nums[i + 1] - nums[i]) == 1)
                    counter++;
                else
                    counter = 0;

                if (counter > maxCounter)
                    maxCounter = counter;

            }

           
                return ++maxCounter;
        }
}
