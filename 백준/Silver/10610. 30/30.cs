using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 입력을 받습니다.
        string input = Console.ReadLine();

        // 입력 숫자들을 리스트 형태로 변환하고 합을 구합니다.
        int[] digits = input.Select(x => x - '0').ToArray();
        int sum = digits.Sum();

        // 조건 1: 숫자에 0이 포함되어 있는지 확인
        if (!digits.Contains(0))
        {
            Console.WriteLine(-1);
            return;
        }

        // 조건 2: 숫자 합이 3의 배수인지 확인
        if (sum % 3 != 0)
        {
            Console.WriteLine(-1);
            return;
        }

        // 내림차순으로 정렬하여 가장 큰 수를 생성
        Array.Sort(digits);
        Array.Reverse(digits);

        // 결과 출력
        Console.WriteLine(string.Concat(digits));
    }
}