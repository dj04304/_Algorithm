using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string)
    {
        int answer = 0;
        string temp = "";
        List<string> list = new List<string>();

        foreach (char c in my_string)
        {
            if (char.IsDigit(c))
                temp += c;
            else
            {
                if (temp.Length > 0)
                {
                    list.Add(temp);
                    temp = "";
                }
            }
        }

        if (temp.Length > 0)
            list.Add(temp);

        foreach (string s in list)
        {
            answer += int.Parse(s);
        }

        return answer;
    }
}
