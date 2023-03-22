public class Solution {
    public int RemoveElement(int[] nums, int val) {
         var lst = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    lst.Add(nums[i]);

                }
            }


            for (int i = 0; i < lst.Count; i++)
            {
                nums[i] = lst[i];
            }
            return lst.Count;
    }
}
