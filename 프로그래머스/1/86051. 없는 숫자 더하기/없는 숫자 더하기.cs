using System;

public class Solution {
    public int solution(int[] numbers)
{
    int answer = 0;

    int total = 45;

    for(int i = 0; i < numbers.Length; i++)
    {
        answer += numbers[i];
    }
    
    answer = total - answer;

    return answer;
}
}