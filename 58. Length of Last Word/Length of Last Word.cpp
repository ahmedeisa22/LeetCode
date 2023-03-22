class Solution {
public:
   vector<string> split(string str, string delimeter = " ")
{
    vector<string> words;
    int pos = 0;
    string sWord = "";
    while ((pos = str.find(delimeter)) != string::npos)
    {
        sWord = str.substr(0, pos);
        if (sWord != "")
        {
            words.push_back(sWord);
        }

        str.erase(0, pos + delimeter.size());
    }
    if (str != "")
    {
        words.push_back(str);
    }

    return words;
}
int lengthOfLastWord(string s)
{
    vector<string> words = split(s);
    for(auto w : words)
        cout << w << endl;

    return words.back().length();
}
};
