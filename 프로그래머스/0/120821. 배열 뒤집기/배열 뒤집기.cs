using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length]; 

        int a = num_list.Length;

        for(int i = 0; i < a; i++)
        {
            answer[i] = num_list[(a - 1) - i];
        }

        return answer;
    }
}