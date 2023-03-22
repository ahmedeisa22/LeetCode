public class Solution {
      public  bool IsAnagram(string s, string t)
        {
            char[] s1 = s.ToCharArray();
            Array.Sort(s1);
            char[] t1 = t.ToCharArray();
            Array.Sort(t1);
            return string.Join("", s1) == string.Join("", t1);
        }
}
