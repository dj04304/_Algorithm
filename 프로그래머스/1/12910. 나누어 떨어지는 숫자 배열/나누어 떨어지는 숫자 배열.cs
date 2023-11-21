using System;
public class Solution
        {
            public int[] solution(int[] arr, int divisor)
            {
                int[] answer = new int[arr.Length];

                int num = 0;

                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % divisor == 0)
                    {
                        answer[num] = arr[i];
                        num++;
                    }
                }

                if (num == 0)
                {
                    Array.Resize(ref answer, 1);
                    answer[num] = -1;
                }
                else
                {
                    Array.Resize(ref answer, num);
                    Array.Sort(answer);
                }

                return answer;
            }
        }