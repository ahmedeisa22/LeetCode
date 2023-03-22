class Solution {
public:
bool containsDuplicate(vector<int>& nums)
{
    int Size = nums.size();
    set<int> st;
    vector<int> freq(Size, 0);
    for(int i = 0 ; i < Size ; i++)
        st.insert(nums[i]);


    return st.size() < Size;
}
};
