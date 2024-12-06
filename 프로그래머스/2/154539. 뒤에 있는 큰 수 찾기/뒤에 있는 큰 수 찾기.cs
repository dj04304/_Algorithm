using System;
using System.Collections.Generic;

public class Solution {
       public int[] solution(int[] numbers)
    {
        int[] answer = new int[numbers.Length];

        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < numbers.Length; i++)
        {

            while(stack.Count > 0 && numbers[stack.Peek()] < numbers[i])
            {
                int index = stack.Pop();
                answer[index] = numbers[i];
            }

            stack.Push(i);

        }

        while(stack.Count > 0)
        {
            answer[stack.Pop()] = -1;
        }

        return answer;
    }
}