using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(CalculateBracketValue(input));
    }

    static int CalculateBracketValue(string s)
    {
        Stack<char> stack = new Stack<char>();
        int result = 0;
        int temp = 1;

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (ch == '(')
            {
                stack.Push(ch);
                temp *= 2;
            }
            else if (ch == '[')
            {
                stack.Push(ch);
                temp *= 3;
            }
            else if (ch == ')')
            {
                if (stack.Count == 0 || stack.Peek() != '(')
                {
                    return 0;
                }
                if (s[i - 1] == '(')
                {
                    result += temp;
                }
                stack.Pop();
                temp /= 2;
            }
            else if (ch == ']')
            {
                if (stack.Count == 0 || stack.Peek() != '[')
                {
                    return 0;
                }
                if (s[i - 1] == '[')
                {
                    result += temp;
                }
                stack.Pop();
                temp /= 3;
            }
        }

        if (stack.Count != 0)
        {
            return 0;
        }

        return result;
    }
}
