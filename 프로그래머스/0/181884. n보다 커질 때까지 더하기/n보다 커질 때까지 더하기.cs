using System;

public class Solution {
    public int solution(int[] numbers, int n)
{
    int answer = 0;
    int a = 0;

    while(true) 
    {
        answer += numbers[a];
        if(answer > n)
        {
            break;
        }

        a++;
    
    }


    return answer;
}
}