public class Solution {
    public  IList<int> FindDisappearedNumbers(int[] nums)
        {
            int n = nums.Length;
            List<int> lst = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int index = Math.Abs(nums[i])-1;
                int temp = nums[index];
                nums[index] = temp > 0 ? -temp : temp; 
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] >0 )
                    lst.Add(i+1);
            }

            return lst;
        }
}
