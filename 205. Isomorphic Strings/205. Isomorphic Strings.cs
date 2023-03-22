public class Solution {
     public bool IsIsomorphic(string s, string t)
        {
            bool isMorph = true;
            var dictS = new Dictionary<char , char>();
            var dictT = new Dictionary<char , char>();

            for (var i = 0 ; i < s.Length; i++)
            {
                if (dictS.ContainsKey(s[i]) )
                {
                    if(dictS[s[i]] != t[i] )
                    {
                        isMorph =  false;
                        break;
                    }
                }
                else
                {
                    if (dictT.ContainsKey(t[i]))
                    {
                        isMorph = false;
                        break;
                    }
                    dictS[s[i]] = t[i]; 
                    dictT[t[i]] = s[i]; 

                  

                }
            }
            return isMorph;
        }

}
