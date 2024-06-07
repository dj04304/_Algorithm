using System;

public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int total = brown + yellow;  // 전체 격자의 수

        // 전체 격자의 수를 가지고 가로 세로의 길이를 구합니다.
        for (int height = 3; height <= total / height; height++)
        {
            if (total % height == 0)
            {
                int width = total / height;
                // 갈색 격자의 수를 계산합니다.
                int brownCount = (width + height) * 2 - 4;
                if (brownCount == brown)
                {
                    return new int[] { width, height };
                }
            }
        }
        return null;  // 조건에 맞는 값이 없는 경우 null 반환
    }
}