class Solution {
public:
  bool isSubsequence(string s, string t)
{
    int n = (int) t.size();
    int idx = 0;

    for(int i = 0 ; i < n ; i++)
    {
        if(s[idx] == t[i])
            idx++;
    }

    return (idx == (int)s.size());
}
};
