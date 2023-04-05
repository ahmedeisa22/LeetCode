 public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int S1 = nums1.Length;
            int S2 = nums2.Length;
            int[] res = new int[S1];
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < S2; i++)
            {
                bool isBigger = false;
                for (int j = i + 1; j < S2; j++)
                {
                    if (nums2[j] > nums2[i])
                    {
                        isBigger = true;
                        dict[nums2[i]] = nums2[j];
                        break;
                    }
                }

                if (!isBigger)
                    dict[nums2[i]] = -1;
            }


            for (int i = 0; i < S1; i++)
            {
                res[i] = dict[nums1[i]];
            }
            return res;
        }
