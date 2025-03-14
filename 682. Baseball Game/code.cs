    public static int CalPoints(string[] operations)
    {
        // Create a stack of integers
        Stack<int> stack = new Stack<int>();
        int totalSum = 0;
        for (int i = 0; i < operations.Length; i++)
        {
           

            switch (operations[i])
            {
                case string s when int.TryParse(s, out int num):
                    stack.Push(num);
                    break;
                case "C":
                    stack.Pop();
                    break;
                case "D":
                    int previous = stack.Peek() * 2;
                    stack.Push(previous);
                    break;
                case "+":
                    int previous1 = stack.Peek();
                    stack.Pop();
                    int previous2 = stack.Peek();
                    stack.Push(previous1);
                    stack.Push(previous1+previous2);
                    break;
                default:
                    Console.WriteLine($"{operations[i]} is an unknown operation");
                    break;
            }
        }



        return stack.Sum();
    }
