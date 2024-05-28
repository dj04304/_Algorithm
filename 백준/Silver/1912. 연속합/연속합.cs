using System;

class Program
{
    static void Main()
    {
        // 입력 받기
        int n = int.Parse(Console.ReadLine());
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        // 최대 부분 배열 합 계산
        int result = MaxSubArraySum(n, array);
        
        // 결과 출력
        Console.WriteLine(result);
    }

    static int MaxSubArraySum(int n, int[] array)
    {
        if (n == 0)
            return 0;

        int currentMax = array[0];
        int globalMax = array[0];

        for (int i = 1; i < n; i++)
        {
            currentMax = Math.Max(array[i], currentMax + array[i]);
            globalMax = Math.Max(globalMax, currentMax);
        }

        return globalMax;
    }
}
