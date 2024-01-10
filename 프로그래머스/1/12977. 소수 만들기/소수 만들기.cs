using System;
using System.Linq;
        class Solution
        {
            public int solution(int[] nums)
            {
                int answer = 0;
                int sum = 0;

                for (int i = 0; i < nums.Length - 2; i++)
                {
                    for(int j = i + 1; j < nums.Length - 1; j++)
                    {
                        for(int k = j + 1; k < nums.Length; k++)
                        {
                            sum = nums[i] + nums[j] + nums[k];

                            if(IsPrime(sum))
                            {
                                answer++;
                            }
                        }
                    }
                }


                return answer;
            }

            private bool IsPrime(int num)
            {
                // 1과 2는 소수
                if(num <= 2)
                {
                    return false;
                }

                // 2를 제외한 짝수는 소수가 아님
                if (num % 2 == 0 && num != 2)
                {
                    return false;
                }

                // 홀수인 경우 3부터 제곱근을 활용해 나누어떨어지는지 여부 확인
                int sqrt = (int)Math.Sqrt(num);

                for(int i = 3; i <= sqrt; i+=2)
                {
                    if (num % i == 0) return false;
                }
             
                return true;

            }
        }