        public class Solution
        {
            public int solution(string t, string p)
            {

                string str = "";

                long a = long.Parse(p);
                long b = 0;
                int answer = 0;

                for (int i = 0; i < t.Length - p.Length + 1; i++)
                {

                    str = t.Substring(i, p.Length);

                    b = long.Parse(str);

                    if (a >= b)
                    {
                        answer++;
                    }

                }

                
                return answer;
            }
        }