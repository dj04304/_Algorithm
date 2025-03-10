using System;

public class Solution {
         public int[] solution(int money)
   {
       int a = 5500;

       int[] answer = new int[2] { money / a, money % a };

       return answer;
   }
}