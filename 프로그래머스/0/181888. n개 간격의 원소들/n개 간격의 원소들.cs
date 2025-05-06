using System;

public class Solution {
      public int[] solution(int[] num_list, int n)
  {
      int[] answer = new int[(num_list.Length - 1) / n + 1];

      int num = 0;

      for (int i = 0; i < num_list.Length; i++)
      {
          if (i % n == 0)
          {
              answer[num] = num_list[i];
              num++;
          }
      }

      return answer;
  }
}