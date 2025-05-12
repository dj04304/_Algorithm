using System;

public class Solution {
    public int solution(string my_string, string is_prefix)
 {
     int answer = 1;

     if (is_prefix.Length > my_string.Length)
         return 0;

    for(int i = is_prefix.Length - 1; i >= 0; i--)
{
    if (my_string[my_string.Length - is_prefix.Length + i] != is_prefix[i])
        return 0;

}

     return answer;
 }
}