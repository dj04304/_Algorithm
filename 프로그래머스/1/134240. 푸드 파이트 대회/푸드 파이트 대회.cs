using System;
using System.Linq;

        public class Solution
        {
            public string solution(int[] food)
            {
                string answer = "";
                string elseAnswer = "";


                for(int i = 0; i < food.Length; i++)
                {
                    for(int j = 0; j < food[i] / 2; j++)
                    {
                        answer += i.ToString();
                    }
                }

                elseAnswer = string.Concat(answer.Reverse());

                answer += "0" + elseAnswer;

                return answer;
            }
        }