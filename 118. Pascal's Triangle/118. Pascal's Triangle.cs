public class Solution {
    

  public IList<IList<int>> Generate(int numRows)
        {
            //var res = new List<IList<int>>();
            int[][] res = new int[numRows][];
            res[0] = new int[1];
            res[0][0]=1;
            for (int i = 1; i < numRows; i++)
            {
                res[i] = new int[i+1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        res[i][j] = 1;
                    else
                    {
                        res[i][j] = res[i - 1][j-1] + res[i - 1][j];
                    }
                     
                }
            }
           
            return res;

        }




}
