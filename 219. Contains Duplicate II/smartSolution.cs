 static bool ContainsNearbyDuplicate(List<int> nums, int k)
 {
     Dictionary<int, int> mp = new Dictionary<int, int>();
     int n = nums.Count;

     for (int i = 0; i < n; i++)
     {
         if (mp.ContainsKey(nums[i]))
         {
             if (Math.Abs(i - mp[nums[i]]) <= k)
                 return true;
         }
         mp[nums[i]] = i;
     }
     return false;
 }
