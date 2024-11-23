using System;

public class Solution
{
    public int MaxCount = 0;

    public int solution(int[] numbers, int target)
    {
        return DFS(numbers, target, 0, 0);
    }

    private int DFS(int[] numbers, int target, int index, int sum)
    {
        if(index == numbers.Length)
        {
            return sum == target ? 1 : 0;
        }

        int add = DFS(numbers, target, index + 1, sum + numbers[index]);
        int subtract = DFS(numbers, target, index + 1, sum - numbers[index]);

        return add + subtract;
    }
}