public class Solution {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int i = 0; i < flowerbed.Length && count < n; i++)
            {
                if (flowerbed[i] == 0)
                {
                    int next = (i == flowerbed.Length - 1) ? 0 : flowerbed[i + 1];
                    int prev = (i == 0) ? 0 : flowerbed[i - 1];

                    if(next == 0 && prev == 0)
                    {
                        count++;
                        flowerbed[i] = 1;
                    }
                }
          
              
           
            }
            return count == n;
        }
}
