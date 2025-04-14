using System;

public class Solution {
     public int solution(int hp)
 {
     int answer = 0;

     int a = 1;
     int b = 3;
     int c = 5;


     while(hp != 0)
 {
     if (hp >= c)
     {
         answer += hp / c;
         hp = hp % c;
     }
     else if(hp >= b)
     {
         answer += hp / b;
         hp = hp % b;
     }
     else if(hp >= a)
     {
         answer += hp / a;
         hp = hp % a;
     }
 }

 
     return answer;
 }
}