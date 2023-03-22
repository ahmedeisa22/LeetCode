public class Solution {
       public  int NumUniqueEmails(string[] emails)
        {
            int counter = 0;
            HashSet<string> odd = new HashSet<string>();
            for (int i = 0; i < emails.Length; i++)
            {
                string local = emails[i].Substring(0, emails[i].IndexOf("@"));
                string domain = emails[i].Substring(emails[i].IndexOf("@"));
                if(local.Contains("+"))
                    local = local.Remove(local.IndexOf("+")).Replace(".","");

                if (local.Contains("."))
                    local = local.Replace(".", "");
         
                string url = local + domain;
                odd.Add(url);

            }

            return odd.Count;
        }
}
