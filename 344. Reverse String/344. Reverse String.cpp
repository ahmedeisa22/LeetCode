 void reverseString(vector<char>& s)
{
    int len = (int)s.size();

    for(int i = 0 ; i < len/2 ; i++)
        swap(s[i],s[len - i - 1]);
}
