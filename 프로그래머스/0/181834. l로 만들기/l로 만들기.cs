using System;

public class Solution {
       public string solution(string myString)
    {

        char a = 'l';
        char[] answer = myString.ToCharArray();
        
        for(int i = 0; i < myString.Length; i++)
        {
            if (answer[i] < a)
            {
                answer[i] = a;
            }
        }

        return new string(answer);
    }
}