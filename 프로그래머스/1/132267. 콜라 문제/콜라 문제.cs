using System;
        public class Solution
        {
            public int solution(int a, int b, int n)
            {
                int answer = 0;

                while (n > a - 1) 
                {
                    answer += n / a * b; // 병을 가져다줬을 때 받을 수 있는 병
                    n = (n / a) * b + n % a; // 남은 병의 개수

                }

                return answer;
            }
        }
        