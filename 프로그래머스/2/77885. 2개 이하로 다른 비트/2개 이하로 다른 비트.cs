using System;

public class Solution
{
    public long[] solution(long[] numbers)
    {
        long[] answer = new long[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            long x = numbers[i];
            if (x % 2 == 0)
            {
                // 짝수인 경우, 바로 다음 숫자가 비트 차이가 1인 최소 숫자
                answer[i] = x + 1;
            }
            else
            {
                // 홀수인 경우, 가장 오른쪽에서 0인 비트를 1로 바꾸고, 그 오른쪽 비트를 0으로 변경
                long bitMask = 1;
                while ((x & bitMask) != 0)
                {
                    bitMask <<= 1;
                }
                answer[i] = x + bitMask - (bitMask >> 1);
            }
        }

        return answer;
    }
}