public  bool IsPalindrome(string s)
        {
       
            string regex = @"[^a-zA-Z0-9]";
       
            string removeSpacesAndSpecilaChar = Regex.Replace(s, regex, "").ToLower();
          
            string[] arr = removeSpacesAndSpecilaChar.Split(" ");
            StringBuilder concatingstring = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
                concatingstring.Append(arr[i]);

           
            if (concatingstring.Length / 2 == 0) return true;
            for (int i = 0; i <= concatingstring.Length/2; i++)
            {
                if (concatingstring[i] != concatingstring[concatingstring.Length - i - 1])
                    return false;
            }

            return true;
        }
