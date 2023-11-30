public class Solution
{
   public string solution(string s)
    {
        string answer = "";
        int wordIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                answer += s[i];
                wordIndex = 0;
                continue;
            }
            if (wordIndex % 2 == 0)
            {
                answer += s[i].ToString().ToUpper();
                wordIndex++;
            }
            else
            {
                answer += s[i].ToString().ToLower();
                wordIndex++;
            }
        }
        return answer;
    }

}