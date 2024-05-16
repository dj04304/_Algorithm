using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Stack<char> stack = new Stack<char>();
        int result = 0;
        int temp = 1;

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

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
                    result = 0;
                    break;
                }
                if (input[i - 1] == '(')
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
                    result = 0;
                    break;
                }
                if (input[i - 1] == '[')
                {
                    result += temp;
                }
                stack.Pop();
                temp /= 3;
            }
        }

        if (stack.Count != 0)
        {
            result = 0;
        }


        Console.WriteLine(result);
    }

}
