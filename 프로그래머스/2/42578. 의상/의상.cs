using System;
using System.Collections.Generic;

public class Solution {
     public int solution(string[,] clothes)
 {
     int answer = 1;

     Dictionary<string, int> dic = new Dictionary<string, int>();

     for(int i = 0; i < clothes.GetLength(0); i++)
     {
         string type = clothes[i, 1];
         if (dic.ContainsKey(type))
             dic[type]++;
         else
             dic[type] = 1;

     }

    foreach(int count in dic.Values)
     {
         answer *= count + 1;
     }


     return answer - 1;
 }
}