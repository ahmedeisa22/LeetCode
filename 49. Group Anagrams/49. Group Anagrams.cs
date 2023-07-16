
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, List<string>>();


            foreach (var st in strs)
            {
                char[] chars = st.ToCharArray();
                Array.Sort(chars);
                string sortedStr = new string(chars);

                if (dict.ContainsKey(sortedStr))
                    dict[sortedStr].Add(st);
                else
                    dict[sortedStr] = new List<string> { st };

            }
         
                return new List<IList<string>>(dict.Values);

        }
