  public  int[] TopKFrequent(int[] nums, int k) {

            var dict = new Dictionary<int,int>();
            var lst = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict[nums[i]] = 1;
                else
                    dict[nums[i]] += 1;
            }
            var soryedDict = dict.OrderByDescending(d => d.Value)
                                .ToDictionary(d => d.Key, d => d.Value);

            for (int i = 0; i < k; i++)
                lst.Add(soryedDict.ElementAt(i).Key);
            
           
            return lst.ToArray(); 
        }
