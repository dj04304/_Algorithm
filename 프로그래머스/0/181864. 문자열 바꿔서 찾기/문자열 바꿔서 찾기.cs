using System;
using System.Text;

public class Solution {
   public int solution(string myString, string pat)
 {
     int answer = 0;

     StringBuilder sb = new StringBuilder();
     StringBuilder sb2 = new StringBuilder();
     int num = 0;

     for(int i = 0; i < myString.Length; i++)
     {
         if (myString[i] == 'A')
             sb.Append('B');
         else if (myString[i] == 'B')
             sb.Append('A');

     }

     for(int i = 0; i < myString.Length; i++)
     {
         if (sb[i] != pat[num])
         {
             sb2.Clear();
             num = 0;

             if (pat.Length > sb.Length - i)
                 break;

             continue;
         }

         sb2.Append(sb[i]);
         num++;
         
         
     if (num == pat.Length)
        {
            answer = 1;
            break;
        }

     }

     return answer;
 }
}