using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries)
 {
     int[] answer = arr;

     for (int i = 0; i < queries.GetLength(0); i++)
     {
         int n = queries[i, 0];
         int k = queries[i, 1];

         int temp = arr[n];
         arr[n] = arr[k];
         arr[k] = temp;
     }

     return answer;
 }
}