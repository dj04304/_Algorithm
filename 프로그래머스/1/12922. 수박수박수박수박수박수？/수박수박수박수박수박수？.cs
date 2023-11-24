       public class Solution
       {
           public string solution(int n)
           {
               string answer = "";
               string str = "수박";

               if(n % 2 == 0)
               {
                   for(int i = 0; i < (n / 2); i++)
                   {
                       answer += str;
                   }
               }
               else
               {
                   for (int i = 0; i < (n / 2); i++)
                   {
                       answer += str;
                   }

                   return answer += "수";
               }
                   

               return answer;
           }
       }