public static bool IsValidSudoku(char[][] board)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < board.Length; i++)
            {
                set.Clear();

                // Rows
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                        continue;
                    else if (!set.Contains(board[i][j]))
                        set.Add(board[i][j]);
                    else if(set.Contains(board[i][j]))
                        return false;
                }
                set.Clear();
                // Columns
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[j][i] == '.')
                        continue;
                    else if(!set.Contains(board[j][i]))
                            set.Add(board[j][i]);
                    else if (set.Contains(board[j][i]))
                        return false;
                }
              
            }

            List<int> first = new List<int>();
            List<int> second = new List<int>();
            List<int> third = new List<int>();

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                        continue;
                     if ((j >= 0 && j <=2))
                        first.Add(board[i][j]);
                    if ((j > 2 && j <=5))
                        second.Add(board[i][j]);
                    if ((j > 5 && j <= 8))
                        third.Add(board[i][j]);
                   
                }
                

                if(i == 2 || i == 5 || i == 8)
                {

                    if (first.GroupBy(x => x).Any(g => g.Count() > 1) ||
                        second.GroupBy(x => x).Any(g => g.Count() > 1) ||
                        third.GroupBy(x => x).Any(g => g.Count() > 1))
                            return false;
                   
                        first.Clear();
                        second.Clear();
                        third.Clear();
                    

                }
            }

            return true;
        }
