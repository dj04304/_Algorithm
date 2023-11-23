        public class Solution
        {
            public string solution(string s)
            {
                int mid = s.Length / 2;
                string answer = "";

                for(int i = 0; i < s.Length; i++)
                {
                    if(s.Length % 2  == 0)
                    {
                        answer += s[mid - 1];
                        answer += s[mid];

                        return answer;
                    }
                    else
                    {
                        return answer += s[mid];
                    }
                }

                return answer;
            }
        }