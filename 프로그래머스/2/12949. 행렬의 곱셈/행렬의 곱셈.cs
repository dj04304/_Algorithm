using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2)
{
    int[,] answer = new int[arr1.GetLength(0),arr2.GetLength(1)];
    // [11, 11 + 12, 21 + 13, 31], [11, 12 + 12, 22 + 13, 32], [11, 13 + 12, 23 + 13, 33], [21, 11 + 22, 21 + 23, 31] ...


    for(int i = 0; i < answer.GetLength(0); i++)
    {
        for(int j = 0; j < answer.GetLength(1); j++)
        {
            answer[i, j] = 0;

            for (int k = 0; k < arr1.GetLength(1); k++)
                answer[i, j] += (arr1[i, k] * arr2[k, j]);

        }

    }


    return answer;
}
}