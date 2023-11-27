using System;
public class Solution
        {
            public string solution(string s)
            {
                string answer = "";
                char[] Arr = s.ToCharArray();

                Array.Sort(Arr);
                Array.Reverse(Arr);

                answer = new string(Arr);

                return answer;
            }
        }