using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokdeKata49
{
    internal class Program
    {

        public class Solution
        {
            /// <summary>
            ///   // 배열 수 더하기, 정렬하기, 중복되는 수 제거해주기
            /// </summary>
            public int[] solution(int[] numbers)
            {

                
                List<int> result = new List<int>();

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    // 안에서 나온 수가 배열 끝까지 다 더하기
                    int index = i + 1;
                    while (true)
                    {
                        int sum = numbers[i] + numbers[index];

                        result.Add(sum);

                        index++;
                        // 해당 배열이 마지막 배열까지 다 더했다면 반복문 탈출
                        if (index == numbers.Length)
                        {
                            break;
                        }
                    }
                }

                // 배열 정렬
                result.Sort();

                //Distinct 배열 중복수 제거
                int[] answer = result.Distinct().ToArray();

                return answer;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 3, 4, 1 };
            Solution s = new Solution();

            int[] result = s.solution(numbers);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }


        }
    }
}
