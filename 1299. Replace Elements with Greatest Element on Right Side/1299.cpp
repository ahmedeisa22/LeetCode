class Solution {
public:
  vector<int> replaceElements(vector<int>& arr)
{
    int n = (int) arr.size();
    vector<int>res(n);

    res[n-1] = -1;
    for(int i = n-1 ; i > 0 ; i--)
    {
        if(arr[i] > res[i])
           res[i-1] = arr[i];
           else
            res[i-1] = res[i];
    }

    return res;
}
};
