using System;

public class Solution {
         public int solution(string s)
   {
       int answer = 0;

       string[] part = s.Split(' ');

       for (int i = 0; i < part.Length; i ++)
       {
           if (part[i] == "Z")
           {
               answer -= int.Parse(part[i - 1]);
               continue;
           }

           answer += int.Parse(part[i]);

       }

       return answer;
   }
}