using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
     public int solution(int[] numbers)
 {
     int answer = 0;

     List<int> list = numbers.ToList();

     list.Sort();

     answer = list[0] * list[1] > list[numbers.Length-2] * list[numbers.Length - 1] ? list[0] * list[1] : list[numbers.Length-2] * list[numbers.Length - 1]; 

     return answer;
 }
}