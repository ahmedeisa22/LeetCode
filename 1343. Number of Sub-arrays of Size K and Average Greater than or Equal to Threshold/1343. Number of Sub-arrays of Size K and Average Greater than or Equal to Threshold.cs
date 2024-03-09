   public static int NumOfSubarrays(int[] arr, int k, int threshold)
   {
       int numOfSub = 0;
       for (int i = 0; i <= arr.Length - k; i++)
       {
           int sum = 0;
           for (int j   = 0; j < k; j++)
           {
               sum += arr[i + j];
           }
           sum = sum / k;

           if (sum >= threshold) numOfSub++;

       }

       return numOfSub;
   }
