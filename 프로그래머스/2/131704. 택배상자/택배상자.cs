using System;
using System.Collections.Generic;
public class Solution {
        public int solution(int[] order)
    {
        int answer = 0;

        // order 리스트
        // 보조 컨테이너  stack
        // 실을 곳 stack

        // 뒤에 자기보다 큰 수가 오면 그때부터 쌓기 시작
        // 여기서 부터는 다시 작은 수로 올라가야됨
        // 41325 4 1 담고, 3싣고 양쪽 비교해서 자신보다 작고, 둘중에는 큰 수 싣고

        Stack<int> sub = new Stack<int>();
        int currentBox = 1;

        foreach (int item in order)
        {
            while(currentBox <= item)
            {
                sub.Push(currentBox);
                currentBox++;   
            }

            if (sub.Peek() == item)
            {
                sub.Pop();
                answer++;
            }
            else
                break;

        }

        return answer;

    }
}