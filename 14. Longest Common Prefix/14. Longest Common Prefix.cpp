class Solution {
public:

string longestCommonPrefix(vector<string>& strs)
{
      int len = strs.size();
     if(len==0) return "";
     
    sort(strs.begin() , strs.end());

    string res = "";
    string a = strs[0];
    string b = strs[len - 1];

    for(int i = 0 ; i < a.size() ; i++)
    {
        if(a[i] == b[i])
            res += a[i];
        else
            break;
    }

    return res;
}
};
