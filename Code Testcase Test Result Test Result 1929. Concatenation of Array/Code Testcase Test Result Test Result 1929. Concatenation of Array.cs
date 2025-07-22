public class Solution {
    public int[] GetConcatenation(int[] nums) {
         int[] result = new int[nums.Length*2];
 int counter = 0;
 for (int i = 0; i < nums.Length*2; i++)
 {
     if(counter == nums.Length) counter = 0;
     result[i] = nums[counter++];
 }

 return result;
    }
}
