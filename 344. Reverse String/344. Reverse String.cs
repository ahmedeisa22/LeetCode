public class Solution {
    public void ReverseString(char[] s) {
         int n = s.Length;
 char first = s[0];
 char last = s[n - 1];
 char tem;

 for (int i = 0; i < n/2; i++)
 {
     first = s[i];
     last = s[n - i - 1];
     s[n-i-1] = first;
     s[i] = last;
 }
    }
}
