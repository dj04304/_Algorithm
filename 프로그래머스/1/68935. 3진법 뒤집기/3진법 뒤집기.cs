using System;
using System.Collections.Generic;

 public class Solution
 {
     public int solution(int n)
     {
         int a = 1; // 진법 계산용
         int num = n; //n을 나누고 난 계산을 담을  num

         int answer = 0;
         List<int> list = new List<int>();
         
         while(num > 0)
         {
             list.Add((num % 3));

             num = num / 3;
         }

         list.Reverse();

         foreach(int i in list)
         {
             answer += i * a;

             a = a * 3;
         }

         
         return answer;
     }
 }