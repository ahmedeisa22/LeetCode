  public static int NumOfSubarrays(int[] arr, int k, int threshold)
  {
      int start = 0;
      int end;
      int sum = 0;
      int result = 0;
      for (end = 0; end < arr.Length; end++)
      {
          sum += arr[end];
          if (getWindowSize(start, end) < k)
          {
              continue;
          }

          if (sum / k >= threshold)
          {
              result++;
          }

          sum -= arr[start];
          start++;
      }
      return result;

  }

  private static int getWindowSize(int start, int end)
  {
      return (end - start + 1);
  }
