using System;

public class Solution {
       public int solution(int n)
   {
       int answer = 0;

       string a = n.ToString();

       for(int i = 0; i < a.Length; i++)
       {
           answer += a[i] - '0';
       }

       return answer;
   }
}