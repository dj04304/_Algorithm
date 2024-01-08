using System;
using System.Collections.Generic;

       public class Solution
       {
           public int[] solution(int[] answers)
           {
               List<int> answer = new List<int>();

               int[] person1 = new int[5] { 1, 2, 3, 4, 5 };
               int[] person2 = new int[8] { 2, 1, 2, 3, 2, 4, 2, 5 };
               int[] person3 = new int[10] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

               int person1Score = 0;
               int person2Score = 0;
               int person3Score = 0;

               int[] scoreArray = { 0, 0, 0};

               int maxScore = 0;

               /// 세 사람의 점수 맞추기
               for(int i = 0; i < answers.Length; i++)
               {
                   if (answers[i] == person1[i % person1.Length])
                   {
                       person1Score++;
                   }

                   if (answers[i] == person2[i % person2.Length])
                   {
                       person2Score++;
                   }

                   if (answers[i] == person3[i % person3.Length])
                   {
                       person3Score++;
                   }

               }

               scoreArray[0] = person1Score;
               scoreArray[1] = person2Score;
               scoreArray[2] = person3Score;

               /// 가장 많이 맞춘 사람 구하기 (동률일 가능성도 포함)
               
               // 젤 높은 점수 구하기
               for (int i = 0; i < scoreArray.Length; i++)
               {
                   if(maxScore < scoreArray[i])
                   {
                       maxScore = scoreArray[i];
                   }
               }

               // 젤 높은 점수와 같은 사람 answer에 포함
               for(int i = 0; i < scoreArray.Length; i++)
               {
                   if(maxScore == scoreArray[i])
                   {
                       answer.Add(i + 1);
                   }
               }

               return answer.ToArray();
           }
       }