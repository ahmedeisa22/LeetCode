public  void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> lst = new List<int>();
            int num = 0, num2 = 0;
            if (n == 0)
            {
                lst.AddRange(nums1);
                return;
            }
            while (num < m && num2 < n)
            {
                if (nums1[num] < nums2[num2])
                {
                    lst.Add(nums1[num]);
                    num++;
                }else if (nums1[num] > nums2[num2])
                {
                    lst.Add(nums2[num2]);
                    num2++;
                }else
                {
                    lst.Add(nums1[num]);
                    lst.Add(nums2[num2]);
                    num++;
                    num2++;

                }
            }
            if(num2 < n)
            {
                for (int i = num2; i < n; i++)
                    lst.Add(nums2[i]);
            }
            if (num < m)
            {
                for (int i = num; i < m; i++)
                    lst.Add(nums1[i]);
            }

            for (int i = 0; i < lst.Count; i++)
                nums1[i] = lst[i];
            
        }
