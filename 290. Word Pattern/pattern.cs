  public  bool WordPattern(string pattern, string s)
        {
            var dict = new Dictionary<char, string>();
            bool res = true;

            var texts = s.Split(" "); // split words by spaces

            if (pattern.Length != texts.Length)
                return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dict.ContainsKey(pattern[i]))
                    dict[pattern[i]] = texts[i];
                else
                {
                    if (dict[pattern[i]] != texts[i])
                        return false;
                }
            }
            // if two values duplicated then two key has same pattern return false
            bool hasDuplicate = dict.GroupBy(g => g.Value)
                                  .Any(g => g.Count() > 1);
            if (hasDuplicate)
                return false;

            return res;
        }
