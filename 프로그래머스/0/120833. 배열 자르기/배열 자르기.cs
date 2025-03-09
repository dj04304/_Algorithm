using System;

public class Solution {
     public int[] solution(int[] numbers, int num1, int num2)
 {
     ArraySegment<int> a = new ArraySegment<int>(numbers, num1, num2 - num1 + 1);

     int[] answer = a.ToArray();

     return answer;
 }

}