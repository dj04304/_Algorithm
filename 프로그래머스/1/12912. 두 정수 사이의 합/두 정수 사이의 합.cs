using System;
public class Solution
{
   public long solution(int a, int b)
   {
       long answer = 0;
       int abs = Math.Abs(a - b);

    if(a != b)
       {
           if (a < b)
           {
               for (int i = 0; i < abs; i++)
               {
                   answer += a++;
               }
           }
           else if (b < a)
           {
               for (int i = 0; i < abs; i++)
               {
                   answer += b++;
               }
           }
       }


       return answer + b;
   }
}