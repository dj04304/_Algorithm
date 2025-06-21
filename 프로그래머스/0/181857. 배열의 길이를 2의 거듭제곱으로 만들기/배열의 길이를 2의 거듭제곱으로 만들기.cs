using System;

public class Solution {
    public int[] solution(int[] arr)
{
    int n = 1;

    while(n < arr.Length) 
    {
        n*= 2;
    }

    if (n == arr.Length)
        return arr;

    int[] answer = new int[n];

    for(int i = 0; i < arr.Length; i++)
    {
        answer[i] = arr[i];
    }
    
    return answer;
}
}