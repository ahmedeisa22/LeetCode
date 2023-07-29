public bool ValidPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;

            while(left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                    return isPaildrome(s,left+1,right) | isPaildrome(s,left,right-1);
            }
          
            return true;
        }
        public bool isPaildrome(string s,int left , int right)
        {
            
           while(left < right)
            {
                if (s[left] != s[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
