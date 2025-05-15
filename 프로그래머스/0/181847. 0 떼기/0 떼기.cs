using System;

public class Solution {
public string solution(string my_string)
{
    string answer = "";
    int idx = 0;

    for(int i = 0; i < my_string.Length; i++)
    {
        if (my_string[i] != '0')
        {
            idx = i;
            break;
        }
    }

    answer = my_string.Substring(idx);

    return answer;
}
}