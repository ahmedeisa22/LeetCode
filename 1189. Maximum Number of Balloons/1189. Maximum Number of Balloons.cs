    static int maxNumberOfBalloons(string text)
        {
            int counter = 0;
            string correctWord = "balloon";
            int Size = correctWord.Length;
            Dictionary<Char, int> trials = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (correctWord.Contains(text[i]))
                {
                    if (trials.ContainsKey(text[i]))
                         trials[text[i]] += 1; 
                    else
                        trials.Add(text[i],1);

                }
            }
           

            while (true)
            {

                if (!trials.ContainsKey('b') || !trials.ContainsKey('a') || !trials.ContainsKey('l') ||
                  !trials.ContainsKey('o') || !trials.ContainsKey('n'))
                    break;

                    if (trials['b'] >= 1 && trials['a'] >= 1 && trials['l'] >= 2 &&
                    trials['o'] >= 2 && trials['n'] >= 1)
                {
                    counter++;

                    foreach (KeyValuePair<char, int> kvp in trials)
                    {
                        if (kvp.Key == 'l' || kvp.Key == 'o')
                            trials[kvp.Key] -= 2;
                        else
                            trials[kvp.Key] -= 1;
                    }

                }
                else
                    break;


            }

                return counter;
        }
