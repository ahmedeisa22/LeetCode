public class Solution {
   public int RemoveDuplicates(int[] nums)
        {
            int Size = nums.Length;
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < Size; i++)
                hash.Add(nums[i]);
            

            int counter = 0;
            foreach (int item in hash)
                nums[counter++] = item;
            

            return counter;
        }
}
