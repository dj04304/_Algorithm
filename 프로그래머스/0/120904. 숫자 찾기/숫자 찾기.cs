using System;

public class Solution {
     public int solution(int num, int k)
 {
     int answer = -1;

     string a = num.ToString();

     for (int i = 0; i < a.Length; i++)
     {
         if ((a[i] - '0') == k)
             return i + 1;
     }

     return answer;
 }
}