using System;
using System.Collections.Generic;

    public class Solution
        {
            public bool solution(string s)
            {
                bool answer = true;

                Stack<char> stack = new Stack<char>();

                foreach (char c in s)
                {
                    if (stack.Count == 0 && c == ')')
                        return answer = false;

                        if (c == '(')
                        {
                            stack.Push(c);
                        }
                        else if(c == ')' && stack.Count > 0)
                        {
                            stack.Pop();
                        }

                }

                if(stack.Count == 0) 
                    answer = true;
                else
                    answer = false;

                return answer;
            }
        }