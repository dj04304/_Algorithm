using System;

public class Solution {
       public int[] solution(int[] arr, int[,] queries)
   {
       int[] answer = arr;

       for(int i = 0; i < queries.GetLength(0); i++)
       {
           int k = queries[i, 2];
           for (int j = queries[i, 0]; j <= queries[i, 1]; j++)
           {
               if(j % k == 0)
                   answer[j] += 1;
           }
       }

       return answer;
   }
}