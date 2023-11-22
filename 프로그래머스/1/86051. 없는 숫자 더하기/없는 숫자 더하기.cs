using System;

        public class Solution
        {
            public int solution(int[] numbers)
            {
                int answer = 0;
                int sum = 0;
                int temps = 0;

                for(int i = 0; i < 10; i++)
                {
                    sum += i;
                }

                for(int i = 0; i < numbers.Length; i++)
                {
                    temps += numbers[i];
                }

                answer = sum - temps;

                return answer;
            }
        }