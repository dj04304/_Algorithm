using System;

public class Solution
        {
            public bool solution(int x)
            {
                bool answer = true;
                string str = x.ToString();
                int num = 0;

                for(int i = 0; i < str.Length; i++)
                {
                    num += (int)Char.GetNumericValue(str[i]);

                }
                if (x % num == 0)
                {
                    return answer;
                }

                return !answer;
            }
        }