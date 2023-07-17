public int[] ProductExceptSelf(int[] nums)
        {
            List<int> res = new List<int>();
            int SIZE = nums.Length;
           int[] left = new int[SIZE];
           int[] right = new int[SIZE];
            left[1] = nums[0];
            left[0] = 1;

            right[SIZE - 2] = nums[SIZE - 1];
            right[SIZE - 1] = 1;

            for (int i = 2; i < SIZE; i++)
                left[i] = left[i-1] * nums[i-1];
            
            for (int i = SIZE - 3; i >= 0 ; i--)
                right[i] = right[ i+1] * nums[i + 1];


            for (int i = 0; i < SIZE; i++)
            {

                //Console.Write("right: " + right[i]);
                //.Write("\tleft: " + left[i]);
                int total = right[i] * left[i];
                res.Add(total);
               // Console.WriteLine(total);

            }
            return res.ToArray();
        }
