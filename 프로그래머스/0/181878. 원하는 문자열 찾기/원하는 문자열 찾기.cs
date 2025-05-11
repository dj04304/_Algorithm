using System;

public class Solution {
        public int solution(string myString, string pat)
    {
        int answer = 0;

        bool isContain = myString.IndexOf(pat, StringComparison.OrdinalIgnoreCase) >= 0;

        answer = isContain ? 1 : 0;

        return answer;
    }
}