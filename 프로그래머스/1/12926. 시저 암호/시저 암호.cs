        public class Solution
        {
            public string solution(string s, int n)
            {
                string answer = "";
                for (int i = 0; i < s.Length; i++)
                {
                    char value = s[i];
                    int shiftCount = n;
                    if (s[i] == ' ')
                    {
                        answer += value;
                        continue;
                    }
                    if ((char)(value + shiftCount) > 'Z' && value < 'a')
                    {
                        shiftCount -= ('Z' - value);
                        value += (char)('Z' - value);
                    }
                    if ((char)(value + shiftCount) > 'z')
                    {
                        shiftCount -= ('z' - value);
                        value += (char)('z' - value);
                    }

                    if (value == 'Z' || value == 'z')
                        value = (char)(value - 26);

                    char a = (char)(value + shiftCount);
                    answer += a.ToString();
                }
                return answer;
            }
          
        }