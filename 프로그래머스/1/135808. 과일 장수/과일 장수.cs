using System;

    public class Solution
    {
        public int solution(int k, int m, int[] score)
        {
            /// 사과 k가 가장 높은 품질
            /// m개 만큼 상자에 담아야함
            /// 계산은 상자에 담은 것 중 가장 낮은 품질 * m
            /// 

            int answer = 0;

            int[] box = new int[m];

            Array.Sort(score);
            Array.Reverse(score);

            int boxIndex = 0;

            for(int i = 0; i < score.Length; i++)
            {
                //TODO
                box[boxIndex] += score[i];
                boxIndex++;

                // 박스가 가득 찼다면
                if(boxIndex == m)
                {
                    answer += box[m - 1] * m;
                    box = new int[m];
                    boxIndex = 0;
                }
             
            }

            return answer;
        }
    }