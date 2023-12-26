using System;
using System.Collections.Generic;

        public class Solution
       {
           public int[] solution(int k, int[] score)
           {
               int[] answer = new int[score.Length];

               List<int> temp = new List<int>();

               int num = 0;

               for(int i = 0; i < score.Length; i++)
               {

                   if (num >= k)
                   {
                       if (score[i] > temp[0])
                       {
                           temp[0] = score[i];
                       }

                       temp.Sort();
                       answer[i] = temp[0];
                   }
                   else
                   {
                       temp.Add(score[i]);
                       temp.Sort();
                       answer[i] = temp[0];
                       num++;
                   }
                  


               }

               return answer;
           }
       }      