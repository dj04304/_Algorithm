using System;
using System.Collections.Generic;

public class Solution {
           public int solution(string s)
    {
        int answer = 0;
        Queue<char> queue = new Queue<char>();

        for (int i = 0; i < s.Length; i++)
        {
            queue.Enqueue(s[i]);
        }

        for(int i = 0; i < s.Length; i++)
        {
            if (IsTrue(new string(queue.ToArray())))
                answer++;

            queue.Enqueue(queue.Dequeue());
        }

        return answer;
    }

    public static bool IsTrue(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if( c == '(' ||  c == '{' || c == '[')
                stack.Push(c);
            else
            {
                if( stack.Count == 0 ) return false;

                char peek = stack.Pop();

                if((c == ')' &&  peek != '(') ||
                    (c == '}' && peek != '{') ||
                    (c == ']' && peek != '[')
                    )
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}