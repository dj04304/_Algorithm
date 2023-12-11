using System;
public class Solution
        {
            public string[] solution(string[] strings, int n)
            {
                string[] answer = new string[strings.Length];

                char[] chars = new char[strings.Length];

                // n번째 문자 추출
                for (int i = 0; i < strings.Length; i++)
                {
                    answer[i] = (strings[i][n]) + strings[i];
                }

                Array.Sort(answer);

                for(int i = 0; i < answer.Length; i++)
                {
                    answer[i] = answer[i].Substring(1);
                }

                //Array.Sort(answer, (a,b) =>
                //{
                //    int c = a[n].CompareTo(b[n]);
                //    if(c == 0) { return a.CompareTo(b); }
                //    return c;
                //});

                return answer;
            }
        }